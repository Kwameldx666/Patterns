using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.State
{
    internal class BannedState : IUserState
    {
        private readonly UserService _userService;
        public BannedState(UserService userService)
        {
            _userService = userService;
        }
        public void Auth()
        {
            Console.WriteLine("[BAN]Write to support center to give information about your BAN");
        }

        public void BuyProduct(string product)
        {
            Console.WriteLine("You cannot buy products while banned");
        }

        public void TryToScam()
        {
            _userService.SetState(new ScammerState(_userService));
        }
    }
}
