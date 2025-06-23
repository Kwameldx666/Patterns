using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Facade
{
    internal class PaymentService
    {
        public bool ProcessPayment(string paymentMethod, decimal amount)
        {
            Console.WriteLine($"Processing {amount:C} payment using {paymentMethod}.");
            // Here you would add logic to process the payment, e.g., calling a payment gateway API.
            return true; // Assuming payment is successful
        }
        public bool RefundPayment(string paymentMethod, decimal amount)
        {
            Console.WriteLine($"Refunding {amount:C} payment using {paymentMethod}.");
            // Here you would add logic to refund the payment, e.g., calling a payment gateway API.
            // Assuming refund is successful
            Console.WriteLine("Refund successful.");
            return true; // Assuming refund is successful
        }
    }
}
