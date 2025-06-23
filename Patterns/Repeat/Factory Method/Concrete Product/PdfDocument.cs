using Patterns.Repeat.Factory_Method.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Document = Patterns.Repeat.Factory_Method.Product.Document;

namespace Patterns.Repeat.Factory_Method.Concrete_Product
{
    public class PdfDocument:Document
    {
        public PdfDocument(string name) : base(name) { }
        public override void OpenDocument()
        {
            Console.WriteLine($"PDFDocument {_name} was oppened");
        }
        public override void CloseDocument()
        {
            Console.WriteLine($"PDFDocument {_name} was closed");
        }
    }
}
