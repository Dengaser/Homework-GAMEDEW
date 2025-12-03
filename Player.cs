using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4
{
    internal class Player
    {
        public Player(string name)
        {
            this.name =name;
        }
        private string name;
        private PlayerInventory inventory= new PlayerInventory();
        public string Name { get { return name; } }
        public PlayerInventory PInventory { get { return inventory; } } 
        
        public void PickUpItem(Item item)
        {

            inventory.AddItem(item);
        }
        public void ShowInventory()
        {
            
            inventory.ShowInventory();

        }
        public int GetInventoryValue()
        {
           return inventory.GetTotalPrice();
        }
    }
}
