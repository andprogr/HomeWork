namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());//окончание во фразе Сколько домов
            int n = (g % 10);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Построили {0} дом", g);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Построили {0} дома", g);
                        break;
                case 5:
                case 6:
                case 7:
                case 0:
                        Console.WriteLine("Построили {0} домов", g);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                    }
                    Console.ReadKey();
            }
        }
    }