using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint4.Task1.V21.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] start = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };

            int res = ds.Calculate(start);
            int wait = 2 * 4 * 8 * 2 * 6 * 8 * 8 * 6 * 6;

            Assert.AreEqual(res, wait);
        }
    }
}
