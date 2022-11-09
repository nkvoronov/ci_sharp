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
            string fname, tname;
            Console.Write("Введите Имя : ");
            fname= Console.ReadLine();
            Console.Write("Введите Фамилию : ");
            tname = Console.ReadLine();
            string txt = "Ваше Имя и Фамилия : " + fname + " " + tname;
            Console.WriteLine(txt);
            Console.ReadLine();
        }
    }
}
