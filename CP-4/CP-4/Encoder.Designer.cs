namespace CP_4
{
    partial class Encoder
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
            Variables = new ListBox();
            VarRemove = new Button();
            StepUp = new Button();
            StepDown = new Button();
            Encrypt = new Button();
            Decrypt = new Button();
            Decrypted = new RichTextBox();
            Old = new RichTextBox();
            Code = new TextBox();
            Encrypted = new RichTextBox();
            Steps = new ListBox();
            VarAdd = new Button();
            SuspendLayout();
            // 
            // Variables
            // 
            Variables.FormattingEnabled = true;
            Variables.ItemHeight = 15;
            Variables.Items.AddRange(new object[] { "Increment (+1)", "Decrement (-1)", "Zero (0)", "Negative (255-code)" });
            Variables.Location = new Point(12, 114);
            Variables.Name = "Variables";
            Variables.Size = new Size(120, 94);
            Variables.TabIndex = 23;
            // 
            // VarRemove
            // 
            VarRemove.Location = new Point(138, 163);
            VarRemove.Name = "VarRemove";
            VarRemove.Size = new Size(28, 23);
            VarRemove.TabIndex = 22;
            VarRemove.Text = "-";
            VarRemove.UseVisualStyleBackColor = true;
            VarRemove.Click += VarRemove_Click;
            // 
            // StepUp
            // 
            StepUp.Location = new Point(321, 134);
            StepUp.Name = "StepUp";
            StepUp.Size = new Size(28, 23);
            StepUp.TabIndex = 21;
            StepUp.Text = "+";
            StepUp.UseVisualStyleBackColor = true;
            StepUp.Click += StepUp_Click;
            // 
            // StepDown
            // 
            StepDown.Location = new Point(321, 163);
            StepDown.Name = "StepDown";
            StepDown.Size = new Size(28, 23);
            StepDown.TabIndex = 20;
            StepDown.Text = "-";
            StepDown.UseVisualStyleBackColor = true;
            StepDown.Click += StepDown_Click;
            // 
            // Encrypt
            // 
            Encrypt.Location = new Point(12, 214);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(337, 23);
            Encrypt.TabIndex = 19;
            Encrypt.Text = "Encrypt";
            Encrypt.UseVisualStyleBackColor = true;
            Encrypt.Click += Encrypt_Click;
            // 
            // Decrypt
            // 
            Decrypt.Location = new Point(12, 374);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(337, 23);
            Decrypt.TabIndex = 18;
            Decrypt.Text = "Decrypt";
            Decrypt.UseVisualStyleBackColor = true;
            Decrypt.Click += Decrypt_Click;
            // 
            // Decrypted
            // 
            Decrypted.Location = new Point(12, 403);
            Decrypted.Name = "Decrypted";
            Decrypted.Size = new Size(337, 96);
            Decrypted.TabIndex = 17;
            Decrypted.Text = "";
            // 
            // Old
            // 
            Old.Location = new Point(12, 12);
            Old.Name = "Old";
            Old.Size = new Size(337, 96);
            Old.TabIndex = 16;
            Old.Text = "";
            // 
            // Code
            // 
            Code.Location = new Point(12, 345);
            Code.Name = "Code";
            Code.Size = new Size(337, 23);
            Code.TabIndex = 15;
            // 
            // Encrypted
            // 
            Encrypted.Location = new Point(12, 243);
            Encrypted.Name = "Encrypted";
            Encrypted.Size = new Size(337, 96);
            Encrypted.TabIndex = 14;
            Encrypted.Text = "";
            // 
            // Steps
            // 
            Steps.FormattingEnabled = true;
            Steps.ItemHeight = 15;
            Steps.Location = new Point(195, 114);
            Steps.Name = "Steps";
            Steps.Size = new Size(120, 94);
            Steps.TabIndex = 13;
            // 
            // VarAdd
            // 
            VarAdd.Location = new Point(138, 134);
            VarAdd.Name = "VarAdd";
            VarAdd.Size = new Size(28, 23);
            VarAdd.TabIndex = 12;
            VarAdd.Text = "+";
            VarAdd.UseVisualStyleBackColor = true;
            VarAdd.Click += VarAdd_Click;
            // 
            // Encoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 509);
            Controls.Add(Variables);
            Controls.Add(VarRemove);
            Controls.Add(StepUp);
            Controls.Add(StepDown);
            Controls.Add(Encrypt);
            Controls.Add(Decrypt);
            Controls.Add(Decrypted);
            Controls.Add(Old);
            Controls.Add(Code);
            Controls.Add(Encrypted);
            Controls.Add(Steps);
            Controls.Add(VarAdd);
            Name = "Encoder";
            Text = "Encoder";
            FormClosing += Encoder_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Variables;
        private Button VarRemove;
        private Button StepUp;
        private Button StepDown;
        private Button Encrypt;
        private Button Decrypt;
        private RichTextBox Decrypted;
        private RichTextBox Old;
        private TextBox Code;
        private RichTextBox Encrypted;
        private ListBox Steps;
        private Button VarAdd;
    }
}