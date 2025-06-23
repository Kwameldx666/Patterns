using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public abstract class Command
    {
        protected Keyboards invoker;
        public Command(Keyboards keyboards)
        {
            this.invoker = keyboards;
        }

        public abstract void Execute();

        public abstract void Undo();
    }
}
