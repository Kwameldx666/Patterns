using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Facade
{
    internal class Facade
    {
        private readonly DeliveryService _deliveryService = new();
        private readonly PaymentService _paymentService = new();
        private readonly NotificationService _notificationService = new();
        private readonly OrderService _orderService = new();

        public void PlaceOrder(string product, string address, decimal amount)
        {
            // Step 1: Create an order
            var order = _orderService.CreateOrder(product);
            // Step 2: Process payment
 
            if (_paymentService.ProcessPayment("Credit Card", amount))
            {
                // Step 3: Arrange delivery
                _deliveryService.DeliverOrder(order, address);
                // Step 4: Notify customer
                _notificationService.NotifyUser(order, "Your order has been placed successfully.");
            }
            else
            {
                _notificationService.NotifyUser(order, "Payment failed. Please try again.");
            }
        }
    }
}
