using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID.D
{
    //Wrong
    public class JuniorEmployeee
    {
        public int GetSalary()
        {
            return 1000;
        }
    }

    public class SeniorEmployeee
    {
        public int GetSalary()
        {
            return 100340;
        }
    }

    public class PayrollService
    {
        private JuniorEmployeee _junior;
        private SeniorEmployeee _senior;

        public PayrollService(JuniorEmployeee junior, SeniorEmployeee senior)
        {
            _junior = junior;
            _senior = senior;
        }

        public int CalculateSalary()
        {
            if (_junior != null)
            {
                return _junior.GetSalary();
            }
            if (_senior != null)
            {
                return _senior.GetSalary();
            }
            return 0;
        }
    }

        //Correct

        // Интерфейс для работников, задающий контракт для получения зарплаты
        public interface IEmployee
        {

        int GetSalary();
        }

        // Реализация для младшего сотрудника
        public class JuniorEmployee : IEmployee
        {
            public int GetSalary()
            {
                return 1000;
            }
        }

        // Реализация для старшего сотрудника
        public class SeniorEmployee : IEmployee
        {
            public int GetSalary()
            {
                return 100340;
            }
        }

        // Класс, зависящий от абстракции IEmployee
        public class PayrollServicee
        {
            private readonly IEmployee _employee;

            public PayrollServicee(IEmployee employee)
            {
                _employee = employee;
            }

            public int CalculateSalaryA()
            {
                return _employee.GetSalary();
            }
        }

    }

