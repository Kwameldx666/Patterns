using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class ModernBed : IBed
    {
        public void GoSleep()
        {
            Console.WriteLine("Modern sleep)");
        }
    }
}
