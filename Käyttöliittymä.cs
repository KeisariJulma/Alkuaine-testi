using System;
using static FileReader;

public static class Käyttöliittymä
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Ohjelma käynnistettiin ilman komentoriviparametreja.");
        }
        else
        {
            if (args[0] == "x")
            {
                Console.WriteLine("Ohjelma lopetetaan.");
                return;
            }
            else if (args[0] == "-help" || args[0] == "-h")
            {
                Console.WriteLine("Apu");
                Console.WriteLine("p: Pelaa");
                Console.WriteLine("t: Pisteet");
                Console.WriteLine("-readfile: Lue tiedosto");
                Console.WriteLine("x: Lopeta ohjelma.");
                Console.WriteLine("quit, exit, q, x: Lopeta ohjelma.");
            }
            else if (args[0] == "p")
            {
                Console.WriteLine("Peli alkaa.");
            }
            else if (args[0] == "t")
            {
                Console.WriteLine("Pisteet");
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
}