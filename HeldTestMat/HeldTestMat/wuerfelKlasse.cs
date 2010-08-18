using System;

namespace wuerfelKlasse
{
    /// <summary>
    /// Klasse, die mit Hilfe von drei Attributen einen
    /// Würfelwurf genau beschreiben kann.
    /// </summary>
    public class wuerfel
    {

        /// <summary>
        /// Mit wie vielen Würfeln soll gewürfelt werden?
        /// </summary>
        public int wuerfelanzahl;

        /// <summary>
        /// Wie viele Augen hat der Würfel, mit dem gewürfelt werden soll?
        /// </summary>
        public int wuerfelaugen;
        
        /// <summary>
        /// Wie hoch ist das Offset, das auf das Ergebnis addiert oder davon
        /// abgezogen werden soll?
        /// </summary>
        public int wuerfeloffset;


        /// <summary>
        /// Würfelt eine beliebige Kombinatin aus x * Wy + z.
        /// ACHTUNG: An dieser Stelle werden Zufallszahlen benötigt.
        /// Der Seed wird hier NICHT von Hand initialisiert!
        /// Negative Ergebnisse sind an dieser Stelle möglich, wenn z negativ ist!
        /// </summary>
        /// <returns> ergebnis des Würfelwurfs</returns>
        public int wuerfelWurf()
        {
        
            int ergebnis = 0;

            for (int i = 0; i < wuerfelanzahl; i++)
            {
                // Wir legen uns ein neues Zufallsgenerator-Objekt an:
                // Dafür verwenden wir die interne System-Funktion!
                Random rand = new Random();
                ergebnis = ergebnis + rand.Next(1, wuerfelaugen);
            }
            ergebnis = ergebnis + wuerfeloffset;

            System.Console.WriteLine("Ergebnis eines Würfelwurfs: " + ergebnis);

            return ergebnis;
         }
    }
}