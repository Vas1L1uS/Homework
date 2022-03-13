using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Program
    {
        static void readFile(string fileName)
        {
            string str = File.ReadAllText(fileName);
            string[] text = str.Split('#');
            foreach (string data in text)
            {
                Console.Write($"{data} ");
            }
        }

        static void writeFile(string fileName)
        {
            string text = "\n";
            string[] dataArray = new string[7];

            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = Console.ReadLine();
                if (i == dataArray.Length - 1)
                {
                    text += $"{dataArray[i]}";
                }
                else text += $"{dataArray[i]}#";
            }
            File.AppendAllText(fileName, text);
        }

        static void Main(string[] args)
        {
            string fileName = @"C:\AProgram\azaza.txt";
            Console.Write($"Введите 1 чтобы вывести данные  2 внести новые: ");
            string a = Console.ReadLine();
            if (a == "2")
            {
                Console.WriteLine("Данные заполняются в таком порядке: ID, Дата добавления, ФИО, Возраст, Рост, Дата рождения, Место рождения");
            }

            if (a == "1") readFile(fileName);
            else writeFile(fileName);

            Console.ReadLine();
        }
    }
}
