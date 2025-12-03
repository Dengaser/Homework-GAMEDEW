using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal abstract class Character
    {
        protected string name;
        protected int hp;
        protected int maxhp;
        protected bool isDead = false;
        protected int defense;
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public string Name {  get { return name; } }
        public int HP { get { return hp; } }
        public int Maxhp { get { return maxhp; } }
        public bool IsDead { get { return isDead; } }
        public List<Effect> ActiveEffects { get; protected set; }
        public Character(string name, int hp, int maxhp)
        {
            this.name = name;
            this.hp = hp;
            this.maxhp = maxhp;
            ActiveEffects = new List<Effect>();

        }
        public abstract void MakeTurn(Character ca, Character ta, BattleLogger logger);

        public virtual void Damage(Character ca,Character ta,int damage,BattleLogger logger)
        {
            int totaldamage = damage - defense;
            hp-= Math.Max(0, totaldamage);
            if (hp <= 0)
                isDead = true;
            Console.WriteLine($"{name} получает {damage} урона. Здоровье: {hp}/{maxhp}");

        }
        public virtual void Regeneration(int regen)
        {
            hp += regen;
            if (hp > maxhp)
                hp = maxhp;
            Console.WriteLine($"{Name} восстанавливает {regen} здоровья. Здоровье: {hp}/{maxhp}");

        }
        //public abstract void MakeTurn(Character target);

        public void ProcessEffects(Character ca,Character ta,BattleLogger logger)
        {
            for (int i = ActiveEffects.Count - 1; i >= 0; i--)
            {
                ActiveEffects[i].Effecting(ca,ta,logger);
                if (ActiveEffects[i].Time <= 0)
                {
                    ActiveEffects[i].EndEffects(this);
                    ActiveEffects.RemoveAt(i);
                }
            }
        }
        public void AddEffect(Effect effect)
        {
            ActiveEffects.Add(effect);
            effect.EffectCast(this);
        }
    }
}
