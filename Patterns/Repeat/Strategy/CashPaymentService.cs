using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Strategy
{
    internal class CashPaymentService : PaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("Cash");
        }
    }
}
