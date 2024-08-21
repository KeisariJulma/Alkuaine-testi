using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public static class TulosTarkastelu
{
    public static void Tarkastele()
    {
        string[] hakemistot = Directory.GetDirectories(Directory.GetCurrentDirectory());

        List<int> kaikkiTulokset = new List<int>();

        foreach (string hakemisto in hakemistot)
        {
            string tiedostoPolku = Path.Combine(hakemisto, "tulokset.json");
            if (File.Exists(tiedostoPolku))
            {
                string json = File.ReadAllText(tiedostoPolku);
                List<int> tulokset = JsonConvert.DeserializeObject<List<int>>(json);
                if (tulokset != null)
                {
                    kaikkiTulokset.AddRange(tulokset);
                }
            }
        }

        if (kaikkiTulokset.Count > 0)
        {
            double keskiarvo = kaikkiTulokset.Average();
            Console.WriteLine($"Keskiarvo: {keskiarvo:F2}");
        }
        else
        {
            Console.WriteLine("Ei tuloksia saatavilla.");
        }
    }
}
