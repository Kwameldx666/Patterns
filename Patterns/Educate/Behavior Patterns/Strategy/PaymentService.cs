using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Strategy
{
    internal class PaymentService
    {
        private IPayment _strategy;

        public  PaymentService(IPayment payment = null)
        {
            _strategy = payment;
        }

        public void SetStrtegy(IPayment strategy)
        {
            _strategy = strategy;
        }

        public void Pay(int amount)
        {
            _strategy.Pay(amount);
        }
    }
}
