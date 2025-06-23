using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Visitor
{
    internal class AttackerVisitor : IVisitor
    {
        public void VisitEnemy(Enemy enemy)
        {
            Console.WriteLine("17 attack");
        }

        public void VisitWarrior(Warrior warrior)
        {
            Console.WriteLine("50 attack");
        }
    }
}
