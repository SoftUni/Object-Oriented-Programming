using System;

public class Mammal
{
    public Mammal(int age)
    {
        this.Age = age;
    }

    public int Age { get; set; }

    public void Sleep()
    {
        Console.WriteLine("Shhh! I'm sleeping!");
    }
}
