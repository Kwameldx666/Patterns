using Patterns.Repeat.Factory_Method.Concrete_Product;
using Patterns.Repeat.Factory_Method.Creator;
using Patterns.Repeat.Factory_Method.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method.Concrete_Creator
{
    public class WordFactory:DocumentsFactory
    {
        public Document CreateDocument(string name)
        {
            return new WordDocument(name);
        }
    }
}
