using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Composite
{
    public abstract class Graphic
    {

        public abstract void Draw();
        public abstract void CountSalary();

        public virtual void Add(Graphic graphic)
        {
            throw new NotImplementedException("This method is not implemented for this graphic type.");
        }
        public virtual void Remove(Graphic graphic)
        {
            throw new NotImplementedException("This method is not implemented for this graphic type.");
        }


    }
}
