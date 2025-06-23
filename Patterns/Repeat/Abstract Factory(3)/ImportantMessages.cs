using Patterns.Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_3_
{
    public class ImportantMessages : FactoryMessages
    {
        public override ILog CreateLog()
        {
            return new ImportantLog();
        }

        public override IMessage CreateMessage()
        {
            return new ImportantMessage();
        }

        public override ISms CreateSMS()
        {
            return new ImportantSms();
        }
    }
}
