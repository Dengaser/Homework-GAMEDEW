using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите возраст вашего ребёнка");
            a= int.Parse(Console.ReadLine());
            if (a < 12)
            {
                Console.WriteLine("Ребёнок");
            }
            if (a < 17)
            {
                if (a > 11) { Console.WriteLine("Подросток"); }
            }
            if (a >= 18)
            { Console.WriteLine("Взрослый"); }
            
        }
    }
}
