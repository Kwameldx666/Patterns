using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Observer
{
    internal interface IPayment
    {
        public void Attach(INotification notification);
        public void Detach(INotification notification);
        public void Notify();
    }
}
