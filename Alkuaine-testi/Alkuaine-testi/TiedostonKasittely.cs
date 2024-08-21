using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public static class TiedostonKasittely
{
    public static string[] LueAlkuaineet(string tiedostoPolku)
    {
        try
        {
            return File.ReadAllLines(tiedostoPolku);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Virhe: {ex.Message}");
            return null;
        }
    }

    public static void TallennaTulos(int tulos)
    {
        string hakemistoNimi = DateTime.Now.ToString("ddMMyyyy");
        string tiedostoPolku = Path.Combine(hakemistoNimi, "tulokset.json");

        if (!Directory.Exists(hakemistoNimi))
        {
            Directory.CreateDirectory(hakemistoNimi);
        }

        List<int> tulokset = new List<int>();

        if (File.Exists(tiedostoPolku))
        {
            string json = File.ReadAllText(tiedostoPolku);
            tulokset = JsonConvert.DeserializeObject<List<int>>(json) ?? new List<int>();
        }

        tulokset.Add(tulos);

        string uusiJson = JsonConvert.SerializeObject(tulokset, Formatting.Indented);
        File.WriteAllText(tiedostoPolku, uusiJson);
    }
}