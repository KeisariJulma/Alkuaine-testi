using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class AlkuaineTesti
{
    private HashSet<int> kysytyt = new HashSet<int>(); // Instanssimuuttuja

    public void Pelaa()
    {
        string[] alkuaineet = TiedostonKasittely.LueAlkuaineet("alkuaineet.txt");
        if (alkuaineet == null || alkuaineet.Length == 0)
        {
            Console.WriteLine("Virhe: Alkuaineet-tiedostoa ei löytynyt tai se on tyhjä.");
            return;
        }

        Random random = new Random();
        int oikein = 0;

        for (int i = 0; i < 5; i++)
        {
            int index;
            do
            {
                index = random.Next(0, alkuaineet.Length);
            } while (kysytyt.Contains(index));

            kysytyt.Add(index);
            string oikeaVastaus = alkuaineet[index];

            string vihje = $"Ensimmäinen kirjain: {oikeaVastaus[0]}, ";
            if (oikeaVastaus.Length >= 5)
            {
                vihje += $"Toinen kirjain: {oikeaVastaus[1]}, ";
            }
            vihje += $"Viimeinen kirjain: {oikeaVastaus[oikeaVastaus.Length - 1]}, Pituus: {oikeaVastaus.Length}";

            string sana = oikeaVastaus;
            string vihjeTahdilla = "";

            for (int kohta = 0; kohta < sana.Length; kohta++)
            {
                if (kohta == 0 || (kohta == 1 && sana.Length > 4) || kohta == sana.Length - 1)
                {
                    vihjeTahdilla += sana[kohta];
                }
                else
                {
                    vihjeTahdilla += "*";
                }
            }

            Console.WriteLine("Arvaa alkuaine! " + vihje + ", " + vihjeTahdilla);
            string vastaus = Console.ReadLine()?.Trim();

            if (string.Equals(vastaus, oikeaVastaus, StringComparison.OrdinalIgnoreCase))
            {
                oikein++;
                Console.WriteLine("Oikein!");
            }
            else
            {
                Console.WriteLine("Väärin!");
            }
        }

        int tulos = oikein;
        Console.WriteLine($"Sait oikein {oikein}/5.");
        TiedostonKasittely.TallennaTulos(tulos);
    }
}
