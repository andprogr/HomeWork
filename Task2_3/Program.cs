using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double d = 2.54;
            Console.WriteLine("Введите длину в дюймах");
            int l = Convert.ToInt32(Console.ReadLine());
            int m = (int)(l * d / 100);
            int sm = (int)(l * d);
            double mm = l * d * 100;
            Console.WriteLine("m={0},sm={1}, mm={2}", m, sm, mm);
            Console.ReadKey();
        }
    }
}
