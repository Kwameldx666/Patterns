using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor
{
    internal class Dog : IAnimal
    {
        public string Name { get; private set; } = "Howwwww";

        public void SetName(string name) { Name = name; }
        public void Accept(AnimalVisitor visitor)
        {
            visitor.VisitDog(this);
        }
    }
}
