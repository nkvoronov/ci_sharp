using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_w1c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Введите Имя : ");
            name= Console.ReadLine();
            Console.Write("Введите Возраст : ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ваше Имя и Возраст : {0} {1}", name, age);
            Console.ReadLine();
        }
    }
}
