using System;

public class Creature
{
    public Creature(string name)
    {
        this.Name = name;
    }

    protected string Name { get; private set; }

    private void Talk()
    {
        Console.WriteLine("I am creature ...");
    }

    protected void Walk()
    {
        Console.WriteLine("Walking, walking, walking ....");
    }
}
