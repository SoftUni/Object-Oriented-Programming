using System;

public abstract class Animal : IComparable<Animal>
{
    // Abstract methods --> should be implemented in the child classes
    public abstract int Speed { get; }

    public abstract string GetName();

    // Non-abstract method
    public override string ToString()
    {
        return "I am " + this.GetName();
    }

    // Interface method
    public int CompareTo(Animal other)
    {
        return this.Speed.CompareTo(other.Speed);
    }
}
