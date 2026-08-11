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

            if (firstLogger == secondLogger)
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
