using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Visitor
{
    internal class DieVisitor : AnimalVisitor
    {
        public void VisitCat(Cat cat)
        {
            Console.WriteLine("Cat ______");
        }

        public void VisitDog(Dog dog)
        {
            Console.WriteLine($"Dog {dog.Name} died");
        }
    }
}
