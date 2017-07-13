using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //определим переменные х,у-координаты точки.
            //переменные имеют тип float.
            double x, y,r;
            //определим строковые переменные сообщений.
             string inside = "точка внутри контура";
             string outside = "точка вне контура";
            //вносим координаты точки.
            Console.WriteLine("Введите абциссу точки");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            y = Convert.ToDouble(Console.ReadLine());
            r = (Math.Pow(x, 2) + Math.Pow(y, 2));
           
            if (x > 0)
            {
                if (r >= 0.5 && r <= 1) Console.WriteLine("inside");
                else Console.WriteLine("outside");
            }
            if (x <= 0)
            {
                if (r > 1) Console.WriteLine("outside");
                else Console.WriteLine("inside");
            }
            Console.ReadKey();
        }
    }
}
