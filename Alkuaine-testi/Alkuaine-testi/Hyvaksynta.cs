using System;
using System.Collections.Generic;

public class Hyvaksynta
{
    public HashSet<string> KeraaVastaukset()
    {
        HashSet<string> vastaukset = new HashSet<string>();
        int kysymystenMäärä = 0;
        string vastaus;

        Console.WriteLine("Anna vastauksia (5 kpl):");
        while (kysymystenMäärä < 5)
        {
            vastaus = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(vastaus))
            {
                Console.WriteLine("Vastaus ei voi olla tyhjä.");
                continue;
            }
            if (vastaukset.Contains(vastaus))
            {
                Console.WriteLine("Samaa vastausta ei saa kirjoittaa kahdesti.");
            }
            else
            {
                vastaukset.Add(vastaus);
                kysymystenMäärä++;
            }
        }

        return vastaukset;
    }
}
