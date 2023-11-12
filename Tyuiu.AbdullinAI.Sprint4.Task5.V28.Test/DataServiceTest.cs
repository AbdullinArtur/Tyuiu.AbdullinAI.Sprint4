using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.AbdullinAI.Sprint4.Task5.V28.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[2, 2] { { -6, 3 }, { 3, -4 } };

            int[,] wait = new int[2,2] { { 0, 3 }, { 3, 0 } };
            int[,] res = ds.Calculate(mtrx);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
