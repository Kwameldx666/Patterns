using Patterns.Factory_Method.Employee;
using Patterns.SOLID.D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Factory
{
    class SeniorEmployeeFactory : FactoryMethod
    {

        private readonly string _name;
        private readonly int _stage;

        public SeniorEmployeeFactory(string name, int stage)
        {
            _name = name;
            _stage = stage;
        }

        public override IEmployee CreateFactory()
        {
            IEmployee employee = new Employee.SeniorEmployee(_name, _stage);
            return employee;
        }


    }
}
