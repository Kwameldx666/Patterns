using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method.Product
{
    public abstract class Document
    {
        protected string _name;
        public Document(string name) { _name = name; }

        public abstract void OpenDocument();
        public abstract void CloseDocument();
    }
}
