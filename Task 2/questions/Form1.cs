using System.Reflection;

namespace questions
{
    public partial class Form1 : Form
    {
        List<Result> SavedResult = new List<Result>();
        int lastindex = -1;
        bool unsaved = false;

        public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "questions");

        public Form1()
        {
            InitializeComponent();
            try
            {
                Directory.CreateDirectory(path);
            }
            catch { }
            try
            {
                LoadSaves();
            }
            catch { }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarUpdate();
            if (PB1.Value == 7) SV.Enabled = true;
            else SV.Enabled = false;
            if (Lst.SelectedIndex != -1)
            {
                LD.Enabled = true;
                DL.Enabled = true;
            }
            else
            {
                LD.Enabled = false;
                DL.Enabled = false;
            }
        }

        private void SV_Click(object sender, EventArgs e)
        {
            lastindex += 1;
            SavedResult.Add(Save(lastindex));
            Lst.Items.Add(SavedResult[lastindex].info[13]);
        }

        private void LD_Click(object sender, EventArgs e)
        {
            Result res = Result.LoadFromFile(Path.Combine(path, $"{Lst.SelectedIndex}.txt"));
            LoadFromInfo(res.info);
        }

        private void DL_Click(object sender, EventArgs e)
        {
            Lst.Items.RemoveAt(Lst.SelectedIndex);
        }

        public void BarUpdate()
        {
            bool[] count = new bool[7];
            int progress = 0;
            if (CH1.Checked || CH2.Checked || CH3.Checked || CH4.Checked) count[0] = true;
            else count[0] = false;
            if (CHB1.SelectedIndex != -1) count[1] = true;
            else count[1] = false;
            if (RB1.Checked || RB2.Checked || RB3.Checked || RB4.Checked) count[2] = true;
            else count[2] = false;
            if (TB1.Text != "") count[3] = true;
            else count[3] = false;
            if (Sec.Text != "") count[4] = true;
            else count[4] = false;
            if (Fir.Text != "") count[5] = true;
            else count[5] = false;
            if (Gr.Text != "") count[6] = true;
            else count[6] = false;

            foreach (bool i in count) if (i) progress += 1;

            PB1.Value = progress;
        }

        public Result Save(int count)
        {

            List<string> info = new List<string>
            {
                Convert.ToString(CH1.Checked),
                Convert.ToString(CH2.Checked),
                Convert.ToString(CH3.Checked),
                Convert.ToString(CH4.Checked),
                Convert.ToString(CHB1.SelectedIndex),
                Convert.ToString(NB1.Value),
                SaveRB(),
                TB1.Text,
                Convert.ToString(TRB1.Value),
                Sec.Text,
                Fir.Text,
                Gr.Text,
                Convert.ToString(Age.Value),
                Sec.Text + " " + Fir.Text[0] + "." + " Группа " + Gr.Text
            };
            unsaved = false;
            Result res = new Result(info);
            DebugL.Text = res.SaveToFile(count);
            return res;
        }


        public void AnyChanged(object sender, EventArgs e)
        {
            unsaved = true;
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (unsaved)
            {
                if (MessageBox.Show("Вы хотите сохранить последние изменения?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lastindex++;
                    Save(lastindex);
                    //e.Cancel = true; для остановки завершения программы
                }
            }
        }

        private void DelSaves_Click(object sender, EventArgs e)
        {
            LoadSaves(true);
        }

        private void LoadSaves(bool delete = false)
        {
            foreach (var path in Directory.GetFiles(path))
            {
                if (delete)
                {
                    File.Delete(path);
                    Lst.Items.Clear();
                }
                else
                {
                    SavedResult.Add(Result.LoadFromFile(path));
                    Lst.Items.Add(SavedResult.Last().info[13]);
                    lastindex++;
                }
            }
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string> { "false", "false", "false", "false", "-1", "0", "0", "", "1", "", "", "", "2000" };
            LoadFromInfo(info);
            unsaved = false;
        }

        private void LoadFromInfo(List<string> info)
        {
            CH1.Checked = Convert.ToBoolean(info[0]);
            CH2.Checked = Convert.ToBoolean(info[1]);
            CH3.Checked = Convert.ToBoolean(info[2]);
            CH4.Checked = Convert.ToBoolean(info[3]);
            CHB1.SelectedIndex = Convert.ToInt32(info[4]);
            NB1.Value = Convert.ToInt32(info[5]);
            LoadRB(info[6]);
            TB1.Text = info[7];
            TRB1.Value = Convert.ToInt32(info[8]);
            Sec.Text = info[9];
            Fir.Text = info[10];
            Gr.Text = info[11];
            Age.Value = Convert.ToInt32(info[12]);
        }

        public string SaveRB()
        {
            if (RB1.Checked) return "1";
            else if (RB2.Checked) return "2";
            else if (RB3.Checked) return "3";
            else if (RB4.Checked) return "4";
            else return "0";
        }

        public void LoadRB(string index)
        {
            if (index == "1") RB1.Checked = true;
            else if (index == "2") RB2.Checked = true;
            else if (index == "3") RB3.Checked = true;
            else if (index == "4") RB4.Checked = true;
            else
            {
                RB1.Checked = false;
                RB2.Checked = false;
                RB3.Checked = false;
                RB4.Checked = false;
            }
        }

    }

}