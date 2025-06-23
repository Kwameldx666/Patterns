using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Decorator.Decorator2
{
    internal class SimpleDocument: IDocument
    {
        public string GetDocument(string name)
        {
            return " Document ";
        }
    }
}
