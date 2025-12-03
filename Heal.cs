using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DZ5
{
    internal class Heal : Spell
    {
        protected int regen = 5;

        public Heal() : base("Заклинание излечивания", "Восстанавливает здоровье",3)
        {
        }
        public override void SpellCast(Character Caster,Character target, BattleLogger logger)
        {
            Caster.Regeneration(regen);
            logger.LogAction(Caster.Name, $"применил {Caster.Name} на {target.Name}", 0, regen);

        }
    }
}
