namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//расположение домов на участке.Упрощенно. Не понятно как учесть расположение домов без наложения площадей.
            int b = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            if (a * b > (p * q) + (r * s))
            {
                Console.WriteLine("На участке {0} на {1} уместятся 2 дома", a, b);
            }
            else
            {
                Console.WriteLine("Дома не уместятся");
            }

            Console.ReadKey();
        }

    }
}


