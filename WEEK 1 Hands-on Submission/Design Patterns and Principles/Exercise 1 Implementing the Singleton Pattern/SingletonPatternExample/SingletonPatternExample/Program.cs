using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Logger\n");

            Logger logger1 = Logger.GetInstance();
            logger1.Log("message 1");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("message 2");

            if (logger1 == logger2)
            {
                Console.WriteLine("\nLogger is singleton, both instances are same.");
            }
            else
            {
                Console.WriteLine("\nLogger is not singleton. Instances are different.");
            }

            Console.ReadLine();
        }
    }
}
