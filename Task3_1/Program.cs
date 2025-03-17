namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");// сравнение 2ч чисел
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            if (a<b)
            {
                Console.WriteLine("a<b");
            }
                if (a == b)
                    Console.WriteLine("a=b");
                Console.ReadKey();
            }
        }
    }
