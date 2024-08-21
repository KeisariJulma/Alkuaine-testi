using System;
using System.Collections.Generic;
using System.IO;
public class Otantaominaisuus
{
    public static void otantaominaisuus()
    {

        try
        {
            string lines = File.ReadAllText("alkuaineet.txt");

            Dictionary<string, string> dict = new Dictionary<string, string>();

            string alkuaineet = lines.Split(" ")
            dict.Add(cut, );
            foreach (string line in dict)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Virhe luettaessa tiedostoa: {ex.Message}");
            new List<string>();
        }
    }
}
