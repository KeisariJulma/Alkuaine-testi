using System;
using static FileReader;

class Alkemisti
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Ohjelma käynnistettiin ilman komentoriviparametreja.");
        }
        else
        {
            if (args[0] == "quit" || args[0] == "exit" || args[0] == "q" || args[0] == "x" || args[0] == "-x" || args[0] == "-q" || args[0] == "-quit" || args[0] == "-exit")
            {
                Console.WriteLine("Ohjelma lopetetaan.");
                return;
            }
            if (args[0] == "-help" || args[0] == "-h")
            {
                Console.WriteLine("Apu");
                Console.WriteLine("p: Pelaa");
                Console.WriteLine("t: Pisteet");
                Console.WriteLine("quit, exit, q, x: Lopeta ohjelma.");
            }
            else if (args[0] == "-readfile")
            {
                if (args.Length < 2)
                {
                    Console.WriteLine("Anna tiedoston nimi.");
                }
                else
                {
                    string fileName = args[1];
                    List<string> lines = ReadFileToList(fileName);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}§