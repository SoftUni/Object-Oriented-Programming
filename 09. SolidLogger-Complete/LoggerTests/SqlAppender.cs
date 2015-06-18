namespace LoggerTests
{
    using System;
    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Interfaces;

    public class SqlAppender : Appender
    {
        public SqlAppender(IFormatter formatter)
            : base(formatter)
        {
        }

        public override void Append(string msg, ReportLevel level, DateTime date)
        {
            // TODO: ...
        }
    }
}
