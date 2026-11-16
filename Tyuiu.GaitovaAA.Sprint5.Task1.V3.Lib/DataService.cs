using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GaitovaAA.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists )
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(Math.Cos(2 * x) + Math.Sin(x) / (x + 2.5) + 2 * x, 2);
                }

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}
