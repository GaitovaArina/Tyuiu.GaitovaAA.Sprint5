using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GaitovaAA.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            double x = Convert.ToDouble(strX);


            double res = Math.Pow(x, 3) * 1.2 * x + 2;
            return Math.Round(res, 3);
        }
    }
}
