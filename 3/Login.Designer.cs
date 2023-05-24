namespace _3
{
    partial class Login
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
            Login_btn = new Button();
            Guest_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            Login_Text = new TextBox();
            Password_Text = new TextBox();
            SuspendLayout();
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(32, 119);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(75, 23);
            Login_btn.TabIndex = 0;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Log_in;
            // 
            // Guest_btn
            // 
            Guest_btn.Location = new Point(121, 119);
            Guest_btn.Name = "Guest_btn";
            Guest_btn.Size = new Size(103, 23);
            Guest_btn.TabIndex = 1;
            Guest_btn.Text = "Login as guest";
            Guest_btn.UseVisualStyleBackColor = true;
            Guest_btn.Click += GuestLog_in;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Login_Text
            // 
            Login_Text.Location = new Point(32, 39);
            Login_Text.Name = "Login_Text";
            Login_Text.Size = new Size(192, 23);
            Login_Text.TabIndex = 4;
            // 
            // Password_Text
            // 
            Password_Text.Location = new Point(32, 90);
            Password_Text.Name = "Password_Text";
            Password_Text.Size = new Size(192, 23);
            Password_Text.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 165);
            Controls.Add(Password_Text);
            Controls.Add(Login_Text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Guest_btn);
            Controls.Add(Login_btn);
            Name = "Login";
            Text = "Login";
            FormClosing += Quit;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_btn;
        private Button Guest_btn;
        private Label label1;
        private Label label2;
        private TextBox Login_Text;
        private TextBox Password_Text;
    }
}