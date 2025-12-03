using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal abstract class Spell
        
    {
        public int Cooldown { get; protected set; }
        public int CurrentCooldown { get; protected set; }
        public bool IsOnCooldown => CurrentCooldown > 0;

        
        public Spell(string sname, string stats,int cooldown=0)
        {
            this.sname = sname;
            this.stats = stats;
            
            Cooldown = cooldown;
        }
        protected string sname;
        protected string stats;
        public string SName
            { get { return sname; } }
        public string Stats
            { get { return stats; } }
        public abstract void SpellCast(Character caster, Character target, BattleLogger logger);
        public virtual void Info()
        {
            Console.WriteLine(sname);
            Console.WriteLine(stats);
        }
        public void StartCooldown()
        {
            CurrentCooldown = Cooldown;
        }
        public void ReduceCooldown()
        {
            if (CurrentCooldown > 0)
                CurrentCooldown--;
        }

    }
}
