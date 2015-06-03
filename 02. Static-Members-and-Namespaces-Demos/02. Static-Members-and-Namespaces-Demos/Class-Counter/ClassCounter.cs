using System;

public class ClassCounter
{
    public static void Main()
    {
        Person p = new Person("Pesho");
        Console.WriteLine("Person name: {0}", p.Name);

        Person g = new Person("Gosho");
        Console.WriteLine("Person name: {0}", g.Name);

        Console.WriteLine("Persons count: {0}", Person.PersonCounter);
    }
}
