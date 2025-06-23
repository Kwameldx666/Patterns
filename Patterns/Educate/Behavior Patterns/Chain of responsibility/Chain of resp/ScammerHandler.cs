using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Chain_of_responsibility.Chain_of_resp
{
    public class ScammerHandler : UserHandler
    {
        public ScammerHandler(UserHandler next = null) : base(next) { }
        public override void Handle(User user)
        {
            if (user != null)
            {
                Console.WriteLine(user?.Email != null ? "User good no scamer" : "bad");
            }
            if (next != null) { next.Handle(user); }

        }
    }
}
