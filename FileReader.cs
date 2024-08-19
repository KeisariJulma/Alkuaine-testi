using System;
using System.Collections.Generic;
using System.IO;

public static class FileReader
{
    public static List<string> ReadFileToList(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            return new List<string>(lines);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Virhe luettaessa tiedostoa: {ex.Message}");
            return new List<string>();
        }
    }
}