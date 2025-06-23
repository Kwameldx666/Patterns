using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Structural_Patterns.Facade
{
    internal class NotificationService
    {
        public void NotifyUser(string order ,string message)
        {
            Console.WriteLine($"Notification sent to user: {message}");
        }
    }
}
