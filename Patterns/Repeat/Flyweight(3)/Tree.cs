using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Flyweight_3_
{
    internal class Tree:ITreeFlyweight
    {
        public int x, y;
        private TreeType type;
        public Tree(TreeType type,int x, int y)
        {
            this.type = type;
            this.x = x;
            this.y = y;
        }

        public void Show(int x , int y)
        {
            type.Show(x,y);
        }
    }
}
