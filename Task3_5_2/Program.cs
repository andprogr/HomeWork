namespace Task3_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == 0)
            {
                Console.WriteLine("Да");//проверка на нуль
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
}
