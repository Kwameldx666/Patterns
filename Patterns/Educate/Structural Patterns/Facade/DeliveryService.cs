using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Facade
{
    internal class DeliveryService
    {
        public void DeliverOrder(string order, string address)
        {
            Console.WriteLine($"We're delivering the order: {order} to {address}");
        }

    }
}
