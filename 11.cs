using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]m=new int[5] {1,2,3,4,5};
            Console.WriteLine("index=?");
            int index= int.Parse(Console.ReadLine());
            while ( index+1 < m.Length)
            {
                
                m[index] = m[index + 1]; 
                index++;
            }
            m[4] = 0;
            var z = string.Join(",", m);
            Console.WriteLine(z);
        }
    }
}
