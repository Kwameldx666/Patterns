using Patterns.Repeat.Factory_Method_2_.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method_2_.Creator
{
    //конкретная фабрика с реализация создания продукта меч
    public class SwordFactory:WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
