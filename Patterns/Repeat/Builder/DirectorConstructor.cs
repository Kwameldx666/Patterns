using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Builder
{
    public class DirectorConstructor
    {
        private readonly IHouseBuilder houseBuilder;
        public DirectorConstructor(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }
        public House ConstructHouse()
        {
            houseBuilder.BuildFoundation();
            houseBuilder.BuildWalls();
            houseBuilder.BuildRoof();
            houseBuilder.BuildDoors();
            houseBuilder.BuildWindows();
            return houseBuilder.GetHouse();
        }
    }
}
