using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class Room : IPrototype<Room>
    {
        private IPrototype<Room> _room;

        public string Wall;
        public string Floor;
        public string Design;
        public int Cost;

        public Room Clone()
        {
            Room r = new Room()
            {
                Wall = this.Wall,
                Floor = this.Floor,
                Design = this.Design,
                Cost = this.Cost
            };
            return r;
        }

        public void Reset()
        {
            _room = new Room();
        }

        public override string ToString()
        {
            return $"The wall {Wall} and the floor {Floor}";
        }
    }
}
