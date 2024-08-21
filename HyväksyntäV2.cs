using System;
using System.Collections.Generic;

public class Hyvaksynta2
{
    public void Run()
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
        vastaukset.Clear();
    }
}