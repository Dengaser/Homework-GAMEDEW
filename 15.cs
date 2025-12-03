using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m1 = new int[5] { 1, 2, 3, 2, 1 };
            int[] m2 = new int[5];
            for (int i = 0; i < m1.Length; i++)
            {
                m2[i] = m1[m1.Length-1-i];

            }
            var z = string.Join(",", m2);
            Console.WriteLine(z);
            var zz = string.Join(",", m1);
            Console.WriteLine(zz);
            int count = 0;
            for (int i = 0;i < m2.Length;i++)
            {
                if (m2[i] == m1[i])
                {
                    count++;
                }
            }
            if (count == 5)
            { Console.WriteLine("Это масив палиндром"); }
            else { Console.WriteLine("Это не палиндром"); }
        }
    }
}
