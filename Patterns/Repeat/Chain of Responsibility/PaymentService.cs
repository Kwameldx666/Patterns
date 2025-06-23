using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Chain_of_Responsibility
{
    internal abstract class PaymentService
    {
        protected PaymentService handler;

        public PaymentService(PaymentService handler) { this.handler = handler; }

        public virtual void SetNextHandler(PaymentService nextHandler)
        {
            handler = nextHandler;
        }

        public abstract void Pay(int amount,string email,int balance);

    }
}
