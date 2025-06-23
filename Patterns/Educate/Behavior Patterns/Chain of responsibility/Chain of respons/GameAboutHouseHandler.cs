using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Chain_of_responsibility.Chain_of_respons
{
    internal class GameAboutHouseHandler
    {
        protected GameAboutHouseHandler next;

        public void Setnext(GameAboutHouseHandler next) => this.next = next;

        public virtual bool Handle(string obj, Roles role)
        {
            return next?.Handle(obj, role) ?? false;
        }
    }
}
