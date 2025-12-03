using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b =0;
            Console.WriteLine("Введите число");
            a = int.Parse(Console.ReadLine());
            for (int i = a; i>0; i--)
            {
                b= b + i;
             
            }
            Console.WriteLine(b);

        }
    }
}
