using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Observer
{
    internal class EmailService : INotification
    {
        public void SendMessage() { Console.WriteLine("[EMAIL] send you sms"); }
    }
}
