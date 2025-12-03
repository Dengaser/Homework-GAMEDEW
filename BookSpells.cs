using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class BookSpells
    {
        private List<Spell> spells; // Храним заклинания как поля класса

        public BookSpells()
        {
            spells = new List<Spell>
        {
            new FireBall(),
            new Heal(),
            new Shield()
        };
        }

        public void BookS(Character enemy, Character me, BattleLogger logger)
        {
            Console.WriteLine("Выбери заклинание");

            
            for (int i = 0; i < spells.Count; i++)
            {
                Console.Write($"{i + 1}) ");
                spells[i].Info();
                if (spells[i].IsOnCooldown)
                {
                    Console.WriteLine($"   [Перезарядка: {spells[i].CurrentCooldown}]");
                }
            }

            int v = IntInput();
            if (v > 0 && v <= spells.Count)
            {
                Spell selectedSpell = spells[v - 1];

                if (!selectedSpell.IsOnCooldown)
                {
                    Character target = ViborCeli(enemy, me);
                    selectedSpell.SpellCast(me, target, logger);
                    selectedSpell.StartCooldown();
                }
                else
                {
                    Console.WriteLine($"Заклинание {selectedSpell.SName} на перезарядке! Осталось: {selectedSpell.CurrentCooldown} ходов");
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
            }
        }

        
        public void ReduceAllCooldowns()
        {
            foreach (Spell spell in spells)
            {
                spell.ReduceCooldown();
            }
        }

        static Character ViborCeli(Character enemy, Character me)
        {
            Console.WriteLine("Использовать заклинание 1)на противника 2)на себя");
            int vv = IntInput();
            while (true)
            {
                if (vv == 1) return enemy;
                if (vv == 2) return me;
                Console.WriteLine("Введён неверный формат целого числа от 1 до 2");
            }
        }

        static int IntInput()
        {
            while (true)
            {
                Console.WriteLine("Введите целое число");
                if (int.TryParse(Console.ReadLine(), out int intInput))
                {
                    return intInput;
                }
                else
                {
                    Console.WriteLine("Введён неверный формат целого числа");
                }
            }
        }
    }
}