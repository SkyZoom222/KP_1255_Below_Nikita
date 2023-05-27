using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class AccountEditor : Form
    {
        Login PreviousForm;
        Account.Permissions perm;
        int LoggedAccIndex = -1;
        List<int> ShowedAccIndex = new List<int>();
        public AccountEditor(Login prevForm, Account acc)
        {
            InitializeComponent();
            PreviousForm = prevForm;
            perm = acc.permissions;
            LoggedAccIndex = Registration.accounts.IndexOf(acc);
            if (!perm.HasFlag(Account.Permissions.ViewPasswords)) Password_Text.Enabled = false;

            UpdateAccounts();
            if (perm != Account.Permissions.Admin) Perm.Enabled = false;

        }

        private void UpdateAccounts()
        {
            Accounts.Items.Clear();
            ShowedAccIndex.Clear();
            int r = 1;
            int i = 0;
            foreach (var a in Registration.accounts)
            {
                if (perm.HasFlag(Account.Permissions.ViewAdmins) && a.permissions == Account.Permissions.Admin)
                {
                    if(LoggedAccIndex == i) Accounts.Items.Add(r + ". " + a.Fname + " " + a.Sname + " --You-- " + a.permissions);
                    else Accounts.Items.Add(r + ". " + a.Fname + " " + a.Sname + " " + a.permissions);
                    ShowedAccIndex.Add(i);
                    r++;
                }
                else if (perm.HasFlag(Account.Permissions.ViewUsers) && a.permissions <= Account.Permissions.Admin)
                {
                    if(LoggedAccIndex == i) Accounts.Items.Add(r + ". " + a.Fname + " " + a.Sname + " --You-- " + a.permissions);
                    else Accounts.Items.Add(r + ". " + a.Fname + " " + a.Sname + " " + a.permissions);
                    ShowedAccIndex.Add(i);
                    r++;
                }
                else if (LoggedAccIndex == i)
                {
                    Accounts.Items.Add(r + ". " + a.Fname + " " + a.Sname + " --You-- " + a.permissions);
                    ShowedAccIndex.Add(i);
                    r++;
                }
                i++;

            }
        }

        private void SaveClk(object sender, EventArgs e)
        {
            int index = Accounts.SelectedIndex;
            if (!perm.HasFlag(Account.Permissions.ViewUsers)) index = LoggedAccIndex;
            if ((perm.HasFlag(Account.Permissions.EditSelf) && LoggedAccIndex == index) || perm.HasFlag(Account.Permissions.EditOther))
            {
                if (FName.Enabled) Registration.accounts[index] = Account.Update(Registration.accounts[index], Fname: FName.Text);
                if (SName.Enabled) Registration.accounts[index] = Account.Update(Registration.accounts[index], Sname: SName.Text);
                if (Login_Text.Enabled) Registration.accounts[index] = Account.Update(Registration.accounts[index], login: Login_Text.Text);
                if (Password_Text.Enabled) Registration.accounts[index] = Account.Update(Registration.accounts[index], password: Password_Text.Text);
                if (dateofbirth.Enabled) Registration.accounts[index] = Account.Update(Registration.accounts[index], date: dateofbirth.Text);
                if (Perm.Enabled)
                {
                    Account.Permissions p;
                    Enum.TryParse(Perm.Text, out p);
                    Registration.accounts[index] = Account.Update(Registration.accounts[index], perm: p);
                }
            }
            UpdateAccounts();
            Accounts.SelectedIndex = index;
            AccountManager.Update();
        }

        private void DelClk(object sender, EventArgs e)
        {
            if ((Accounts.SelectedIndex == LoggedAccIndex || !perm.HasFlag(Account.Permissions.ViewUsers)) && perm.HasFlag(Account.Permissions.EditSelf))
            {
                Registration.accounts.RemoveAt(Accounts.SelectedIndex);
                AccountManager.Update();
                perm = Account.Permissions.None;
                LoggedAccIndex = -1;
                this.Hide();
                PreviousForm.Show();
            }
            else if (perm.HasFlag(Account.Permissions.EditOther))
            {
                Registration.accounts.RemoveAt(Accounts.SelectedIndex);
                AccountManager.Update();
            }
            UpdateAccounts();
        }

        private void Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Accounts.SelectedIndex;
            if (!perm.HasFlag(Account.Permissions.ViewUsers)) index = LoggedAccIndex;
            if (FName.Enabled) FName.Text = Registration.accounts[index].Fname;
            if (SName.Enabled) SName.Text = Registration.accounts[index].Sname;
            if (Login_Text.Enabled) Login_Text.Text = Registration.accounts[index].login;
            if (Password_Text.Enabled) Password_Text.Text = Registration.accounts[index].password;
            if (dateofbirth.Enabled) dateofbirth.Text = Registration.accounts[index].date;
            if (Perm.Enabled) Perm.Text = Convert.ToString(Registration.accounts[index].permissions);
        }

        private void AccountEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviousForm.Show();
        }
    }
}
