using System;

public class Dog : Mammal
{
    public Dog(int age, string breed)
        : base(age)
    {
        this.Breed = breed;
    }

    public string Breed { get; set; }

    public void WagTail()
    {
        Console.WriteLine("Tail wagging...");
    }
}
