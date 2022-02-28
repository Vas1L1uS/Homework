using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static int RowInput()
        {
            int row = 0;

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
            return row;
        }

        static int ColumnInput()
        {
            int column = 0;

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

            return column;
        }

        static int[,] CreatMatrix(int row, int column)
        {
            Random random = new Random();
            int[,] matrix = new int[row, column];

            for (int i = 0; i < row; i++) // Заполнение матрицы
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(1, 6);
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
            Console.WriteLine();

            return matrix;
        }

        static void MatrixMultiply(int row, int column) // Умножение матрицы на число
        {
            int[,] matrix = CreatMatrix(row, column);

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
        }

        static void MatrixAdd(int row, int column) // Сложение двух матриц
        {
            int[,] matrix = CreatMatrix(row, column);
            int[,] matrix2 = CreatMatrix(row, column);

            for (int i = 0; i < row; i++) // Вывод сложения
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j] + matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MatrixMultiply(RowInput(), ColumnInput());
            Console.WriteLine();
            MatrixAdd(RowInput(), ColumnInput());
        }
    }
}
