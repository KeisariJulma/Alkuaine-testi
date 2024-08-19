using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Hyvaksynta
{
    public Hyvaksynta(string[] args)
    {
        int kysymystenMäärä = 1; ;
        string vastaus;
        List<string> vastaukset = new List<string>();
        while (true)
        {
            vastaus = Convert.ToString(Console.ReadLine());
            foreach (string vastausLista in vastaukset)
            {
                if (vastaukset.Contains(vastausLista))
                {
                    Console.WriteLine("samaa vastausta ei saa kirjoittaa kahdesti");
                }
                else
                {
                    vastaukset.Add(vastaus);
                }
            }
            kysymystenMäärä++;
            if (kysymystenMäärä > 5)
            {
                vastaukset.Clear();
            }
        }
    }
}