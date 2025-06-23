using Patterns.Repeat.Factory_Method_2_.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method_2_.Creator
{
    //фабрика(абстрактный создатель)
    public class OnionFactory:WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Onion();
        }
    }
}
