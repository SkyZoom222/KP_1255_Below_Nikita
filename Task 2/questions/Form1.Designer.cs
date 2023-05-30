namespace questions
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SV = new Button();
            CH1 = new CheckBox();
            CHB1 = new ComboBox();
            label1 = new Label();
            Lst = new ListBox();
            NB1 = new NumericUpDown();
            PB1 = new ProgressBar();
            RB1 = new RadioButton();
            TB1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            TRB1 = new TrackBar();
            CH2 = new CheckBox();
            CH3 = new CheckBox();
            CH4 = new CheckBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            RB2 = new RadioButton();
            RB3 = new RadioButton();
            RB4 = new RadioButton();
            Sec = new TextBox();
            Gr = new TextBox();
            Fir = new TextBox();
            Age = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            LD = new Button();
            groupBox1 = new GroupBox();
            DL = new Button();
            DelSaves = new Button();
            DebugL = new Label();
            restartbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)NB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TRB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Age).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SV
            // 
            SV.Enabled = false;
            SV.Location = new Point(602, 428);
            SV.Name = "SV";
            SV.Size = new Size(138, 36);
            SV.TabIndex = 0;
            SV.Text = "Сохранить";
            SV.UseVisualStyleBackColor = true;
            SV.Click += SV_Click;
            // 
            // CH1
            // 
            CH1.AutoSize = true;
            CH1.Location = new Point(12, 39);
            CH1.Name = "CH1";
            CH1.Size = new Size(83, 19);
            CH1.TabIndex = 1;
            CH1.Text = "checkBox1";
            CH1.UseVisualStyleBackColor = true;
            CH1.CheckedChanged += AnyChanged;
            // 
            // CHB1
            // 
            CHB1.DropDownStyle = ComboBoxStyle.DropDownList;
            CHB1.FormattingEnabled = true;
            CHB1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            CHB1.Location = new Point(12, 177);
            CHB1.Name = "CHB1";
            CHB1.Size = new Size(121, 23);
            CHB1.TabIndex = 2;
            CHB1.SelectedIndexChanged += AnyChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Lst
            // 
            Lst.FormattingEnabled = true;
            Lst.ItemHeight = 15;
            Lst.Location = new Point(746, 310);
            Lst.Name = "Lst";
            Lst.Size = new Size(190, 154);
            Lst.TabIndex = 4;
            // 
            // NB1
            // 
            NB1.Location = new Point(12, 248);
            NB1.Name = "NB1";
            NB1.ReadOnly = true;
            NB1.Size = new Size(120, 23);
            NB1.TabIndex = 5;
            NB1.ValueChanged += AnyChanged;
            // 
            // PB1
            // 
            PB1.Location = new Point(746, 287);
            PB1.Maximum = 7;
            PB1.Name = "PB1";
            PB1.Size = new Size(190, 17);
            PB1.TabIndex = 6;
            // 
            // RB1
            // 
            RB1.AutoSize = true;
            RB1.Location = new Point(6, 22);
            RB1.Name = "RB1";
            RB1.Size = new Size(94, 19);
            RB1.TabIndex = 7;
            RB1.TabStop = true;
            RB1.Tag = "";
            RB1.Text = "radioButton1";
            RB1.UseVisualStyleBackColor = true;
            RB1.CheckedChanged += AnyChanged;
            // 
            // TB1
            // 
            TB1.Location = new Point(249, 177);
            TB1.Name = "TB1";
            TB1.Size = new Size(100, 23);
            TB1.TabIndex = 8;
            TB1.TextChanged += AnyChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // TRB1
            // 
            TRB1.Location = new Point(249, 250);
            TRB1.Minimum = 1;
            TRB1.Name = "TRB1";
            TRB1.Size = new Size(104, 45);
            TRB1.TabIndex = 9;
            TRB1.Value = 1;
            TRB1.Scroll += AnyChanged;
            // 
            // CH2
            // 
            CH2.AutoSize = true;
            CH2.Location = new Point(12, 64);
            CH2.Name = "CH2";
            CH2.Size = new Size(83, 19);
            CH2.TabIndex = 10;
            CH2.Text = "checkBox2";
            CH2.UseVisualStyleBackColor = true;
            CH2.CheckedChanged += AnyChanged;
            // 
            // CH3
            // 
            CH3.AutoSize = true;
            CH3.Location = new Point(12, 89);
            CH3.Name = "CH3";
            CH3.Size = new Size(83, 19);
            CH3.TabIndex = 11;
            CH3.Text = "checkBox3";
            CH3.UseVisualStyleBackColor = true;
            CH3.CheckedChanged += AnyChanged;
            // 
            // CH4
            // 
            CH4.AutoSize = true;
            CH4.Location = new Point(12, 114);
            CH4.Name = "CH4";
            CH4.Size = new Size(83, 19);
            CH4.TabIndex = 12;
            CH4.Text = "checkBox4";
            CH4.UseVisualStyleBackColor = true;
            CH4.CheckedChanged += AnyChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 159);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 232);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 159);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 17;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 423);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 18;
            label7.Text = "Фамилия";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(150, 423);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 19;
            label8.Text = "Имя";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 423);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 20;
            label9.Text = "Группа";
            // 
            // RB2
            // 
            RB2.AutoSize = true;
            RB2.Location = new Point(6, 47);
            RB2.Name = "RB2";
            RB2.Size = new Size(94, 19);
            RB2.TabIndex = 21;
            RB2.TabStop = true;
            RB2.Tag = "";
            RB2.Text = "radioButton2";
            RB2.UseVisualStyleBackColor = true;
            RB2.CheckedChanged += AnyChanged;
            // 
            // RB3
            // 
            RB3.AutoSize = true;
            RB3.Location = new Point(6, 72);
            RB3.Name = "RB3";
            RB3.Size = new Size(94, 19);
            RB3.TabIndex = 22;
            RB3.TabStop = true;
            RB3.Tag = "";
            RB3.Text = "radioButton3";
            RB3.UseVisualStyleBackColor = true;
            RB3.CheckedChanged += AnyChanged;
            // 
            // RB4
            // 
            RB4.AutoSize = true;
            RB4.Location = new Point(6, 97);
            RB4.Name = "RB4";
            RB4.Size = new Size(94, 19);
            RB4.TabIndex = 23;
            RB4.TabStop = true;
            RB4.Text = "radioButton4";
            RB4.UseVisualStyleBackColor = true;
            RB4.CheckedChanged += AnyChanged;
            // 
            // Sec
            // 
            Sec.Location = new Point(8, 441);
            Sec.Name = "Sec";
            Sec.Size = new Size(133, 23);
            Sec.TabIndex = 24;
            Sec.TextChanged += AnyChanged;
            // 
            // Gr
            // 
            Gr.Location = new Point(289, 441);
            Gr.Name = "Gr";
            Gr.Size = new Size(60, 23);
            Gr.TabIndex = 25;
            Gr.TextChanged += AnyChanged;
            // 
            // Fir
            // 
            Fir.Location = new Point(150, 441);
            Fir.Name = "Fir";
            Fir.Size = new Size(133, 23);
            Fir.TabIndex = 26;
            Fir.TextChanged += AnyChanged;
            // 
            // Age
            // 
            Age.Location = new Point(355, 442);
            Age.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            Age.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Size = new Size(69, 23);
            Age.TabIndex = 27;
            Age.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            Age.ValueChanged += AnyChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(355, 423);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 28;
            label10.Text = "Год рождения";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(746, 269);
            label11.Name = "label11";
            label11.Size = new Size(132, 15);
            label11.TabIndex = 29;
            label11.Text = "Прогресс выполнения";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(592, 310);
            label12.Name = "label12";
            label12.Size = new Size(148, 15);
            label12.TabIndex = 30;
            label12.Text = "Сохраненные результаты";
            // 
            // LD
            // 
            LD.Location = new Point(602, 386);
            LD.Name = "LD";
            LD.Size = new Size(138, 36);
            LD.TabIndex = 34;
            LD.Text = "Загрузить";
            LD.UseVisualStyleBackColor = true;
            LD.Click += LD_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RB1);
            groupBox1.Controls.Add(RB2);
            groupBox1.Controls.Add(RB3);
            groupBox1.Controls.Add(RB4);
            groupBox1.Location = new Point(249, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 121);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "/";
            // 
            // DL
            // 
            DL.Location = new Point(602, 344);
            DL.Name = "DL";
            DL.Size = new Size(138, 36);
            DL.TabIndex = 38;
            DL.Text = "Удалить";
            DL.UseVisualStyleBackColor = true;
            DL.Click += DL_Click;
            // 
            // DelSaves
            // 
            DelSaves.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            DelSaves.Location = new Point(726, 21);
            DelSaves.Name = "DelSaves";
            DelSaves.Size = new Size(193, 23);
            DelSaves.TabIndex = 39;
            DelSaves.Text = "Удалить все предыдущие сохранения";
            DelSaves.UseVisualStyleBackColor = true;
            DelSaves.Click += DelSaves_Click;
            // 
            // DebugL
            // 
            DebugL.AutoSize = true;
            DebugL.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            DebugL.Location = new Point(726, 114);
            DebugL.Name = "DebugL";
            DebugL.Size = new Size(0, 11);
            DebugL.TabIndex = 40;
            // 
            // restartbtn
            // 
            restartbtn.Location = new Point(455, 440);
            restartbtn.Name = "restartbtn";
            restartbtn.Size = new Size(95, 23);
            restartbtn.TabIndex = 41;
            restartbtn.Text = "Сброс данных";
            restartbtn.UseVisualStyleBackColor = true;
            restartbtn.Click += restartbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 476);
            Controls.Add(restartbtn);
            Controls.Add(DebugL);
            Controls.Add(DelSaves);
            Controls.Add(DL);
            Controls.Add(groupBox1);
            Controls.Add(LD);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Age);
            Controls.Add(Fir);
            Controls.Add(Gr);
            Controls.Add(Sec);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(CH4);
            Controls.Add(CH3);
            Controls.Add(CH2);
            Controls.Add(TRB1);
            Controls.Add(TB1);
            Controls.Add(PB1);
            Controls.Add(NB1);
            Controls.Add(Lst);
            Controls.Add(label1);
            Controls.Add(CHB1);
            Controls.Add(CH1);
            Controls.Add(SV);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)NB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TRB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Age).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SV;
        private CheckBox CH1;
        private ComboBox CHB1;
        private Label label1;
        private ListBox Lst;
        private NumericUpDown NB1;
        private ProgressBar PB1;
        private RadioButton RB1;
        private TextBox TB1;
        private System.Windows.Forms.Timer timer1;
        private TrackBar TRB1;
        private CheckBox CH2;
        private CheckBox CH3;
        private CheckBox CH4;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton RB2;
        private RadioButton RB3;
        private RadioButton RB4;
        private TextBox Sec;
        private TextBox Gr;
        private TextBox Fir;
        private NumericUpDown Age;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button LD;
        private GroupBox groupBox1;
        private Button DL;
        private Button DelSaves;
        private Label DebugL;
        private Button restartbtn;
    }
}