using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[10] ;
            int count = 5;
            while (count <= m.Length)
            {
                for (int i = 0; i < count; i++) 
                {
                    m[i] = (i+1)*10 ;
                }
                Console.WriteLine("Исходный массив:");
                var z = string.Join(" ", m);
                Console.WriteLine(z);
                for (int i = 4; i < m.Length; ++i)
                {
                    m[i] = (i + 1) * 10;
                    count++;
                }
                var zz = string.Join(" ", m);
                Console.WriteLine(zz);


            }
            
            
                int NewL = m.Length * 2;
                int[] NewM = new int[NewL];
                m.CopyTo(NewM, 0);
                var w = string.Join(" ", NewM);
                Console.WriteLine(w);
            
            //Console.WriteLine(count);
            //Console.WriteLine(m.Length);





        }
    }
}
