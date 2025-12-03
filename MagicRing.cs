using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class MagicRing:Item,IEquipable,ISellable
    {
        public int Price { get; set; } = 70;
        public MagicRing()
        {
            Name = "Магическое кольцо";
            Description = "Сохраняет рассудок";
        }
        public void Equip(Character user)
        {
            user.EquipMagicRing(this);
        }
        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
