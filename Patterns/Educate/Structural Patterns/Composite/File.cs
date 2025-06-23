using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Composite
{
    public class File:Graphic
    {
        public File(string name) : base(name) { }

        public override void Display(int intent = 0)
        {
            Console.WriteLine($"{new String(' ', intent)}File:{Name}");
        }
    }
}
