using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("index=?");
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < m.Length; i++)
            {
                if (i == index)
                {
                    m[i] = m.Last();
                    m[m.Length-1] = 0;
                    //Console.WriteLine(m[i]);
                }
            }
            var z= string.Join(",", m);
            Console.WriteLine(z);
        }
    }
}
