using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge.Abstraction
{
    public abstract class Message
    {
        protected INotification _notification;

        protected Message(INotification notification)
        {
            _notification = notification;
        }

        public abstract void Notify(string message);
    }
}
