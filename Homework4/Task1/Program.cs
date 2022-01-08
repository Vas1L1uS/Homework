using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            int[] arrayIncome = new int[12];
            int[] arrayCosts = new int[12];
            int[] arrayProfit = new int[12];

            int[] worstMonths = new int[12];

            int numberOfMounths = 0;

            Random random = new Random();

            for (int i = 0; i < arrayIncome.Length; i++)
            {
                arrayIncome[i] = random.Next(0, 100) * 100;
            }

            for (int i = 0; i < arrayIncome.Length; i++)
            {
                arrayCosts[i] = random.Next(0, 100) * 100;
            }

            //Console.WriteLine("Вводите доходы через Enter");

            //for (int i = 0; i < arrayIncome.Length; i++)
            //{
            //    arrayIncome[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine();                            Для ручного ввода

            //Console.WriteLine("Вводите расходы через Enter");

            //for (int i = 0; i < arrayIncome.Length; i++)
            //{
            //    arrayCosts[i] = int.Parse(Console.ReadLine());
            //}

            Console.WriteLine("Доход, тыс. руб.    Расход, тыс. руб.    Прибыль, тыс. руб.");

            for (int i = 0; i < arrayIncome.Length; i++)
            {
                arrayProfit[i] = arrayIncome[i] - arrayCosts[i];
                if (arrayIncome[i] - arrayCosts[i] > 0) numberOfMounths++;

                Console.WriteLine($"{arrayIncome[i],17}{arrayCosts[i],17}{arrayProfit[i],17}");
            }

            int min = 1000000000;

            int limit = 3;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (arrayProfit[j] < min)
                    {
                        min = arrayProfit[j];
                    }
                }
                for (int l = 0; l < 12; l++)
                {
                    if (arrayProfit[l] == min)
                    {
                        arrayProfit[l] = 1000000000;// Минимальному знанчению задается 1млрд от повторного считывания
                        if (limit > 0)
                        {
                            for (int k = 0; k < 12; k++)
                            {
                                if(worstMonths[k] == 0)
                                {
                                    worstMonths[k] = l + 1;
                                    break;
                                }
                            }                        
                        }
                        
                    }
                }
                limit--;
                min = 1000000000;
            }

            Console.Write("Худшая прибыль в месяцах ");

            for (int i = 0; i < 12; i++)
            {
                if (worstMonths[i] > 0)
                {
                    Console.Write($"{worstMonths[i]} ");
                }
            }

            Console.WriteLine($"Месяцев с положительной прибылью: {numberOfMounths}");

            Console.ReadKey();
        }
    }
}
