namespace SOLIDLogger.Interfaces
{
    using System;

    public interface IAppender
    {
        IFormatter Formatter { get; }

        void Append(string msg, ReportLevel level, DateTime date);
    }
}
