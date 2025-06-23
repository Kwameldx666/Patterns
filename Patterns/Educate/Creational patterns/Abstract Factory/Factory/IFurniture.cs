using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public interface IFurniture
    {
        public IBed CreateBed();
        public IChair CreateChair();
        public ITable CrateTable();
    }
}
