using System;
using System.Collections.Generic;

public class Hyvaksynta
{
    public Hyvaksynta(string[] args)
    {
        int kysymystenMäärä = 0;
        string vastaus;
        HashSet<string> vastaukset = new HashSet<string>();

        while (kysymystenMäärä < 5)
        {
            vastaus = Console.ReadLine();
            if (vastaukset.Contains(vastaus))
            {
                Console.WriteLine("samaa vastausta ei saa kirjoittaa kahdesti");
            }
            else
            {
                vastaukset.Add(vastaus);
                kysymystenMäärä++;
            }
        }
    }
}