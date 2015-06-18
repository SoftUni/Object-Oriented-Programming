namespace SuperRpgGame.Exceptions
{
    using System;

    public class ObjectOutOfBoundsException : Exception
    {
        public ObjectOutOfBoundsException(string message)
            : base(message)
        {
        }
    }
}
