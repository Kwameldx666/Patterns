using Patterns.Abstract_Factory.Furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class ModernRoom : IFurniture
    {
        public IBed CreateBed()
        {
            return new ModernBed();
        }

        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CrateTable()
        {
            return new TableModern();
        }
    }
}
