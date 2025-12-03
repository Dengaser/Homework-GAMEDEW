using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Character
    {
        protected string name;
        protected int hp;
        protected int maxhp;
        protected int energy;
        protected int maxenergy;
        protected int money;
        protected Weapon Eweapon;
        protected Armor Earmor;
        protected MagicRing Ering;
        protected bool isDead = false;
        protected int defense;

        public string Name { get { return name; } }
        public int HP { get { return hp; } }
        public int Maxhp { get { return maxhp; } }
        public bool IsDead { get { return isDead; } }

        public Character(string name, int maxhp, int maxenergy,int gold=0)
        {
            this.name = name;
            this.maxenergy = maxenergy;
            this.maxhp = maxhp;
            this.maxhp = maxhp;
            this.maxenergy = maxenergy;
            this.money = gold;

        }
        public void AddHealth(int value)
        {
            hp += value;
            if (hp > maxhp)
                hp = maxhp;
            if (hp < 0)
                hp = 0;

        }
        public void AddEnergy(int value)
        {
            energy += value;
            if (energy > maxenergy)
                energy = maxenergy;
            if (energy < 0)
                energy = 0;
        }
        public void AddGold(int value)
        {
            if (money+value <0)
                throw new InvalidOperationException("Недостаточно золота");

            money += value;
            
        }
        public void EquipWeapon(Weapon weapon)
        {
            Eweapon= weapon;
        }
        public void EquipArmor(Armor armor)
        {
            Earmor= armor;
        }
        public void EquipMagicRing(MagicRing ring)
        {
            Ering = ring;
        }
        public void UnequipWeapon(Weapon weapon)
        {
            Eweapon = null;
        }
        public void UnequipArmor(Armor armor)
        {
            Earmor = null;
        }
        public void UnequipMagicRing(MagicRing ring)
        {
            Ering = null;
        }
        public void ShowInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine($"У тебя сейчас {hp}/{maxhp} HP");
            Console.WriteLine($"У тебя сейчас { energy}/{ maxenergy} энергии");
            Console.WriteLine($"У тебя сейчас{money}денег");
            if (Eweapon!=null)
            Console.WriteLine($"Сейчас на тебе экипирован оружие {Eweapon.Name}");
            if (Earmor != null)
                Console.WriteLine($"Сейчас на тебе экипирован защита {Earmor.Name}");
            if (Ering != null) Console.WriteLine($"Сейчас на тебе экипировано " + Ering.Name);
        }
    }
}
