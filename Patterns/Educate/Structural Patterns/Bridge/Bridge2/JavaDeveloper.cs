using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge2
{
    public class JavaDeveloper:IDeveloper
    {
        public void WriteCode()
        {
            Console.WriteLine("I'm writing java code");
        }
    }
}
