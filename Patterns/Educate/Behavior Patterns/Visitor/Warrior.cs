using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Visitor
{
    internal class Warrior : ICharacter
    {
        private string _name;
        public Warrior(string name)
        {
            _name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitWarrior(this);
        }
    }
}
