using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Chain_of_Responsibility
{
    internal class BalanceHandler : PaymentService
    {
        public BalanceHandler(PaymentService handler = null) : base(handler) { }

        public override void Pay(int amount, string email, int balance)
        {
            if (balance < 160)
            {
                Console.WriteLine("Susccesful payment");
            }
            if (handler != null)
            {
                handler.Pay(amount, email,balance);
            }
        }
    }
}
