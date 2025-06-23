using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Factory
{
    class MiddleEmployeeFactory : FactoryMethod
    {

        private readonly string _name;
        private readonly int _stage;

        public MiddleEmployeeFactory(string name, int stage)
        {
            _name = name;
            _stage = stage;
        }

        public override IEmployee CreateFactory()
        {
            IEmployee employee = new MiddleEmployee(_name, _stage);
            return employee;
        }


    }
}
