using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Visitor
{
    internal class Enemy : ICharacter
    {
        private string _name;
        public Enemy(string name) => _name = name;
        public void Accept(IVisitor visitor)
        {
            visitor.VisitEnemy(this);
        }
    }
}
