using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.Behavior_Patterns.Chain_of_responsibility.Chain_of_resp
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return $"User: {Name}, Email: {Email}";
        }
    }
}
