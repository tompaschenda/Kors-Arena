using rassenStruktur;
using wuerfelKlasse;
using System.Text;
using System.Reflection;

namespace heldenStruktur
{

    /// <summary>
    /// [Tom] Dies ist ein Beispiel für eine C-Sharp-konforme Kommentierungssyntax
    /// Definition der Struktur eines Helden:
    /// </summary>
    public struct held
    {
        //////////////////////////////////////
        //  Grundlegendes
        //////////////////////////////////////

        // Wir definieren zunächst die Grundlegenden Eigenschaften
        // eines Helden, die einen Helden definieren:
        public string vorname, nachname, titel;
        public string name; // Wird zusammen gesetzt aus "Vorname + Titel_ + Nachname"
        public string geschlecht;   // männlich oder weiblich
        public int apAusgegeben, apUebrig;

        // Jeder Held ist von einer bestimmten Art (nicht zu verwechseln mit der Rasse)
        // Folgende Arten gibt es:
        // - Mensch (Elf, Zwerg, etc.)
        // - Tier
        // - Dämon
        // - Elementar
        public string art;

        // Außerdem hat er oder sie einen Ort, andem er/sie sich aufhält, sowie eine position:
        public koordinaten ort;
        public string position;


        //////////////////////////////////////
        //  Rasse
        //////////////////////////////////////

        // Jeder Held verfügt über GENAU eine Rasse.
        // Wir legen die Rasse hier zunächst auf "Mittelreichler" fest.
        //  Die Rasse kann Auswirkungen auf die abgeleiteten Grundwerte, etc. haben!
        public rassenStruct rasse;


        // Jeder Held verfügt über eine Größe - wir gehen hier davon aus, dass ein
        // Held immer ein Mensch / Zwerg / Elf (etc.) ist und somit "menschengroß" ist.
        // Nach dem DSA-Vokabular ist er damit in der Kategorie "mittel" einzuordnen.
        // Allgemein muss diese Größenkategorie durch die Art und die Rasse bestimmt werden.
        public string groessenkategorie;

        // Jeder Held hat eine Größe in Schritt und ein Gewicht in Stein:
        // Der genaue Wert ist von der Rasse des Helden abhängig.
        public double koerpergroesse, gewicht;
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
        }


        // Nun fehlen noch die Augen- und die Haarfarbe, die beide ebenfalls von der Rasse
        // abhängig sind:
        public string augenfarbe, haarfarbe;
        private string berechneAugenfarbe()
        {
            // Holen wir uns einen Würfel:
            wuerfel meinWuerfel = new wuerfel();
            int ergebnis = meinWuerfel.wuerfelWurf(new int[] { 1, 20, 0 });
            for (int i = 0; i < rasse.augenfarbe.werte.GetLength(0); i++)
            {
                if (ergebnis >= rasse.augenfarbe.werte[i, 0] && ergebnis <= rasse.augenfarbe.werte[i, 1])
                {
                    augenfarbe = rasse.augenfarbe.farben[i];
                }
            }
            return augenfarbe;
        }
        private string berechneHaarfarbe()
        {
            // Holen wir uns einen Würfel:
            wuerfel meinWuerfel = new wuerfel();
            int ergebnis = meinWuerfel.wuerfelWurf(new int[] { 1, 20, 0 });
            for (int i = 0; i < rasse.haarfarbe.werte.GetLength(0); i++)
            {
                if (ergebnis >= rasse.haarfarbe.werte[i, 0] && ergebnis <= rasse.haarfarbe.werte[i, 1])
                {
                    haarfarbe = rasse.haarfarbe.farben[i];
                }
            }
            return haarfarbe;
        }


        // Hier definieren wir die Koordinaten, an denen sich ein Held aufhalten kann in einer Unterstruktur:
        public struct koordinaten
        {
            public int xKoord, yKoord, zKoord;
        }

        private bool berechneNamen()
        {
            name = (vorname + " " + titel + nachname);
            return true;
        }

        
        /// <summary>
        /// Dies ist eine Initialisierungsfunktion, die probeweise einen Helden erstellt:
        /// </summary>
        /// <returns>[Tom]: Kann nicht fehlschlagen und gibt daher immer 'true' zurück</returns>
        public bool initialsiereHelden()
        {
            vorname = "Rondran";
            nachname = "Kartakis";
            titel = "";
            berechneNamen();
            geschlecht = "männlich";
            apAusgegeben = 0;
            apUebrig = 0;
            art = "Mensch";
            groessenkategorie = "mittel";
            position = "stehend";
            ort.xKoord = 5;
            ort.yKoord = 0;
            ort.zKoord = 0;
            //[Tom] Hier benutzen wir jetzt die Property für den Rassennamen
            rasse.Name="Mittelreichler";
            berechneKoerpergroesse();
            berechneGewicht();
            berechneHaarfarbe();
            berechneAugenfarbe();
            return true;
        }

        /// <summary>
        /// [Tom]: In C-Sharp ist es üblich, jeder Klasse eine ToString Methode zu verpassen. Diese kann dann zum Ausgeben genutzt werden.
        /// </summary>
        /// <returns>Das Objekt als String</returns>
        public override string ToString()
        {
            return ToStringGeneric();
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
            sb.AppendLine("Name des Helden: " + name);
            sb.AppendLine("Aufenthaltsort des Helden: " + ort.xKoord);
            sb.AppendLine("Rasse des Helden: " + rasse.Name); //[Tom]: Hier sehen wir den Lesezugriff auf die Property
            sb.AppendLine("Haarfarbe des Helden: " + haarfarbe);
            sb.AppendLine("Augenfarbe des Helden: " + augenfarbe);
            sb.AppendLine("Größe (ein Schritt): " + koerpergroesse);
            sb.AppendLine("Gewicht (in Stein): " + gewicht);
            sb.AppendLine("Größenkategorie: " + groessenkategorie);
            return sb.ToString();
        }

        /// <summary>
        /// [Tom]: Eine generische Implementierung der ToString Methode, die selbst erkennt, welche Felder die Klasse hat und diese ausgibt.
        /// Vorteil: Beim Hinzufügen von neuen Feldern muss sie nicht geändert werden. 
        /// Nachteil: Man ist bei der Formatierung nicht so flexibel wie in ToStringSimple.
        /// Geklaut von http://www.fincher.org/tips/Languages/csharp.shtml
        /// </summary>
        /// <returns>Alle Felder des Objekts in einem String</returns>
        public string ToStringGeneric()
        {
            StringBuilder sb = new StringBuilder();
            System.Type type = this.GetType();
            sb.Append("Information for " + type.Name);
            sb.Append("\r\nFields:");
            System.Reflection.FieldInfo[] fi = type.GetFields();
            foreach (FieldInfo f in fi)
            {
                sb.Append("\r\n  " + f.ToString() + " = \"" + f.GetValue(this) + "\"");
            }
            System.Reflection.PropertyInfo[] pi = type.GetProperties();
            sb.Append("\r\nProperties:");
            foreach (PropertyInfo p in pi)
            {
                sb.Append("\r\n  " + p.ToString() + " = \"" + p.GetValue(this, null) + "\"");
            }
            return sb.ToString();
        }



    }
}