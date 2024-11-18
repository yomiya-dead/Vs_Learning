namespace LossCalculate1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public const float cXCount = 20F;
        public const float cYCount = 20F;
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Calculate = new System.Windows.Forms.Button();
            this.VpvNorm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vpvmax = new System.Windows.Forms.TextBox();
            this.Vpvmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VBUSMin = new System.Windows.Forms.TextBox();
            this.VBUSNor = new System.Windows.Forms.TextBox();
            this.VBUSMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RatedPwr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CalPwr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.N_Pv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IinMax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Expected_Effi = new System.Windows.Forms.TextBox();
            this.fs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SRMode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.L_NoBias = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Factor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Turns = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.MagLen = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CoreArea = new System.Windows.Forms.TextBox();
            this.CoreVol = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SteinCoeff_a0 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.SteinCoeff_b0 = new System.Windows.Forms.TextBox();
            this.SteinCoeff_c0 = new System.Windows.Forms.TextBox();
            this.AttCoeff_a1 = new System.Windows.Forms.TextBox();
            this.AttCoeff_b1 = new System.Windows.Forms.TextBox();
            this.AttCoeff_c1 = new System.Windows.Forms.TextBox();
            this.AttCoeff_d1 = new System.Windows.Forms.TextBox();
            this.MaxDCRPwr = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.MaxDCREMI_P = new System.Windows.Forms.TextBox();
            this.AC_Coeffi = new System.Windows.Forms.TextBox();
            this.TempPwr = new System.Windows.Forms.TextBox();
            this.TempEMI = new System.Windows.Forms.TextBox();
            this.C_Single = new System.Windows.Forms.TextBox();
            this.ParCount = new System.Windows.Forms.TextBox();
            this.SerCount = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.TanSigma = new System.Windows.Forms.TextBox();
            this.Cin = new System.Windows.Forms.TextBox();
            this.ESR_Cin = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.MaxDCREMI_N = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(1978, 172);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(141, 69);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // VpvNorm
            // 
            this.VpvNorm.Location = new System.Drawing.Point(35, 91);
            this.VpvNorm.Multiline = true;
            this.VpvNorm.Name = "VpvNorm";
            this.VpvNorm.Size = new System.Drawing.Size(115, 61);
            this.VpvNorm.TabIndex = 1;
            this.VpvNorm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pv_Input_Voltage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vpvmax
            // 
            this.Vpvmax.Location = new System.Drawing.Point(202, 91);
            this.Vpvmax.Multiline = true;
            this.Vpvmax.Name = "Vpvmax";
            this.Vpvmax.Size = new System.Drawing.Size(115, 61);
            this.Vpvmax.TabIndex = 1;
            this.Vpvmax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Vpvmin
            // 
            this.Vpvmin.Location = new System.Drawing.Point(372, 91);
            this.Vpvmin.Multiline = true;
            this.Vpvmin.Name = "Vpvmin";
            this.Vpvmin.Size = new System.Drawing.Size(115, 61);
            this.Vpvmin.TabIndex = 1;
            this.Vpvmin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vpv";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(196, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vpvmax";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(375, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vpvmin";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // VBUSMin
            // 
            this.VBUSMin.Location = new System.Drawing.Point(35, 247);
            this.VBUSMin.Multiline = true;
            this.VBUSMin.Name = "VBUSMin";
            this.VBUSMin.Size = new System.Drawing.Size(115, 61);
            this.VBUSMin.TabIndex = 1;
            this.VBUSMin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VBUSNor
            // 
            this.VBUSNor.Location = new System.Drawing.Point(202, 247);
            this.VBUSNor.Multiline = true;
            this.VBUSNor.Name = "VBUSNor";
            this.VBUSNor.Size = new System.Drawing.Size(115, 61);
            this.VBUSNor.TabIndex = 1;
            this.VBUSNor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VBUSMax
            // 
            this.VBUSMax.Location = new System.Drawing.Point(372, 247);
            this.VBUSMax.Multiline = true;
            this.VBUSMax.Name = "VBUSMax";
            this.VBUSMax.Size = new System.Drawing.Size(115, 61);
            this.VBUSMax.TabIndex = 1;
            this.VBUSMax.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Output INV BUS_Voltage";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(31, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Min";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(197, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Norminal";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(376, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // RatedPwr
            // 
            this.RatedPwr.Location = new System.Drawing.Point(37, 368);
            this.RatedPwr.Multiline = true;
            this.RatedPwr.Name = "RatedPwr";
            this.RatedPwr.Size = new System.Drawing.Size(115, 61);
            this.RatedPwr.TabIndex = 1;
            this.RatedPwr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(31, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 36);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rated Pwr";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalPwr
            // 
            this.CalPwr.Location = new System.Drawing.Point(204, 368);
            this.CalPwr.Multiline = true;
            this.CalPwr.Name = "CalPwr";
            this.CalPwr.Size = new System.Drawing.Size(115, 61);
            this.CalPwr.TabIndex = 1;
            this.CalPwr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(196, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 36);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pwr for Cal";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // N_Pv
            // 
            this.N_Pv.Location = new System.Drawing.Point(372, 368);
            this.N_Pv.Multiline = true;
            this.N_Pv.Name = "N_Pv";
            this.N_Pv.Size = new System.Drawing.Size(115, 61);
            this.N_Pv.TabIndex = 1;
            this.N_Pv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(375, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "N_Pv";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // IinMax
            // 
            this.IinMax.Location = new System.Drawing.Point(37, 504);
            this.IinMax.Multiline = true;
            this.IinMax.Name = "IinMax";
            this.IinMax.Size = new System.Drawing.Size(115, 61);
            this.IinMax.TabIndex = 1;
            this.IinMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(31, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 36);
            this.label12.TabIndex = 2;
            this.label12.Text = "Max_Iin";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // Expected_Effi
            // 
            this.Expected_Effi.Location = new System.Drawing.Point(370, 504);
            this.Expected_Effi.Multiline = true;
            this.Expected_Effi.Name = "Expected_Effi";
            this.Expected_Effi.Size = new System.Drawing.Size(115, 61);
            this.Expected_Effi.TabIndex = 1;
            this.Expected_Effi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fs
            // 
            this.fs.Location = new System.Drawing.Point(202, 504);
            this.fs.Multiline = true;
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(115, 61);
            this.fs.TabIndex = 1;
            this.fs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(367, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 36);
            this.label13.TabIndex = 2;
            this.label13.Text = "Exp_Eff";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(209, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 36);
            this.label14.TabIndex = 2;
            this.label14.Text = "fs";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // SRMode
            // 
            this.SRMode.Location = new System.Drawing.Point(37, 626);
            this.SRMode.Multiline = true;
            this.SRMode.Name = "SRMode";
            this.SRMode.Size = new System.Drawing.Size(115, 61);
            this.SRMode.TabIndex = 1;
            this.SRMode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(31, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 36);
            this.label15.TabIndex = 2;
            this.label15.Text = "SR mode";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(1978, 88);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(115, 61);
            this.Results.TabIndex = 1;
            this.Results.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(1978, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 37);
            this.label16.TabIndex = 2;
            this.label16.Text = "Results";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(670, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 37);
            this.label17.TabIndex = 2;
            this.label17.Text = "Section2";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_NoBias
            // 
            this.L_NoBias.Location = new System.Drawing.Point(677, 91);
            this.L_NoBias.Multiline = true;
            this.L_NoBias.Name = "L_NoBias";
            this.L_NoBias.Size = new System.Drawing.Size(137, 61);
            this.L_NoBias.TabIndex = 1;
            this.L_NoBias.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(671, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 36);
            this.label18.TabIndex = 2;
            this.label18.Text = "L_NoBias";
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // Factor
            // 
            this.Factor.Location = new System.Drawing.Point(848, 91);
            this.Factor.Multiline = true;
            this.Factor.Name = "Factor";
            this.Factor.Size = new System.Drawing.Size(137, 61);
            this.Factor.TabIndex = 1;
            this.Factor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(870, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 36);
            this.label19.TabIndex = 2;
            this.label19.Text = "Factor";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // Turns
            // 
            this.Turns.Location = new System.Drawing.Point(1034, 91);
            this.Turns.Multiline = true;
            this.Turns.Name = "Turns";
            this.Turns.Size = new System.Drawing.Size(137, 61);
            this.Turns.TabIndex = 1;
            this.Turns.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(1028, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 36);
            this.label20.TabIndex = 2;
            this.label20.Text = "Turns";
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // MagLen
            // 
            this.MagLen.Location = new System.Drawing.Point(1220, 91);
            this.MagLen.Multiline = true;
            this.MagLen.Name = "MagLen";
            this.MagLen.Size = new System.Drawing.Size(137, 61);
            this.MagLen.TabIndex = 1;
            this.MagLen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(1214, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 36);
            this.label21.TabIndex = 2;
            this.label21.Text = "MagLen";
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // CoreArea
            // 
            this.CoreArea.Location = new System.Drawing.Point(1403, 91);
            this.CoreArea.Multiline = true;
            this.CoreArea.Name = "CoreArea";
            this.CoreArea.Size = new System.Drawing.Size(137, 61);
            this.CoreArea.TabIndex = 1;
            this.CoreArea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CoreVol
            // 
            this.CoreVol.Location = new System.Drawing.Point(1589, 91);
            this.CoreVol.Multiline = true;
            this.CoreVol.Name = "CoreVol";
            this.CoreVol.Size = new System.Drawing.Size(137, 61);
            this.CoreVol.TabIndex = 1;
            this.CoreVol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(1397, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 36);
            this.label22.TabIndex = 2;
            this.label22.Text = "CoreArea";
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(1583, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 36);
            this.label23.TabIndex = 2;
            this.label23.Text = "CoreVol";
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // SteinCoeff_a0
            // 
            this.SteinCoeff_a0.Location = new System.Drawing.Point(677, 210);
            this.SteinCoeff_a0.Multiline = true;
            this.SteinCoeff_a0.Name = "SteinCoeff_a0";
            this.SteinCoeff_a0.Size = new System.Drawing.Size(137, 61);
            this.SteinCoeff_a0.TabIndex = 1;
            this.SteinCoeff_a0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(640, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(198, 36);
            this.label24.TabIndex = 2;
            this.label24.Text = "SteinCoeff_a0";
            this.label24.Click += new System.EventHandler(this.label1_Click);
            // 
            // SteinCoeff_b0
            // 
            this.SteinCoeff_b0.Location = new System.Drawing.Point(941, 210);
            this.SteinCoeff_b0.Multiline = true;
            this.SteinCoeff_b0.Name = "SteinCoeff_b0";
            this.SteinCoeff_b0.Size = new System.Drawing.Size(137, 61);
            this.SteinCoeff_b0.TabIndex = 1;
            this.SteinCoeff_b0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SteinCoeff_c0
            // 
            this.SteinCoeff_c0.Location = new System.Drawing.Point(1205, 210);
            this.SteinCoeff_c0.Multiline = true;
            this.SteinCoeff_c0.Name = "SteinCoeff_c0";
            this.SteinCoeff_c0.Size = new System.Drawing.Size(137, 61);
            this.SteinCoeff_c0.TabIndex = 1;
            this.SteinCoeff_c0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AttCoeff_a1
            // 
            this.AttCoeff_a1.Location = new System.Drawing.Point(677, 328);
            this.AttCoeff_a1.Multiline = true;
            this.AttCoeff_a1.Name = "AttCoeff_a1";
            this.AttCoeff_a1.Size = new System.Drawing.Size(137, 61);
            this.AttCoeff_a1.TabIndex = 1;
            this.AttCoeff_a1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AttCoeff_b1
            // 
            this.AttCoeff_b1.Location = new System.Drawing.Point(941, 328);
            this.AttCoeff_b1.Multiline = true;
            this.AttCoeff_b1.Name = "AttCoeff_b1";
            this.AttCoeff_b1.Size = new System.Drawing.Size(137, 61);
            this.AttCoeff_b1.TabIndex = 1;
            this.AttCoeff_b1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AttCoeff_c1
            // 
            this.AttCoeff_c1.Location = new System.Drawing.Point(1205, 328);
            this.AttCoeff_c1.Multiline = true;
            this.AttCoeff_c1.Name = "AttCoeff_c1";
            this.AttCoeff_c1.Size = new System.Drawing.Size(137, 61);
            this.AttCoeff_c1.TabIndex = 1;
            this.AttCoeff_c1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AttCoeff_d1
            // 
            this.AttCoeff_d1.Location = new System.Drawing.Point(1469, 328);
            this.AttCoeff_d1.Multiline = true;
            this.AttCoeff_d1.Name = "AttCoeff_d1";
            this.AttCoeff_d1.Size = new System.Drawing.Size(137, 61);
            this.AttCoeff_d1.TabIndex = 1;
            this.AttCoeff_d1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MaxDCRPwr
            // 
            this.MaxDCRPwr.Location = new System.Drawing.Point(678, 437);
            this.MaxDCRPwr.Multiline = true;
            this.MaxDCRPwr.Name = "MaxDCRPwr";
            this.MaxDCRPwr.Size = new System.Drawing.Size(137, 61);
            this.MaxDCRPwr.TabIndex = 1;
            this.MaxDCRPwr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(918, 166);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(201, 36);
            this.label25.TabIndex = 2;
            this.label25.Text = "SteinCoeff_b0";
            this.label25.Click += new System.EventHandler(this.label1_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(1199, 166);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(197, 36);
            this.label26.TabIndex = 2;
            this.label26.Text = "SteinCoeff_c0";
            this.label26.Click += new System.EventHandler(this.label1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(653, 284);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(172, 36);
            this.label27.TabIndex = 2;
            this.label27.Text = "AttCoeff_a1";
            this.label27.Click += new System.EventHandler(this.label1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(1192, 284);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(171, 36);
            this.label28.TabIndex = 2;
            this.label28.Text = "AttCoeff_c1";
            this.label28.Click += new System.EventHandler(this.label1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(921, 284);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(175, 36);
            this.label29.TabIndex = 2;
            this.label29.Text = "AttCoeff_b1";
            this.label29.Click += new System.EventHandler(this.label1_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(1459, 284);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(175, 36);
            this.label30.TabIndex = 2;
            this.label30.Text = "AttCoeff_d1";
            this.label30.Click += new System.EventHandler(this.label1_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(646, 393);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(179, 36);
            this.label31.TabIndex = 2;
            this.label31.Text = "MaxDCRPwr";
            this.label31.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaxDCREMI_P
            // 
            this.MaxDCREMI_P.Location = new System.Drawing.Point(883, 437);
            this.MaxDCREMI_P.Multiline = true;
            this.MaxDCREMI_P.Name = "MaxDCREMI_P";
            this.MaxDCREMI_P.Size = new System.Drawing.Size(137, 61);
            this.MaxDCREMI_P.TabIndex = 1;
            this.MaxDCREMI_P.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AC_Coeffi
            // 
            this.AC_Coeffi.Location = new System.Drawing.Point(1272, 437);
            this.AC_Coeffi.Multiline = true;
            this.AC_Coeffi.Name = "AC_Coeffi";
            this.AC_Coeffi.Size = new System.Drawing.Size(137, 61);
            this.AC_Coeffi.TabIndex = 1;
            this.AC_Coeffi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TempPwr
            // 
            this.TempPwr.Location = new System.Drawing.Point(1470, 437);
            this.TempPwr.Multiline = true;
            this.TempPwr.Name = "TempPwr";
            this.TempPwr.Size = new System.Drawing.Size(137, 61);
            this.TempPwr.TabIndex = 1;
            this.TempPwr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TempEMI
            // 
            this.TempEMI.Location = new System.Drawing.Point(1668, 437);
            this.TempEMI.Multiline = true;
            this.TempEMI.Name = "TempEMI";
            this.TempEMI.Size = new System.Drawing.Size(137, 61);
            this.TempEMI.TabIndex = 1;
            this.TempEMI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // C_Single
            // 
            this.C_Single.Location = new System.Drawing.Point(677, 553);
            this.C_Single.Multiline = true;
            this.C_Single.Name = "C_Single";
            this.C_Single.Size = new System.Drawing.Size(137, 61);
            this.C_Single.TabIndex = 1;
            this.C_Single.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ParCount
            // 
            this.ParCount.Location = new System.Drawing.Point(883, 553);
            this.ParCount.Multiline = true;
            this.ParCount.Name = "ParCount";
            this.ParCount.Size = new System.Drawing.Size(137, 61);
            this.ParCount.TabIndex = 1;
            this.ParCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SerCount
            // 
            this.SerCount.Location = new System.Drawing.Point(1071, 553);
            this.SerCount.Multiline = true;
            this.SerCount.Name = "SerCount";
            this.SerCount.Size = new System.Drawing.Size(137, 61);
            this.SerCount.TabIndex = 1;
            this.SerCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(843, 393);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(209, 36);
            this.label32.TabIndex = 2;
            this.label32.Text = "MaxDCREMI_P";
            this.label32.Click += new System.EventHandler(this.label1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(1297, 393);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(147, 36);
            this.label33.TabIndex = 2;
            this.label33.Text = "AC_Coeffi";
            this.label33.Click += new System.EventHandler(this.label1_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(1473, 393);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(141, 36);
            this.label34.TabIndex = 2;
            this.label34.Text = "TempPwr";
            this.label34.Click += new System.EventHandler(this.label1_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(675, 509);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(128, 36);
            this.label35.TabIndex = 2;
            this.label35.Text = "C_Single";
            this.label35.Click += new System.EventHandler(this.label1_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(1667, 393);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(141, 36);
            this.label36.TabIndex = 2;
            this.label36.Text = "TempEMI";
            this.label36.Click += new System.EventHandler(this.label1_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(878, 509);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(139, 36);
            this.label37.TabIndex = 2;
            this.label37.Text = "ParCount";
            this.label37.Click += new System.EventHandler(this.label1_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(1092, 509);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(139, 36);
            this.label38.TabIndex = 2;
            this.label38.Text = "SerCount";
            this.label38.Click += new System.EventHandler(this.label1_Click);
            // 
            // TanSigma
            // 
            this.TanSigma.Location = new System.Drawing.Point(1272, 553);
            this.TanSigma.Multiline = true;
            this.TanSigma.Name = "TanSigma";
            this.TanSigma.Size = new System.Drawing.Size(137, 61);
            this.TanSigma.TabIndex = 1;
            this.TanSigma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cin
            // 
            this.Cin.Location = new System.Drawing.Point(1470, 553);
            this.Cin.Multiline = true;
            this.Cin.Name = "Cin";
            this.Cin.Size = new System.Drawing.Size(137, 61);
            this.Cin.TabIndex = 1;
            this.Cin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ESR_Cin
            // 
            this.ESR_Cin.Location = new System.Drawing.Point(1668, 553);
            this.ESR_Cin.Multiline = true;
            this.ESR_Cin.Name = "ESR_Cin";
            this.ESR_Cin.Size = new System.Drawing.Size(137, 61);
            this.ESR_Cin.TabIndex = 1;
            this.ESR_Cin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(1272, 509);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(145, 36);
            this.label39.TabIndex = 2;
            this.label39.Text = "TanSigma";
            this.label39.Click += new System.EventHandler(this.label1_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(1510, 509);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 36);
            this.label40.TabIndex = 2;
            this.label40.Text = "Cin";
            this.label40.Click += new System.EventHandler(this.label1_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(1680, 509);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(120, 36);
            this.label41.TabIndex = 2;
            this.label41.Text = "ESR_Cin";
            this.label41.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaxDCREMI_N
            // 
            this.MaxDCREMI_N.Location = new System.Drawing.Point(1071, 437);
            this.MaxDCREMI_N.Multiline = true;
            this.MaxDCREMI_N.Name = "MaxDCREMI_N";
            this.MaxDCREMI_N.Size = new System.Drawing.Size(137, 61);
            this.MaxDCREMI_N.TabIndex = 1;
            this.MaxDCREMI_N.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.Location = new System.Drawing.Point(1061, 393);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(215, 36);
            this.label42.TabIndex = 2;
            this.label42.Text = "MaxDCREMI_N";
            this.label42.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(35, 712);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(932, 476);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2068, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1912, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 71);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set Default Value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2259, 1257);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VBUSMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VBUSNor);
            this.Controls.Add(this.fs);
            this.Controls.Add(this.Expected_Effi);
            this.Controls.Add(this.CalPwr);
            this.Controls.Add(this.SRMode);
            this.Controls.Add(this.N_Pv);
            this.Controls.Add(this.IinMax);
            this.Controls.Add(this.RatedPwr);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Vpvmin);
            this.Controls.Add(this.VBUSMin);
            this.Controls.Add(this.Vpvmax);
            this.Controls.Add(this.SerCount);
            this.Controls.Add(this.MaxDCRPwr);
            this.Controls.Add(this.SteinCoeff_a0);
            this.Controls.Add(this.ParCount);
            this.Controls.Add(this.AttCoeff_d1);
            this.Controls.Add(this.CoreVol);
            this.Controls.Add(this.C_Single);
            this.Controls.Add(this.AttCoeff_c1);
            this.Controls.Add(this.CoreArea);
            this.Controls.Add(this.TempEMI);
            this.Controls.Add(this.AttCoeff_b1);
            this.Controls.Add(this.ESR_Cin);
            this.Controls.Add(this.MagLen);
            this.Controls.Add(this.TempPwr);
            this.Controls.Add(this.AttCoeff_a1);
            this.Controls.Add(this.Cin);
            this.Controls.Add(this.Turns);
            this.Controls.Add(this.AC_Coeffi);
            this.Controls.Add(this.SteinCoeff_c0);
            this.Controls.Add(this.TanSigma);
            this.Controls.Add(this.Factor);
            this.Controls.Add(this.MaxDCREMI_N);
            this.Controls.Add(this.MaxDCREMI_P);
            this.Controls.Add(this.SteinCoeff_b0);
            this.Controls.Add(this.L_NoBias);
            this.Controls.Add(this.VpvNorm);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox VpvNorm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vpvmax;
        private System.Windows.Forms.TextBox Vpvmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VBUSMin;
        private System.Windows.Forms.TextBox VBUSNor;
        private System.Windows.Forms.TextBox VBUSMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RatedPwr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CalPwr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox N_Pv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IinMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Expected_Effi;
        private System.Windows.Forms.TextBox fs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SRMode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox L_NoBias;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Factor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Turns;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox MagLen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox CoreArea;
        private System.Windows.Forms.TextBox CoreVol;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox SteinCoeff_a0;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox SteinCoeff_b0;
        private System.Windows.Forms.TextBox SteinCoeff_c0;
        private System.Windows.Forms.TextBox AttCoeff_a1;
        private System.Windows.Forms.TextBox AttCoeff_b1;
        private System.Windows.Forms.TextBox AttCoeff_c1;
        private System.Windows.Forms.TextBox AttCoeff_d1;
        private System.Windows.Forms.TextBox MaxDCRPwr;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox MaxDCREMI_P;
        private System.Windows.Forms.TextBox AC_Coeffi;
        private System.Windows.Forms.TextBox TempPwr;
        private System.Windows.Forms.TextBox TempEMI;
        private System.Windows.Forms.TextBox C_Single;
        private System.Windows.Forms.TextBox ParCount;
        private System.Windows.Forms.TextBox SerCount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox TanSigma;
        private System.Windows.Forms.TextBox Cin;
        private System.Windows.Forms.TextBox ESR_Cin;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox MaxDCREMI_N;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

