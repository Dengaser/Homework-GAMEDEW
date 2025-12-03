    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4
{
    internal class Item
    {
        private string name;
        private int price;
        private float weight;
        public string Name { get { return name; } }
        public int Price { get { return price; } }
        public float Weight { get { return weight; } }
        public Item (string name, int price, float weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Предмет: {name}");
            Console.WriteLine($"Цена: {price} монет");
            Console.WriteLine($"Вес: {weight} кг");
            Console.WriteLine("-----------");
        }
       
    }
}
