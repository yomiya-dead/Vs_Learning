using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Integration;

namespace LossCalculate1
{
    public partial class CalculationUtilities : Form1
    {
        static public float Cal_Vo_BST(float V_in)
        {
            if (V_in >= S1.V_Inv_Bus.f32_Normal)
            {
                return V_in + 50;
            }
            else
            {
                return S1.V_Inv_Bus.f32_Normal;
            }
        }

        static public float Cal_InDC_onePV(float V_in, float V_out, float P_out)
        {
            if (S1.V_Inv_Bus.f32_Min <= V_out && V_out <= S1.V_Inv_Bus.f32_Max && V_in < V_out)
            {
                if (S1.Vpv.f32_Min <= V_in && V_in <= S1.Vpv.f32_Max)
                {
                    if ((P_out / (S1.i16_N_PV * V_in * S1.f32_ExpEff)) < S1.f32_MaxInCur)
                    {
                        return P_out / (S1.i16_N_PV * V_in * S1.f32_ExpEff);
                    }
                    else
                    {
                        return S1.f32_MaxInCur;
                    }
                }
                else
                {
                    return 0f;
                }
            }
            else if (V_in == V_out)
            {
                return IFMIN(P_out / (S1.i16_N_PV * V_in * S1.f32_ExpEff), S1.f32_MaxInCur);
            }
            else
            {
                return 0f;
            }
        }

        static public float Cal_IoDC_onePV(float V_in, float V_out, float P_out)
        {
            if (S1.V_Inv_Bus.f32_Min <= V_out && V_out <= S1.V_Inv_Bus.f32_Max && V_in < V_out)
            {
                if (S1.Vpv.f32_Min <= V_in && V_in <= S1.Vpv.f32_Max)
                {
                    float result = P_out / (S1.i16_N_PV * V_out);
                    if (result < S1.f32_MaxInCur)
                    {
                        return result;
                    }
                    else
                    {
                        return S1.f32_MaxInCur * V_in * S1.f32_ExpEff / V_out;
                    }
                }
                else
                {
                    return 0f;
                }
            }
            else if (V_in == V_out)
            {
                return IFMIN(P_out / (S1.i16_N_PV * V_out), S1.f32_MaxInCur * V_in / V_out);
            }
            else
            {
                return 0f;
            }
        }
        static public float Cal_Po_max_Limitation(float V_in, float V_out, float P_out)
        {
            return S1.i16_N_PV * Cal_InDC_onePV(V_in, V_out, P_out) * V_in * S1.f32_ExpEff;
        }

        static public float Cal_Po_verification(float V_in, float V_out, float P_out)
        {
            float poMaxLimitation = Cal_Po_max_Limitation(V_in, V_out, P_out);
            return (P_out < poMaxLimitation) ? P_out : poMaxLimitation;
        }

        static public float Cal_I_CRM(float V_in, float V_out, int N_L)  //CRM Boundary of each PV Input
        {   //N_L means turns of L
            float f32_Temp;
            f32_Temp = (V_in * V_out - V_in * V_in) / (2 * S1.f32_fs * S2.L.f32_Lpv0 * V_out);
            return f32_Temp;
        }
        static public float Cal_H_Field(float V_in, float V_out, float P_out, float N_L) //P_out's unit is W
        {
            return 100 * (N_L * Cal_InDC_onePV(V_in, V_out, P_out)) / S2.L.f32_MagLen;
        }
        static public float Cal_Mu_DC_bias_ratio(float V_in, float V_out, float P_out, float N_L)
        {
            float H_e = Cal_H_Field(V_in, V_out, P_out, N_L);
            float f32_Tmp;
            f32_Tmp = POW((H_e / (S2.L.LinAttCoeff.f32_b1 * cOe_cvt)), S2.L.LinAttCoeff.f32_c1);
            return ((S2.L.LinAttCoeff.f32_a1 / (1 + f32_Tmp)) + S2.L.LinAttCoeff.f32_d1) / 100;

        }

