using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int row = 0;
            int column = 0;

            while (true)
            {
                Console.Write("Количество строк в математической матрице: ");

                string inputString = Console.ReadLine();
                bool result = int.TryParse(inputString, out row);

                if (result)
                {
                    if (row < 1)
                    {
                        Console.WriteLine("Количество строк не может быть меньше 1. Попробуйте еще раз ввести число");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неудалось конвертировать данное значение к типу int. Попробуйте еще раз ввести число");
                }
            }

            while (true)
            {
                Console.Write("Количество столбцов в математической матрице: ");

                string inputString = Console.ReadLine();
                bool result = int.TryParse(inputString, out column);

                if (result)
                {
                    if (column < 1)
                    {
                        Console.WriteLine("Количество столбцов не может быть меньше 1. Попробуйте еще раз ввести число");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неудалось конвертировать данное значение к типу int. Попробуйте еще раз ввести число");
                }
            }

            int[,] matrix = new int[row, column];
            int[,] matrix2 = new int[row, column];
            int[,] matrixResult = new int[row,column];

            Console.WriteLine();

            Random random = new Random();

            for (int i = 0; i < row; i++) // Заполнение матрицы
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(1, 6);
                }
            }

            for (int i = 0; i < row; i++) // Заполнение матрицы2
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = random.Next(1, 6);
                }
            }

            for (int i = 0; i < row; i++) // Вывод матрицы
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Write("Умножить матрицу на: ");
            int multiply = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++) // Вывод умноженой матрицы
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j] * multiply} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            for (int i = 0; i < row; i++) // Вывод матрицы
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сложить с");

            for (int i = 0; i < row; i++) // Вывод матрицы2
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Равно");

            for (int i = 0; i < row; i++) // Вывод сложений матриц
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j] + matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            if (row != column)
            {
                Console.WriteLine("Матрицы не возможно перемножить так, как они не согласованы");
            }
            else
            {
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                for (int i = 0; i < row; i++) // Вывод матрицы
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Умножить с");

                for (int i = 0; i < row; i++) // Вывод матрицы2
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"{matrix2[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Равно");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        for (int k = 0; k < row; k++)
                        {
                            matrixResult[i, j] += matrix[i, k] * matrix2[k, j];
                        }
                        Console.Write($"{matrixResult[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
