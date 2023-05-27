using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3
{
    internal class AccountManager
    {
        public static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Accounts");

        public static void Update()
        {
            try
            {
                File.Delete(Path.Combine(path, "accountInfo.json"));
                File.Delete(Path.Combine(path, "accounts.json"));
            }
            catch { }
            try
            {
                foreach (Account account in Registration.accounts)
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(path, "accountInfo.json"), true))
                    {
                        sw.Write(account.Serialize(password: false));
                    }
                    using (StreamWriter sw = new StreamWriter(Path.Combine(path, "accounts.json"), true))
                    {
                        sw.Write(account.Serialize(Fname: false, Sname: false, permissions: false, date: false));
                    }
                }
            }
            catch { }
        }

        public static void Save(Account account)
        {
            try { Directory.CreateDirectory(path); }
            catch { }

            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, "accountInfo.json"), true))
                {
                    sw.Write(account.Serialize(password: false));
                }
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, "accounts.json"), true))
                {
                    sw.Write(account.Serialize(Fname: false, Sname: false, permissions: false, date: false));
                }
            }
            catch { }
        }

        public static Account? Load(int index)
        {
            int counter = -1;
            string info = "{";
            string? line = "";
            try
            {
                using (StreamReader sw = new StreamReader(Path.Combine(path, "accountInfo.json")))
                {
                    while (line != null)
                    {
                        line = sw.ReadLine();
                        if (line == "{") counter++;
                        if (counter > index) break;
                        if (counter == index && line != "{" && line != "}" && line != null) info += line + "\n";
                    }
                }
                counter = -1;
                using (StreamReader sw = new StreamReader(Path.Combine(path, "accounts.json")))
                {
                    line = "";
                    while (line != null)
                    {
                        line = sw.ReadLine();
                        if (line == "{") counter++;
                        if (counter > index) break;
                        if (counter == index && line != "{" && line != "}" && line != null) info += line + "\n";
                    }
                }
                info += "}";
                if (info.Length < 5) return null;
                return Account.DeSerialize(info);
            }
            catch { return null; }
        }
    }
}
