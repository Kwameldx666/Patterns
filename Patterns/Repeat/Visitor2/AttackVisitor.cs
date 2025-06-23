using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor2
{
    internal class AttackVisitor : ICharacterVisitor
    {
        public void VisitEnemy(Enemy enemy)
        {
           Console.WriteLine($"Attacking enemy with {enemy.Name}"); 
        }

        public void VisitWarrior(Warrior warrior)
        {
            Console.WriteLine($"Attacking warrior with {warrior.Name}");
        }
    }
}
