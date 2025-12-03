using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 3, 7, 4, 5, 2};
            string a = "";
            var str = string.Join(" ", ages);
            Console.WriteLine(str);
        }
    }
}
