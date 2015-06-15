using System;

public class ActionAndFunc
{
    static void Main()
    {
        Func<string, int> intParseFunction = int.Parse;
        int num = intParseFunction("10");

        Action<int> printNumberAction = Console.WriteLine;
        printNumberAction(num);

        Execute(intParseFunction, printNumberAction, "-50");
        Execute(double.Parse, Console.WriteLine, "3.14");

        Action<string, int> printNameAge = 
            (name, age) =>
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            };

        printNameAge("Pesho", 5);

        Func<string> magic = () =>
        {
            return "Magic";
        };

        Console.WriteLine(magic);
        Console.WriteLine(magic());
    }

    static void Execute<T1, T2>(Func<T1, T2> func, Action<T2> action, T1 value)
    {
        action(func(value));
    }
}
