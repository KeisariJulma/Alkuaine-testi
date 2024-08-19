using System;



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
                Console.WriteLine("-help, -h: Näytä tämä ohje.");
                return;
            }

            if (args[0] == "p")
            {
                Console.WriteLine("Pelaa");
                return;
            }

            if (args[0] == "t")
            {
                Console.WriteLine("Pisteet");
                return;
            }

            Console.WriteLine("Tuntematon komento.");
        }
    }
}