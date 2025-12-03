using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class OldBoot: Item, IDiscardable
    {
        public OldBoot()
        {
            Name = "Старые ботинки";
            Description = "Они давно не выполняют своих функций";
        }
        public void Discard()
        {
            Console.WriteLine("Ботинок выкинут в мусорку");
        }
    }
}
