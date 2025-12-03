using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class HealthPotion : Item , IUsable, IStackable
    {
        private int _count = 1;
        public int HealAmount { get; set; } = 30;
        public int Count { get { return _count; } }

        public HealthPotion()
        {
            Name = "Зелье здоровья";
            Description = "Восстанавливает "+HealAmount+" здоровья";
        }
        public void Use(Character user)
        {
            user.AddHealth(HealAmount);
            RemoveOne();
        }
        public void AddOne()
        {
            _count++;
        }
        public void RemoveOne()
        {
            _count = Math.Max(0, _count - 1);
        }



    }
}
