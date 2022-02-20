using System;

namespace Homework5
{
    internal class Program
    {
        public static string[] DivisionIntoWords(string str)
        {
            int startWord = 0;
            int endWord = 0;
            string word = "";
            int amountWords = 1;
            int a = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    amountWords++;
                }
            }

            string[] wordsArray = new string[amountWords];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    endWord = i;

                    for (int j = startWord; j < endWord; j++)
                    {
                        word += str[j];
                    }

                    startWord = i + 1;
                    wordsArray[a] = word;
                    a++;
                    word = "";
                }

                else if (i == str.Length - 1)
                {
                    for (int j = startWord; j < str.Length; j++)
                    {
                        word += str[j];
                    }

                    wordsArray[a] = word;
                }
            }

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