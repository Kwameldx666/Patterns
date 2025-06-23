using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.ConcreteProduct1
{
    public class BlueSword:ISword
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is a blue sword.");
        }
        public void Attack()
        {
            Console.WriteLine("Attacking with the blue sword!");
        }
        public void Upgrade()
        {
            Console.WriteLine("Upgrading the blue sword!");
        }
        public void Enchant()
        {
            Console.WriteLine("Enchanting the blue sword!");
        }
    }
}
