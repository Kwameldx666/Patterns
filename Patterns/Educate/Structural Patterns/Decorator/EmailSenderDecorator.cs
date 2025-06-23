using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator
{
    internal class EmailSenderDecorator:DocumentDecorator
    {
        public EmailSenderDecorator(IDocument document) : base(document) { }

        public override string GetContent()
        {
            return "\n" + _document.GetContent() + "[EMAIL]Вы получили новый документ!";
        }
    }
}
