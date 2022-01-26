using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Халдон. Условие: Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

namespace Distance
{
    class Program
    {
        //Метод для расчета
        static double DistanceAB(int x1, int x2, int y1, int y2)
        {


            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }
        static void Main(string[] args)
        {
            Console.Title = "Distance A to B";

            int aX = 100;
            int aY =150;
            int bX =300;
            int bY =350;

            //расчет и сохранение результата
            double result = DistanceAB(aX, bX, aY, bY);

            //проверка
            double resultCheck = DistanceAB(100, 300, 150, 350);
            
            //Вывод основного и проверочного результата с двойной точностью
            Console.WriteLine($"Distance between A and B is {result:F}"); //по умолчанию выведет два знака после запятой
            Console.WriteLine($"Distance between A and B is {resultCheck:F2}");//простро проверяю, что с уточненнием работает также

            Console.ReadLine();
        }
    }
}
