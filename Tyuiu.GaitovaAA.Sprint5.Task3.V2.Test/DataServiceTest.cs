using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task3.V2.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
