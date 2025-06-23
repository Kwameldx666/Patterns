using Patterns.Repeat.Factory_Method.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Factory_Method.Creator
{
    public  interface DocumentsFactory
    {
        public Document CreateDocument(string name);
    }
}
