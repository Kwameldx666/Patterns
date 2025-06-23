using Patterns.Repeat.Abstract_Factory_2_.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.ConcreteProduct2
{
    public class WoodOnion:IOnion
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is a wood onion.");
        }
        public void Attack()
        {
            Console.WriteLine("Attacking with the wood onion!");
        }
        public void Upgrade()
        {
            Console.WriteLine("Upgrading the wood onion!");
        }

    }
}
