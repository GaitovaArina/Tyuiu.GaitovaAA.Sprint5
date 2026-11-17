using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task4.V10.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V10");
            File.WriteAllText(path, "2.5");

            double res = ds.LoadFromDataFile(path);
            double wait = 48.875;

            Assert.AreEqual(wait, res);

        }
    }
}
