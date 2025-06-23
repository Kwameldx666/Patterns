using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method_2_.Product
{
    //Интерфес абстрактного продукта с медотами
    public interface IWeapon
    {
        public void ShowInfo();
        public void Attack();
    }
}
