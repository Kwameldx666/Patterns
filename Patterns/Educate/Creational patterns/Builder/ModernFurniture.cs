using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    class ModernFurniture : IFurnitureBuilder
    {
        private readonly Furniture _product = new();

        public Furniture Build()
        {
            return _product;
        }

        public IFurnitureBuilder SetChairCount(int count)
        {
            _product.ChairCount = count;
            return this;
        }

        public IFurnitureBuilder SetColor(string color)
        {
            _product.Color = color;
            return this;
        }

        public IFurnitureBuilder SetHasShelf(bool hasShelf)
        {
            _product.HasShelf = hasShelf;
            return this;
        }

        public IFurnitureBuilder SetInfo(string info)
        {
            _product.Info = info;
            return this;
        }

        public IFurnitureBuilder SetMaterial(string material)
        {
            _product.Material = material;
            return this;
        }

        public IFurnitureBuilder SetPrice(double price)
        {
            _product.Price = price;
            return this;
        }

        public IFurnitureBuilder SetTableCount(int count)
        {
            _product.TableCount = count;
            return this;
        }
    }
}
