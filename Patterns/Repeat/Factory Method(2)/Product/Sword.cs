using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method_2_.Product
{
    //реализация интерфейса для меча(конкретный продукт номер 2)
    public class Sword:IWeapon
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is a sword.");
        }
        public void Attack()
        {
            Console.WriteLine("Sword attacks!");
        }
    }
}
