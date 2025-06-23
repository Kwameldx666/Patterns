using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID.O
{
    public class OCP
    {
        // OCP - Open/Closed Principle. Классы должны быть открыты для расширения, но закрыты для модификации.
        // В данном случае класс OCP не имеет никакой логики и не нарушает OCP, так как он не делает ничего лишнего.
        private List<Employee> _employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void GetSalary(object input)
        {
            _employees.Add((Employee)input);
            if (input is Employee)
            {
                
            }

        }
    }
        public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        }
        public class Director 
        {
            public decimal Bonus { get; set; }
        }
    }
