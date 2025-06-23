using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor
{
    internal class SoundVisitor : AnimalVisitor
    {
        public void VisitCat(Cat cat)
        {
            Console.WriteLine("Says meow");
        }

        public void VisitDog(Dog dog)
        {
            Console.WriteLine("Says gavgav");
        }
    }
}
