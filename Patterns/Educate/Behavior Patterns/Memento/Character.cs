using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Memento
{
    internal class Character
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Skill { get; set; }

        public Character(string name, int age, string skill)
        {
            Name = name;
            Age = age;
            Skill = skill;
        }

        // Сохраняем состояние
        public CharacterMemento Save()
        {
            return new CharacterMemento(Name, Age, Skill);
        }

        // Восстанавливаем состояние
        public void Restore(CharacterMemento memento)
        {
            Name = memento.Name;
            Age = memento.Age;
            Skill = memento.Skill;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old, skilled in {Skill}.";
        }
    }
}
