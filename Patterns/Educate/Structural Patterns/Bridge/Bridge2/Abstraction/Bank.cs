using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge2.Abstraction
{
    public abstract class Bank
    {
        protected IDeveloper developer;
        protected Bank(IDeveloper developer)
        {
            this.developer = developer;
        }

        public abstract void OpenSourceOfBank();
            
    }
}
