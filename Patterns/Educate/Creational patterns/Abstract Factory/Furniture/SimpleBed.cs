using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    class SimpleBed : IBed
    {
        public void GoSleep()
        {
            Console.WriteLine("Sleep simple");
        }
    }
}
