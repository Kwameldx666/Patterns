using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Chain_of_Responsibility
{
    internal class AuthorizeHandler : PaymentService
    {
        public AuthorizeHandler(PaymentService handler = null) : base(handler) { }

        public override void Pay(int amount,string email, int balance)
        {
            if(email.Length > 0)
            {
                Console.WriteLine("Susccesful payment");
            }
            if(handler != null)
            {
                handler.Pay(amount,email, balance);
            }
        }
    }
}
