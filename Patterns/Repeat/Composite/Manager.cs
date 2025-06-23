using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Composite
{
    public class Manager: Graphic
    {

        public string Name { get; set; }
        public int Salary { get; set; }
        public Manager(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        // Manager can have multiple subordinates (Employees or other Managers)
        public List<Graphic> Subordinates { get; set; } = new List<Graphic>();
        public override void Draw()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {Salary}");
            Console.WriteLine("Drawing Manager");
            foreach (var subordinate in Subordinates)
            {
                subordinate.Draw();
            }
        }
        
        public override void Add(Graphic graphic)
        {
            Subordinates.Add(graphic);
        }

        public override void Remove(Graphic graphic)
        {
            Subordinates.Remove(graphic);
        }
        public override void CountSalary()
        {
            int totalSalary = Salary;
            foreach (var subordinate in Subordinates)
            {
                subordinate.CountSalary();
                if (subordinate is Employee e)
                    totalSalary += e.Salary;
                else if (subordinate is Manager m)
                {
                    // Рекурсивно считаем зарплату всех подчинённых менеджеров
                    m.CountSalary(); 
                    totalSalary += m.Salary;
                }
            }
            Console.WriteLine($"Total Salary in group managed by {Name}: {totalSalary}");
        }
    }

}
