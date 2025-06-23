using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Chain_of_responsibility.Chain_of_resp
{
    public class AuthorizationHandler : UserHandler
    {
        public AuthorizationHandler(UserHandler userHandler = null) : base(userHandler) { }

        public override void Handle(User user)
        {
            Console.WriteLine(user.Email.Length >= 4 ? "User good" : "Bad"); 
            if (next != null) next.Handle(user); 
            else
                Console.WriteLine("No one can to do it");
        }
    }
}
