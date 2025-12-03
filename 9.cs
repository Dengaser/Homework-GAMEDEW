using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] m = new int[] { 46,565,115,25};
            int mMax = m[0];
            int mMin = m[0];
            int MaxIndeks = 0;
            int MinIndeks = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (mMin > m[i]) { MinIndeks = i; mMin = m[i]; }
                if (mMax < m[i]) { MaxIndeks = i; mMax = m[i]; }
            }
            Console.WriteLine($"Минимальный элемент масива {m[MinIndeks]}");
            Console.WriteLine($"Максимальный элемент масива { m[MaxIndeks]}");
        }
    }
}
