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

    public struct InputCircuitSpecifications
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
    public partial class Form1 : Form
    {
        InputCircuitSpecifications Section1; //Data in section1
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
            Section1.Vpv.f32_Normal = GetFloatValue(VpvNorm.Text);
            Section1.Vpv.f32_Max = GetFloatValue(Vpvmax.Text);
            Section1.Vpv.f32_Min = GetFloatValue(Vpvmin.Text);

            Section1.V_Inv_Bus.f32_Normal = GetFloatValue(VBUSNor.Text);
            Section1.V_Inv_Bus.f32_Max = GetFloatValue(VBUSMax.Text);
            Section1.V_Inv_Bus.f32_Min = GetFloatValue(VBUSMin.Text);

            Section1.Po.f32_Max = GetFloatValue(RatedPwr.Text);
            Section1.Po.f32_ForCalc = GetFloatValue(CalPwr.Text);

            Section1.i16_N_PV = GetIntValue(N_Pv.Text);
            Section1.f32_MaxInCur = GetFloatValue(IinMax.Text);
            Section1.f32_fs = GetFloatValue(fs.Text);

            Section1.f32_ExpEff = GetFloatValue(Expected_Effi.Text);
            Section1.i16_SR = GetIntValue(SRMode.Text);

            Section1.Po.f32_onePV = Section1.Po.f32_ForCalc / Section1.i16_N_PV;
            Section1.f32_Ts = 1 / Section1.f32_fs;
            Section1.Pin.f32_onePV = Section1.Po.f32_ForCalc / (Section1.i16_N_PV * Section1.f32_ExpEff); //Seems redundant



            float sum = 2 * cPi * Section1.Vpv.f32_Max;

  
            Results.Text = sum.ToString();
        }

        // 辅助方法：如果文本框为空或无法转换为浮点数，则返回0
        private float GetFloatValue(string text)
        {
            float result = 0f;
            if (!string.IsNullOrEmpty(text) && !float.TryParse(text, out result))
            {
                result = 0f; // 如果转换失败，返回0
            }
            return result;
        }

        // 辅助方法：如果文本框为空或无法转换为整数，则返回0
        private int GetIntValue(string text)
        {
            int result = 0;
            if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out result))
            {
                result = 0; // 如果转换失败，返回0
            }
            return result;
        }
    }
}
