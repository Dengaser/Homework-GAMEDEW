    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Mage : Character
    {
       public Mage(string name, int hp, int maxhp) : base(name, hp, maxhp)
        {

        }
        public override void MakeTurn(Character ca, Character target, BattleLogger logger)
        {


            Console.WriteLine($"\n=== Ход гоблина {Name} ===");
            int damage = new Random().Next(3, 8);
            Console.WriteLine($"{Name} атакует {target.Name}!");
            target.Damage(ca, target, damage, logger);
        }
    }
    
}
