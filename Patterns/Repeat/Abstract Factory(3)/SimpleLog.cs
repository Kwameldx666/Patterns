using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_3_
{
    public class SimpleLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"Simple Log: {message}");
        }
    }
}
