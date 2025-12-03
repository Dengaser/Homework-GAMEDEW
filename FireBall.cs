using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace DZ5
{
    internal class FireBall : Spell
    {
        private Random random;
        private string name="Fireball";
        private int damage=3;
        private string discription = "Метает огненый шар наносящий 3 урона";
        public int Damage
            { get { return damage; } }
        public FireBall(): base("Fireball", "Метает огненый шар наносящий 3 урона",2)
        {
            
            random = new Random();

        }

        public override void SpellCast(Character Caster, Character target, BattleLogger logger)
        {
            target.Damage(Caster,target,damage,logger);
            logger.LogAction(Caster.Name, $"применил {name} на {target.Name}", damage, 0);
            if (random.Next(100) < 30)
            {
                target.AddEffect(new Burning(3));

                logger.LogEffect(target.Name, "Горение", 3);
            }

        }
        public override void Info()
        {
            base.Info();
        }

                             
    }
}
