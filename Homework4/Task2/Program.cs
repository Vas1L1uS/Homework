using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько будет строк в треугольнике Паскаля?");
            int n = int.Parse(Console.ReadLine());

            int [,] array = new int [n, n];

            array[0, 0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    array[i, j] = array[i - 1, j -1] + array[i - 1, j];
                }
            }

            for(int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (array[i, j] != 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}