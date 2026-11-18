using System.IO;
using Tyuiu.GaitovaAA.Sprint5.Task7.V21.Lib;

namespace Tyuiu.GaitovaAA.Sprint5.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V21.txt");
            File.WriteAllText(path, "Привет, мир! Как дела? Отлично: без знаков.");

            string pathSaveFile = ds.LoadDataAndSave(path);

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
