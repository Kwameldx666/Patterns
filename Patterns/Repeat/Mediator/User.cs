using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Mediator
{
    internal interface User
    {
        public void SendMessage(string message);
        public void Receive(string message);
    }
}
