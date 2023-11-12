using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint4.Task4.V9.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int wait = 42;

            int[,] mtx = new int[5, 5] { { 3, 7, 3, 1, 5 }, { 6, 3, 2, 1, 2 }, { 1, 3, 2, 8, 1 }, { 5, 8, 1, 5, 1 }, { 3, 3, 4, 4, 6 } };
            int res = ds.Calculate(mtx);

            Assert.AreEqual(wait, res);

        }
    }
}
