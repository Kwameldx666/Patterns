using Patterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewFolder
{
    class Mouse : IDevice
    {
        private readonly string _name;
        public string States { get; set; }

        public Mouse(string name)
        {
            _name = name;
        }

        public bool Start()
        {
            return true;
        }
    }
}
