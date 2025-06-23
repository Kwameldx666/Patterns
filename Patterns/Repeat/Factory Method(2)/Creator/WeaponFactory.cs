using Patterns.Repeat.Factory_Method_2_.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method_2_.Creator
{
    //конкретная фабрика с реализация создания продукта лук
    public abstract class WeaponFactory
    {
        public void ShowInfo() => CreateWeapon().ShowInfo();
        public void Attack() => CreateWeapon().Attack();
        public abstract IWeapon CreateWeapon();
    }
}
