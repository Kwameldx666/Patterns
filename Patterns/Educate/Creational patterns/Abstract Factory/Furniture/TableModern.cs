using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Furniture
{
    public class TableModern:ITable 
    {
        public void Info()
        {
            Console.WriteLine("Table modern");  
        }
    }
}
