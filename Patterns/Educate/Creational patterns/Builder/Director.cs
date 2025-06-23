using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    class Director
    {
        private readonly IFurnitureBuilder _builder;
        public Director(IFurnitureBuilder builder)
        {
            _builder = builder;
        }

        public void CreateRoom()
        {
            Furniture product =_builder.SetMaterial("Lak").SetPrice(12).Build() ;

            Console.WriteLine($"Я смделал продукт{product.Material}");
        }
    }
}
