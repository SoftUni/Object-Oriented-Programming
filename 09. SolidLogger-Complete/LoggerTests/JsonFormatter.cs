using SOLIDLogger;
namespace LoggerTests
{
    using System;
    using System.Text;
    using SOLIDLogger.Interfaces;

    public class JsonFormatter : IFormatter
    {
        public int Limit { get; set; }

        public string Format(string msg, ReportLevel level, DateTime date)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("{");
            output.AppendLine(string.Format("  \"text\" : \"{0}\"", msg));
            output.AppendLine(string.Format("  \"level\" : \"{0}\"", level));
            output.AppendLine(string.Format("  \"date\" : \"{0}\"", date));
            output.AppendLine("}");

            return output.ToString();
        }
    }
}
