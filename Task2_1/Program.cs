using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int t = a;
            int s = b;
            a = c;
            b = t;
            c = s;
            Console.WriteLine("a ={0}, b={1}, c ={2}", a, b, c);
            Console.Write("нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
