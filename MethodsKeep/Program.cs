using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Халдон. Сделать класс с методами, которые могут пригодиться в учебе
namespace MethodsKeep
{
    class MethodKeep
    {
        //Печатает строчку по заданным координатам
        static void PrintLinesCustom(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        //Находит скалярное произведение векторов в трехмерном пространстве
        static int ScalarVector3D(int aX, int aY, int aZ, int bX, int bY, int bZ)
        {
            int scalar = (aX * bX) + (aY * bY) + (aZ * bZ);
            return scalar;

        }

        //Ну а вдруг надо поменять размер массива...
        static int[] ChangeArrayLength(int[] n, int newLength)
        {
          int length = 0;
          length = n.Length;
          Array.Resize(ref n, newLength);
         length = n.Length;
        return n;
        }

        //Метод для перевода чисел в массив
        static int[] intToArray(string num)
        {
         //измеряем длину строки, она будет длиной массива 
         int[] arrayNumber = new int [num.Length];

         for (int i =0; i<num.Length; i++)
        {

        //Я видел решения лучше, но они сложнее для понимания, сделал сам через перменную-костыль
        //В нее записывается поочередно кайдый символ в строке
            char x = num[i];
        // символ конвертируется в число и записывается в соответствующую ячейку массива
             arrayNumber[i] = (Convert.ToInt32(x) - 48);
         }

         return arrayNumber;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
