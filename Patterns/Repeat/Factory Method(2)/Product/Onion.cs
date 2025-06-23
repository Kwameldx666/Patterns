using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method_2_.Product
{
    //реализация интерфейса для лука(конкретный продукт номер 1)
    public class Onion:IWeapon
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is an onion.");
        }
        public void Attack()
        {
            Console.WriteLine("Onion attacks!");
        }
    }
    
}
