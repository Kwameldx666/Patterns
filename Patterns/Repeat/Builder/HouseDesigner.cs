using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Builder
{
    public class HouseDesigner:IHouseBuilder     {
        private House house;
        public HouseDesigner()
        {
            house = new House();
        }
        public void BuildFoundation()
        {
            house.Floor = "Concrete Foundation";
        }
        public void BuildWalls()
        {
            house.Walls = "Brick Walls";
        }
        public void BuildRoof()
        {
            house.Roof = "Tile Roof";
        }
        public void BuildDoors()
        {
            house.Doors = "Wooden Doors";
        }
        public void BuildWindows()
        {
            house.Windows = "Double Glazed Windows";
        }
        public House GetHouse()
        {
            return house;
        }
    }
}
