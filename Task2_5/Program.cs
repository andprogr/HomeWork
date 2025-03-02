using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы");//округление в большую сторону
            double l = Convert.ToDouble(Console.ReadLine());
           
           l = Math.Ceiling(l);
            Console.WriteLine("Округленная длина" + l);
            Console.ReadKey();

        }
    }
}
