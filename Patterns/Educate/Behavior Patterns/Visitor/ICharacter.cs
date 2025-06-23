using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Visitor
{
    internal interface ICharacter
    {
        void Accept(IVisitor visitor);
    }
}
