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
            Console.Write("Количество строк в математической матрице: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Количество столбцов в математической матрице: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];
            int[,] matrix2 = new int[row, column];

            Console.WriteLine();

            Random random = new Random();

            for (int i = 0; i < row; i++) // Заполнение матрицы
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }

            for (int i = 0; i < row; i++) // Заполнение матрицы2
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = random.Next(10);
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

            for (int i = 0; i < row; i++) // Вывод умножений матриц
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j] * matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
