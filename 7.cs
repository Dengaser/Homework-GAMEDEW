using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] m =  { 5, 9, 4, 5, 7 };
            int a = 0;
            for (int i = -1; i < m.Length-1; i++)
            {
                a = a + m[i+1];
            }
            Console.WriteLine($"Сумма равна {a}, а среднее арифметическое {a/m.Length}");
        }
    }
}
