using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1_5
{
    internal class InputConsoleDemo
    {
        static void Main(string[] args)
        {
            // Текстовая переменная:
            string name;
            // Заголовок консольного окна:
            Console.Title = "Давайте познакомимся...";
            // Сообщение в консоле:
            Console.Write("Как вас зовут? ");
            // Считывание текста:
            name=Console.ReadLine();
            // Еще одна текстовая переменная:
            string txt = "Очень приятно, "+name+"!";
            // Заголовок консольного окна:
            Console.Title = "Знакомство состоялось";
            // Сообщение в консоле:
            Console.WriteLine(txt);
            Console.ReadLine();
        }
    }
}
