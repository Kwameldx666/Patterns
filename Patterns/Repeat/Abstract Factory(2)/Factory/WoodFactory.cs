using Patterns.Repeat.Abstract_Factory_2_.Abstract_Product;
using Patterns.Repeat.Abstract_Factory_2_.ConcreteProduct2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.Factory
{
    public class WoodFactory: IFactory
    {
        public ISword CreateSword()
        {
            return new WoodSword();
        }
        public IOnion CreateOnion()
        {
            return new WoodOnion();
        }

    }
}
