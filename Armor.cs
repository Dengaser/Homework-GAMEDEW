using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Armor:Item,IEquipable
    {
        public Armor()
        {
            Name = "Броня";
            Description = "Не защищает, но греет душу";
        }
        public void Equip(Character user)
        {
            user.EquipArmor(this);
        }
    }
}
