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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1377, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Location = new System.Drawing.Point(30, 17);
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
            this.label2.Location = new System.Drawing.Point(31, 52);
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
            this.label3.Location = new System.Drawing.Point(197, 52);
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
            this.label4.Location = new System.Drawing.Point(376, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vpvmin";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // VBUSMin
            // 
            this.VBUSMin.Location = new System.Drawing.Point(35, 246);
            this.VBUSMin.Multiline = true;
            this.VBUSMin.Name = "VBUSMin";
            this.VBUSMin.Size = new System.Drawing.Size(115, 61);
            this.VBUSMin.TabIndex = 1;
            this.VBUSMin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VBUSNor
            // 
            this.VBUSNor.Location = new System.Drawing.Point(202, 246);
            this.VBUSNor.Multiline = true;
            this.VBUSNor.Name = "VBUSNor";
            this.VBUSNor.Size = new System.Drawing.Size(115, 61);
            this.VBUSNor.TabIndex = 1;
            this.VBUSNor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VBUSMax
            // 
            this.VBUSMax.Location = new System.Drawing.Point(372, 246);
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
            this.label9.Location = new System.Drawing.Point(30, 328);
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
            this.label12.Location = new System.Drawing.Point(30, 454);
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
            this.label13.Location = new System.Drawing.Point(366, 455);
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
            this.label15.Location = new System.Drawing.Point(31, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 36);
            this.label15.TabIndex = 2;
            this.label15.Text = "SR mode";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(1377, 91);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(115, 61);
            this.Results.TabIndex = 1;
            this.Results.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(1383, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 36);
            this.label16.TabIndex = 2;
            this.label16.Text = "Results";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2349, 1464);
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
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.VpvNorm);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

