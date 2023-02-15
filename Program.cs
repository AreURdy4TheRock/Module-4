using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) [] User = new (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) [3];
            for (int k = 0; k < 3;k++) 
            {
                Console.WriteLine("Введите имя");
                User[k].Name = Console.ReadLine();
                Console.WriteLine("Введите Фамилию");
                User[k].LastName = Console.ReadLine();
                Console.WriteLine("Введите Логин");
                User[k].Login = Console.ReadLine();
                User[k].LoginLength = User[k].Login.Length;
                Console.WriteLine("Есть ли у Вас животное? Да/Нет");
                if (Console.ReadLine() == "Да")
                {
                    User[k].HasPet = true;
                }
                else User[k].HasPet = false;
                Console.WriteLine("Введите Ваш возраст");
                User[k].Age = double.Parse(Console.ReadLine());
                User[k].favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User[k].favcolors.Length; i++)
                {
                    User[k].favcolors[i] = Console.ReadLine();

                }
            }
            Console.ReadKey();
        }
    }
}