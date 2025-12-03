using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Goblin : Character
    {
        
        public Goblin(string name, int hp,int maxhp): base(name,hp,maxhp)
        {
            this.name = name;
            this.hp = hp;
            this.maxhp = maxhp;
        }
        public override void Damage(Character ca, Character ta,int damage,BattleLogger logger)
        {
            
            hp -= Math.Max(0, damage-1);
            if (hp <= 0)
                isDead = true;
            Console.WriteLine($"{name} получает {damage} урона. Здоровье: {hp}/{maxhp}");

        }
        public override void MakeTurn(Character ca,Character target,BattleLogger logger)
        {
            

            Console.WriteLine($"\n=== Ход гоблина {Name} ===");
            int damage = new Random().Next(3, 8);
            Console.WriteLine($"{Name} атакует {target.Name}!");
            target.Damage(ca,target,damage,logger);
            logger.LogAction(ca.Name, $"Атаковал {target.Name}", damage, 0);
        }



    }
}
