using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введи чмисло");
            string s = Console.ReadLine();
            a=int .Parse(s);
            a = a + 100;
            Console.WriteLine(a);

        }
    }
}
