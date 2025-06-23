using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Composite2.Component
{
    public abstract class Graphic
    {
        public abstract void ShowGraphic(int intent = 0);
        public virtual void Add(Graphic ob) { }
        public virtual void Remove(Graphic ob) { }
    }
}
