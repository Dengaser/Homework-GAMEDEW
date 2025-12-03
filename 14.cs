using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]m1 = new int[5] {1,2565,3,4546,5};
            int[] m2 = new int[5];
            for (int i = 0; i < m1.Length; i++)
            {
                m2[i] = m1[m1.Length-1-i];
            }
            var z = string.Join (",", m2);
            Console.WriteLine(z);
        }
    }
}
