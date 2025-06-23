using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Flyweight_3_
{
    internal class FactoryTreeType
    {
        private Dictionary<string, TreeType> _factoryTrees;

        public FactoryTreeType()
        {
            _factoryTrees = new();
        }

        public TreeType GetTreeType(string texture,string description ,float health)
        {
            string key = $"{texture}_{description}_{health}";
            if(!_factoryTrees.ContainsKey(key))
            {
                _factoryTrees.Add(key, new TreeType(texture, description, health));
            }
            return _factoryTrees[key];

        }
    }
}
