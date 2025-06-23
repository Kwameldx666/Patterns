using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public interface IFurnitureBuilder
    {
        IFurnitureBuilder SetChairCount(int count);
        IFurnitureBuilder SetTableCount(int count);
        IFurnitureBuilder SetHasShelf(bool hasShelf);
        IFurnitureBuilder SetMaterial(string material);
        IFurnitureBuilder SetColor(string color);
        IFurnitureBuilder SetPrice(double price);
        IFurnitureBuilder SetInfo(string info);
        Furniture Build();
    }

}
