using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProgram
{
    class Program
    {
        //Метод, похожий на описанный в примере
        static void PrintData(string data, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(data);
        }

        //Метод, который запрашивает только сообщение в качестве аргумента
        static void PrintDataCenter(string data)
        {
            int X = (Console.WindowWidth / 2) - (data.Length / 2);
            int Y = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(data);
        }

        static void Main(string[] args)
        {
            Console.Title = "Print";
            string myData = "Joe Haldon, St. Petersburg";

            Console.WriteLine(myData);

            #region ManualCenter

            //Рассчет координат начала строки
            int lineX = (Console.WindowWidth / 2) - (myData.Length /2);
            int lineY = (Console.WindowHeight / 2) -1;

            //установка позиции курсора
            Console.SetCursorPosition(lineX, lineY);

            //печать строки
            Console.WriteLine(myData);
            Console.ReadLine();
            #endregion ManualCenter

            #region Method1
            Console.Clear();
            PrintData(myData,lineX,lineY);
            Console.ReadLine();
            #endregion Method1

            #region Method2
            Console.Clear();
            PrintDataCenter(myData);
            Console.ReadLine();
            #endregion Method2
        }
    }
}
