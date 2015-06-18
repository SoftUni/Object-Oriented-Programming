namespace SOLIDLogger
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Logger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public List<IAppender> Appenders { get; set; }

        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel level)
        {
            var date = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.Append(msg, level, date);
            }
        }
    }
}
