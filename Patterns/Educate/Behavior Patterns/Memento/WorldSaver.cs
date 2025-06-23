using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Memento
{
    internal class WorldSaver
    {
        private Stack<CharacterMemento> story = new();
        public void Push(CharacterMemento c)
        {
            story.Push(c);
        }

        public CharacterMemento Pop()
        {
            if (story.Count > 0)
            {
                return story.Pop();
            }
            return null;
        }
    }
}
