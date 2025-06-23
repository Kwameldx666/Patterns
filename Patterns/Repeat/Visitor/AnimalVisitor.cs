using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor
{
    internal interface AnimalVisitor
    {
        void VisitDog(Dog dog);
        void VisitCat(Cat cat);
    }
}
