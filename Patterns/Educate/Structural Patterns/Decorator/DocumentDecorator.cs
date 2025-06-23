using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator
{
    public class DocumentDecorator:IDocument
    {
        protected readonly IDocument _document;
        public DocumentDecorator(IDocument document)
        {
            _document = document;
        }
        public virtual string GetContent()
        {
            return _document.GetContent();
        }
    }
}