        static public float Cal_Lpv_Correct(float V_in, float V_out, float P_out, float N_L)
        {
            float f32_Lpv0_Temp;
            f32_Lpv0_Temp = (S2.L.f32_Factor * N_L * N_L) / 1000000000f;
            return f32_Lpv0_Temp * Cal_Mu_DC_bias_ratio(V_in, V_out, P_out, N_L);
        }

        static public float Cal_D_boost(float V_in, float V_out, float P_out, float N_L)
        {
            if (V_in < V_out)
            {
                float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
                float i_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L); // Placeholder for IN_CRM calculation
                int rectifierMode = S1.i16_SR;

                if (I_inDC_onePV >= i_in_CRM || rectifierMode == 2)
                {
                    return 1 - V_in / V_out;
                }
                else
                {
                    return SQRT((1 - V_in / V_out) * (2 * S1.f32_fs * Cal_Lpv_Correct(V_in, V_out, P_out, N_L) * I_inDC_onePV) / V_in);
                }
            }
            else
            {
                return 0;
            }
        }

        static public float Cal_Dp_boost(float V_in, float V_out, float P_out, float N_L)
        {
            if (V_in < V_out)
            {
                float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
                float I_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L); // Placeholder for IN_CRM calculation
                int rectifierMode = S1.i16_SR;

                if (I_inDC_onePV >= I_in_CRM || rectifierMode == 2)
                {
                    return V_in / V_out;
                }
                else
                {
                    return SQRT((V_in / (V_out - V_in)) * (2 * S1.f32_fs * Cal_Lpv_Correct(V_in, V_out, P_out, N_L) * I_inDC_onePV) / V_out);
                }
            }
            else
            {
                return 1;
            }
        }

        static public float Cal_Delta_Iin(float V_in, float V_out, float P_out, float N_L)
        {
            if (V_in < V_out)
            {
                float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
                float I_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L); // Placeholder for IN_CRM calculation
                int rectifierMode = S1.i16_SR;

                if (I_inDC_onePV >= I_in_CRM || rectifierMode == 2)
                {
                    return (1 - V_in / V_out) * V_in / (S1.f32_fs * Cal_Lpv_Correct(V_in, V_out, P_out, N_L));
                }
                else
                {
                    return SQRT((1 - V_in / V_out) * (2 * I_inDC_onePV * V_in) / (S1.f32_fs * Cal_Lpv_Correct(V_in, V_out, P_out, N_L)));
                }
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_IinL(float V_in, float V_out, float P_out, float N_L)
        {
            float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
            float delta_Iin = Cal_Delta_Iin(V_in, V_out, P_out, N_L);
            float I_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L);


            if (V_in < V_out)
            {
                if (I_inDC_onePV >= I_in_CRM || S1.i16_SR == 2)
                {
                    return I_inDC_onePV - delta_Iin / 2;
                }
                else
                {
                    return 0;
                }
            }
            else if (V_in == V_out)
            {
                return I_inDC_onePV;
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_IinH(float V_in, float V_out, float P_out, float N_L)
        {
            float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
            float delta_Iin = Cal_Delta_Iin(V_in, V_out, P_out, N_L);
            float I_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L);

            if (V_in < V_out)
            {
                if (I_inDC_onePV >= I_in_CRM || S1.i16_SR == 2)
                {
                    return I_inDC_onePV + delta_Iin / 2;
                }
                else
                {
                    return SQRT((1 - V_in / V_out) * (2 * I_inDC_onePV * V_in) / (S1.f32_fs * Cal_Lpv_Correct(V_in, V_out, P_out, N_L)));
                }
            }
            else if (V_in == V_out)
            {
                return I_inDC_onePV;
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_dI1_in(float V_in, float V_out, float P_out, float N_L)
        {
            return V_in / Cal_Lpv_Correct(V_in, V_out, P_out, N_L);
        }
        static public float Cal_dI2_in(float V_in, float V_out, float P_out, float N_L)
        {
            return (V_in - V_out) / Cal_Lpv_Correct(V_in, V_out, P_out, N_L);
        }
        static public float Cal_L_Pv(float t, float V_in, float V_out, float P_out, float N_L)
        {
            float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
            float I_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L);
            float I_Lin_L = Cal_IinL(V_in, V_out, P_out, N_L);
            float I_Lin_H = Cal_IinH(V_in, V_out, P_out, N_L);
            float d_I1in = Cal_dI1_in(V_in, V_out, P_out, N_L);
            float d_I2in = Cal_dI2_in(V_in, V_out, P_out, N_L);

            float D_boost = Cal_D_boost(V_in, V_out, P_out, N_L);
            float Dp_boost = Cal_Dp_boost(V_in, V_out, P_out, N_L);

            if (V_in < V_out)
            {
                if (I_inDC_onePV >= I_in_CRM || S1.i16_SR == 2)
                {
                    if ((t % S1.f32_Ts) < (D_boost / S1.f32_fs))
                    {
                        return I_Lin_L + d_I1in * (t % S1.f32_Ts);
                    }
                    else
                    {
                        return I_Lin_H + d_I2in * ((t - D_boost / S1.f32_fs) % S1.f32_Ts);
                    }
                }
                else
                {
                    if ((t % S1.f32_Ts) < (D_boost / S1.f32_fs))
                    {
                        return I_Lin_L + d_I1in * (t % S1.f32_Ts);
                    }
                    else if ((D_boost / S1.f32_fs) <= (t % S1.f32_Ts) && (t % S1.f32_Ts) < (D_boost / S1.f32_fs + Dp_boost / S1.f32_fs))
                    {
                        return I_Lin_H + d_I2in * ((t - D_boost / S1.f32_fs) % S1.f32_Ts);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return I_inDC_onePV;
            }
        }
        static public float Cal_I_rms(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_i_L_Pv = (float)GaussLegendreRule.Integrate(
                    t => (double)Cal_L_Pv((float)t, V_in, V_out, P_out, N_L) * Cal_L_Pv((float)t, V_in, V_out, P_out, N_L),  // 被积函数
                    0,                 // 积分下限
                    S1.f32_Ts,           // 积分上限
                    128                 // 高斯-勒让德积分的节点数（越大精度越高）
                    );
            return SQRT(S1.f32_fs * Inte_i_L_Pv);
        }
        static public float Cal_I_avg(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_i_L_Pv = (float)GaussLegendreRule.Integrate(
                    t => (double)Cal_L_Pv((float)t, V_in, V_out, P_out, N_L),  // 被积函数
                    0,                 // 积分下限
                    S1.f32_Ts,           // 积分上限
                    128                 // 高斯-勒让德积分的节点数（越大精度越高）
                    );
            return S1.f32_fs * Inte_i_L_Pv;
        }
        static public float Cal_I_MosBst(float t, float V_in, float V_out, float P_out, float N_L)
        {
            float iLpv = Cal_L_Pv(t, V_in, V_out, P_out, N_L);
            float D_boost = Cal_D_boost(V_in, V_out, P_out, N_L);

            if (V_in < V_out)
            {
                if ((t % S1.f32_Ts) <= (D_boost / S1.f32_fs))
                {
                    return iLpv;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_Body_Conduction_FlagMOS(float t, float V_in, float V_out, float P_out, float N_L)
        {
            float iMosBst = Cal_I_MosBst(t, V_in, V_out, P_out, N_L);

            if ((iMosBst < 0) && S1.i16_SR == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_I_DiodeBst(float t, float V_in, float V_out, float P_out, float N_L)
        {
            float iLpv = Cal_L_Pv(t, V_in, V_out, P_out, N_L);
            float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
            float D_boost = Cal_D_boost(V_in, V_out, P_out, N_L);

            if (V_in < V_out)
            {
                if ((D_boost / S1.f32_fs) < (t % S1.f32_Ts))
                {
                    return iLpv;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return I_inDC_onePV;
            }
        }
        static public float Cal_0CrossTime(float V_in, float V_out, float P_out, float N_L)
        {
            float I_Lin_L = Cal_IinL(V_in, V_out, P_out, N_L);
            float d_I1in = Cal_dI1_in(V_in, V_out, P_out, N_L);


            if ((I_Lin_L < 0) && S1.i16_SR == 2)
            {
                return -I_Lin_L / d_I1in;
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_Iavg_BstMosBodyDiode(float V_in, float V_out, float P_out, float N_L)
        {
            float Zero_CrossTime = Cal_0CrossTime(V_in, V_out, P_out, N_L);
            if ((Zero_CrossTime != 0) && S1.i16_SR == 2)
            {
                float Inte_iMosBst = (float)GaussLegendreRule.Integrate(
                t => (double)Cal_I_MosBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
                0,                 // 积分下限
                Zero_CrossTime,           // 积分上限
                128                 // 高斯-勒让德积分的节点数（越大精度越高）
                );
                return S1.f32_fs * Inte_iMosBst;
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_Irms_BstMos(float V_in, float V_out, float P_out, float N_L)
        {
            float Zero_CrossTime = Cal_0CrossTime(V_in, V_out, P_out, N_L);
            float D_boost = Cal_D_boost(V_in, V_out, P_out, N_L);

            if (S1.i16_SR == 1)
            {
                float Inte_iMosBst_1 = (float)GaussLegendreRule.Integrate(
                t => (double)Cal_I_MosBst((float)t, V_in, V_out, P_out, N_L) * (double)Cal_I_MosBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
                0,                   // 积分下限
                S1.f32_Ts,           // 积分上限
                128                  // 高斯-勒让德积分的节点数（越大精度越高）
                );
                return SQRT(S1.f32_fs * Inte_iMosBst_1);
            }
            else if (S1.i16_SR == 2)
            {
                float Inte_iMosBst_2 = (float)GaussLegendreRule.Integrate(
                t => (double)Cal_I_MosBst((float)t, V_in, V_out, P_out, N_L) * Cal_I_MosBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
                Zero_CrossTime,             // 积分下限
                D_boost / S1.f32_fs,        // 积分上限
                128                         // 高斯-勒让德积分的节点数（越大精度越高）
                );
                return SQRT(S1.f32_fs * Inte_iMosBst_2);
            }
            else
            {
                return 0;
            }
        }
        static public float Cal_Iavg_BstMos(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_iMosBst = (float)GaussLegendreRule.Integrate(
            t => (double)Cal_I_MosBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
            0,                 // 积分下限
            S1.f32_Ts,           // 积分上限
            128                 // 高斯-勒让德积分的节点数（越大精度越高）
            );
            return S1.f32_fs * Inte_iMosBst;
        }
        static public float Cal_Irms_BstDiode(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_iDiodeBst2 = (float)GaussLegendreRule.Integrate(
            t => (double)Cal_I_DiodeBst((float)t, V_in, V_out, P_out, N_L) * (double)Cal_I_DiodeBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
            0,                   // 积分下限
            S1.f32_Ts,           // 积分上限
            128                  // 高斯-勒让德积分的节点数（越大精度越高）
            );
            return SQRT(S1.f32_fs * Inte_iDiodeBst2);
        }
        static public float Cal_Iavg_BstDiode(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_iDiodeBst = (float)GaussLegendreRule.Integrate(
            t => (double)Cal_I_DiodeBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
            0,                 // 积分下限
            S1.f32_Ts,           // 积分上限
            128                 // 高斯-勒让德积分的节点数（越大精度越高）
            );
            return S1.f32_fs * Inte_iDiodeBst;
        }
        static public float Cal_Iavg_BstDiode_Ontime(float V_in, float V_out, float P_out, float N_L)
        {
            float D_boost = Cal_D_boost(V_in, V_out, P_out, N_L);
            float Dp_boost = Cal_Dp_boost(V_in, V_out, P_out, N_L);

            float Inte_iDiodeBst = (float)GaussLegendreRule.Integrate(
            t => (double)Cal_I_DiodeBst((float)t, V_in, V_out, P_out, N_L),  // 被积函数
            D_boost / S1.f32_fs,                        // 积分下限
            (D_boost + Dp_boost) / S1.f32_fs,           // 积分上限
            128                                         // 高斯-勒让德积分的节点数（越大精度越高）
            );
            return S1.f32_fs / Dp_boost * Inte_iDiodeBst;
        }
    }
}
