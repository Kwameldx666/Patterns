using Patterns.Educate.Structural_Patterns.Composite2.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Composite2.Leaf
{
    public class Product : Graphic
    {
        private string _name;
        public Product(string name)
        {
            _name = name;
        }

        public override void ShowGraphic(int intent = 0)
        {
            Console.WriteLine($"{new String(' ', intent)}Product:{_name}");
        }
    }
}
