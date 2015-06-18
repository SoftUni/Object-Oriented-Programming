namespace SOLIDLogger
{
    using System;

    public class Logger
    {
        public void Info(string msg)
        {
            var date = DateTime.Now;
            Console.WriteLine("{0} - {1} - {2}", date, ReportLevel.Info, msg);
        }

        public void Warn(string msg)
        {
            var date = DateTime.Now;
            Console.WriteLine("{0} - {1} - {2}", date, ReportLevel.Info, msg);
        }

        public void Error(string msg)
        {
            var date = DateTime.Now;
            Console.WriteLine("{0} - {1} - {2}", date, ReportLevel.Info, msg);
        }

        public void Critical(string msg)
        {
            var date = DateTime.Now;
            Console.WriteLine("{0} - {1} - {2}", date, ReportLevel.Info, msg);
        }

        public void Fatal(string msg)
        {
            var date = DateTime.Now;
            Console.WriteLine("{0} - {1} - {2}", date, ReportLevel.Info, msg);
        }
    }
}
