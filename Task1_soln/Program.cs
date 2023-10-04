using System;

public class Logger
{
    // Private static instance of the Logger class.
    private static Logger? instance;

    // Private constructor to prevent external instantiation.
    private Logger()
    {
    }

    // Public property to get the single instance of the Logger.
    public static Logger Instance
    {
        get
        {
            // If the instance is null, create a new one.
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    // Public method to log messages.
    public void Log(string message)
    {
        // Print the message to the console.
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the Logger instance.
        Logger logger = Logger.Instance;

        // Log some messages.
        logger.Log("Log message is here");
        logger.Log("And this is another log messgae");

    }
}

