using Patterns.Repeat.Abtract_Factory.AbstractFactory;
using Patterns.Repeat.Abtract_Factory.AbstractProduct;
using Patterns.Repeat.Abtract_Factory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abtract_Factory.ConcreteFactory
{
    public class PdfDocuments: Document
    {
        public override IBody CreateBode()
        {
            return new PDFBoody();
        }

        public override IFooter CreateFooter()
        {
          return new PDFooter();    
        }

        public override IHeader CreateHeader()
        {
            return new PDFHeader();
        }
    }
}
