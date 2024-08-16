using System;

class Alkemisti
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No command-line arguments provided.");
        }
        else
        {
            if (args[0] == "quit" || args[0] == "exit" || args[0] == "q")
            {
                Console.WriteLine("Exiting program.");
                return;
            }
            if (args[0] == "-help" || args[0] == "-h")
            {
                Console.WriteLine("Help menu:");
                Console.WriteLine("quit, exit, q: Exit the program.");
                Console.WriteLine("help, h: Display this help menu.");
                return;
            }
            Console.WriteLine("Unknown command-line argument.");
        }
    }
}