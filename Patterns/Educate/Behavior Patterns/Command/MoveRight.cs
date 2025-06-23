using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    class MoveRight:Command
    {
        public MoveRight(Keyboards invoker) : base(invoker) { }
        public override void Execute()
        {
            invoker.MoveRight();
        }
        public override void Undo()
        {
           invoker.MoveLeft();
        }
    }
}
