using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace _3
{
    public partial class Registration : Form
    {
        public static Dictionary<char, string> Transliteration = new Dictionary<char, string>
        {
        {'�', "a"},
        {'�', "b"},
        {'�', "v"},
        {'�', "g"},
        {'�', "d"},
        {'�', "e"},
        {'�', "yo"},
        {'�', "zh"},
        {'�', "z"},
        {'�', "i"},
        {'�', "j"},
        {'�', "k"},
        {'�', "l"},
        {'�', "m"},
        {'�', "n"},
        {'�', "o"},
        {'�', "p"},
        {'�', "r"},
        {'�', "s"},
        {'�', "t"},
        {'�', "u"},
        {'�', "f"},
        {'�', "h"},
        {'�', "c"},
        {'�', "ch"},
        {'�', "sh"},
        {'�', "sch"},
        {'�', "j"},
        {'�', "i"},
        {'�', "j"},
        {'�', "e"},
        {'�', "yu"},
        {'�', "ya"},
        {'�', "A"},
        {'�', "B"},
        {'�', "V"},
        {'�', "G"},
        {'�', "D"},
        {'�', "E"},
        {'�', "Yo"},
        {'�', "Zh"},
        {'�', "Z"},
        {'�', "I"},
        {'�', "J"},
        {'�', "K"},
        {'�', "L"},
        {'�', "M"},
        {'�', "N"},
        {'�', "O"},
        {'�', "P"},
        {'�', "R"},
        {'�', "S"},
        {'�', "T"},
        {'�', "U"},
        {'�', "F"},
        {'�', "H"},
        {'�', "C"},
        {'�', "Ch"},
        {'�', "Sh"},
        {'�', "Sch"},
        {'�', "J"},
        {'�', "I"},
        {'�', "J"},
        {'�', "E"},
        {'�', "Yu"},
        {'�', "Ya"}
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