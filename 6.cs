using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] masivik = new int[4] { 4, 5, 9, 2 };
            for (int i = 0; i < masivik.Length; i++)
            {
                
                if ((masivik[i] % 2) == 0) { count++; }
                
            }
            Console.WriteLine(count);
        }
    }
}
