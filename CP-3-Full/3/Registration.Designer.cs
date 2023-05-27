namespace _3
{
    partial class Registration
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
            dateofbirth = new DateTimePicker();
            Create = new Button();
            upper = new CheckBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            Generation = new Button();
            letCountChecker = new CheckBox();
            Countofletters = new NumericUpDown();
            spec = new CheckBox();
            Password = new TextBox();
            PasswordLength = new NumericUpDown();
            label1 = new Label();
            Fname = new TextBox();
            Accounts = new ListBox();
            label2 = new Label();
            Sname = new TextBox();
            Login = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AccountInfo = new ListBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Countofletters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordLength).BeginInit();
            SuspendLayout();
            // 
            // dateofbirth
            // 
            dateofbirth.Location = new Point(409, 83);
            dateofbirth.Name = "dateofbirth";
            dateofbirth.Size = new Size(378, 23);
            dateofbirth.TabIndex = 0;
            // 
            // Create
            // 
            Create.Location = new Point(12, 394);
            Create.Name = "Create";
            Create.Size = new Size(379, 44);
            Create.TabIndex = 1;
            Create.Text = "Create new Account";
            Create.UseVisualStyleBackColor = true;
            Create.Click += CreateAccount;
            // 
            // upper
            // 
            upper.AutoSize = true;
            upper.Location = new Point(6, 107);
            upper.Name = "upper";
            upper.Size = new Size(116, 19);
            upper.TabIndex = 2;
            upper.Text = "Uppercase letters";
            upper.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Generation);
            groupBox1.Controls.Add(letCountChecker);
            groupBox1.Controls.Add(Countofletters);
            groupBox1.Controls.Add(spec);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(PasswordLength);
            groupBox1.Controls.Add(upper);
            groupBox1.Location = new Point(12, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 267);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Password Generator";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 60);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 14;
            label6.Text = "Password length";
            // 
            // Generation
            // 
            Generation.Location = new Point(6, 229);
            Generation.Name = "Generation";
            Generation.Size = new Size(367, 32);
            Generation.TabIndex = 14;
            Generation.Text = "Generate new password";
            Generation.UseVisualStyleBackColor = true;
            Generation.Click += GeneratePassword;
            // 
            // letCountChecker
            // 
            letCountChecker.AutoSize = true;
            letCountChecker.Location = new Point(6, 158);
            letCountChecker.Name = "letCountChecker";
            letCountChecker.Size = new Size(108, 19);
            letCountChecker.TabIndex = 17;
            letCountChecker.Text = "Count of letters";
            letCountChecker.UseVisualStyleBackColor = true;
            letCountChecker.CheckedChanged += CountChecker;
            // 
            // Countofletters
            // 
            Countofletters.Enabled = false;
            Countofletters.Location = new Point(120, 154);
            Countofletters.Name = "Countofletters";
            Countofletters.Size = new Size(113, 23);
            Countofletters.TabIndex = 16;
            // 
            // spec
            // 
            spec.AutoSize = true;
            spec.Location = new Point(6, 132);
            spec.Name = "spec";
            spec.Size = new Size(120, 19);
            spec.TabIndex = 15;
            spec.Text = "Special characters";
            spec.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            Password.Enabled = false;
            Password.Location = new Point(6, 22);
            Password.Name = "Password";
            Password.Size = new Size(367, 23);
            Password.TabIndex = 14;
            // 
            // PasswordLength
            // 
            PasswordLength.Location = new Point(6, 78);
            PasswordLength.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            PasswordLength.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            PasswordLength.Name = "PasswordLength";
            PasswordLength.Size = new Size(113, 23);
            PasswordLength.TabIndex = 4;
            PasswordLength.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "First name";
            // 
            // Fname
            // 
            Fname.Location = new Point(12, 27);
            Fname.Name = "Fname";
            Fname.Size = new Size(379, 23);
            Fname.TabIndex = 6;
            Fname.TextChanged += Fname_TextChanged;
            // 
            // Accounts
            // 
            Accounts.FormattingEnabled = true;
            Accounts.ItemHeight = 15;
            Accounts.Location = new Point(409, 144);
            Accounts.Name = "Accounts";
            Accounts.Size = new Size(191, 289);
            Accounts.TabIndex = 7;
            Accounts.SelectedIndexChanged += Accounts_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 8;
            label2.Text = "Second name";
            // 
            // Sname
            // 
            Sname.Location = new Point(409, 27);
            Sname.Name = "Sname";
            Sname.Size = new Size(379, 23);
            Sname.TabIndex = 9;
            // 
            // Login
            // 
            Login.Location = new Point(11, 83);
            Login.Name = "Login";
            Login.Size = new Size(379, 23);
            Login.TabIndex = 10;
            Login.TextChanged += Login_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 66);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 66);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 12;
            label4.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 126);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Accounts";
            // 
            // AccountInfo
            // 
            AccountInfo.FormattingEnabled = true;
            AccountInfo.ItemHeight = 15;
            AccountInfo.Location = new Point(606, 143);
            AccountInfo.Name = "AccountInfo";
            AccountInfo.Size = new Size(191, 289);
            AccountInfo.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(606, 125);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 22;
            label7.Text = "Information";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(AccountInfo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Login);
            Controls.Add(Sname);
            Controls.Add(label2);
            Controls.Add(Accounts);
            Controls.Add(Fname);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(Create);
            Controls.Add(dateofbirth);
            Name = "Registration";
            Text = "Registration";
            FormClosing += Quit;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Countofletters).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateofbirth;
        private Button Create;
        private CheckBox upper;
        private GroupBox groupBox1;
        private NumericUpDown PasswordLength;
        private Label label1;
        private TextBox Fname;
        private ListBox Accounts;
        private Label label2;
        private TextBox Sname;
        private TextBox Login;
        private Label label3;
        private Label label4;
        private Button Generation;
        private CheckBox letCountChecker;
        private NumericUpDown Countofletters;
        private CheckBox spec;
        private TextBox Password;
        private Label label5;
        private Label label6;
        private ListBox AccountInfo;
        private Label label7;
    }
}