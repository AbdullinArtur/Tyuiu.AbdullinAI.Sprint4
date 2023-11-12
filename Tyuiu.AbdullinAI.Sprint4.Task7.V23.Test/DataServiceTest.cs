using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.AbdullinAI.Sprint4.Task7.V23.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validcalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;

            string str = "678135972584";
            int[,] mtrx = new int[n, m];

            int res = ds.Calculate(n, m, str);

            int wait = 5;

            Assert.AreEqual(res, wait);
        }
    }
}
