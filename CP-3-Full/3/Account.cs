using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _3
{
    public struct Account
    {
        public string login, password, Fname, Sname, date;

        public enum Permissions
        {
            None = 0,
            ViewUsers = 1,
            ViewAdmins = 2,
            EditSelf = 4,
            EditOther = 8,
            ViewPasswords = 16,

            Guest = ViewUsers,
            CommonUser = ViewAdmins | ViewUsers,
            ExtendedUser = CommonUser | EditSelf,
            Moderator = CommonUser | ViewPasswords,
            Admin = ExtendedUser | EditOther | ViewPasswords
        }

        public Permissions permissions = Permissions.Admin;

        public Account(string login, string password, string Fname, string Sname, string date, Permissions perm)
        {
            permissions = perm;
            this.login = login;
            this.password = password;
            this.Fname = Fname;
            this.Sname = Sname;
            this.date = date;
        }
        
        public string Serialize(bool login = true, bool password = true, bool Fname = true, bool Sname = true, bool date = true, bool permissions = true)
        {
            string info = "{\n";
            if (login) info += "\"login\" : \"" + this.login + "\"\n";
            if (password) info += "\"password\" : \"" + this.password + "\"\n";
            if (Fname) info += "\"Fname\" : \"" + this.Fname + "\"\n";
            if (Sname) info += "\"Sname\" : \"" + this.Sname + "\"\n";
            if (date) info += "\"date\" : \"" + this.date + "\"\n";
            if (permissions) info += "\"permissions\" : \"" + this.permissions + "\"\n";
            info += "}\n";

            return info;
        }

        public static string GetValue(string line)
        {
            int counter = -1;
            string value = "";
            foreach (char ch in  line)
            {
                if (ch == '\"') counter++;
                if (counter == 2 && ch != '\"') value += ch;
            }
            return value;
        }

        public static Account DeSerialize(string info)
        {
            string[] lines = info.Split("\n");
            Account account = new Account();
            foreach (string line in lines)
            {
                if (line != "{" && line !=  "}")
                {
                    if (line.Contains("login")) account.login = GetValue(line);
                    if (line.Contains("password")) account.password = GetValue(line);
                    if (line.Contains("Fname")) account.Fname = GetValue(line);
                    if (line.Contains("Sname")) account.Sname = GetValue(line);
                    if (line.Contains("date")) account.date = GetValue(line);
                    if (line.Contains("permissions")) Enum.TryParse(GetValue(line), out account.permissions);
                }
            }
            return account;
        }

        public static Account Update(Account ac, string login = "", string password = "", string Fname = "", string Sname = "", string date = "", Permissions perm = Permissions.Guest)
        {
            Account a = (Account)ac.MemberwiseClone();
            if (login != "") a.login = login;
            if (password != "") a.password = password;
            if (Fname != "") a.Fname = Fname;
            if (Sname != "") a.Sname = Sname;
            if (date != "") a.date = date;
            if (perm != Permissions.Guest) a.permissions = perm;
            return a;
        }
    }
}
