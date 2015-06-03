using System;

public class IndexerExample
{
    public static void Main()
    {
        BitArray32 bits = new BitArray32();

        bits[0] = 1;
        bits[5] = 1;
        bits[5] = 0;
        bits[25] = 1;
        bits[31] = 1;

        for (int i = 0; i <= 31; i++)
        {
            Console.WriteLine("arr[{0}] = {1}", i, bits[i]);
        }

        Console.Write("bits = ");
        for (int i = 0; i <= 31; i++)
        {
            Console.Write(bits[i]);
        }

        Console.WriteLine();
    }
}