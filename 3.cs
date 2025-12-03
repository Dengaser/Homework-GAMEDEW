using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            
            Console.WriteLine("Введите число");
            string newString = Console.ReadLine();
            if (int.TryParse(newString, out int Number))
            {
                Console.WriteLine(Number * Number); }
            else { Console.WriteLine("Ошибка!"); 

            }
        }
    }
}
