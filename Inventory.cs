using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Inventory
    {
        private List<Item> items;
        private int maxItems;
        public Inventory(int maxSize)
        {
            items = new List<Item>();
            maxItems = maxSize;
        }
        public bool Add(Item item)
        {
            if (item is IStackable newStackable)
            {
                foreach (var existingItem in items)
                {
                    if (existingItem is IStackable existingStackable &&
                        existingItem.GetType() == item.GetType() &&
                        existingItem.Name == item.Name)
                    {
                        existingStackable.AddOne();
                        return true;
                    }
                }
            }
            if (items.Count >= maxItems)
            {
                Console.WriteLine("Инвентарь полон!");
                return false;
            }

            items.Add(item);
            return true;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Неверный индекс!");
                return;
            }

            var item = items[index];
            if (item is IStackable stackable)
            {
                stackable.RemoveOne();
                if (stackable.Count <= 0)
                {
                    items.RemoveAt(index);
                }
            }
            else
            {
                items.RemoveAt(index);
            }
        }
        public Item GetItem (int index)
        {
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Неверный индекс!");
                return null;
            }
            return items[index];
        }
        public void ShowInventory()
        {
            Console.WriteLine("\n=== ИНВЕНТАРЬ ===");
            if (items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    if (item is IStackable stackble)
                    {
                        Console.WriteLine($"[{i}] {item.Name}x {stackble.Count}-{item.Description}");

                    }
                    else
                    {
                        Console.WriteLine($"[{i}] {item.Name}-{item.Description}");
                    }
                }
            }
            Console.WriteLine("================\n");
        }
    }
}
