using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator.Decorator2
{
    internal class EmailSenderDocumentDecorator : DocumentDecorator
    {
        public EmailSenderDocumentDecorator(IDocument document) : base(document) { }
        public override string GetDocument(string name)
        {
            return document.GetDocument(name) + "Send on email and" + "Someone oppened document " + name;
        }
    }
}
