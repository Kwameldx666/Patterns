using Patterns.Factory_Method.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Factory
{
    class JuniorEmployeeFactory: FactoryMethod
    {

        private readonly string _name;
        private readonly int _stage;

        public JuniorEmployeeFactory(string name, int stage)
        {
            _name = name;
            _stage = stage;
        }

        public override IEmployee CreateFactory()
        {
            IEmployee employee = new JuniorEmployee(_name, _stage);
            return employee;
        }


    }
}
