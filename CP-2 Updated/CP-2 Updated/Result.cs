using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CP_2_Updated
{
    internal class Result
    {

        public string[] TestResult { get; set; } = new string[13];

        public Result(string[] info) 
        {
            TestResult = info;
        }


        public static Result ReturnResult(Questions form)
        {
            
            string[] info = new string[13];

            info[0] = form.Fname.Text;
            info[1] = form.Sname.Text;
            info[2] = Convert.ToString(form.Age.Value);
            info[3] = form.Gr.Text;

            info[4] = Convert.ToString(form.CH1.Checked);
            info[5] = Convert.ToString(form.CH2.Checked);
            info[6] = Convert.ToString(form.CH3.Checked);
            info[7] = Convert.ToString(form.CH4.Checked);

            info[8] = Convert.ToString(form.CHB1.SelectedIndex);

            info[9] = Convert.ToString(form.NB1.Value);

            info[10] = GetValueFromRB(form);

            info[11] = form.TB1.Text;

            info[12] = Convert.ToString(form.TRB1.Value);

            Result newRes = new Result(info);
            return newRes;
        }

        public void LoadToForm(Questions form)
        {
            form.Fname.Text = TestResult[0];
            form.Sname.Text = TestResult[1];
            form.Age.Value = Convert.ToInt32(TestResult[2]);
            form.Gr.Text = TestResult[3];

            form.CH1.Checked = Convert.ToBoolean(TestResult[4]);
            form.CH2.Checked = Convert.ToBoolean(TestResult[5]);
            form.CH3.Checked = Convert.ToBoolean(TestResult[6]);
            form.CH4.Checked = Convert.ToBoolean(TestResult[7]);

            form.CHB1.SelectedIndex = Convert.ToInt32(TestResult[8]);

            form.NB1.Value = Convert.ToInt32(TestResult[9]);

            Result.SetValueToRB(form, TestResult[10]);

            form.TB1.Text = TestResult[11];

            form.TRB1.Value = Convert.ToInt32(TestResult[12]);

        }

        private static string GetValueFromRB(Questions form)
        {
            if (form.RB1.Checked) return "1";
            else if (form.RB2.Checked) return "2";
            else if (form.RB3.Checked) return "3";
            else if (form.RB4.Checked) return "4";
            else return "-1";
        }

        private static void SetValueToRB(Questions form, string value)
        {
            switch(value)
            {
                case "1":
                    form.RB1.Checked = true;
                    break;
                case "2":
                    form.RB2.Checked = true;
                    break;
                case "3":
                    form.RB3.Checked = true;
                    break;
                case "4":
                    form.RB4.Checked = true;
                    break;

            }

        }

        public static string Serialize(string[] info)
        {
            string save = "{\n";

            foreach (string st in info)
            {
                save += $"\"{st}\"\n";
            }
            save += "}\n";

            return save;
        }

        public static string[] DeSerialize(string info)
        {
            string[] res = new string[13];
            int i = 0;
            foreach(string st in info.Split('\n'))
            {
                string temp = "";
                bool write = false;
                foreach(char ch in st)
                {
                    if (ch == '\"' && !write)
                    { 
                        write = true;
                        continue;
                    }

                    if (ch == '\"') write = false;

                    if (write) temp += ch;

                    

                }
                if (i < 13) res[i] = temp;
                i++;
            }

            return res;
        }
    }
}
