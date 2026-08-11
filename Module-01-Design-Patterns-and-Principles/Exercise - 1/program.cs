using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger firstLogger = Logger.GetInstance();
            firstLogger.Log("Application Started");

            Logger secondLogger = Logger.GetInstance();
            secondLogger.Log("User Logged In");

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
