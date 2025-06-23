using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Flyweight_3_
{
    internal class TreeType : ITreeFlyweight
    {
        private string texture, description;
        private float health;

        public TreeType(string texture, string descr,float health)
        {
            this.texture = texture;
            this.description = descr;
            this.health = health;
        }
        public void Show(int x, int y)
        {
            Console.WriteLine($"{texture} and {health} level health in x: {x} and y {y}");
        }
    }
}
