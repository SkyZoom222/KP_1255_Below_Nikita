namespace _3
{
    partial class AccountEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Accounts = new ListBox();
            FName = new TextBox();
            SName = new TextBox();
            Login_Text = new TextBox();
            Password_Text = new TextBox();
            Perm = new ComboBox();
            dateofbirth = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            SaveBtn = new Button();
            DelBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // Accounts
            // 
            Accounts.FormattingEnabled = true;
            Accounts.ItemHeight = 15;
            Accounts.Location = new Point(397, 12);
            Accounts.Name = "Accounts";
            Accounts.Size = new Size(391, 409);
            Accounts.TabIndex = 8;
            Accounts.SelectedIndexChanged += Accounts_SelectedIndexChanged;
            // 
            // FName
            // 
            FName.Location = new Point(12, 24);
            FName.Name = "FName";
            FName.Size = new Size(379, 23);
            FName.TabIndex = 11;
            // 
            // SName
            // 
            SName.Location = new Point(12, 83);
            SName.Name = "SName";
            SName.Size = new Size(379, 23);
            SName.TabIndex = 12;
            // 
            // Login_Text
            // 
            Login_Text.Location = new Point(12, 141);
            Login_Text.Name = "Login_Text";
            Login_Text.Size = new Size(379, 23);
            Login_Text.TabIndex = 13;
            // 
            // Password_Text
            // 
            Password_Text.Location = new Point(12, 203);
            Password_Text.Name = "Password_Text";
            Password_Text.Size = new Size(379, 23);
            Password_Text.TabIndex = 14;
            // 
            // Perm
            // 
            Perm.FormattingEnabled = true;
            Perm.Items.AddRange(new object[] { "Guest", "CommonUser", "ExtendedUser", "Moderator", "Admin" });
            Perm.Location = new Point(12, 330);
            Perm.Name = "Perm";
            Perm.Size = new Size(379, 23);
            Perm.TabIndex = 16;
            // 
            // dateofbirth
            // 
            dateofbirth.Location = new Point(13, 264);
            dateofbirth.Name = "dateofbirth";
            dateofbirth.Size = new Size(378, 23);
            dateofbirth.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 18;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 19;
            label2.Text = "Second name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 20;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 246);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 21;
            label4.Text = "Date of birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 185);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 22;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 312);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 23;
            label5.Text = "Permissions";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(12, 389);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(116, 32);
            SaveBtn.TabIndex = 24;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveClk;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(144, 389);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(116, 32);
            DelBtn.TabIndex = 25;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelClk;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(275, 389);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(116, 32);
            ExitBtn.TabIndex = 26;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // AccountEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitBtn);
            Controls.Add(DelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateofbirth);
            Controls.Add(Perm);
            Controls.Add(Password_Text);
            Controls.Add(Login_Text);
            Controls.Add(SName);
            Controls.Add(FName);
            Controls.Add(Accounts);
            Name = "AccountEditor";
            Text = "AccountEditor";
            FormClosed += AccountEditor_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Accounts;
        private TextBox FName;
        private TextBox SName;
        private TextBox Login_Text;
        private TextBox Password_Text;
        private ComboBox Perm;
        private DateTimePicker dateofbirth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button SaveBtn;
        private Button DelBtn;
        private Button ExitBtn;
    }
}