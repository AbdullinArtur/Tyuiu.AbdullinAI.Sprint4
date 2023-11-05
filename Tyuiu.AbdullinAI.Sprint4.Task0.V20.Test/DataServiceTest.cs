using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint4.Task0.V20.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] nums = new int[10] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int res = ds.GetMultEvenArrEl(nums);
            int wait = 4 * 8 * 6 * 8 * 2 * 4 * 2;
            Assert.AreEqual(res, wait);

            
          
        }
    }
}
