using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint4.Task6.V7.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 3;
            var array = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика"};
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
