namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");// сравнение 3х чисел
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите с");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
