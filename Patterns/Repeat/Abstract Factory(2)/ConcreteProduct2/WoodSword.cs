using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.ConcreteProduct2
{
    public class WoodSword : ISword
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is a wood sword.");
        }
        public void Attack()
        {
            Console.WriteLine("Attacking with the wood sword!");
        }
        public void Upgrade()
        {
            Console.WriteLine("Upgrading the wood sword!");
        }
        public void Enchant()
        {
            Console.WriteLine("Enchanting the wood sword!");
        }
    }
}
