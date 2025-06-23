using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Mediator
{
    internal class Administrator : User
    {
        public string Name { get; set; }
        private Mediator mediator;
        public Administrator(string name,Mediator mediator)
        {
            Name = name;
            this.mediator = mediator;
        }
        public void SendMessage(string message)
        {
            mediator.SendMessage(message,this);
            Console.WriteLine(message + "From: " + Name);
        }

        public void Receive(string message)
        {
            Console.WriteLine("Receive To Name:" + Name);
        }
    }
}
