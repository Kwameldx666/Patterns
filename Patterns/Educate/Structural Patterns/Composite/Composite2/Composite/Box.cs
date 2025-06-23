using Patterns.Educate.Structural_Patterns.Composite2.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Composite2.Composite
{
    public class Box : Graphic
    {
        private string _boxName;
        public Box(string name)
        {
            _boxName = name;
        }
        private List<Graphic> _obj = new List<Graphic>();
        public override void Add(Graphic obj)
        {
            _obj.Add(obj);
        }

        public override void Remove(Graphic obj)
        {
            if (_obj.Contains(obj)) _obj.Remove(obj);

        }
        public override void ShowGraphic(int intent = 0)
        {
            Console.WriteLine($"{new string(' ', intent)}Box name is" + _boxName);
            if (_obj.Count > 0)
            {
                foreach (Graphic obj in _obj)
                {
                    obj.ShowGraphic(intent + 2);
                }
            }
        }
    }
}
