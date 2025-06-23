using Patterns.Abstract_Factory.Furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Factory
{
    class SimpleRoom : IFurniture
    {
        public IBed CreateBed()
        {
            return new SimpleBed();
        }

        public IChair CreateChair()
        {
            return new SimpleChair();
        }

        public ITable CrateTable()
        {
            return new TableSimple();
        }
    }
}
