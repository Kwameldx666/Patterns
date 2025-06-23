using Patterns.Repeat.Abstract_Factory_2_.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_.Factory
{
    public interface IFactory
    {
        ISword CreateSword();
        IOnion CreateOnion();
    }
}
