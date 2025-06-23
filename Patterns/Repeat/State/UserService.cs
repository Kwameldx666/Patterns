using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.State
{
    internal class UserService
    {
        private IAtm currentState;

        public UserService() {  currentState =  new UnauthorizedUser(this); }
        public void SetState(IAtm state)
        {
            currentState = state;
        }

        public void Withdraw(int count)
        {
            Console.WriteLine(currentState.WithdrowMoney(count));
        }

        public void JoinAccount(string login,string password)
        {
            currentState.Authorize(login, password);    
        }
    }
}
