using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Memento
{
    internal class GitRepository
    {
        private Stack<ProjectMemento> mementos = new Stack<ProjectMemento>();

        public void Push(ProjectMemento memento)
        {
            this.mementos.Push(memento);
            Console.WriteLine(memento.IsCorrect + "[PUSH]");
        }

        public ProjectMemento Pop()
        {
            if (mementos.Count > 0) {
                var pr = mementos.Pop();
                Console.WriteLine(pr.IsCorrect + "[Pop]");
                return pr;
            }
            Console.WriteLine("Stack is empty");
            return null;
        }
    }
}
