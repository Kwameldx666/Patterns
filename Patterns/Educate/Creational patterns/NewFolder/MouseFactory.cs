using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewFolder
{
    public class MouseFactory:FactoryDevices
    {
        private readonly string _name;
        public MouseFactory(string name)
        {
            _name = name;  
        }
        public override IDevice CreateDevice()
        {
            return new Mouse(_name);
        }
    }
}
