using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task3.V2.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Гаитова А. А. | Группа: ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Гаитова А. А. | Группа: ПКТб-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y = e^x / x, вычислить его значение при x = 3,           *");
            Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и вывести       *");
            Console.WriteLine("* на консоль. Округлить до трёх знаков после запятой.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            double resultValue;
            using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
            {
                resultValue = reader.ReadDouble();
            }

            Console.WriteLine("y = " + resultValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
