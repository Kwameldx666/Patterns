using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Employee
{
    class SeniorEmployee : IEmployee
    {
        private readonly string _name;
        public string Name => _name;

        public SeniorEmployee(string name, decimal stage)
        {
            _name = name;
            this.Stage = stage;
        }

        public decimal Stage { get; set; }

        public int Salary()
        {
            return Convert.ToInt32(Stage * 500);
        }
    }
}
