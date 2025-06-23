using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor2
{
    public class Enemy : ICharacter
    {
        public string Name { get; set; }
        public void Accept(ICharacterVisitor visitor)
        {
            visitor.VisitEnemy(this);
        }
    }
}
