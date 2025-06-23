using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Observer
{
    internal class SmsService : INotification
    {
        public void SendMessage() { Console.WriteLine("[Sms] send you sms"); }
    }
}
