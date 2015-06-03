using System;

public class HandlingExceptions
{
    public static void Main()
    {
        string str = Console.ReadLine();

        try
        {
            int.Parse(str);
            Console.WriteLine("You entered a valid Int32 number {0}.", str);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fit in Int32!");
        }
    }
}
