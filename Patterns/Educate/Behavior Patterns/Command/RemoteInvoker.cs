using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class RemoteInvoker
    {
        private readonly Stack<Command> _stackHistory = new Stack<Command>();
        private Command _command;

        public void SetTask(Command command) => _command = command;
        public void Undo()
        {
            if (_stackHistory.Count != 0 && _command != null)
            {
                _command.Undo();
                _command = null;
                _stackHistory.Pop();
            }
            else 
                Console.WriteLine("I can't do it");
        }


        public void Execute()
        {
            _command.Execute(); _stackHistory.Push(_command);
        }
    }



}

