using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor2
{
    internal interface ICharacter
    {
        public void Accept(ICharacterVisitor visitor);
    }
}
