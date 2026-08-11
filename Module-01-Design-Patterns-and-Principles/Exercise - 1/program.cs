using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var appLogger = new Logger();
            appLogger.Log("Application initialized");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("User Logged In");

            if (logger1 == logger2)
            {
                Console.WriteLine("Both objects are the same instance.");
            }
            else
            {
                Console.WriteLine("Different instances created.");
            }
        }
    }
}
