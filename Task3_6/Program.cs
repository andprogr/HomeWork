namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 && a < 100)
            {
                Console.WriteLine("Да");//проверка на 2х значное число
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
}
