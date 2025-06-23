using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Chain_of_responsibility.Chain_of_respons
{
    internal class AdminHandler : GameAboutHouseHandler
    {
        public override bool Handle(string obj, Roles role)
        {
            if (role == Roles.Admin)
            {
                Console.WriteLine($"I Done {obj}(Admin)");
                return true;
            }
            return next?.Handle(obj, role) ?? false;

        }
    }
}
