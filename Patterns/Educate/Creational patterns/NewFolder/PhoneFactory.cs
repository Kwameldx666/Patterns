using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewFolder
{
    public class PhoneFactory : FactoryDevices
    {
        private readonly string _name;
        public PhoneFactory(string name)
        {
            _name = name;
        }
        public override IDevice CreateDevice()
        {
            return new Phone(_name);
        }
    }
}

