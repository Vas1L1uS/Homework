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
            Console.WriteLine("Сколько будет строк в треугольнике Паскаля? (Не больше 27)");

            int n = 0;

            while (true)
            {
                n = int.Parse(Console.ReadLine());

                if (n < 28)
                {
                    break;
                }
                Console.WriteLine("Вы ввели число превышающее максимально значение. Попробуйте еще раз");
            }

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
                if (n < 18)
                {
                    for (int j = 1; j < (n - i); j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 1; j < n; j++)
                    {
                        if (array[i, j] != 0)
                        {
                            Console.Write($"{array[i, j],4}");
                        }
                    }
                }
                else if (n < 24)
                {
                    for (int j = 1; j < (n - i); j++)
                    {
                        Console.Write("   ");
                    }
                    for (int j = 1; j < n; j++)
                    {
                        if (array[i, j] != 0)
                        {
                            Console.Write($"{array[i, j],6}");
                        }
                    }
                }
                else if (n > 23)
                {
                    for (int j = 1; j < (n - i); j++)
                    {
                        Console.Write("    ");
                    }
                    for (int j = 1; j < n; j++)
                    {
                        if (array[i, j] != 0)
                        {
                            Console.Write($"{array[i, j],8}");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}