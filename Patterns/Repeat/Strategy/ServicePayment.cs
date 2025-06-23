using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Strategy
{
    internal class ServicePayment
    {
        private PaymentStrategy strategy;
        public ServicePayment(PaymentStrategy strategy) => this.strategy = strategy;

        public void PayProduct()
        {
            strategy.Pay();
        }
        public void SetStrategy(PaymentStrategy strategy) { this.strategy = strategy; }
    }
}
