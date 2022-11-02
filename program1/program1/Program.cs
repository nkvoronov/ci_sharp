using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Привет, " + name);
            // Ожидание реакции пользователя
            Console.WriteLine();
            Console.WriteLine("Нажмите <Enter> для выхода...");
            Console.Read();
        }
    }
}
