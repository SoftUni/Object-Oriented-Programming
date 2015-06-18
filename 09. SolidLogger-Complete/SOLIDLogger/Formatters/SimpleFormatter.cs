namespace SOLIDLogger.Formatters
{
    using System;
    using Interfaces;

    public class SimpleFormatter : IFormatter
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            return string.Format("{0} - {1} - {2}", msg, level, date);
        }
    }
}
