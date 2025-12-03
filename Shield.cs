    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Shield:Spell
    {
        public Shield() : base("Щит", "Накладывает защиту на цель",2) { }

        public override void SpellCast(Character caster, Character target, BattleLogger logger)
        {
            Console.WriteLine($"{caster.Name} накладывает щит на {target.Name}!");
            target.AddEffect(new Shielded(2));
            logger.LogEffect(target.Name, "Защита", 2);
        }
    }

}
