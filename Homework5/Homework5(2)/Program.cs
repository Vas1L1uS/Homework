using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2_
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

        static string[] ReverseWords(string[] wordsArray)
        {
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
            ConsoleWrite(ReverseWords(DivisionIntoWords(str)));
        }
    }
}
