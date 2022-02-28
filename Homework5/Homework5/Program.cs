using System;

namespace Homework5
{
    internal class Program
    {
        public static string[] DivisionIntoWords(string str)
        {
            string[] wordsArray = str.Split(' ');

            return wordsArray;
        }

        static void ConsoleWrite(string[] wordsArray)
        {
            for (int i = 0; i < wordsArray.Length; i++)
            {
                Console.WriteLine(wordsArray[i]);
            }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            DivisionIntoWords(str);
            string[] wordsArray = DivisionIntoWords(str);
            ConsoleWrite(wordsArray);
        }
    }
}