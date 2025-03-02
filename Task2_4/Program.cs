using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //4Х значное число, поменять местами 2и3 цифру

            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;

            Console.Write("{0}{1}{2}{3}", a, c, b, d);
            Console.ReadKey();
        }
    }
}
