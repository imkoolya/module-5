using System;
using System.Xml.Linq;

namespace module5 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            User.Dishes = new string[5];

            Console.WriteLine("Введите имя пользователя");
            User.Name = Console.ReadLine();

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine($"Введите любимое блюдо номер {i+1}");
                User.Dishes[i] = Console.ReadLine();
            }

        }
    }
}