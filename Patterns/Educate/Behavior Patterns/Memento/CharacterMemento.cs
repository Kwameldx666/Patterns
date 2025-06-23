using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Memento
{
    internal class CharacterMemento
    {
        public string Name { get; }
        public int Age { get; }
        public string Skill { get; }

        public CharacterMemento(string name, int age, string skill)
        {
            Name = name;
            Age = age;
            Skill = skill;
        }
    }
}
