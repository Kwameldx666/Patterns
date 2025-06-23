using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.State
{
    internal interface IAtm
    {
        bool WithdrowMoney(int count);
        void Authorize(string login,string password);
    }
}
