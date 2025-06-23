using Patterns.Educate.Behavior_Patterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor2
{
    internal class DeffendVisitor : ICharacterVisitor
    {
        public void VisitWarrior(Warrior warrior)
        {
            Console.WriteLine($"Warrior {warrior.Name} is defending with shield and armor.");
        }

        public void VisitEnemy(Enemy enemy)
        {
            Console.WriteLine($"Enemy {enemy.Name} is defending with agility and cunning.");
        }   
    }
}
