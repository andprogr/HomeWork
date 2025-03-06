namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");// медиана 3х чисел
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите с");
            int c = Convert.ToInt32(Console.ReadLine());
            if (( b <a&&a<c)||(b>a&&a>c))
            {
                Console.WriteLine(a);
            }
            else if ((a < b && b < c) || (a > b && b > c))
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
