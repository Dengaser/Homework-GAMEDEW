using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи какого размера хочешь масив");
            int r = int.Parse(Console.ReadLine());
            int[] m = new int[r];
            Console.WriteLine($"Введи {r} чисел по очереди");
            for (int i = 0; i < r; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            
            
            int count= 1;
            for (int i = 0;i < r-1; i++)
            {
                while (m[i] == m[i+1])
                {
                    m[i] = 0;
                }
                if (m[i] != 0)
                {
                    count++;
                    
                }
            }
            int c2 = 0;
            int[]m3= new int[count];
            for (int i = 0; i < r; i++)
            {
                
                if (m[i] != 0)
                {
                    m3[c2] = m[i];
                    ++c2;
                }
                
            }
            
            var z = string.Join(",", m3);
            Console.WriteLine($"Почищенная строка:{z}");
            
        }
    }
}
