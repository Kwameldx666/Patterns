using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.SOLID.Solid2
{
    public interface IBook
    {
        void Read();
        void ChangePage();
        void Tranlate();
    }


    

    public class Book : IBook
    {
        public void Read()
        {
            Console.WriteLine("Reading the book.");
        }
        public void ChangePage()
        {
            Console.WriteLine("Changing page in the book.");
        }
        public void Tranlate()
        {
            Console.WriteLine("Translating the book.");
        }
    }

    public class EBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("Reading the e-book.");
        }
        public void ChangePage()
        {
            Console.WriteLine("Changing page in the e-book.");
        }
        public void Tranlate()
        {
            Console.WriteLine("Translating the e-book.");
        }
    }

    public class BookService
    {
        private readonly IBook _book;
        public BookService(IBook book)
        {
            _book = book;
        }
        public void ReadBook()
        {
            _book.Read();
        }
        public void ChangePage()
        {
            _book.ChangePage();
        }
        public void Translate()
        {
            _book.Tranlate();
        }
    }

}
