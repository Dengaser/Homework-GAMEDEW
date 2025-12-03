using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = int.Parse(Console.ReadLine());
            if (a % 3 == 0) { Console.WriteLine("Число делится на 3"); }
            else { Console.WriteLine("Число не делится на 3"); }
            if (a % 5 == 0) { Console.WriteLine("Число делится на 5"); }
            else { Console.WriteLine("Число не делится на 5"); }
        }
    }
}
