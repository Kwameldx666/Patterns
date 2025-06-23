using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class MoveLeft : Command
    {
        public MoveLeft(Keyboards invoker) : base(invoker) { }
        public override void Execute()
        {
            invoker.MoveLeft();
        }
        public override void Undo()
        {
            invoker.MoveRight();
        }
    }
}
