using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bond;
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
    }
    public struct POWER
    {
        public float f32_ForCalc; //Power for calculate
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
    public partial class Form1 : Form
    {
        Input_Circuit_Specifications S1; //Data in Section1
        Input_Inductor_Capacitor_EMI S2; //Data in Section2
        public static float COSINE(float a) => (float)Math.Cos(a);
        public static float SINE(float a) => (float)Math.Sin(a);
        public static float SQRT(float a) => (float)Math.Sqrt(a);
        public static float FABS(float a) => Math.Abs(a);
        public static float IFMAX(float a, float b) => (a >= b) ? a : b;
        public static float IFMIN(float a, float b) => (a < b) ? a : b;
        public static float CLAMP(float a, float b, float c) => IFMIN(IFMAX(a, b), c);

        public const float cPi = 3.14159265358979323846F;
        public const float cSqrt3 = 1.73205080756887729352F;
        public const float cSqrt2 = 1.41421356237309504880F;

        public Form1()
        {
            InitializeComponent();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeInputSpecifications();
            InitializeInductorCapacitorEMI();

            float sum = S2.C.f32_ESR_Equiv;

            Results.Text = sum.ToString();
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
            S1.Po.f32_ForCalc = GetFloatValue(CalPwr.Text);

            S1.i16_N_PV = GetIntValue(N_Pv.Text);
            S1.f32_MaxInCur = GetFloatValue(IinMax.Text);
            S1.f32_fs = GetFloatValue(fs.Text);

            S1.f32_ExpEff = GetFloatValue(Expected_Effi.Text);
            S1.i16_SR = GetIntValue(SRMode.Text);

            //below value is computed automatically
            S1.Po.f32_onePV = S1.Po.f32_ForCalc / S1.i16_N_PV;
            S1.f32_Ts = 1 / S1.f32_fs;
            S1.Pin.f32_onePV = S1.Po.f32_ForCalc / (S1.i16_N_PV * S1.f32_ExpEff); //Seems redundant
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
    }
}
