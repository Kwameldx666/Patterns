using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor
{
    internal interface IAnimal
    {
        void Accept(AnimalVisitor visitor);
    }
}
