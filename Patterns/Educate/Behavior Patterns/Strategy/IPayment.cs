using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Strategy
{
    internal interface IPayment
    {
        public void Pay(int amount);
    }
}
