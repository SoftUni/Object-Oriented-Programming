namespace SuperRpgGame.UI
{
    using System;
    using Interfaces;

    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
