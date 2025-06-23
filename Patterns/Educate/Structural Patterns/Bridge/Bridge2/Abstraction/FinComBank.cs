using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge2.Abstraction
{
    public class FinComBank:Bank
    {
        public FinComBank(IDeveloper developer) : base(developer) { }

        public override void OpenSourceOfBank()
        {
            developer.WriteCode();
        }

    }
}
