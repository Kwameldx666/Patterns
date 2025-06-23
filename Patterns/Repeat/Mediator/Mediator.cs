using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Mediator
{
    internal abstract class Mediator
    {
        protected List<User> users;

        public Mediator()
        {
            users = new();
        }
        public void AddUser(User user) => users.Add(user);

        public abstract void SendMessage(string message, User user);
    }
}
