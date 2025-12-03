using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4
{
    internal class PlayerInventory
    {
        private Item[] items= new Item[5];
        public Item[] Items { get { return items; } }
        private float weightCapacity= 20;
        public float WeightCapacity { get { return weightCapacity; } }
        public int SvobodniMest =5 ;
        public float TotalWeight= 0;
        private int slots;
        public int TotalPrice = 0;
        
        public void AddItem(Item item)
        {
            
            for (int i = 0;i<5;i++)
            {
                if (SvobodniMest > 0 &&( WeightCapacity - TotalWeight )>= item.Weight)
                {   
                    Items[5- SvobodniMest]= item;
                    

                }
                else {
                    if (SvobodniMest == 0)
                    {
                        Console.WriteLine("Место закончилось");
                        //хз как стопнуть
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Предмет слишком жирный");
                        break;
                    }
                }
            }
            SvobodniMest--;
            GetTotalWeight();
            GetTotalPrice();
        }
        public int GetTotalPrice()
        {
            int coast = 0;

            for (int i = 0; i < 5; i++)
            {
                if (Items[i] != null)
                { coast += Items[i].Price; }


            }
            TotalPrice = coast;
            return TotalPrice;
        }
        public float GetTotalWeight()
        {

            float weight = 0;
            
            for (int i = 0; i < 5;i++)
            {
                if (Items[i]!=null)
                { weight += Items[i].Weight; }
                

            }
            TotalWeight= weight;
            return TotalWeight;
        }
        public void ShowInventory()
        {
            for (int i = 0; i < 5; i++)
            {
                if (Items[i] != null)
                {
                    Console.WriteLine("Название: "+Items[i].Name);
                    Console.WriteLine("Цена: "+Items[i].Price);
                    Console.WriteLine("Вес: "+Items[i].Weight);
                    Console.WriteLine("");
                }



            }
            Console.WriteLine("Общий вес равен: "+TotalWeight);
            //Console.WriteLine("Общая ценность предметов: " + TotalPrice);
        }
    }
}
