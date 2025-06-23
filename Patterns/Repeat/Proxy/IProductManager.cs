using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Proxy
{
    internal interface IProductManager
    {
        public void AddProduct(string productName);
        public void RemoveProduct(string productName);
    }
}
