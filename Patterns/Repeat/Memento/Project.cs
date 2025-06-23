using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Memento
{
    internal class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCorrect { get; set; }

        public Project(string name, string description, bool isCorrect)
        {
            Name = name;
            Description = description;
            IsCorrect = isCorrect;
        }

        public void Undo(ProjectMemento memento)
        {
            Name = memento.Name;
            Description = memento.Description;
            IsCorrect = memento.IsCorrect;
        }
        public ProjectMemento Save()
        {
            return new ProjectMemento(Name, Description, IsCorrect);
        }
    }
}
