using System;

public abstract class Figure
{
    public virtual void Draw()
    {
        Console.WriteLine(
            "I am a figure of unknown kind: {0}",
            this.GetType().Name);
    }
}
