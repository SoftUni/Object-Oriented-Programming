public class Person
{
    private static int instanceCounter = 0;

    public Person(string name = null)
    {
        Person.instanceCounter++;
        this.Name = name;
    }

    public static int PersonCounter
    {
        get
        {
            return Person.instanceCounter;
        }
    }

    public string Name { get; set; }
}