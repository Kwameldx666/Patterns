using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SRP - Single Responsibility Principle.Отвечает за то, что класс должен иметь только одну причину для изменения.
// В данном случае класс S не имеет никакой логики и не нарушает SRP, так как он не делает ничего лишнего.

namespace Patterns.SOLID.SRP
{
    public class IncorectExempдCalculatorAandBModel
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Result { get; set; }
        public void Calculate()
        {
            Result = A + B;
        }
        public void PrintResult()
        {
            Console.WriteLine($"Result: {Result}");
        }
    }


    public class CorrectExemppStudentModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Group: {Group}");
        }
    }

    public class CorrectExemppStudentGroupService
    {
        public void ChangeGroup(CorrectExemppStudentModel student, string newGroup)
        {
            student.Group = newGroup;
            Console.WriteLine($"Group changed to: {student.Group}");
        }
    }

    public class CorrectExemppStudentSmsSenderService
    {
        public void SendEmail(CorrectExemppStudentModel student, string message)
        {
            Console.WriteLine($"Sending email to {student.Email}: {message}");
        }

    }
}
