using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целочисленное число:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }

            Console.WriteLine("Нажмите любую клавишу для перехода на второе задание");
            Console.ReadKey();
            Console.Clear();


            //Второе задание

            string value;
            int sum = 0;

            Console.Write("Введите количество карт: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номинал карты:");

            for (int z = 0; z < number; z++)
            {
                value = Console.ReadLine();

                switch (value)
                {
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    case "J":
                        sum += 2;
                        break;
                    case "Q":
                        sum += 3;
                        break;
                    case "K":
                        sum += 4;
                        break;
                    case "T":
                        sum += 11;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Введите номинал следующей карты:");
            }

            Console.WriteLine($"Сумма карт = {sum}");

            Console.WriteLine("Нажмите любую клавишу для перехода на третье задание");
            Console.ReadKey();
            Console.Clear();



            // Третье задание

            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());

            int i = 2;

            while (number % i != 0)
            {
                i++;

                if (i == number)
                {
                    Console.WriteLine("Простое"); break;
                }
            }

            if (number != i)
            {
                Console.WriteLine("Число непростое ");
            }
        }
    }
}
