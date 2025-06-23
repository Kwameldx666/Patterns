using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.State
{
    internal interface IUserState
    {
        public void Auth();
        public void BuyProduct(string product);
        public void TryToScam();
    }
}
