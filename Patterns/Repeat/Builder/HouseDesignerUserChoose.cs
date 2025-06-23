using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Builder
{
    public class HouseDesignerUserChoose:IHouseBuilder
    {
        private House house;
        public HouseDesignerUserChoose()
        {
            house = new House();
        }
        public void BuildFoundation()
        {
            Console.WriteLine("Enter the type of foundation:");
            house.Floor = Console.ReadLine();
        }
        public void BuildWalls()
        {
            Console.WriteLine("Enter the type of walls:");
            house.Walls = Console.ReadLine();
        }
        public void BuildRoof()
        {
            Console.WriteLine("Enter the type of roof:");
            house.Roof = Console.ReadLine();
        }
        public void BuildDoors()
        {
            Console.WriteLine("Enter the type of doors:");
            house.Doors = Console.ReadLine();
        }
        public void BuildWindows()
        {
            Console.WriteLine("Enter the type of windows:");
            house.Windows = Console.ReadLine();
        }
        public House GetHouse()
        {
            return house;
        }
    }
}
