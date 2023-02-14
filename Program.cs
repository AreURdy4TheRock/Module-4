using System.Diagnostics;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш люимый цвет красный");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш люимый цвет зелёный");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш люимый цвет голубой");
            }

            Console.ReadKey();
        }
    }
}