using System.ComponentModel.Design;

namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");// сравнение 4х чисел
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите с");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d");
            int d = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c) && (a > d))
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b > c) && (b > d))
            {
                Console.WriteLine(b);
            }
            else if ((c > a) && (c > b) && (c > d))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }
                        Console.ReadKey();
                    }
                }
            }
