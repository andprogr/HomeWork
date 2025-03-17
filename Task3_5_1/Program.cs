using System.ComponentModel.Design;

namespace Task3_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Да");//проверка четности
            }
            else
            {
                Console.WriteLine("Нет");
            }
                Console.ReadKey();
        }

}
}
