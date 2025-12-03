using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace DZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Mage Iam=new Mage("Danilchik",10,10);
            Goblin BALBES = new Goblin("Балбес",10,10);
            BatleC.Batle(BALBES, Iam);
            
        }

    }
}
