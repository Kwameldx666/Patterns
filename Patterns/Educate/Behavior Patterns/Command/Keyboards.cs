using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{

    //Receiver

    public class Keyboards
    {
        public void MoveRight() { Console.WriteLine("Move right"); }
        public void MoveLeft() { Console.WriteLine("Move left"); }
        public void MoveUp() { Console.WriteLine("Move up"); }
        public void MoveDown() { Console.WriteLine("Move down"); }
    }
}
