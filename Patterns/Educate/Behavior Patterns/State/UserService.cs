using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.State
{
    internal class UserService
    {
        private IUserState _userState;

        private ScammerState _scammerState;
        private AuthenticatedState _authenticatedState;
        private BannedState _bannedState;
        public UserService()
        {
            _scammerState = new(this);
            _authenticatedState = new(this);
            _bannedState = new(this) ;
            _userState = new NoAuthenticatedState(this);

        }



        public void SetState(IUserState userState)
        {
            _userState = userState;
        }
        public UserService(IUserState userState) { _userState = userState; }

        public void Auth() => _userState.Auth();
        public void BuyProduct(string product) => _userState.BuyProduct(product);
        public void TryToScam() => _userState.TryToScam();

    }
}
