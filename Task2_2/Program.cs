using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите гр"); //градусы в радианы
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мин");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сек");
            int s = Convert.ToInt32(Console.ReadLine());


            double r = (Math.PI * (d+((double)m)/60+ ((double)s)/3600))/180;
            Console.WriteLine("Значение в рад" + r);
            Console.Write("нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
