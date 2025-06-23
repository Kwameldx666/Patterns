using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Proxy
{
    internal class ProductProxy : IProductManager
    {
        private readonly IProductManager _manager;
        private string _role;

        public ProductProxy(string role, IProductManager manager)
        {
            _manager = manager;
            _role = role;
        }

        public void AddProduct(string productName)
        {
            if (_role != "admin")
            {
                Console.WriteLine("Access denied");
                return;
            }
            _manager.AddProduct(productName);

        }

        public void RemoveProduct(string productName)
        {
            if (_role != "admin")
            {
                Console.WriteLine("Access denied");
                return;
            }
            _manager.RemoveProduct(productName);
        }
    }
}
