namespace SOLIDLogger
{
    class Program
    {
        public static void Main()
        {
            Logger logger = new Logger();
            logger.Critical("Out of memory");
            logger.Info("Unused local variable 'name'");
        }
    }
}
