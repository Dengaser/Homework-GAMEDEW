using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Weapon: Item, IEquipable
    {
        public Weapon()
        {
            Name = "Экскалибур";
            Description = "Ваншотит врагов";
        }
        public void Equip(Character user)
        {
            user.EquipWeapon(this);
        }
    }
}
