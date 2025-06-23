using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator.Decorator2
{
    internal class LoggerDocument : DocumentDecorator
    {
        public LoggerDocument(IDocument document) : base(document) { }

        public override string GetDocument(string name)
        {
            return "[LOG]" + document.GetDocument(name);
        }
    }
}
