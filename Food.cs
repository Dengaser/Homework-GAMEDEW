using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Food: Item,IUsable,IStackable
    {
        private int _count = 1;
        public int Count { get { return _count; } }
        public int EnergyAmount { get; set; } = 30;
        public Food()
        {
            Name = "Еда";
            Description = "Востанавливает энергию";

        }
        public void Use(Character user)
        {
            user.AddEnergy(EnergyAmount);
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
