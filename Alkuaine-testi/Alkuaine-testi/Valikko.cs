using System;

class Valikko
{
    public static void Valinta()
    {
        AlkuaineTesti testi = new AlkuaineTesti();
        Hyvaksynta hyvaksynta = new Hyvaksynta();

        while (true)
        {
            Console.WriteLine("Tervetuloa Alkuaine-testiin!");
            Console.WriteLine("Valitse toiminto: Pelaa (p), Tarkastele tuloksia (t), Poistu (x)");

            string valinta = Console.ReadLine()?.Trim().ToLower();

            if (valinta == "p")
            {
                testi.Pelaa();
            }
            else if (valinta == "t")
            {
                TulosTarkastelu.Tarkastele();
            }
            else if (valinta == "x")
            {
                Console.WriteLine("Poistutaan ohjelmasta...");
                break;
            }
            else
            {
                Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
            }
        }
    }
}
