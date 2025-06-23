using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewFolder
{
    class Phone:IDevice
    {
        private readonly string _name;

        public Phone(string name)
        {
            _name = name;
        }

        public bool Start() {
            return true;
        }
    }
}
