using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Composite
{
    public class Employee : Graphic
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing Employee: {Name}, Salary: {Salary}");
        }

        public override void CountSalary()
        {
            Console.WriteLine($"Counting Salary for Employee: {Name}, Salary: {Salary}");
        }
    }
}


