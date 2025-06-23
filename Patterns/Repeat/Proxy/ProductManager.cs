using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Proxy
{
    internal class ProductManager : IProductManager
    {

        public void AddProduct(string productName)
        {
            Console.WriteLine("Product added: " + productName);
        }

        public void RemoveProduct(string productName)
        {
           Console.WriteLine("Product removed: " + productName);
        }
    }
}
