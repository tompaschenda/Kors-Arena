using System;

namespace wuerfelKlasse
{

    public class wuerfel
    {


        // Würfelt eine beliebige Kombinatin aus x * Wy + z.
        // ACHTUNG: An dieser Stelle werden Zufallszahlen benötigt.
        // Der Seed wird hier NICHT von Hand initialisiert!
        // Negative Ergebnisse sind an dieser Stelle möglich, wenn z negativ ist!
        public int wuerfelWurf(int[] wuerfelVek)
        {
            int anzahlWuerfel = wuerfelVek[0];
            int anzahlAugenProWuerfel = wuerfelVek[1];
            int anzahlZuAddierenderPunkte = wuerfelVek[2];
        
            int ergebnis = 0;

            for(int i=0; i<anzahlWuerfel; i++)
            {
                // Wir legen uns ein neues Zufallsgenerator-Objekt an:
                // Dafür verwenden wir die interne System-Funktion!
                Random rand = new Random();

                ergebnis = ergebnis + rand.Next(1, anzahlAugenProWuerfel);
            }

            ergebnis = ergebnis + anzahlZuAddierenderPunkte;

            System.Console.WriteLine("Ergebnis eines Würfelwurfs: " + ergebnis);

            return ergebnis;
         }
    }
}