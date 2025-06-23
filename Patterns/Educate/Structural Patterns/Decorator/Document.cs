using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator
{
    internal class Document:IDocument
    {
        public string GetContent()
        {
            return "This is a document content.";
        }
    }
}
