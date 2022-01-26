using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Халдон. Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

namespace ExchangeValues
{
    class Program
    {
        //метод меняет переменные значениями без использования третьей переменной, а уже потом заносит их в массив
        //да, их можно было вообще просто поменять местами в массиве, но тогда это почти тоже самое что третья переменная
        //а еще можно было вообще не делать метод, но мне захотелось поэксперементировать
        static int[] ExchangeNoVar(int i, int k)
        {
            i = i + k;
            k = i - k;
            i = i - k;
            int[] result = new int[2]{ i,k};
            return result;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value: ");
            int value1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"First value is {value1} and the second value is {value2}");
            int changeBuffer = value1;
            value1 = value2;
            value2 = changeBuffer;
            Console.WriteLine($"First value is {value1} and the second value is {value2}");
            Console.ReadLine();

            Console.Clear();
            //выводим значения до обмена
            Console.WriteLine($"NOW! First value is {value1} and the second value is {value2}");
            int[] varChange = ExchangeNoVar(value1,value2);

            //достаем значения из массива и записываем в переменные
            value1 = varChange[0];
            value2 = varChange[1];

            //выводим значения после обмена
            Console.WriteLine($"THEN! First value is {value1} and the second value is {value2}");
            Console.ReadLine();
        }
    }
}
