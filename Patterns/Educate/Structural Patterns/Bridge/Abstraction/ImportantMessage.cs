using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge.Abstraction
{
    class ImportantMessage:Message
    {
        public ImportantMessage(INotification notification):base(notification) { }

        public override void Notify(string message)
        {
            Console.Write("Я отправлю сообщение важное:");
            _notification.Send(message);
        }
    }
}
