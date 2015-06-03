using System;

public class ExceptionsProperties
{
    public static void Main()
    {
        try
        {
            CauseFormatException();
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine("Exception caught: " + fe);
            Console.Error.WriteLine("\nMessage: " + fe.Message);
            Console.Error.WriteLine("\nStack Trace: " + fe.StackTrace);
        }
    }

    public static void CauseFormatException()
    {
        string str = "an invalid number";
        int.Parse(str);
    }
}
