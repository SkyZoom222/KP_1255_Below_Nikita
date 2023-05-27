using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace _3
{
    public partial class Registration : Form
    {
        public static Dictionary<char, string> Transliteration = new Dictionary<char, string>
        {
        {'à', "a"},
        {'á', "b"},
        {'â', "v"},
        {'ã', "g"},
        {'ä', "d"},
        {'å', "e"},
        {'¸', "yo"},
        {'æ', "zh"},
        {'ç', "z"},
        {'è', "i"},
        {'é', "j"},
        {'ê', "k"},
        {'ë', "l"},
        {'ì', "m"},
        {'í', "n"},
        {'î', "o"},
        {'ï', "p"},
        {'ð', "r"},
        {'ñ', "s"},
        {'ò', "t"},
        {'ó', "u"},
        {'ô', "f"},
        {'õ', "h"},
        {'ö', "c"},
        {'÷', "ch"},
        {'ø', "sh"},
        {'ù', "sch"},
        {'ú', "j"},
        {'û', "i"},
        {'ü', "j"},
        {'ý', "e"},
        {'þ', "yu"},
        {'ÿ', "ya"},
        {'À', "A"},
        {'Á', "B"},
        {'Â', "V"},
        {'Ã', "G"},
        {'Ä', "D"},
        {'Å', "E"},
        {'¨', "Yo"},
        {'Æ', "Zh"},
        {'Ç', "Z"},
        {'È', "I"},
        {'É', "J"},
        {'Ê', "K"},
        {'Ë', "L"},
        {'Ì', "M"},
        {'Í', "N"},
        {'Î', "O"},
        {'Ï', "P"},
        {'Ð', "R"},
        {'Ñ', "S"},
        {'Ò', "T"},
        {'Ó', "U"},
        {'Ô', "F"},
        {'Õ', "H"},
        {'Ö', "C"},
        {'×', "Ch"},
        {'Ø', "Sh"},
        {'Ù', "Sch"},
        {'Ú', "J"},
        {'Û', "I"},
        {'Ü', "J"},
        {'Ý', "E"},
        {'Þ', "Yu"},
        {'ß', "Ya"}
        };
        public static string AllowedLetters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM_-@";
        bool passwordGenerated = false;
        public static List<Account> accounts = new List<Account>();
        int lastAccount = 1;

        int countErrors = 0;

        Login LoginForm;
        public Registration(Login LoginForm)
        {
            InitializeComponent();
            this.LoginForm = LoginForm;
            LoadAccounts();
        }

        private void GeneratePassword(object sender, EventArgs e)
        {
            string args = "--length=" + Convert.ToString(PasswordLength.Value) + " --letters=" + Convert.ToString(Countofletters.Value);
            if (upper.Checked) args += " -u";
            if (spec.Checked) args += " -s";
            Process PassGenerator = new Process();
            PassGenerator.StartInfo.FileName = "PassGen/1.exe";
            PassGenerator.StartInfo.Arguments = args;
            PassGenerator.StartInfo.CreateNoWindow = true;
            PassGenerator.StartInfo.RedirectStandardOutput = true;
            PassGenerator.Start();
            Password.Text = PassGenerator.StandardOutput.ReadLine();
            passwordGenerated = true;
        }

        private void CreateAccount(object sender, EventArgs e)
        {
            if (!passwordGenerated) MessageBox.Show("Generate Password!");
            if (Fname.Text != "" && Sname.Text != "" && passwordGenerated)
            {
                accounts.Add(new Account(Login.Text, Password.Text, Fname.Text, Sname.Text, dateofbirth.Text, Account.Permissions.Admin));
                AccountManager.Save(accounts.Last());
                Accounts.Items.Add($"{lastAccount}." + Login.Text);
                lastAccount++;
                LoginForm.Show();
                this.Hide();
            }
        }

        private void CountChecker(object sender, EventArgs e)
        {
            if (letCountChecker.Checked) Countofletters.Enabled = true;
            else
            {
                Countofletters.Enabled = false;
                Countofletters.Value = 0;
            }
        }

        private void LoadAccounts()
        {
            lastAccount = 1;
            accounts.Clear();
            Accounts.Items.Clear();
            try
            {
                Account? account = new Account();
                while(account != null)
                {
                    account = AccountManager.Load(lastAccount - 1);
                    if (!account.HasValue) continue;
                    accounts.Add(account ?? new Account());
                    Accounts.Items.Add(lastAccount + ". " + accounts.Last().Fname);
                    lastAccount++;
                }
                
            }
            catch { }
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
            Login.Text = LoginGenerator(Fname.Text);
            countErrors = 0;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            Login.Text = LoginGenerator(Login.Text, true, true);
        }
        private void Quit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private string LoginGenerator(string username, bool check = false, bool checkErrors = false)
        {
            string login = "";
            if (check)
            {
                foreach (char ch in username)
                    if (AllowedLetters.Contains(ch)) login += ch;
                    else countErrors++;
                if (countErrors == 3 && checkErrors)
                {
                    countErrors = 0;
                    MessageBox.Show($"Allowed letters : {AllowedLetters}");
                }
                return login;
            }
            else
            {
                try
                {
                    foreach (char ch in username)
                    {
                        if (ch == ' ') continue;
                        login += Transliteration[ch];
                    }
                }
                catch
                {
                    return LoginGenerator(username, true);
                }
                return login;
            }
        }

        private void Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountInfo.Items.Clear();
            AccountInfo.Items.Add("Name: " + accounts[Accounts.SelectedIndex].Fname + " " + accounts[Accounts.SelectedIndex].Sname);
            AccountInfo.Items.Add("Date of Birth: " + accounts[Accounts.SelectedIndex].date);
            //AccountInfo.Items.Add("Permissions: " + accounts[Accounts.SelectedIndex].permissions);
        }
    }
}