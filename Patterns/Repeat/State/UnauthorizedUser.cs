using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.State
{
    internal class UnauthorizedUser : IAtm
    {
        private UserService userserv;
        public UnauthorizedUser(UserService userserv) { this.userserv = userserv; }
        public bool WithdrowMoney(int count)
        {
            Console.WriteLine("Pls join now and then repeat action");
            return false;
        }

        public void Authorize(string login, string password)
        {
            if (login.Length > 0 && password == "123")
            {
                userserv.SetState(new AuthorizedState(userserv));
            }
        }
    }
}
