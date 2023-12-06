namespace ChainOfResponsibilityLibrary.LoggingExample.Common
{
    public abstract class Logger
    {
        private readonly LogLevel loggerLevel;
        private Logger next;

        protected Logger(LogLevel loggerLevel)
        {
            this.loggerLevel = loggerLevel;
        }

        public Logger RegisterNext(Logger next)
        {
            this.next = next;

            return next;
        }

        public void Log(LogLevel level, string message)
        {
            if (loggerLevel <= level)
            {
                Write(message);
            }
            
            next?.Log(level, message);
        }
        
        protected abstract void Write(string message);
    }
}