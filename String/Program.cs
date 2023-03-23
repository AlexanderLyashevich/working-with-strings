using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string job;

            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой у вас знак зодиака? ");
            zodiacSign = Console.ReadLine();
            Console.Write("На какой работе вы работаете? ");
            job = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, ваш знак зодиака - {zodiacSign}, ваше место работы - {job}");
        }
    }
}
