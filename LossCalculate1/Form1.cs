using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Bond;
using MathNet.Numerics.Integration;
using NHibernate.Mapping;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LossCalculate1
{
    public struct VOLTAGE
    {
        public float f32_Min;
        public float f32_Normal;
        public float f32_Max;

        //used for cal
        public float f32_InCal;
        public float f32_OutCal;
    }
    public struct POWER
    {
        public float f32_All; //Sum of PV Power, used for calculate
        public float f32_Max; //Max or Rated

        public float f32_onePV; // = Po_all / N_Pv
    }
    public struct Input_Circuit_Specifications
    {
        public VOLTAGE Vpv;         // PV Voltage
        public VOLTAGE V_Inv_Bus;   // Inverter Bus Voltage
        public POWER Po;            // Power out
        public POWER Pin;           // Power in

        public float f32_MaxInCur;     //Maximum Input Current of Each PV Input
        public float f32_fs;           //Switching Frequency
        public float f32_Ts;           // 1 / fs
        public float f32_Tshift;       //Multiple PV Input Phase Shift Time
        public float f32_ExpEff;       //Expected Efficiency

        public int i16_N_PV;           //Number of PV or BAT Parallel Input
        public int i16_SR;             //Synchronous rectification mode [1: Diode mode; 2: SR mode ]
    }
    public struct COEFFICIENT
    {
        public float f32_a0;
        public float f32_a1;
        public float f32_b0;
        public float f32_b1;
        public float f32_c0;
        public float f32_c1;
        public float f32_d1;
    }
    public struct INDUCTOR
    {
        public float f32_L_NoBias;        // Inductor L Without Bias
        public float f32_Factor;          // Inductor Factor (nH)
        public float f32_Turns;           // Inductor Turns
        public float f32_MagLen;          // Magnetic Path Length
        public float f32_CoreArea;        // Core Cross-section Area
        public float f32_CoreVol;         // Core Volume
        public float f32_MaxDCR_Pwr;      // Max DCR Power
        public float f32_MaxDCR_EMI_Pos;  // Max DCR EMI Positive
        public float f32_MaxDCR_EMI_Neg;  // Max DCR EMI Negative
        public float f32_AC_DCR_Coeff;    // AC DCR Coefficient
        public float f32_MaxTemp_Pwr;     // Max Temp Power
        public float f32_MaxTemp_EMI;     // Max Temp EMI

        public COEFFICIENT SteinCoeff;    // Steinmetz Coefficient
        public COEFFICIENT LinAttCoeff;   // Linear Attenuation Coefficient

        //below value is computed automatically
        public float f32_Lpv0;            // Turns of Power Inductor (H)
    }
    public struct CAPACITOR
    {
        public float f32_C_Single;        // Single Capacitance (uF)
        public float f32_TanSigma;        // Tan Sigma @ 120Hz
        public float f32_C_In;            // Input Capacitance
        public float f32_ESR_In;          // Input ESR
        public int i16_ParCount;          // Parallel Count
        public int i16_SerCount;          // Series Count

        //below value is computed automatically
        public float f32_C_Equiv;         // Equivalent Capacitance (F)
        public float f32_ESR_Equiv;       // Equivalent ESR (ohm)
    }
    public struct Input_Inductor_Capacitor_EMI
    {
        public INDUCTOR L;
        public CAPACITOR C;
    }
    public struct Waveform_Calculation
    {
        public VOLTAGE V;
    }
    public partial class Form1 : Form
    {
        Input_Circuit_Specifications S1; //Data in Section1
        Input_Inductor_Capacitor_EMI S2; //Data in Section2
        Waveform_Calculation S3;         //Data in Section3
        public static float COSINE(float a) => (float)Math.Cos(a);
        public static float SINE(float a) => (float)Math.Sin(a);
        public static float SQRT(float a) => (float)Math.Sqrt(a);
        public static float FABS(float a) => Math.Abs(a);
        public static float IFMAX(float a, float b) => (a >= b) ? a : b;
        public static float IFMIN(float a, float b) => (a < b) ? a : b;
        public static float CLAMP(float a, float b, float c) => IFMIN(IFMAX(a, b), c);
        public static float POW(float a, float b) => (float)Math.Pow(a, b);

        public const float cPi = 3.14159265358979323846F;
        public const float cSqrt3 = 1.73205080756887729352F;
        public const float cSqrt2 = 1.41421356237309504880F;
        public const float cOe_cvt = 1 / (4 * cPi * 0.001f); //oe to A/m

        public Form1()
        {
            InitializeComponent();
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox_Load();
        }
        private void ComboBox_Load()
        {
            // 初始化 ComboBox
            comboBox1.Items.Add("I_inDC_onePV");
            comboBox1.Items.Add("IoDC_onePV");
            comboBox1.Items.Add("Po_max_Limitation");
            comboBox1.Items.Add("Lpv_ILX");
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart(comboBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeInputSpecifications();
            InitializeInductorCapacitorEMI();
            DrawChart(comboBox1.SelectedIndex);

            //float sum = Cal_H_Field(S1.Vpv.f32_Min, Cal_Vo_BST(S1.Vpv.f32_Min), 10000, S2.L.f32_Turns);
            float sum = Cal_Dp_boost(S1.Vpv.f32_Normal, Cal_Vo_BST(S1.Vpv.f32_Normal), 0.01f * S1.Po.f32_All, S2.L.f32_Turns);
            Results.Text = sum.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AssignDefaultValues();
            DisplayAssignedValues();
        }

        private void InitializeInputSpecifications()
        {
            //Section1
            S1.Vpv.f32_Normal = GetFloatValue(VpvNorm.Text);
            S1.Vpv.f32_Max = GetFloatValue(Vpvmax.Text);
            S1.Vpv.f32_Min = GetFloatValue(Vpvmin.Text);

            S1.V_Inv_Bus.f32_Normal = GetFloatValue(VBUSNor.Text);
            S1.V_Inv_Bus.f32_Max = GetFloatValue(VBUSMax.Text);
            S1.V_Inv_Bus.f32_Min = GetFloatValue(VBUSMin.Text);

            S1.Po.f32_Max = GetFloatValue(RatedPwr.Text);
            S1.Po.f32_All = GetFloatValue(CalPwr.Text);

            S1.i16_N_PV = GetIntValue(N_Pv.Text);
            S1.f32_MaxInCur = GetFloatValue(IinMax.Text);
            S1.f32_fs = GetFloatValue(fs.Text);

            S1.f32_ExpEff = GetFloatValue(Expected_Effi.Text);
            S1.i16_SR = GetIntValue(SRMode.Text);

            //below value is computed automatically
            S1.Po.f32_onePV = S1.Po.f32_All / S1.i16_N_PV;
            S1.f32_Ts = 1 / S1.f32_fs;
            S1.Pin.f32_onePV = S1.Po.f32_All / (S1.i16_N_PV * S1.f32_ExpEff); //Seems redundant
        }

        private void InitializeInductorCapacitorEMI()
        {
            //Section2
            S2.L.f32_L_NoBias = GetFloatValue(L_NoBias.Text);
            S2.L.f32_Factor = GetFloatValue(Factor.Text);
            S2.L.f32_Turns = GetFloatValue(Turns.Text);
            S2.L.f32_MagLen = GetFloatValue(MagLen.Text);
            S2.L.f32_CoreArea = GetFloatValue(CoreArea.Text);
            S2.L.f32_CoreVol = GetFloatValue(CoreVol.Text);

            S2.L.SteinCoeff.f32_a0 = GetFloatValue(SteinCoeff_a0.Text);
            S2.L.SteinCoeff.f32_b0 = GetFloatValue(SteinCoeff_b0.Text);
            S2.L.SteinCoeff.f32_c0 = GetFloatValue(SteinCoeff_c0.Text);

            S2.L.LinAttCoeff.f32_a1 = GetFloatValue(AttCoeff_a1.Text);
            S2.L.LinAttCoeff.f32_b1 = GetFloatValue(AttCoeff_b1.Text);
            S2.L.LinAttCoeff.f32_c1 = GetFloatValue(AttCoeff_c1.Text);
            S2.L.LinAttCoeff.f32_d1 = GetFloatValue(AttCoeff_d1.Text);

            S2.L.f32_MaxDCR_Pwr = GetFloatValue(MaxDCRPwr.Text);
            S2.L.f32_MaxDCR_EMI_Neg = GetFloatValue(MaxDCREMI_N.Text);
            S2.L.f32_MaxDCR_EMI_Pos = GetFloatValue(MaxDCREMI_P.Text);
            S2.L.f32_AC_DCR_Coeff = GetFloatValue(AC_Coeffi.Text);
            S2.L.f32_MaxTemp_Pwr = GetFloatValue(TempPwr.Text);
            S2.L.f32_MaxTemp_EMI = GetFloatValue(TempEMI.Text);

            S2.C.f32_C_Single = GetFloatValue(C_Single.Text);
            S2.C.i16_ParCount = GetIntValue(ParCount.Text);
            S2.C.i16_SerCount = GetIntValue(SerCount.Text);
            S2.C.f32_TanSigma = GetFloatValue(TanSigma.Text);
            S2.C.f32_C_In = GetFloatValue(Cin.Text);
            S2.C.f32_ESR_In = GetFloatValue(ESR_Cin.Text);

            //below value is computed automatically
            S2.L.f32_Lpv0 = (S2.L.f32_Factor * S2.L.f32_Turns * S2.L.f32_Turns) / 1000000000f;
            S2.C.f32_C_Equiv = (S2.C.f32_C_Single * (float)S2.C.i16_ParCount) / ((float)S2.C.i16_SerCount) / 1000000f;
            S2.C.f32_ESR_Equiv = (1 / (2.0f * cPi * 120f * S2.C.f32_C_Equiv)) * S2.C.f32_TanSigma;
        }

        public void WaveformCalculation()
        {
        }

        //Below this line is functions in WaveformCalculation(S3)
        private float Cal_Vo_BST(float V_in)  
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

        private float Cal_InDC_onePV(float V_in, float V_out, float P_out)
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

        private float Cal_IoDC_onePV(float V_in, float V_out, float P_out)
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
        private float Cal_Po_max_Limitation(float V_in, float V_out, float P_out)
        {
            return S1.i16_N_PV * Cal_InDC_onePV(V_in, V_out, P_out) * V_in * S1.f32_ExpEff;
        }

        private float Cal_Po_verification(float V_in, float V_out, float P_out)
        {
            float poMaxLimitation = Cal_Po_max_Limitation(V_in, V_out, P_out);
            return (P_out < poMaxLimitation) ? P_out : poMaxLimitation;
        }

        private float Cal_I_CRM(float V_in, float V_out, int N_L)  //CRM Boundary of each PV Input
        {   //N_L means turns of L
            float f32_Temp;
            f32_Temp = (V_in * V_out - V_in * V_in) / (2 * S1.f32_fs * S2.L.f32_Lpv0 * V_out);
            return f32_Temp;
        }
        private float Cal_H_Field(float V_in, float V_out, float P_out, float N_L) //P_out's unit is W
        {
            return 100 * (N_L * Cal_InDC_onePV(V_in, V_out, P_out)) / S2.L.f32_MagLen;
        }
        private float Cal_Mu_DC_bias_ratio(float V_in, float V_out, float P_out, float N_L)
        {
            float H_e = Cal_H_Field(V_in, V_out, P_out, N_L);
            float f32_Tmp;
            f32_Tmp = POW((H_e / (S2.L.LinAttCoeff.f32_b1 * cOe_cvt)), S2.L.LinAttCoeff.f32_c1);
            return ((S2.L.LinAttCoeff.f32_a1 / (1 + f32_Tmp)) + S2.L.LinAttCoeff.f32_d1) / 100;

        }

        private float Cal_Lpv_Correct(float V_in, float V_out, float P_out, float N_L)
        {
            float f32_Lpv0_Temp;
            f32_Lpv0_Temp = (S2.L.f32_Factor * N_L * N_L) / 1000000000f;
            return f32_Lpv0_Temp * Cal_Mu_DC_bias_ratio(V_in, V_out, P_out, N_L);
        }

        private float Cal_D_boost(float V_in, float V_out, float P_out, float N_L)
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

        private float Cal_Dp_boost(float V_in, float V_out, float P_out, float N_L)
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

        private float Cal_Delta_Iin(float V_in, float V_out, float P_out, float N_L)
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
        private float Cal_IinL(float V_in, float V_out, float P_out, float N_L)
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
        private float Cal_IinH(float V_in, float V_out, float P_out, float N_L)
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
        private float Cal_dI1_in(float V_in, float V_out, float P_out, float N_L)
        {
            return V_in / Cal_Lpv_Correct(V_in, V_out, P_out, N_L);
        }
        private float Cal_dI2_in(float V_in, float V_out, float P_out, float N_L)
        {
            return (V_in - V_out) / Cal_Lpv_Correct(V_in, V_out, P_out, N_L);
        }
        private float Cal_L_Pv(float t, float V_in, float V_out, float P_out, float N_L)
        {
            float I_inDC_onePV = Cal_InDC_onePV(V_in, V_out, P_out);
            float delta_Iin = Cal_Delta_Iin(V_in, V_out, P_out, N_L);
            float I_in_CRM = Cal_I_CRM(V_in, V_out, (int)N_L);
            float I_Lin_L = Cal_IinL(V_in, V_out, P_out, N_L);
            float I_Lin_H = Cal_IinH(V_in, V_out, P_out, N_L);
            float d_I1in = Cal_dI1_in(V_in, V_out, P_out, N_L);
            float d_I2in = Cal_dI2_in(V_in, V_out, P_out, N_L);

            int rectifierMode = S1.i16_SR;
            float D_boost = Cal_D_boost(V_in, V_out, P_out, N_L);
            float Dp_boost = Cal_Dp_boost(V_in, V_out, P_out, N_L);

            if (V_in < V_out)
            {
                if (I_inDC_onePV >= I_in_CRM || S1.i16_SR == 2)
                {
                    if((t % S1.f32_Ts) < (D_boost / S1.f32_fs))
                    {
                        return I_Lin_L + d_I1in * (t % S1.f32_Ts);
                    }
                    else
                    {
                        return I_Lin_H + d_I2in * ((t - D_boost / S1.f32_Ts) % S1.f32_Ts);
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
                        return I_Lin_H + d_I2in * ((t - D_boost / S1.f32_Ts) % S1.f32_Ts);
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
        private float Cal_I_rms(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_i_L_Pv = (float)GaussLegendreRule.Integrate(
                    t => (double)Cal_L_Pv((float)t, V_in,V_out, P_out, N_L),  // 被积函数
                    0,                 // 积分下限
                    S1.f32_Ts,           // 积分上限
                    32                 // 高斯-勒让德积分的节点数（越大精度越高）
                    );
            return SQRT(S1.f32_fs * Inte_i_L_Pv);
        }
        private float Cal_I_avg(float V_in, float V_out, float P_out, float N_L)
        {
            float Inte_i_L_Pv = (float)GaussLegendreRule.Integrate(
                    t => (double)Cal_L_Pv((float)t, V_in, V_out, P_out, N_L),  // 被积函数
                    0,                 // 积分下限
                    S1.f32_Ts,           // 积分上限
                    32                 // 高斯-勒让德积分的节点数（越大精度越高）
                    );
            return S1.f32_fs * Inte_i_L_Pv;
        }
        private void DrawChart(int chartIndex)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();  // 添加清除 ChartArea，以防止重复显示

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            Series series = new Series(comboBox1.Items[chartIndex].ToString());
            series.ChartType = SeriesChartType.Line;

            // 根据选择的图表绘制不同的曲线
            switch (chartIndex)
            {
                case 0:
                    DrawChart1(series);
                    break;
                case 1:
                    DrawChart2(series);
                    break;
                case 2:
                    DrawChart3(series);
                    break;
                case 3: 
                    DrawChart4(series);
                    break;
            }
            chart1.Series.Add(series); //Tricks is in 'Series clear & add', if don't do this, data will not be reload.
            //chart1.ResetAutoValues();  // 重置轴的自动范围
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart1.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart1.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart1.ChartAreas[0].AxisY.Maximum = double.NaN;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.Update();
            chart1.Invalidate();
        }

        private void DrawChart1(Series series)
        {
            // 折线图1 ：V_in 从 0 到 1000 递增，并计算对应的 I_inDC_onePV
            for (float vin = 0; vin <= 1000; vin += 2)
            {
                float iinDConePV = Cal_InDC_onePV(vin, Cal_Vo_BST(vin), 10000); // V_out 和 P_out 为示例值
                series.Points.AddXY(vin, iinDConePV);
            }
        }
        private void DrawChart2(Series series)
        {
            // 折线图2 ：V_in 从 0 到 1000 递增，并计算对应的 IoDC_onePV
            for (float vin = 0; vin <= 1000; vin += 2)
            {
                float ioDConePV = Cal_IoDC_onePV(vin, Cal_Vo_BST(vin), 10000); // V_out 和 P_out 为示例值
                series.Points.AddXY(vin, ioDConePV);
            }
        }

        private void DrawChart3(Series series)
        {
            // 折线图3 ：V_in 从 0 到 1000 递增，并计算对应的 Po_max_Limitation
            for (float vin = 0; vin <= 1000; vin += 2)
            {
                float poMaxLimitation = Cal_Po_max_Limitation(vin, Cal_Vo_BST(vin), 20000); // V_out 和 P_out 为示例值
                series.Points.AddXY(vin, poMaxLimitation);
            }
        }
        private void DrawChart4(Series series)
        {
            // 折线图3 ：I_Lx 从 0 到 1000 递增，并计算对应的 Lpv
            for (float Ilx = 0; Ilx <= 20; Ilx += 0.02f)
            {
                float Lpv = Cal_Lpv_Correct(200, 750, Ilx * 200 * S1.f32_ExpEff, S2.L.f32_Turns); // V_out 和 P_out 为示例值
                series.Points.AddXY(Ilx, Lpv);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox2.Image = Image.FromFile("D:\\Self_Soft\\VS2022\\Workplace\\LossCalculate1\\picture\\pic1.jpg"); // 修改为实际图片的路径
                    break;
                case 1:
                    pictureBox2.Image = Image.FromFile("D:\\Self_Soft\\VS2022\\Workplace\\LossCalculate1\\picture\\pic2.png");
                    break;
            }
            DrawChart(comboBox1.SelectedIndex);
        }
        private float GetFloatValue(string text)
        {
            float result = 0f;
            if (!string.IsNullOrEmpty(text) && !float.TryParse(text, out result))
            {
                result = 0f; // 如果转换失败，返0
            }
            return result;
        }

        private int GetIntValue(string text)
        {
            int result = 0;
            if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out result))
            {
                result = 1; // 如果转换失败，返1
            }
            return result;
        }

        private void AssignDefaultValues()
        {
            // Assign all inputs the default value of 3 for debugging purposes
            S1.Vpv = new VOLTAGE { f32_Min = 120, f32_Normal = 600, f32_Max = 950 };
            S1.V_Inv_Bus = new VOLTAGE { f32_Min = 120, f32_Normal = 750, f32_Max = 1000 };
            S1.Po = new POWER { f32_All = 10000, f32_Max = 12000, f32_onePV = 3333 };
            S1.Pin = new POWER { f32_All = 3, f32_Max = 3, f32_onePV = 3 };
            S1.f32_MaxInCur = 20;
            S1.f32_fs = 36000;
            S1.f32_Ts = 1 / S1.f32_fs;
            S1.f32_Tshift = 1/4 * S1.f32_Ts;
            S1.f32_ExpEff = 0.99f;
            S1.i16_N_PV = 3;
            S1.i16_SR = 1;

            S2.L = new INDUCTOR
            {
                f32_L_NoBias = 1080,
                f32_Factor = 192,
                f32_Turns = 75,
                f32_MagLen = 14.37f,
                f32_CoreArea = 3.65f,
                f32_CoreVol = 52.81f,
                f32_MaxDCR_Pwr = 38,
                f32_MaxDCR_EMI_Pos = 0.007f,
                f32_MaxDCR_EMI_Neg = 0.0025f,
                f32_AC_DCR_Coeff = 1.1f,
                f32_MaxTemp_Pwr = 120,
                f32_MaxTemp_EMI = 120,
                SteinCoeff = new COEFFICIENT { f32_a0 = 1.9638f, f32_a1 = 0, f32_b0 = 2.4352f, f32_b1 = 0, f32_c0 = 0.0259f, f32_c1 = 0, f32_d1 = 0 },
                LinAttCoeff = new COEFFICIENT { f32_a0 = 0, f32_a1 = 96.2184f, f32_b0 = 0, f32_b1 = 133.3088f, f32_c0 = 0, f32_c1 = 2.6102f, f32_d1 = 2.4737f },
                f32_Lpv0 = 3
            };

            S2.C = new CAPACITOR
            {
                f32_C_Single = 680,
                f32_TanSigma = 0.2f,
                f32_C_In = 12,
                f32_ESR_In = 0.009f,
                i16_ParCount = 5,
                i16_SerCount = 2,
                f32_C_Equiv = 0.0017f,
                f32_ESR_Equiv = 0.156f
            };
        }

        private void DisplayAssignedValues()
        {
            VpvNorm.Text = S1.Vpv.f32_Normal.ToString();
            Vpvmax.Text = S1.Vpv.f32_Max.ToString();
            Vpvmin.Text = S1.Vpv.f32_Min.ToString();

            VBUSNor.Text = S1.V_Inv_Bus.f32_Normal.ToString();
            VBUSMax.Text = S1.V_Inv_Bus.f32_Max.ToString();
            VBUSMin.Text = S1.V_Inv_Bus.f32_Min.ToString();

            RatedPwr.Text = S1.Po.f32_Max.ToString();
            CalPwr.Text = S1.Po.f32_All.ToString();

            N_Pv.Text = S1.i16_N_PV.ToString();
            IinMax.Text = S1.f32_MaxInCur.ToString();
            fs.Text = S1.f32_fs.ToString();

            Expected_Effi.Text = S1.f32_ExpEff.ToString();
            SRMode.Text = S1.i16_SR.ToString();

            L_NoBias.Text = S2.L.f32_L_NoBias.ToString();
            Factor.Text = S2.L.f32_Factor.ToString();
            Turns.Text = S2.L.f32_Turns.ToString();
            MagLen.Text = S2.L.f32_MagLen.ToString();
            CoreArea.Text = S2.L.f32_CoreArea.ToString();
            CoreVol.Text = S2.L.f32_CoreVol.ToString();

            SteinCoeff_a0.Text = S2.L.SteinCoeff.f32_a0.ToString();
            SteinCoeff_b0.Text = S2.L.SteinCoeff.f32_b0.ToString();
            SteinCoeff_c0.Text = S2.L.SteinCoeff.f32_c0.ToString();

            AttCoeff_a1.Text = S2.L.LinAttCoeff.f32_a1.ToString();
            AttCoeff_b1.Text = S2.L.LinAttCoeff.f32_b1.ToString();
            AttCoeff_c1.Text = S2.L.LinAttCoeff.f32_c1.ToString();
            AttCoeff_d1.Text = S2.L.LinAttCoeff.f32_d1.ToString();

            MaxDCRPwr.Text = S2.L.f32_MaxDCR_Pwr.ToString();
            MaxDCREMI_N.Text = S2.L.f32_MaxDCR_EMI_Neg.ToString();
            MaxDCREMI_P.Text = S2.L.f32_MaxDCR_EMI_Pos.ToString();
            AC_Coeffi.Text = S2.L.f32_AC_DCR_Coeff.ToString();
            TempPwr.Text = S2.L.f32_MaxTemp_Pwr.ToString();
            TempEMI.Text = S2.L.f32_MaxTemp_EMI.ToString();

            C_Single.Text = S2.C.f32_C_Single.ToString();
            ParCount.Text = S2.C.i16_ParCount.ToString();
            SerCount.Text = S2.C.i16_SerCount.ToString();
            TanSigma.Text = S2.C.f32_TanSigma.ToString();
            Cin.Text = S2.C.f32_C_In.ToString();
            ESR_Cin.Text = S2.C.f32_ESR_In.ToString();
        }
    }
}
