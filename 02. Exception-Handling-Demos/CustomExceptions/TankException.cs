using System;

namespace CustomExceptions
{
    public class TankException : Exception
    {
        public TankException(string msg)
            : base(msg)
        {
        }
    }
}
