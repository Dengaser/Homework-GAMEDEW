using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var character = new Character("Герой", 100, 50, 100);
            var inventory = new Inventory(10);
            inventory.Add(new HealthPotion());
            inventory.Add(new HealthPotion());
            inventory.Add(new Food());
            inventory.Add(new Gem());
            inventory.Add(new OldBoot());
            inventory.Add(new Weapon());
            inventory.Add(new Armor());
            inventory.Add(new MagicRing());
            inventory.Add(new Scroll());
            while (true)
            {
                character.ShowInfo();
                inventory.ShowInventory();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Использовать предмет");
                Console.WriteLine("2 - Экипировать предмет");
                Console.WriteLine("3 - Продать предмет");
                Console.WriteLine("4 - Выбросить предмет");
                Console.WriteLine("0 - Выход");
                string input = Console.ReadLine();
                if (input == "0") break;
                if (int.TryParse(input, out int action) && action >= 1 && action <= 4)
                {
                    Console.Write("Введите индекс предмета: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        Item item = inventory.GetItem(index);
                        if (item != null)
                        {
                            ProcessAction(action, item, character, inventory, index);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Неверный индекс!");
                    }

                }
                else
                {
                    Console.WriteLine("Неверное действие!");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //    static void ProcessAction(int action, Item item, Character character1, Inventory inventory1, int index)
        //    {
        //       if (action==1)
        //       {
        //            if (item is IUsable usable)
        //            {
        //                usable.Use(character1);
        //                if (item is IStackable stackable && stackable.Count <= 0)
        //                {
        //                    inventory1.RemoveAt(index);
        //                }
        //                else if (!(item is IStackable))
        //                {
        //                    inventory1.RemoveAt(index);
        //                }

        //            }
        //        else
        //        {
        //            Console.WriteLine("Этот предмет нельзя использовать");

        //        }


        //        if (action == 2)
        //        {
        //            if (item is IEquipable equipable)
        //            {
        //                equipable.Equip(character1);

        //            }
        //            else
        //            {
        //                Console.WriteLine("Этот предмет нельзя надеть");

        //            }

        //        }
        //        if (action == 3)
        //        {
        //            if (item is ISellable sellable)
        //            {
        //                sellable.Sell(character1);
        //                inventory1.RemoveAt(index);

        //            }
        //            else
        //            {
        //                Console.WriteLine("Этот предмет нельзя продать");

        //            }

        //        }
        //        if (action == 4)
        //        {
        //            if (item is IDiscardable discardable)
        //            {
        //                discardable.Discard();
        //                inventory1.RemoveAt(index);

        //            }
        //            else
        //            {
        //                Console.WriteLine("Этот предмет нельзя выброситьчё");

        //            }

        //        }

        //        return;
        //    }

        //}
        static void ProcessAction(int action, Item item, Character character1, Inventory inventory1, int index)
        {
            switch (action)
            {
                case 1: 
                    if (item is IUsable usable)
                    {
                        usable.Use(character1);
                        
                        if (item is IStackable stackable)
                        {
                            //stackable.RemoveOne();
                            if (stackable.Count <= 0)
                            {
                                inventory1.RemoveAt(index);
                            }
                        }
                        else
                        {
                            inventory1.RemoveAt(index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет нельзя использовать");
                    }
                    break;

                case 2: 
                    if (item is IEquipable equipable)
                    {
                        equipable.Equip(character1);
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет нельзя надеть");
                    }
                    break;

                case 3: 
                    if (item is ISellable sellable)
                    {
                        sellable.Sell(character1);
                        inventory1.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет нельзя продать");
                    }
                    break;

                case 4: 
                    if (item is IDiscardable discardable)
                    {
                        discardable.Discard();
                        inventory1.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет нельзя выбросить");
                    }
                    break;
            }
        }

    }
}
