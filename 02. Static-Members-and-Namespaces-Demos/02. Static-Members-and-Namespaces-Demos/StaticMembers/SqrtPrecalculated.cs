using System;

class SqrtPrecalculated
{
    public const int MaxValue = 10000;

    // Static field
    private static int[] sqrtValues;

    // Static constructor 
    static SqrtPrecalculated()
    {
        sqrtValues = new int[MaxValue + 1];
        for (int i = 0; i < sqrtValues.Length; i++)
        {
            sqrtValues[i] = (int)Math.Sqrt(i);
        }
    }

    // Static method 
    public static int GetSqrt(int value)
    {
        return sqrtValues[value];
    }

    // The Main() method is always static
    static void Main()
    {
        Console.WriteLine(SqrtPrecalculated.GetSqrt(254));
    }
}
