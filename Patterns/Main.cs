
using Patterns.Repeat.Chain_of_Responsibility;
using Patterns.Repeat.Flyweight_3_;
using Patterns.Repeat.Mediator;
using Patterns.Repeat.Memento2;
using Patterns.Repeat.Visitor2;

class Program
{
    static void Main()
    {
        Mediator med = new NewsMediator();
        User user = new Administrator("Miha", med);
        User user1 = new Administrator("Miha1", med);
        User user2 = new Administrator("Miha2", med);
        User user3 = new Administrator("Miha3", med);
        med.AddUser(user1);
        med.AddUser(user2);
        med.AddUser(user3);
        med.AddUser(user);
        user.SendMessage("Pizda");
    }
}