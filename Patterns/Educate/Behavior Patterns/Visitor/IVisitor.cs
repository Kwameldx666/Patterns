using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Visitor
{
    internal interface IVisitor
    {
        void VisitWarrior(Warrior warrior);
        void VisitEnemy(Enemy enemy);
    }
}
