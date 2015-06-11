namespace GenericStack
{
    using System;

    static class Program
    {
        static void Main()
        {
            var stack = new Stack<string>();
            stack.Push("Main()");
            stack.Push("Stack.Pop()");
            stack.Push("Aggregate()");

            Console.WriteLine(stack);
            Console.WriteLine(stack.Count);
        }
    }
}
