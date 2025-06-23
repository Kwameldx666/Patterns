using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.SOLID.SRP
{
    //Нарушение SRP принципа
    class StudentWrong
    {
        public string Name { get; set; }
        public string Hobby { get; set; }
        public string Book { get; set; }

        public StudentWrong(string Name, string Hobby)
        {
            this.Name = Name;
            this.Hobby = Hobby;
        }

        public void ReadBook(string Book)
        {
            Console.WriteLine($"My name is {this.Name} and I'm reading the book:" + Book);
        }

        public void DrawPicture()
        {
            Console.WriteLine($"I'm driwing about my {this.Hobby}");
        }

        public void WriteHomeworkAboutMe(string Book)
        {
            Console.WriteLine($"Writing...My Name is {Name} and I love reading {Book}.My hobby is {Hobby}");
        }


        //так наш класс может очень долго расширяться и заполняться самыми различными методами и данными. Поэтому на стоит разделить всё по принципу ответственности.
    }


    public class StudentData
    {
        public string? Name { get; set; }
        public string? Book { get; set; }
        public string? Hobby { get; set; }
    }

    public class StudentRightResponsibilities
    {
        private StudentData _student;
        public StudentRightResponsibilities(StudentData student)
        {
            _student = student;
        }

        public void WriteHomeworkAboutMe()
        {
            Console.WriteLine($"Writing...My Name is {_student.Name} and I love reading {_student.Book}.My hobby is {_student.Hobby}");
        }
    }

    public class StudentActivities
    {
        private StudentData _student;
        public StudentActivities(StudentData student)
        {
            _student = student;
        }

        public void ReadBook()
        {
            Console.WriteLine($"My name is {_student.Name} and I'm reading the book: {_student.Book}");
        }

        public void DrawPicture()
        {
            Console.WriteLine($"I'm drawing about my {_student.Hobby}");
        }
    }
}