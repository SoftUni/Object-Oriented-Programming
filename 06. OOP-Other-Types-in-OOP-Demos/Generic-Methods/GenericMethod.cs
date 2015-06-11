using System;

class GenericMethod
{
    static void Main()
    {
        int i = 5;
        int j = 7;
        int min = Min(i, j); // The same like Min<int>(i, j);
        Console.WriteLine("Min({0}, {1}) = {2}", i, j, min);

        string firstString = "Rakiya";
        string secondString = "Beer";
        string minString = Min(firstString, secondString);
        Console.WriteLine("Min({0}, {1}) = {2}", firstString, secondString, minString);

        //Point p1 = new Point();
        //Point p2 = new Point();
        //Point minPoint = Min(p1, p2); // This will not compile

        string[] strings = CreateArray("hello", 5);
        Console.WriteLine(String.Join(", ", strings));
    }

    public static T[] CreateArray<T>(T value, int count)
    {
        T[] arr = new T[count];
        for (int i = 0; i < count; i++)
        {
            arr[i] = value;
        }

        return arr;
    }

    public static T Min<T>(T first, T second)
        where T : IComparable<T>
    {
        if (first.CompareTo(second) <= 0)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}
