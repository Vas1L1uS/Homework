using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первое задание

            string fullName = "Ivanov Ivan Ivanovich";
            string email = "Ivanov@mail.com";
            int age = 25;
            double mathScores = 87.2;
            double programmingScores = 95.8;
            double physicsScores = 74.4;

            Console.WriteLine($"ФИО {fullName}\nВозраст {age} \nПочта {email} \n" +
                $"Баллы по математике {mathScores}\nБаллы по программированию {programmingScores}\nБаллы по физике {physicsScores}");

            Console.WriteLine("Нажмите на любую клавишу для перехода на второе задание");
            Console.ReadKey();

            // Второе задание

            double totalScores, averageScore;

            totalScores = mathScores + programmingScores + physicsScores;

            averageScore = totalScores / 3;

            Console.WriteLine($"Общий балл {totalScores} \nСредний балл {averageScore} ");
            Console.ReadKey();
        }
    }
}
