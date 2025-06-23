using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_3_
{
    public abstract class FactoryMessages
    {
        public abstract ILog CreateLog();
        public abstract IMessage CreateMessage();
        public abstract ISms CreateSMS();
    }
}
