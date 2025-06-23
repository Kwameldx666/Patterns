using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Furniture
{
    public class ModernChair : IChair
    {
        public void Sitdown()
        {
            Console.WriteLine("Modern chair");
        }
    }
}
