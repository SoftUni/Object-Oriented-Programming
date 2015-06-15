using System;
using System.Collections.Generic;
using System.Linq;

class PredicatesExample
{
    static void Main()
    {
        var elements = new List<int>()
        {
            40, 50, 60, 5, 10, 20, 30,
        };

        // Lambda expression with body
        var divisorsWithoutRemainder = elements
            .Where(delegate(int x)
            {
                return x % 3 == 0;
            });

        // Inline lambda expression
        divisorsWithoutRemainder = elements
            .Where(x => x % 3 == 0);

        // Passing method that is Func<int, bool>
        divisorsWithoutRemainder = elements
            .Where(DividesByThree);

        // Passing Func<int, bool> delegate
        Func<int, bool> dividesByThreePredicate = DividesByThree;
        divisorsWithoutRemainder = elements
            .Where(dividesByThreePredicate);

        Console.WriteLine(string.Join(", ", divisorsWithoutRemainder));
    }

    static bool DividesByThree(int num)
    {
        return num % 3 == 0;
    }
}
