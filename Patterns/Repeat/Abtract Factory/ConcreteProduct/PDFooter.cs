using Patterns.Repeat.Abtract_Factory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abtract_Factory.ConcreteProduct
{
    public class PDFooter : IFooter
    {
        public void Render()
        {
            Console.WriteLine("New footer pdf");
        }
    }
}
