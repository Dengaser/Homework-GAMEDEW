using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Burning:Effect
    {
        
        private int damagePerTurn;
        public Burning(int time) :base("Burning",time)
        {
            
            damagePerTurn = 5;
        }
        public override void EffectCast(Character pic)
        {
            Console.WriteLine($"{pic.Name} начинает гореть!");

        }
        public override void Effecting(Character me, Character pic,BattleLogger logger)
        {
            if (pic.IsDead) return;
            


            Console.WriteLine($"Горение");//{pic.Name} получает {3} урона от горения
            pic.Damage(me,pic,1,logger);
                
            
            time--;
        }
        public override void EndEffects( Character pic)
        {
            
            Console.WriteLine($"{pic.Name} перестал гореть");

        }
    }
}
