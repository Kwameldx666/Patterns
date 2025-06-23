using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_3_
{
    public class Application
    {
        FactoryMessages messageFactory;
        ILog log;
        ISms sms;
        IMessage message1;

        public Application(FactoryMessages messageFactory1, ILog log, ISms sms, IMessage message1)
        {
            this.log = log;
            this.sms = sms;
            this.message1 = message1;
            this.messageFactory = messageFactory1;
        }

        public void CreateImporntant()
        {
            message1 =  messageFactory.CreateMessage();
            log =  messageFactory.CreateLog();
            sms = messageFactory.CreateSMS();
        }

        public void UseMethods()
        {
            message1.GetMessage();
            log.Log("Imba");
            sms.Send();
        }
    }
}
