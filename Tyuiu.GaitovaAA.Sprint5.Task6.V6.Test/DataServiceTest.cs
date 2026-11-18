using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task6.V6.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V6.txt");
            File.WriteAllText(path, "Привет, Мир! Hello 123 ёлка");

            int res = ds.LoadFromDataFile(path);
            int wait = 11;

            Assert.AreEqual(wait, res);
        }
    }
}
