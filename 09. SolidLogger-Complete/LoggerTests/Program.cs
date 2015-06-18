namespace LoggerTests
{
    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Formatters;

    class Program
    {
        public static void Main()
        {
            var simpleFormatter = new SimpleFormatter();
            var xmlFormatter = new XmlFormatter();
            // Create own formatter
            var jsonFormatter = new JsonFormatter();

            var fileAppender = new FileAppender(jsonFormatter, "log.txt");
            var consoleAppender = new ConsoleAppender(xmlFormatter);
            // Create own appender
            var sqlAppender = new SqlAppender(jsonFormatter);

            Logger logger = new Logger(consoleAppender, fileAppender);

            logger.Critical("Out of memory");
            logger.Info("Unused local variable 'name'");

            fileAppender.Close();
        }
    }
}
