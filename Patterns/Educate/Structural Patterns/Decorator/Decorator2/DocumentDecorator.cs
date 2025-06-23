using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator.Decorator2
{
    internal abstract class DocumentDecorator :IDocument
    {
        protected IDocument document;
        protected DocumentDecorator(IDocument document) { this.document = document; }

        public virtual string GetDocument(string name) => this.document.GetDocument(name);
    }
}
