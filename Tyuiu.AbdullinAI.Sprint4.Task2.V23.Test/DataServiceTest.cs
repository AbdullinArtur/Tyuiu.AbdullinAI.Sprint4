using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint4.Task2.V23.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] start = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int res = ds.Calculate(start);
            int wait = 2 * 4 * 6 * 8 * 10 * 12 * 14;

            Assert.AreEqual(wait, res);

        }
    }
}
