using System.Reflection;

namespace CP_2_Updated
{
    public partial class Questions : Form
    {

        public static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Results");
        private bool unsaved = false;

        bool clearLists = true;

        bool load = true;

        private List<Result> results = new List<Result>();

        public Questions()
        {
            InitializeComponent();
            this.FormClosing += Quit;
            ReadFromFile();

        }


        private void AnyChanged(object o, EventArgs e)
        {
            unsaved = true;
        }

        private void Quit(object sender, EventArgs e)
        {
            if (unsaved && Save.Enabled)
            {
                DialogResult res = MessageBox.Show("Сохранить последние изменения?", "///", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
            }
        }

        private void DelSaves_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (string path in Directory.GetFiles(path))
                {
                    File.Delete(path);
                }
                if (clearLists)
                {
                    results.Clear();
                    Results.Items.Clear();
                }
            }
            catch { }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (Results.SelectedIndex != -1)
            {
                results.RemoveAt(Results.SelectedIndex);
                Results.Items.RemoveAt(Results.SelectedIndex);
                clearLists = false;
                DelSaves_Click(sender, e);
                foreach (var res in results)
                {
                    SaveToFile(res);
                }
                clearLists = true;
            }
        }

        private void LoadResult_Click(object sender, EventArgs e)
        {
            if (Results.SelectedIndex != -1)
            {
                results[Results.SelectedIndex].LoadToForm(this);
                unsaved = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            results.Add(Result.ReturnResult(this));
            Results.Items.Add(results.Last().TestResult[0] + " " + results.Last().TestResult[1] + "   Группа - " + results.Last().TestResult[3]);
            SaveToFile(results.Last());
            unsaved = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CH1.Checked = false;
            CH2.Checked = false;
            CH3.Checked = false;
            CH4.Checked = false;

            CHB1.SelectedIndex = -1;

            NB1.Value = 0;

            RB1.Checked = false;
            RB2.Checked = false;
            RB3.Checked = false;
            RB4.Checked = false;

            TB1.Text = "";

            TRB1.Value = 1;

            unsaved = false;
        }

        private void SaveToFile(Result res)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch { }

            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, "results.json"), true))
                {
                    sw.Write(Result.Serialize(res.TestResult));
                }
            }
            catch { }
        }

        private void ReadFromFile()
        {
            results.Clear();
            Results.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(path, "results.json")))
                {
                    string line = "";
                    string result = "";
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != "{" && line != "}") result += line + "\n";
                        else if (line == "}")
                        {
                            results.Add(new Result(Result.DeSerialize(result)));
                            result = "";
                        }
                    }

                    foreach (Result res in results)
                    {
                        Results.Items.Add(res.TestResult[0] + " " + res.TestResult[1] + "   Группа - " + res.TestResult[3]);
                    }
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int value = 0;
            if (CH1.Checked || CH2.Checked || CH3.Checked || CH4.Checked) value++;

            if (CHB1.SelectedIndex != -1) value++;

            if (RB1.Checked || RB2.Checked || RB3.Checked || RB4.Checked) value++;

            if (TB1.Text != "") value++;

            if (Fname.Text != "") value++;

            if (Sname.Text != "") value++;

            if (Gr.Text != "") value++;

            Progress.Value = value;

            if (value == 7)
            {
                Save.Enabled = true;
            }
            else
            {
                Save.Enabled = false;
            }


        }

    }

}