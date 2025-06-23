using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Proxy
{
    internal class ProductService : IProduct
    {
        public string GetProductData(string key)
        {
            //Get data grom database*/
            return "All the data:" + key;
        }
    }
}
