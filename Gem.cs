using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Gem:Item,ISellable
    {
        public int Price { get; set; } = 100;        
        public Gem()
        {
            Name = "Гем";
            Description = $"Выгодно продать за {Price} монет";
        }
        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
