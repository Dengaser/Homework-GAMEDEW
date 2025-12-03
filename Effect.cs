using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal abstract class Effect
    {
        protected string name;
        protected int time;
        public string Name
            { get { return name; } }
        public int Time
            { get { return time; } }
        public Effect(string name, int time)
        {
            this.name = name;
            this.time = time;
        }
        public abstract void EffectCast(Character pic);

        public abstract void Effecting( Character me, Character pic,BattleLogger logger);
        public abstract void EndEffects( Character pic);

    }
}
