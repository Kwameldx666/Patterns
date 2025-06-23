using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Memento
{
    internal class ProjectMemento
    {
        public string Name { get;  }
        public string Description { get;  }
        public bool IsCorrect { get;  }

        public ProjectMemento(string name, string description, bool isCorrect)
        {
            Name = name;
            Description = description;
            IsCorrect = isCorrect;
        }
    }
}
