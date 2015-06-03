using System;
using Drawing = System.Drawing.Drawing2D;

namespace Matrices
{
    class Program
    {
static void TestTryFinally()
{
    Console.WriteLine("Code executed before try-finally.");
    try
    {
        string str = Console.ReadLine();
        int.Parse(str);
        Console.WriteLine("Parsing was successful.");
        return; // Exit from the current method
    }
    catch (FormatException)
    {
        Console.WriteLine("Parsing failed!");
    }
    finally
    {
        Console.WriteLine("This cleanup code is always executed.");
    }

    Console.WriteLine("This code is after the try-finally block.");
}
    }
}


