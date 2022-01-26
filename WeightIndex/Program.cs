using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Халдон. Условие: Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
// где m — масса тела в килограммах, h — рост в метрах.

namespace WeightIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Weight Index";
            //просим вести вес с запятой перед десятичной частью
            Console.WriteLine("Enter your weight in kilograms, use "," before fraction :");
            double weight = double.Parse(Console.ReadLine());
            // просим ввести рост с запятой перед десятичной частью
            Console.WriteLine("Enter your height in meters, use ", " before fraction :");
            double height = double.Parse(Console.ReadLine());

            //основной расчет
            double weightIndex = weight / Math.Pow(height, 2);

            //проверочный расчет
            double indexControl = weight / (height * height);

            //вывод основного результата и проверки
            Console.WriteLine("Your weight index is {0}", weightIndex);
            Console.WriteLine("Your weight index is " + indexControl);
           
            Console.ReadLine();
        }
    }
}
