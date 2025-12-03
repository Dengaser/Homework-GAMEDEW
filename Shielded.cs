using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Shielded: Effect
    {
        public Shielded(int duration) : base("Защита", duration) { }

        public override void EffectCast(Character target)
        {
            Console.WriteLine($"{target.Name} получает 5 защиты!");
            target.Defense = 5;
        }

        public override void Effecting(Character ca,Character target,BattleLogger logger)
        {
            
            time--;
        }

        public override void EndEffects(Character target)
        {
            Console.WriteLine($"{target.Name} теряет защиту");
            target.Defense = 0;
        }
    }
}
