using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Composite
{
    public abstract class Graphic
    {
        protected string Name { get;set; }
        protected Graphic(string name) { Name = name; }

        public abstract void Display(int intent = 0);
    }
}
