using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2_
{
    internal class Program
    {
        static string[] ReverseWords(string str) // Перестановка слов
        {
            string[] wordsArray = str.Split(' ');

            int a = 1;
            string temporary;
            for (int i = 0; i < wordsArray.Length / 2; i++)
            {
                temporary = wordsArray[i];
                wordsArray[i] = wordsArray[wordsArray.Length - a];
                wordsArray[wordsArray.Length - a] = temporary;
                a++;
            }
                return wordsArray;
        }

        static void ConsoleWrite(string[] wordsArray) // вывод на экран
        {
            for (int i = 0; i < wordsArray.Length; i++)
            {
                Console.WriteLine(wordsArray[i]);
            }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            ConsoleWrite(ReverseWords(str));
        }
    }
}
