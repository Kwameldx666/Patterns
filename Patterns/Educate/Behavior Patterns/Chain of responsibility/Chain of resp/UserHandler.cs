using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Chain_of_responsibility.Chain_of_resp
{
    public abstract class UserHandler
    {
        protected UserHandler next;
        protected UserHandler(UserHandler next)
        {
            this.next = next;
        }

        public abstract void Handle(User user);
    }
}
