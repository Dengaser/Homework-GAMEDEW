using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //1
            Item F1 = Sozdanie();
            Console.WriteLine("");
            Item F2 = Sozdanie();
            Item[] items = new Item[2];
            items[0] = F1;
            items[1] = F2;
            F1.DisplayInfo();
            Console.WriteLine("");
            F2.DisplayInfo();
            //2
            PlayerInventory inventory = new PlayerInventory();
            inventory.AddItem(Sozdanie());
            inventory.AddItem(Sozdanie());
            inventory.AddItem(Sozdanie());
            inventory.AddItem(Sozdanie());
            inventory.AddItem(Sozdanie());
            inventory.AddItem(Sozdanie());



            Console.WriteLine("Вес инвентаря: "+inventory.GetTotalWeight());
            //3
            PlayerInventory inventory1 = new PlayerInventory();
            Console.WriteLine("Введи имя игрока");
           string Name = Console.ReadLine();
            Player player = new Player(Name);
            string arm = "armor";
            int c = 10;
            float f = 1.2f;
            Item i1 = new Item(arm,c,f);
            string arm2 = "aegis";
            int c2 = 10;
            float f2 = 2.22f;
            Item i2 = new Item(arm2, c2, f2);
            
            player.PickUpItem(i1);
            player.PickUpItem(i2);
            Console.WriteLine("Имя: "+Name);
            
            player.ShowInventory();
            Console.WriteLine("Общая стоимоть инвентаря: "+player.GetInventoryValue());
            
            
        }
        static Item Sozdanie()
        {
            Console.WriteLine("Создай предмет");
            Console.WriteLine("Назови предмет");
            string name = Console.ReadLine();
            Console.WriteLine("Price");
            int.TryParse(Console.ReadLine(), out int prise);
            Console.WriteLine("Введи вес предмета");
            float.TryParse(Console.ReadLine(), out float weight);
            Item Item1 = new Item(name, prise, weight);
            return Item1;
        }
        
    }
}
