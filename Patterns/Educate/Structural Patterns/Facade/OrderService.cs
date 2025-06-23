using Patterns.Educate.SOLID.Solid2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Facade
{
    internal class OrderService
    {
        public string CreateOrder(string product)
        {
            Console.WriteLine($"Order created for product: {product}");

            return product;
        }   
    }
}
