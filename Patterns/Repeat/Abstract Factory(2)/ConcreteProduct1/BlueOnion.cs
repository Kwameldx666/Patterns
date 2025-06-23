using Patterns.Repeat.Abstract_Factory_2_.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.ConcreteProduct1
{
    public class BlueOnion:IOnion
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is a blue onion.");
        }
        public void Attack()
        {
            Console.WriteLine("Attacking with the blue onion!");
        }
        public void Upgrade()
        {
            Console.WriteLine("Upgrading the blue onion!");
        }
    }
}
