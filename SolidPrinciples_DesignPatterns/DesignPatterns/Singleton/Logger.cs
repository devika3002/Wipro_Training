namespace DesignPatterns.Singleton
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance =
            new Lazy<Logger>(() => new Logger());

        private Logger()
        {
        }

        public static Logger Instance
        {
            get { return _instance.Value; }
        }

        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
}