using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_3_
{
    public class ImportantSms : ISms
    {
        public void Send()
        {
            Console.WriteLine("Important SMS sent!");
        }
    }


    public class ImportantMessage : IMessage
    {
        public void GetMessage()
        {
            Console.WriteLine("Important message received!");
        }
    }

    public class ImportantLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}

