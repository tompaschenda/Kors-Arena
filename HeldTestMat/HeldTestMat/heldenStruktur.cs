using rassenStruktur;
using wuerfelKlasse;
using System.Text;
using System.Reflection;
using kulturenStruktur;
using Listen;
using Common;

namespace heldenStruktur
{

    /// <summary>
    /// [Tom] Dies ist ein Beispiel für eine C-Sharp-konforme Kommentierungssyntax
    /// Definition der Struktur eines Helden:
    /// </summary>
    public class Held
    {
        //////////////////////////////////////
        //  Grundlegendes
        //////////////////////////////////////

        /// <summary>
        /// Der Name eines Helden.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Das Geschlecht eines Helden. Entweder männlich oder weiblich.
        /// </summary>
        public GeschlechtNamen Geschlecht {get; set;}

        /// <summary>
        /// Gibt an, wie viele AP ein Held bereits ausgegeben hat, bzw. wie viele AP
        /// ein Held noch ausgeben kann.
        /// </summary>
        public int apAusgegeben, apUebrig;

        /// <summary>
        /// Jeder Held ist von einer bestimmten Art (nicht zu verwechseln mit der Rasse)
        /// Folgende Arten gibt es:
        /// - Mensch (Elf, Zwerg, etc.)
        /// - Tier
        /// - Dämon
        /// - Elementar
        /// </summary>
        public string art;

        /// <summary>
        /// Jeder Held hat einen Ort, an dem er/sie sich aufhält (x, y, z): 
        /// </summary>
        public koordinaten ort;
        /// <summary>
        /// Jeder Held hat eine Position, in der er sich befindet (stehend, liegend, etc.)
        /// </summary>
        public string position;


        //////////////////////////////////////
        //  Rasse
        //////////////////////////////////////


        /// <summary>
        /// Jeder Held verfügt über GENAU eine Rasse.
        /// Die Rasse kann Auswirkungen auf die abgeleiteten Grundwerte, etc. haben!
        /// Eine Rasse kann wiederum Subrassen besitzen, von denen der Spieler eine (oder keine) annehmen kann.
        /// </summary>
        public rassenStruct Rasse { get; set; }

        /// <summary>
        /// Der Held kann eine oder keine Subrasse haben. Sie muss zur Rasse passen.
        /// </summary>
        public subrasse Subrasse { get; set; }

        /// <summary>
        /// Die Kombination aus Rasse und Subrasse für die GUI
        /// </summary>
        public string RasseAlsString
        {
            get
            {
                if (Rasse==null)
                {
                    return "";
                }
                if (Subrasse == null)
                {
                    return Rasse.Name;
                }
                else
                {
                    return Rasse.Name + ", " + Subrasse.Name;
                }
            }
        }

        /// <summary>
        /// Jeder Held verfügt über eine Größe - wir gehen hier davon aus, dass ein
        /// Held immer ein Mensch / Zwerg / Elf (etc.) ist und somit "menschengroß" ist.
        /// Nach dem DSA-Vokabular ist er damit in der Kategorie "mittel" einzuordnen.
        /// Allgemein muss diese Größenkategorie durch die Art und die Rasse bestimmt werden.
        /// </summary>
        public string groessenkategorie;


        /// <summary>
        /// Jeder Held hat eine Größe in Schritt und ein Gewicht in Stein:
        /// Der genaue Wert ist von der Rasse des Helden abhängig.
        /// </summary>
        public double koerpergroesse, gewicht;
        /*
        private double berechneKoerpergroesse()
        {
            // Holen wir uns einen Würfel:
            wuerfel meinWuerfel = new wuerfel();
            double wuerfelErgebnis = meinWuerfel.wuerfelWurf(rasse.koerpergroesse.wuerfel);
            koerpergroesse = rasse.koerpergroesse.basisgroesse + wuerfelErgebnis / 100;
            return koerpergroesse;
        }
        private double berechneGewicht()
        {
            gewicht = koerpergroesse * 100 - rasse.gewichtsabzug;
            return gewicht;
        }*/

