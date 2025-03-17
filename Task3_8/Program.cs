namespace Task3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a > -1.0/0 && a <= -10)||(a>=10&&a<1.0/0))
            {
                Console.WriteLine("Да");//проверка на диапазон
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
}
