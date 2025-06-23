using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Flyweight_3_
{
    internal class Forest
    {
        private List<Tree> _trees = new();
        FactoryTreeType _factoryTreeType = new();
        public void PlantTree(int x,int y,string texture,string desc, float health)
        {
            _trees.Add(new Tree(_factoryTreeType.GetTreeType(texture,desc,health),x,y));
        }

        public void ShowAllInfo()
        {
            foreach (var _tree in _trees) { _tree.Show(_tree.x,_tree.y); }
        }
    }
}
