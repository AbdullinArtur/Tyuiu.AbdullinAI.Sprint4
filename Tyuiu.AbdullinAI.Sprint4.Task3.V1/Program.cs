using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint4.Task3.V1.Lib;

namespace Tyuiu.AbdullinAI.Sprint4.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Найдите сумму элементов  *");
            Console.WriteLine("* в последнем столбце массива.                                            *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtx = new int[5, 5] { { 3, 4, 3, 4, 1 }, { 8, 1, 6, 6, 9 }, { 9, 8, 5, 1, 3 }, { 1, 8, 7, 1, 2 }, { 9, 9, 7, 5, 6 } };

            Console.WriteLine("Масив: ");
            for (int i = 0; i < mtx.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < mtx.Length/ (mtx.GetUpperBound(0) + 1); j++)
                {
                    Console.Write($"{mtx[i,j]} \t");
                }
                Console.WriteLine();

            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtx);
            Console.WriteLine($"Сумма числе последнего столбца = {res}");

            Console.ReadKey();
        }
    }
}
