using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge.Abstraction
{
    class SimpleMessage:Message
    {
        public SimpleMessage(INotification _notification) : base(_notification) { }
        public override void Notify(string  message) { _notification.Send(message); }
    }
}
