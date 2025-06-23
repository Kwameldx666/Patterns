using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Visitor
{
    internal class DeffencerVisitor : IVisitor
    {
        public void VisitEnemy(Enemy enemy)
        {
            Console.WriteLine("17 defence");
        }

        public void VisitWarrior(Warrior warrior)
        {
            Console.WriteLine("147 defence");
        }
    }
}
