using Patterns.Educate.Structural_Patterns.Composite2.Component;
using Patterns.Educate.Structural_Patterns.Composite2.Composite;
using Patterns.Educate.Structural_Patterns.Composite2.Leaf;

class Program
{
    static void Main()
    {


        Graphic box = new Box("Posta");
        Graphic box2 = new Box("Mail");
        Graphic pr = new Product("mail");
        Graphic pr2 = new Product("sms");
        Graphic pr3 = new Product("meow");
        Graphic pr4 = new Product("secret");
        box2.Add(pr); box2.Add(pr2); box2.Add(pr3);

        box.Add(box2);
        box.Add(pr4);
        box.ShowGraphic();


    }

}