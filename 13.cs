using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[10] { 1, 2, 2, 2, 4, 8, 4, 54, 2, 4 };
            var zz= string.Join(",", m);
            Console.WriteLine($"Вот масивчик:{zz}");
            Console.WriteLine("Напиши что хочешь удалить");
            int ind=int.Parse(Console.ReadLine());
            for (int i=0; i<m.Length; i++)
            {
                if (m[i] == ind)
                {
                    m[i] = 0;
                }
            }
            var z = string.Join(",", m);
            Console.WriteLine(z);
        }
    }
}
