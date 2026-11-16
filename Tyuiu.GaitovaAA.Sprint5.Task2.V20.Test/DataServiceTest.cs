using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task2.V20.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                {  5, -5, -1 },
                { -4,  2, -4 },
                { -7,  1,  4 }
            };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