        /// <summary>
        /// Augenfarbe und Haarfarbe des Helden. Hängen beide von der Rasse des Helden ab.
        /// </summary>
        public string augenfarbe, haarfarbe;
        /*
        private string berechneAugenfarbe()
        {
            // Holen wir uns einen Würfel:
            wuerfel meinWuerfel = new wuerfel();
            int ergebnis = meinWuerfel.wuerfelWurf(new int[] { 1, 20, 0 });
            // Wert aus der Map auslesen:
            augenfarbe = rasse.augenfarbe.getValue(ergebnis);
            return augenfarbe;
        }
        private string berechneHaarfarbe()
        {
            // Holen wir uns einen Würfel:
            wuerfel meinWuerfel = new wuerfel();
            int ergebnis = meinWuerfel.wuerfelWurf(new int[] { 1, 20, 0 });

            haarfarbe = rasse.haarfarbe.getValue(ergebnis);
            return haarfarbe;
        }*/


        /// <summary>
        /// Hier definieren wir die Koordinaten, an denen sich ein Held aufhalten kann in einer Unterstruktur: 
        /// </summary>
        public struct koordinaten
        {
            /// <summary>
            /// Die drei Koordinatendimensionen x, y und z. Wenn wir von oben auf ein
            /// Grid schauen, dann ist x die von links nach rechts (horizontal) verlaufende
            /// Komponente.
            /// y ist die Komponente, die von unten nach oben (vertikal) verläuft.
            /// z ist die Höhenkomponente, die von der Fläche aus der Fläche heraus verläuft.
            /// </summary>
            public int xKoord, yKoord, zKoord;
        }

        /// <summary>
        /// Jeder Held verfügt über genau EINE Kultur
        /// </summary>
        public kulturenStruct kultur;

        
        /// <summary>
        /// Dies ist eine Initialisierungsfunktion, die probeweise einen Helden erstellt:
        /// </summary>
        /// <returns>[Tom]: Kann nicht fehlschlagen und gibt daher immer 'true' zurück</returns>
        public bool initialsiereHelden()
        {
            Name = "Rondran Kartakis";
            Geschlecht = GeschlechtNamen.maennlich;
            apAusgegeben = 0;
            apUebrig = 0;
            art = "Mensch";
            groessenkategorie = "mittel";
            position = "stehend";
            ort.xKoord = 5;
            ort.yKoord = 0;
            ort.zKoord = 0;
            Rasse = rassenStruct.getRasseByIdentifier(SpielerRassenName.Tulamiden);
            Subrasse = Rasse.moeglicheSubrassen[0];
            kultur.Kultur = KulturName.AndergastUndNostria;
            // TODO: Wähle Subrasse, falls möglich!
            // TODO! Muss an Subrassen gepasst werden!
            // berechneKoerpergroesse();
            //berechneGewicht();
            //berechneHaarfarbe();
            //berechneAugenfarbe();
            return true;
        }

        /// <summary>
        /// [Tom]: In C-Sharp ist es üblich, jeder Klasse eine ToString Methode zu verpassen. Diese kann dann zum Ausgeben genutzt werden.
        /// </summary>
        /// <returns>Das Objekt als String</returns>
        public override string ToString()
        {
            return ObjectExtentions.ToStringGeneric(this);
        }

        /// <summary>
        /// [Tom]: Eine einfache Implementierung der ToString Methode. Sie gibt alle Felder des Objekts aus.
        /// Nachteil: Wird ein Feld zur Klasse hinzugefügt, muss diese Methode geändert werden.
        /// Vorteil: Man hat großen Einfluss auf die Formatierung
        /// </summary>
        /// <returns>Eine String-Darstellung des Helden</returns>
        public string ToStringSimple()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name des Helden: " + Name);
            sb.AppendLine("Aufenthaltsort des Helden: " + ort.xKoord);
            sb.AppendLine("Rasse des Helden: " + Rasse.Name); //[Tom]: Hier sehen wir den Lesezugriff auf die Property
            sb.AppendLine("Haarfarbe des Helden: " + haarfarbe);
            sb.AppendLine("Augenfarbe des Helden: " + augenfarbe);
            sb.AppendLine("Größe (ein Schritt): " + koerpergroesse);
            sb.AppendLine("Gewicht (in Stein): " + gewicht);
            sb.AppendLine("Größenkategorie: " + groessenkategorie);
            sb.AppendLine("Kultur: " + kultur);
            return sb.ToString();
        }

    }
}