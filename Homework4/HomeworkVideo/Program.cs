using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Сколько строк будет в матрице? ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Сколько столбцов будет в матрице? ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];

            int sum = 0;
            int i = 0;

            for (i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }

            for (i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    sum = sum + matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов: {sum}");
            Console.Write($"Нажмите любую клавишу для перехода ко второму заданию");
            Console.ReadKey();
            Console.Clear();

            //Пользователь вводит длину последовательности. 
            //Затем пользователь последовательно вводит целые числа(как положительные, так и отрицательные). Числа разделяются клавишей Enter.
            //Каждое введённое число помещается в соответствующий элемент массива.
            //После окончания ввода данных отдельный цикл проходит по последовательности и находит минимальное число.Для этого он сравнивает каждое число в итерации с предыдущим найденным минимальным числом.

            Console.Write("Сколько элементов будет в массиве? ");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[count];

            Console.WriteLine("Вводите элементы через Enter ");

            for (i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = array[0];

            for (i = 0; i < count; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($"Минимальное число в данной последовательности: {min}");
            Console.Write("Нажмите любую клавишу для перехода к третьему заданию");
            Console.ReadKey();
            Console.Clear();

            //Пользователь вводит максимальное целое число диапазона. 
            //На основе диапазона целых чисел(от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона.
            //Пользователю предлагается ввести загаданное программой случайное число.Пользователь вводит свои предположения в консоли приложения.
            //Если число меньше загаданного, программа сообщает об этом пользователю. 
            //Если больше, то тоже сообщает, что число больше загаданного.
            //Программа завершается, когда пользователь угадал число.
            //Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая, какое число было загадано.

            Console.Write("Введите максимальное число диапозона: ");
            int range = int.Parse(Console.ReadLine());


            int win = random.Next(range + 1);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine($"Загаданное число: {win}");
                    break;
                }

                int number = Convert.ToInt32(input);

                if (number > win)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else if (number < win)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}