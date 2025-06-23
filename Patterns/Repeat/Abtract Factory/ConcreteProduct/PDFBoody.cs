using Patterns.Repeat.Abtract_Factory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abtract_Factory.ConcreteProduct
{
    public class PDFBoody : IBody
    {
        public void Render()
        {
            Console.WriteLine("Bode render pdf");
        }
    }
}
