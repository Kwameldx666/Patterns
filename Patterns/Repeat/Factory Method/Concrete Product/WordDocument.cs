using Patterns.Repeat.Factory_Method.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method.Concrete_Product
{
    public class WordDocument:Document
    {
        public WordDocument(string name) : base(name) { }

        public override void CloseDocument()
        {
            Console.WriteLine($"WordDocument {_name} was closed");
        }
        public override void OpenDocument()
        {
            Console.WriteLine($"WordDocument {_name} was openned");
        }
    }
}
