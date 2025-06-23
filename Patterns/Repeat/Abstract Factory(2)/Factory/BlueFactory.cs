using Patterns.Repeat.Abstract_Factory_2_.Abstract_Product;
using Patterns.Repeat.Abstract_Factory_2_.ConcreteProduct1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.Factory
{
    public class BlueFactory : IFactory
    {
        public ISword CreateSword()
        {
            return new BlueSword();
        }
        public IOnion CreateOnion()
        {
            return new BlueOnion();
        }
    }
}
