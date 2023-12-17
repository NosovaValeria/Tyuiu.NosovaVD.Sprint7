using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint7.Project.V15.Lib;
namespace Tyuiu.NosovaVD.Sprint7.Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumm()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Валерия\Desktop\Task7.csv";
            int fileExists = ds.Sum(path);
            int wait = 50000;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
