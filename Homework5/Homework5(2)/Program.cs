using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2_
{
    internal class Program
    {

        public static string[] DivisionIntoWords(string str) // Разделение предложения на слова
        {
            string[] wordsArray = str.Split(' ');

            return wordsArray;
        }

        static string[] ReverseWords(string str) // Перестановка слов
        {
            string[] wordsArray = DivisionIntoWords(str);

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
            ConsoleWrite(ReverseWords(Console.ReadLine()));
        }
    }
}
