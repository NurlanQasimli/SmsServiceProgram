using _Example;


var smsService=new SMSService1();
UserManager usermanager = new(smsService);
usermanager.RegisterNewUser(new User
{
    Id=1,
    Name="Nurlan"
});
usermanager.RegisterNewUser(new User
{
    Id = 2,
    Name = "elnur"
});
usermanager.RegisterNewUser(new User
{
    Id = 3,
    Name = "Ramiz"
});
usermanager.EditUser(new User { Id = 2, Name = "Elnur" });

#region Interface_example

/*
IPersonVisualizer pv = new PersonVisualizer2();
Person p = new(pv)
{
    ID = 100,
    Name = "Nurlan",
    Surname = "Qasimli"
};
p.PrintPerson();
public class Person(IPersonVisualizer pv)
{
    private readonly IPersonVisualizer _pv = pv;

    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public void PrintPerson()
    {
        _pv.PrintPerson(this);
    }
}
public class PersonVisualizer1 : IPersonVisualizer
{
    public void PrintPerson(Person p)
    {
        Console.WriteLine($"{nameof(p.ID)}: {p.ID}");
        Console.WriteLine($"{nameof(p.Name)}: {p.Name}");
        Console.WriteLine($"{nameof(p.Surname)} :  {p.Surname}");
    }
}
public class PersonVisualizer2 : IPersonVisualizer
{
    public void PrintPerson(Person p)
    {
        Console.WriteLine($"Person {nameof(p.ID)} - {p.ID}");
        Console.WriteLine($"Person {nameof(p.Name)} - {p.Name}");
        Console.WriteLine($"Person {nameof(p.Surname)} - {p.Surname}");
    }
}
public interface IPersonVisualizer
{
    void PrintPerson(Person p);
}*/
#endregion

#region DifferenceInterfaceAndAbstractClass
public abstract class Animal
{
    private string? Color { get; set; }
    public void SetColor(string color)
    {
        Color = color;
    }
    public abstract int LegCount { get; set; }
    public void Go()
    {
        Console.WriteLine("Animal is moving...");
    }
    public abstract void MakeSound();

}
public class Dog : Animal,ICreature
{
    private int _legcount;
    public override int LegCount
    {
        get
        {
            return _legcount;
        }
        set { }
    }

    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Grow()
    {
        throw new NotImplementedException();
    }

    public override void MakeSound()
    {
        Console.WriteLine("Hav-Hav");
    }
}
public  interface ICreature
{
    string Name { get; set; }
    void Grow();
}
#endregion
