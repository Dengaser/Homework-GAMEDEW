using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine("Напишие по очереди два числа");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Сложение {a + b} Вычитание {a - b} Произведение {a*b}");
            if (b!=0)
            {
                Console.WriteLine($"Частное {a/b}");
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя :(");
            }
            
        }
    }
}
