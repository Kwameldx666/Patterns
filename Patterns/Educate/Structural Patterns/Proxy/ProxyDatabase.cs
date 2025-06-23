using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Proxy
{
    internal class ProxyDatabase : IProduct
    {
        private readonly ProductService _product;
        private Dictionary<string, IProduct> keyValuePairs = new();

        public ProxyDatabase(ProductService product)
        {
            _product = product;
        }

        public string GetProductData(string key)
        {
            if (!keyValuePairs.ContainsKey(key))
            {
                keyValuePairs.Add(key, _product);
                return _product.GetProductData(key);
            }
            Console.WriteLine("Data from hash table");
            return _product.GetProductData(key);
        }

    }
}
