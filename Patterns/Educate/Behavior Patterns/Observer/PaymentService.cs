using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Observer
{
    internal class PaymentService : IPayment
    {
        private List<INotification> observers = new();

        public void Attach(INotification notification)
        {
            Console.WriteLine("Subscribe");
            observers.Add(notification);
        }

        public void Detach(INotification notification)
        {
            if (observers.Contains(notification))
            {
                observers.Remove(notification);
            }
            else
                Console.WriteLine("You wasn't attached");
        }

        public void Notify()
        {
            foreach (var ob in observers)
            {
                ob.SendMessage();
            }
        }
        public void Payment()
        {
            Console.Write("You bought it[CONGRATULATIONS]\n");
            Notify();
        }
    }
}
