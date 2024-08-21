using System;
using System.Collections.Generic;
using System.IO;

class VastausKasittely
{

    public static void TarkistaVastaukset(HashSet<string> vastaukset)
    {
        int oikein = 0;
        int vaarin = 0;

        foreach (string alkuaine in vastaukset)
        {
            Console.WriteLine("Arvaa alkuaine!");
            Console.WriteLine($"Vihje: Ensimmäinen kirjain: {alkuaine[0]}, Viimeinen kirjain: {alkuaine[alkuaine.Length - 1]}, Pituus: {alkuaine.Length}");
            string vastaus = Console.ReadLine().Trim();

            if (OnkoVastausOikein(vastaus))
            {
                oikein++;
                Console.WriteLine($"{vastaus}: Oikein!");
            }
            else
            {
                vaarin++;
                Console.WriteLine($"{vastaus}: Väärin!");
            }
        }

        // Tulostetaan yhteenveto
        Console.WriteLine($"Oikein: {oikein}");
        Console.WriteLine($"Väärin: {vaarin}");
    }

    private static bool OnkoVastausOikein(string vastaus)
    {
        try
        {
            // Lue kaikki rivit tiedostosta
            string[] kaikkiRivit = File.ReadAllLines("alkuaineet.txt");

            // Käydään läpi jokainen rivi ja tarkistetaan, onko se yhtä kuin käyttäjän vastaus
            foreach (string rivi in kaikkiRivit)
            {
                // Muutetaan käyttäjän syöte ja tiedostosta luettu rivi pieniksi kirjaimiksi
                if (rivi.ToLower() == vastaus.ToLower())
                {
                    return true;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Virhe: Tiedostoa 'alkuaineet.txt' ei löytynyt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Virhe: {ex.Message}");
        }

        return false;
    }
}
