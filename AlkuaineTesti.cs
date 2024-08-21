using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class AlkuaineTesti
{
    // Instanssimuuttuja, johon tallennetaan kysytyt alkuaineet
    private HashSet<int> kysytyt = new HashSet<int>();

    public void Pelaa()
    {
        // Lue alkuaineet tiedostosta
        string[] alkuaineet = TiedostonKasittely.LueAlkuaineet("alkuaineet.txt");
        if (alkuaineet == null || alkuaineet.Length == 0)
        {
            Console.WriteLine("Virhe: Alkuaineet-tiedostoa ei löytynyt tai se on tyhjä.");
            return;
        }

        // Satunnaislukugeneraattori ja oikein laskuri
        Random random = new Random();
        int oikein = 0;

        // Kysy 5 alkuaineen arvausta
        for (int i = 0; i < 5; i++)
        {
            int index = ArvoUusiIndeksi(alkuaineet.Length, random);

            // Lisää indeksi kysyttyjen joukkoon ja hae oikea vastaus
            kysytyt.Add(index);
            string oikeaVastaus = alkuaineet[index];

            // Luo vihje ja vihje, jossa korvataan osa kirjaimista tähdillä
            string vihje = LuoVihje(oikeaVastaus);
            string vihjeTahdilla = LuoVihjeTahdilla(oikeaVastaus);

            // Tulosta vihjeet ja pyydä käyttäjältä vastausta
            Console.WriteLine("Arvaa alkuaine! " + vihje + ", " + vihjeTahdilla);
            string vastaus = Console.ReadLine()?.Trim();

            // Tarkista vastaus ja ilmoita oikein tai väärin
            if (OnVastausOikein(vastaus, oikeaVastaus))
            {
                oikein++;
                Console.WriteLine("Oikein!");
            }
            else
            {
                Console.WriteLine("Väärin!");
            }
        }

        // Tulosta tulos ja tallenna se tiedostoon
        TulostaJaTallennaTulos(oikein);
    }

    // Arvotaan uusi indeksi, jota ei ole vielä kysytty
    private int ArvoUusiIndeksi(int maxIndex, Random random)
    {
        int index;
        do
        {
            index = random.Next(0, maxIndex);
        } while (kysytyt.Contains(index));
        return index;
    }

    // Luo vihje oikean vastauksen perusteella
    private string LuoVihje(string oikeaVastaus)
    {
        string vihje = $"Ensimmäinen kirjain: {oikeaVastaus[0]}, ";
        if (oikeaVastaus.Length >= 5)
        {
            vihje += $"Toinen kirjain: {oikeaVastaus[1]}, ";
        }
        vihje += $"Viimeinen kirjain: {oikeaVastaus[^1]}, Pituus: {oikeaVastaus.Length}";
        return vihje;
    }

    // Luo vihje, jossa osa kirjaimista korvataan tähdillä
    private string LuoVihjeTahdilla(string oikeaVastaus)
    {
        string vihjeTahdilla = "";
        for (int kohta = 0; kohta < oikeaVastaus.Length; kohta++)
        {
            if (kohta == 0 || (kohta == 1 && oikeaVastaus.Length > 4) || kohta == oikeaVastaus.Length - 1)
            {
                vihjeTahdilla += oikeaVastaus[kohta];
            }
            else
            {
                vihjeTahdilla += "*";
            }
        }
        return vihjeTahdilla;
    }

    // Tarkistaa, onko käyttäjän vastaus oikein
    private bool OnVastausOikein(string vastaus, string oikeaVastaus)
    {
        return string.Equals(vastaus, oikeaVastaus, StringComparison.OrdinalIgnoreCase);
    }

    // Tulostaa tuloksen ja tallentaa sen tiedostoon
    private void TulostaJaTallennaTulos(int oikein)
    {
        Console.WriteLine($"Sait oikein {oikein}/5.");
        TiedostonKasittely.TallennaTulos(oikein);
    }
}
