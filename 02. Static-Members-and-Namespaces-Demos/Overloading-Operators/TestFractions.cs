using System;

public class TestFractions
{
    public static void Main()
    {
        Fraction fr = new Fraction(56, 42);
        Fraction f1 = (double)1 / 4;
        Console.WriteLine("f1 = {0}", f1);
        Fraction f2 = (double)7 / 10;
        Console.WriteLine("f2 = {0}", f2);
        Console.WriteLine("-f1 = {0}", -f1);
        Console.WriteLine("f1 + f2 = {0}", f1 + f2);
        Console.WriteLine("f1 - f2 = {0}", f1 - f2);
        Console.WriteLine("f1 * f2 = {0}", f1 * f2);
        Console.WriteLine("f1 / f2 = {0}", f1 / f2);
        Console.WriteLine("f1 / f2 as double = {0}", (double)(f1 / f2));
        Console.WriteLine("-(f1+f2)*(f1-f2/f1) = {0}", -(f1 + f2) * (f1 - f2 / f1));
        Console.WriteLine("++f1 = {0}", ++f1);
    }
}
