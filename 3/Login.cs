using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Login : Form
    {
        Registration RegistrationForm;
        AccountEditor EditorForm;
        public Login()
        {
            InitializeComponent();
            RegistrationForm = new Registration(this);
        }

        private void Log_in(object sender, EventArgs e)
        {
            foreach(Account acc in Registration.accounts)
            {
                if(acc.login == Login_Text.Text && acc.password == Password_Text.Text)
                {
                    EditorForm = new AccountEditor(this, acc);
                    EditorForm.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Incorrect Login or Password!");
        }

        private void GuestLog_in(object sender, EventArgs e)
        {
            RegistrationForm = new Registration(this);
            RegistrationForm.Show();
            this.Hide();
        }

        private void Quit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
