using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Furniture
{
    public class SimpleChair : IChair
    {
        public void Sitdown()
        {
            Console.WriteLine("SimpleChair");
        }
    }
}
