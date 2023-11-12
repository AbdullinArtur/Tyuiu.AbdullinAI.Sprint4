using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbdullinAI.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length > 8);
            return res.Length;
        }
    }
}
