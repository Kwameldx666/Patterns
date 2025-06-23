using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Strategy
{
    internal class ApplePay: IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine("ApplePay payment");
        }
    }
}
