using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Composite
{
    public class Folder:Graphic
    {
        private List<Graphic> _children = new();
        public void Add(Graphic children)
        {
            _children.Add(children);
        }

        public void Remove(Graphic ch)
        {
            _children.Remove(ch);
        }
        public Folder(string name) : base(name) { }
        public override void Display(int intent = 0)
        {
            Console.WriteLine(new String(' ', intent) + $"{Name}");
            foreach (Graphic child in _children)
            {
               child.Display(intent + 2);
            }
        }
    }
}
