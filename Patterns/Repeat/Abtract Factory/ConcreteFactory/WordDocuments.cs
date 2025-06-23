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
    public class WordDocuments : Document
    {
        public override IBody CreateBode()
        {
            return new WordBody();
        }

        public override IFooter CreateFooter()
        {
            return new WordFooter();
        }

        public override IHeader CreateHeader()
        {
            return new WordHeader();
        }
    }
}
