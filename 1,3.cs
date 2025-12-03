using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = int.Parse(Console.ReadLine());
            if ((a % 2) == 0) { Console.WriteLine("Это чётное число!"); }
            else
            {
                Console.WriteLine("Это не чётное число!"); 
            }
        }
    }
}
