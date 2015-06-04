using System;

public class Mammal : Creature
{
    public Mammal(string name, int age)
        : base(name)
    {
        this.Age = age;
    }

    public int Age { get; set; }

    public void Sleep()
    {
        Console.WriteLine("Shhh! {0} is sleeping!", this.Name);
    }
}
