using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite chislo");
            double i=double.Parse(Console.ReadLine());
            Console.WriteLine($"{(int)i} уменьшилась на {i-(int)i}");
        }
    }
}
