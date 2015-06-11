using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, 
    AllowMultiple = true)]
public class AuthorAttribute : System.Attribute
{
	public string Name { get; private set; }

	public AuthorAttribute(string name)
	{
		this.Name = name;
	}
}

[Author("Svetlin Nakov")]
[Author("Bay Ivan")]
class CustomAttributesDemo
{
    static void Main(string[] args)
    {
        Type type = typeof(CustomAttributesDemo);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (AuthorAttribute authorAttribute in allAttributes)
        {
            Console.WriteLine("This class is written by {0}. ", authorAttribute.Name);
        }
    }
}
