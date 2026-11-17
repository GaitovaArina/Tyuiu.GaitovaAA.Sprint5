using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task5.V30.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V30.txt");
            File.WriteAllText(path, "4 -3 19 20 7.5 11");

            double res = ds.LoadFromDataFile(path);
            double wait = 19;

            Assert.AreEqual(wait, res);
        }
    }
}
