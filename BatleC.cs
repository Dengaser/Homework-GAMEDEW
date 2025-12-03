using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DZ5
{
    internal class BatleC
    {
        protected int wartime;
        public static Character Batle (Character enemy, Character me)
        {
            BattleLogger logger = new BattleLogger();
            int round = 1;
            
            BookSpells Book = new BookSpells();
            while (me.IsDead == false&& enemy.IsDead == false)
            {
                Console.WriteLine($"\n--- Раунд {round} ---");
                Console.WriteLine("Ход игрока " + me.Name);
                Book.BookS(enemy ,me,logger);
                
                enemy.ProcessEffects(me,enemy,logger);
                me.ProcessEffects(me, enemy, logger);
                logger.LogHealth(enemy.Name, enemy.HP, enemy.Maxhp);
                Console.WriteLine("У игрока " + enemy.Name + " осталось " +enemy.HP + " Здоровья");

                enemy.MakeTurn(enemy,me,logger);
                logger.LogHealth(me.Name, me.HP, me.Maxhp);
                Console.WriteLine("У игрока " + me.Name + " осталось " + me.HP + " Здоровья");
                Book.ReduceAllCooldowns();
                round++;
            }
            if (me.IsDead == false)
            {
                logger.PrintLog();
                logger.PrintSummary(me, enemy);
                return enemy;

            }
            else 
            {
                logger.PrintLog();
                logger.PrintSummary(me, enemy);
                return me;
            }
            
        }
    }
}
