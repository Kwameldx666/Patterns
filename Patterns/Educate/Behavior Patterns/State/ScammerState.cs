using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.State
{
    internal class ScammerState : IUserState
    {
        private readonly UserService _userService;
        public ScammerState(UserService userService)
        {
            _userService = userService;
        }
        public void Auth()
        {
            Console.WriteLine("DUTE in PULA");
        }

        public void BuyProduct(string product)
        {
          Console.WriteLine("Great, pls don't continue to be a scammer. Take your product: " + product);
            _userService.SetState(new AuthenticatedState(_userService));
        }

        public void TryToScam()
        {
            Console.WriteLine("You can't anymore to scam");
            _userService.SetState(new BannedState(_userService));
        }
    }
}
