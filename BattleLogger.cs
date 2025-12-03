using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class BattleLogger
    {
        private List<string> log;
        public BattleLogger()
        {
            log=new List<string>();
        }
        public void LogAction(string actor,string action,int damage, int heal)
        {
            string entry = $"{actor} {action}";
            if (damage > 0) entry += $", урон: {damage}";
            if (heal > 0) entry += $", лечение: {heal}";
            log.Add(entry);
        }
        public void LogEffect(string target, string effect, int duration)
        {
            log.Add($"{target} получает эффект '{effect}' на {duration} ходов");
        }
        public void LogHealth(string character, int current, int max)
        {
            log.Add($"{character}: {current}/{max} HP");
        }
        public void PrintLog()
        {
            Console.WriteLine("\n=== ЖУРНАЛ БОЯ ===");
            foreach (var entry in log)
            {
                Console.WriteLine(entry);
            }
        }
        public void PrintSummary(Character player1, Character player2)
        {
            Console.WriteLine("\n=== СВОДКА БОЯ ===");
            Console.WriteLine($"{player1.Name}: {(player1.IsDead ? "ПОРАЖЕНИЕ" : "ПОБЕДА")}");
            Console.WriteLine($"{player2.Name}: {(player2.IsDead ? "ПОРАЖЕНИЕ" : "ПОБЕДА")}");
        }
    }
}
