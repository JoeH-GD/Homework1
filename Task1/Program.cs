﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Анкета";
            Console.WriteLine("Введите ваше имя!");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию!");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Какой у вас рост?");
            string height = Console.ReadLine();
            Console.WriteLine("Какой у вас вес?");
            string weight = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ваши данные: " + name + " " + surname + ", " + age + ", " + height + ", " + weight);
            Console.WriteLine("{0} {1}, {2}, {3}, {4}", name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname}, {age}, {height}, {weight}");
            Console.ReadLine();
        }
    }
}
