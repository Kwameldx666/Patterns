using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator
{
    internal class CapsLookDocumentDecorator:DocumentDecorator
    {
        public CapsLookDocumentDecorator(IDocument document) : base(document) { }

        public override string GetContent()
        {
            return _document.GetContent().ToUpper();
        }
    }
}
