using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    internal interface IEmployee
    {
         string Name { get; }
         decimal Stage { get; set; }
         int Salary();

    }
}
