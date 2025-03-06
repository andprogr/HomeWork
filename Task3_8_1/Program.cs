namespace Task3_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= -10 && a <= 10)
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
