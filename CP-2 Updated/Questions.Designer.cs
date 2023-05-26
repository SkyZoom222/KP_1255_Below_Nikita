namespace CP_2_Updated
{
    partial class Questions
    {

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
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Save = new Button();
            CH1 = new CheckBox();
            CHB1 = new ComboBox();
            label1 = new Label();
            Results = new ListBox();
            NB1 = new NumericUpDown();
            Progress = new ProgressBar();
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
            Sname = new TextBox();
            Gr = new TextBox();
            Fname = new TextBox();
            Age = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            LoadResult = new Button();
            groupBox1 = new GroupBox();
            Del = new Button();
            DelSaves = new Button();
            DebugL = new Label();
            ClearBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)NB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TRB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Age).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Enabled = false;
            Save.Location = new Point(602, 428);
            Save.Name = "Save";
            Save.Size = new Size(138, 36);
            Save.TabIndex = 0;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // CH1
            // 
            CH1.AutoSize = true;
            CH1.Location = new Point(12, 39);
            CH1.Name = "CH1";
            CH1.Size = new Size(66, 19);
            CH1.TabIndex = 1;
            CH1.Text = "Ответ 1";
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
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Вопрос 1";
            // 
            // Results
            // 
            Results.FormattingEnabled = true;
            Results.ItemHeight = 15;
            Results.Location = new Point(746, 310);
            Results.Name = "Results";
            Results.Size = new Size(190, 154);
            Results.TabIndex = 4;
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
            // Progress
            // 
            Progress.Location = new Point(746, 287);
            Progress.Maximum = 7;
            Progress.Name = "Progress";
            Progress.Size = new Size(190, 17);
            Progress.TabIndex = 6;
            // 
            // RB1
            // 
            RB1.AutoSize = true;
            RB1.Location = new Point(6, 22);
            RB1.Name = "RB1";
            RB1.Size = new Size(71, 19);
            RB1.TabIndex = 7;
            RB1.TabStop = true;
            RB1.Tag = "";
            RB1.Text = "Выбор 1";
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
            CH2.Size = new Size(66, 19);
            CH2.TabIndex = 10;
            CH2.Text = "Ответ 2";
            CH2.UseVisualStyleBackColor = true;
            CH2.CheckedChanged += AnyChanged;
            // 
            // CH3
            // 
            CH3.AutoSize = true;
            CH3.Location = new Point(12, 89);
            CH3.Name = "CH3";
            CH3.Size = new Size(66, 19);
            CH3.TabIndex = 11;
            CH3.Text = "Ответ 3";
            CH3.UseVisualStyleBackColor = true;
            CH3.CheckedChanged += AnyChanged;
            // 
            // CH4
            // 
            CH4.AutoSize = true;
            CH4.Location = new Point(12, 114);
            CH4.Name = "CH4";
            CH4.Size = new Size(66, 19);
            CH4.TabIndex = 12;
            CH4.Text = "Ответ 4";
            CH4.UseVisualStyleBackColor = true;
            CH4.CheckedChanged += AnyChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 159);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 13;
            label2.Text = "Вопрос 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 232);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "Вопрос 6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 159);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 16;
            label5.Text = "Вопрос 5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 17;
            label6.Text = "Вопрос 3";
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
            RB2.Size = new Size(71, 19);
            RB2.TabIndex = 21;
            RB2.TabStop = true;
            RB2.Tag = "";
            RB2.Text = "Выбор 2";
            RB2.UseVisualStyleBackColor = true;
            RB2.CheckedChanged += AnyChanged;
            // 
            // RB3
            // 
            RB3.AutoSize = true;
            RB3.Location = new Point(6, 72);
            RB3.Name = "RB3";
            RB3.Size = new Size(71, 19);
            RB3.TabIndex = 22;
            RB3.TabStop = true;
            RB3.Tag = "";
            RB3.Text = "Выбор 3";
            RB3.UseVisualStyleBackColor = true;
            RB3.CheckedChanged += AnyChanged;
            // 
            // RB4
            // 
            RB4.AutoSize = true;
            RB4.Location = new Point(6, 97);
            RB4.Name = "RB4";
            RB4.Size = new Size(71, 19);
            RB4.TabIndex = 23;
            RB4.TabStop = true;
            RB4.Text = "Выбор 4";
            RB4.UseVisualStyleBackColor = true;
            RB4.CheckedChanged += AnyChanged;
            // 
            // Sname
            // 
            Sname.Location = new Point(8, 441);
            Sname.Name = "Sname";
            Sname.Size = new Size(133, 23);
            Sname.TabIndex = 24;
            Sname.TextChanged += AnyChanged;
            // 
            // Gr
            // 
            Gr.Location = new Point(289, 441);
            Gr.Name = "Gr";
            Gr.Size = new Size(60, 23);
            Gr.TabIndex = 25;
            Gr.TextChanged += AnyChanged;
            // 
            // Fname
            // 
            Fname.Location = new Point(150, 441);
            Fname.Name = "Fname";
            Fname.Size = new Size(133, 23);
            Fname.TabIndex = 26;
            Fname.TextChanged += AnyChanged;
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
            // LoadResult
            // 
            LoadResult.Location = new Point(602, 386);
            LoadResult.Name = "LoadResult";
            LoadResult.Size = new Size(138, 36);
            LoadResult.TabIndex = 34;
            LoadResult.Text = "Загрузить";
            LoadResult.UseVisualStyleBackColor = true;
            LoadResult.Click += LoadResult_Click;
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
            groupBox1.Text = "Вопрос 4";
            // 
            // Del
            // 
            Del.Location = new Point(602, 344);
            Del.Name = "Del";
            Del.Size = new Size(138, 36);
            Del.TabIndex = 38;
            Del.Text = "Удалить";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // DelSaves
            // 
            DelSaves.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            DelSaves.Location = new Point(726, 21);
            DelSaves.Name = "DelSaves";
            DelSaves.Size = new Size(210, 23);
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
            // ClearBtn
            // 
            ClearBtn.Location = new Point(455, 440);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(95, 23);
            ClearBtn.TabIndex = 41;
            ClearBtn.Text = "Сброс данных";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(583, 6);
            label3.Name = "label3";
            label3.Size = new Size(353, 12);
            label3.TabIndex = 42;
            label3.Text = "Файл с результатами лежит в папке Results вместе с исполняемым файлом ";
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 476);
            Controls.Add(label3);
            Controls.Add(ClearBtn);
            Controls.Add(DebugL);
            Controls.Add(DelSaves);
            Controls.Add(Del);
            Controls.Add(groupBox1);
            Controls.Add(LoadResult);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Age);
            Controls.Add(Fname);
            Controls.Add(Gr);
            Controls.Add(Sname);
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
            Controls.Add(Progress);
            Controls.Add(NB1);
            Controls.Add(Results);
            Controls.Add(label1);
            Controls.Add(CHB1);
            Controls.Add(CH1);
            Controls.Add(Save);
            Name = "Questions";
            Text = "Questions";
            ((System.ComponentModel.ISupportInitialize)NB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TRB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Age).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button Save;
        public CheckBox CH1;
        public ComboBox CHB1;
        public Label label1;
        public ListBox Results;
        public NumericUpDown NB1;
        public ProgressBar Progress;
        public RadioButton RB1;
        public TextBox TB1;
        public System.Windows.Forms.Timer timer1;
        public TrackBar TRB1;
        public CheckBox CH2;
        public CheckBox CH3;
        public CheckBox CH4;
        public Label label2;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public RadioButton RB2;
        public RadioButton RB3;
        public RadioButton RB4;
        public TextBox Sname;
        public TextBox Gr;
        public TextBox Fname;
        public NumericUpDown Age;
        public Label label10;
        public Label label11;
        public Label label12;
        public Button LoadResult;
        public GroupBox groupBox1;
        public Button Del;
        public Button DelSaves;
        public Label DebugL;
        public Button ClearBtn;
        private System.ComponentModel.IContainer components;
        public Label label3;
    }
}