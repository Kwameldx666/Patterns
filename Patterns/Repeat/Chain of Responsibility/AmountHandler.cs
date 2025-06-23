using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Chain_of_Responsibility
{
    internal class AmountHandler : PaymentService
    {
        public AmountHandler(PaymentService handler = null) : base(handler) { }

        public override void Pay(int amount, string email, int balance)
        {
            if (amount > 0)
            {
                Console.WriteLine("Susccesful checked amount");
            }
            if (handler != null)
            {
                handler.Pay(amount, email, balance);
            }
        }
    }
}
