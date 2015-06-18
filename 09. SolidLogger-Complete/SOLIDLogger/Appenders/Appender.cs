namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public IFormatter Formatter { get; private set; }

        public abstract void Append(string msg, ReportLevel level, DateTime date);
    }
}
