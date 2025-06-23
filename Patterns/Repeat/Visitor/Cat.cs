using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor
{
    internal class Cat : IAnimal
    {
        public string Name { get; private set; } = "Meow";

        public void SetName(string name) {Name = name;}
        public void Accept(AnimalVisitor visitor)
        {
           visitor.VisitCat(this);
        }
    }
}
