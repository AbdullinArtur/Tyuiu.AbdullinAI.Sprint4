using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbdullinAI.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // количество строк
            int columns = array.Length / rows; // количество столбцов

            int res = 0;
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 4)
                    {
                        res += array[i, j];  
                    }
                }
            }
            return res;



        }
    }
}
