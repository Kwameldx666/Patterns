using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.State
{
    internal class AuthorizedState : IAtm
    {
        private UserService userserv;
        public AuthorizedState(UserService userserv) { this.userserv = userserv; }
        string Name { get; }
        public int balance { get; private set; } = 500; 
        public bool WithdrowMoney(int count)
        {
            if(count <  balance) return true;
            return false;
        }

        public void Authorize(string login, string password)
        {
            Console.WriteLine("You already joinned into your account");
        }
    }
}
