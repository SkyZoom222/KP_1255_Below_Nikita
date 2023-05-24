using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace questions
{
    public class Result
    {
        public List<string> info;

        public Result(List<string> info) 
        {
            this.info = info;
        }

        public string SaveToFile(int count)
        {
            string Save = "";
            for (int i = 0; i < info.Count; i++)
            {
                Save += info[i] + "/n";
            }
            try
            {
                File.AppendAllLines(Path.Combine(Form1.path, Convert.ToString(count) + ".txt"), Save.Split("/n"));
                return "Сохранено";
            }
            catch { return "Ошибка!"; }
        }


        public static Result LoadFromFile(string path)
        {
            try
            {
                string[] preload = File.ReadAllLines(path);
                List<string> info = new List<string>();
                for (int index = 0; index < 14; index++)
                {
                    info.Add(preload[index]);
                }
                return new Result(info);
            }
            catch { return null; }
        }

    }
}
