using Patterns.Repeat.Abtract_Factory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abtract_Factory.AbstractFactory
{
    public abstract class Document
    {
        public abstract IBody CreateBode();
        public abstract IFooter CreateFooter();
        public abstract IHeader CreateHeader();
    }
}
