using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Введите пароль");
            a= Console.ReadLine();
            if (a == "4negra")
            {
                Console.WriteLine("Хорош!!!");
            }
            else
            {while (Console.ReadLine() != "4negra") { Console.WriteLine("Переделывай"); }

                Console.WriteLine("Урааа");

            }
        }
    }
}
