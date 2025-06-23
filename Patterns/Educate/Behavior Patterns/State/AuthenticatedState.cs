using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.State
{
    internal class AuthenticatedState : IUserState
    {
        private readonly UserService _userService;
        public AuthenticatedState(UserService userService)
        {
            _userService = userService;
        }
        public void Auth()
        {
            Console.WriteLine("You are already authenticated");
        }
        public void BuyProduct(string product)
        {
            Console.WriteLine("You bought " + product);
        }
        public void TryToScam()
        {
            Console.WriteLine("You can't anymore to scam after being authenticated");
            _userService.SetState(new BannedState(_userService));
        }
    }
}
