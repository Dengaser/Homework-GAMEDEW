using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a=int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0) { Console.WriteLine($"{i} делится на 2"); }
                if (i % 3 == 0) { Console.WriteLine($"{i} делится на 3"); }
            }


        }
    }
}
