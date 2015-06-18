namespace SOLIDLogger.Interfaces
{
    using System;

    public interface IFormatter
    {
        string Format(string msg, ReportLevel level, DateTime date);
    }
}
