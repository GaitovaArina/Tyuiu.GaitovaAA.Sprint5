using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GaitovaAA.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            double maxPrime = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string val in values)
                    {
                        if (int.TryParse(val, out int number))
                        {
                            if (IsPrime(number) && number > maxPrime)
                            {
                                maxPrime = number;
                            }
                        }
                    }
                }
            }

            return Math.Round(maxPrime, 3);
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
