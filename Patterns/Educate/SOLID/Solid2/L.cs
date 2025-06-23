using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.SOLID.Solid2
{
    public class L
    {
        public abstract class Book
        {
            public abstract void  Read();
            public abstract void BurnDown();
            public abstract void ClickToChangePage();
        }


        public class Book_ : Book
        {
            public override void Read()
            {
                Console.WriteLine("Reading the book.");
            }
            public override void BurnDown()
            {
                Console.WriteLine("Burning down the book.");
            }
            public override void ClickToChangePage()
            {
                throw new NotImplementedException("This method is not implemented yet.");
            }
        }


        public class EBook : Book
        {
            public override void Read()
            {
                Console.WriteLine("Reading the e-book.");
            }
            public override void BurnDown()
            {
               throw new NotImplementedException("E-books cannot be burned down.");
            }
            public override void ClickToChangePage()
            {
                Console.WriteLine("Changing page in the e-book.");
            }
    }



}

    public class  Correct 
    {
        
    }
}
