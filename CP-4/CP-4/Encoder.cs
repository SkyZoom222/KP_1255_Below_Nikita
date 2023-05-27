namespace CP_4
{
    public partial class Encoder : Form
    {
        public Encoder()
        {
            InitializeComponent();
        }

        string[] variables = new string[] 
        {
            "Increment (+1)",
            "Decrement (-1)",
            "Zero (0)",
            "Negative (255-code)"
        };

        private void Encoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void VarAdd_Click(object sender, EventArgs e)
        {
            Steps.Items.Add(variables[Variables.SelectedIndex]);
        }

        private void VarRemove_Click(object sender, EventArgs e)
        {
            Steps.Items.RemoveAt(Steps.SelectedIndex);
        }

        private void StepUp_Click(object sender, EventArgs e)
        {
            if(Steps.SelectedIndex != 0)
            {
                string temp = Convert.ToString(Steps.SelectedItem);
                int index = Steps.SelectedIndex;
                Steps.Items.Insert(Steps.SelectedIndex - 1, temp);
                Steps.Items.RemoveAt(Steps.SelectedIndex);
                Steps.SelectedIndex = index - 1;
            }
        }

        private void StepDown_Click(object sender, EventArgs e)
        {
            if (Steps.SelectedIndex != Steps.Items.Count - 1)
            {
                string temp = Convert.ToString(Steps.SelectedItem);
                int index = Steps.SelectedIndex;
                Steps.Items.Insert(Steps.SelectedIndex + 2, temp);
                Steps.Items.RemoveAt(Steps.SelectedIndex);
                Steps.SelectedIndex = index + 1;
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            int step = 0;
            string result = "";
            string code = "";
            foreach(string item in Steps.Items)
            {
                code += item[0];
            }
            foreach(char ch in Old.Text)
            {
                result += EncodeDecodeChar(ch, Convert.ToString(Steps.Items[step]));
                step++;
                if (step == Steps.Items.Count) step = 0;
            }
            Encrypted.Text = result;
            Code.Text = code;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            int step = 0;
            string code = "";
            string result = "";
            foreach (char ch in Encrypted.Text)
            {
                code += Code.Text[step];
                step++;
                if (step == Code.Text.Length) step = 0;
            }
            step = 0;
            foreach (char ch in code)
            {
                result += EncodeDecodeChar(Encrypted.Text[step], Convert.ToString(ch),true);
                step++;
            }
            Decrypted.Text = result;
        }

        private char EncodeDecodeChar(char ch, string action, bool Decode = false)
        {
            int code = Convert.ToInt32(ch);
            if(!Decode)
            {
                switch (action)
                {
                    case "Increment (+1)":
                        code++;
                        break;
                    case "Decrement (-1)":
                        code--;
                        break;
                    case "Zero (0)":
                        break;
                    case "Negative (255-code)":
                        code = 255 - code;
                        break;
                }
                return Convert.ToChar(code);
            }
            else
            {
                switch (action)
                {
                    case "I":
                        code--;
                        break;
                    case "D":
                        code++;
                        break;
                    case "Z":
                        break;
                    case "N":
                        code = 255 - code;
                        break;
                }
                return Convert.ToChar(code);
            }
            
        }
    }
}