using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Scroll:Item,IUsable,ISellable
    {
        public int Price { get; set; } = 50;
        public Scroll()
        {
            Name = "Свиток";
            Description = "Содержит отборные анегдоты";
        }
        public void Use(Character user)
        {
            Console.WriteLine("Ты использовал свиток");
        }
        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
