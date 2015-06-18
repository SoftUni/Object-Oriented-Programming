namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(IFormatter formatter)
            : base(formatter)
        {
        }

        public override void Append(string msg, ReportLevel level, DateTime date)
        {
            var output = this.Formatter.Format(msg, level, date);
            Console.WriteLine(output);
        }
    }
}
