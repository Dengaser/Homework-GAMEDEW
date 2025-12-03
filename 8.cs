using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[] { 1, 2, 3, 4, 5 };
            if (m.Length >= 2)
            { 
                int ram = m[0];
                m[0] = m[m.Length-1];
                m[m.Length-1] = ram;
                var s = string.Join(" ", m);
                Console.WriteLine(s);
            
            
            }
            

            
        }
    }
}
