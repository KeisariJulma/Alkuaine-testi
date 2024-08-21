using System;
using static FileReader;
using static Otantaominaisuus;
using static Hyvaksynta2;

public class Kayttoliittyma
{
    public static void Run(string[] args) // Renamed method to Run
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
                otantaominaisuus();
            }
            else if (args[0] == "-HyväksyntäV2")
            {
                Hyvaksynta2();
            }
        }
    }
}