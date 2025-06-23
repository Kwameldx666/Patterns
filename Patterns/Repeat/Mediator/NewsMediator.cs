using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Mediator
{
    internal class NewsMediator : Mediator
    {
        public override void SendMessage(string message,User user)
        {
            foreach(var user1 in users)
            {
                if(user1 != user)
                {
                    user1.Receive(message);
                }
            }
        }
    }
}
