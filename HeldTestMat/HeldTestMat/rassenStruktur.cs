using System.Collections.Generic;

namespace rassenStruktur
{

    //////////////////////////////////////
    //  Rassen-Struktur. TODO: Ausgliedern!
    //////////////////////////////////////


    /// <summary>
    /// [Tom] Dies ist ein Beispiel für eine C-Sharp-konforme Kommentierungssyntax
    /// Definition der Rassen-Struktur:
    /// </summary>
    public struct rassenStruct
    {

        // Wir listen nun auf, welche Attribute eine Rasse hat:
        
        public int generierungskosten;
        public haarfarbe haarfarbe;
        public augenfarbe augenfarbe;
        public koerpergroesse koerpergroesse;
        public int gewichtsabzug;
        public eigenschaftsModifikationen[] eigenschaftsModifikationen;
        public int leModifikator;
        public int auModifikator;
        public int mrModifikator;
        public string[] automatischeVorteile;
        public string[] automatischeNachteile;
        public string[] empfohleneVorteile;
        public string[] empfohleneNachteile;
        public string[] ungeeigneteVorteile;
        public string[] ungeeigneteNachteile;
        /// <summary>
        /// [Tom] Hier benutzen wir eine Liste statt eines Arrays. Listen sind im Umgang etwas komfortabler (und bieten gleichzeitig den einfach Zugriff über [0], [1], ...
        /// </summary>
        public List<string> ueblicheKulturen;
        /// <summary>
        /// [Tom] Ebenfalls: Liste statt Array. Dann können wir die Liste auch ganz ohne Indizierung füllen (siehe unten)
        /// </summary>
        public List<string> unueblicheKulturen;
        /// <summary>
        /// Die Talentmodifikatoren dieser Rasse
        /// </summary>
        public List<talentModifikatoren> talentModifikatoren;

        /// <summary>
        /// [Tom] In dieser privaten Variablen speichern wir den Namen der Rasse. Der Zugriff ist nur über die Property möglich
        /// </summary>
        private string name;
        /// <summary>
        /// [Tom]: Der Name der Rasse. Beim Setzen des Namens werden die anderen Felder automatisch gefüllt.
        /// Dies ist eine sogenannte Property.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
       
            set
            {
                try
                {
                    switch (value)
                    {
                        case "Mittelreichler":

                            /////////////////////////////
                            //  TODO: Auslagern in "Rassenfabrik"
                            //////////////////////////////


                            name = value;
                            generierungskosten = 0;

                            haarfarbe.farben = new string[6];
                            haarfarbe.farben[0] = "schwarz";
                            haarfarbe.farben[1] = "braun";
                            haarfarbe.farben[2] = "dunkelblond";
                            haarfarbe.farben[3] = "blond";
                            haarfarbe.farben[4] = "weißblond";
                            haarfarbe.farben[5] = "rot";

                            haarfarbe.werte = new int[6, 2];
                            haarfarbe.werte[0, 0] = 1;
                            haarfarbe.werte[0, 1] = 3;
                            haarfarbe.werte[1, 0] = 4;
                            haarfarbe.werte[1, 1] = 7;
                            haarfarbe.werte[2, 0] = 8;
                            haarfarbe.werte[2, 1] = 12;
                            haarfarbe.werte[3, 0] = 13;
                            haarfarbe.werte[3, 1] = 16;
                            haarfarbe.werte[4, 0] = 17;
                            haarfarbe.werte[4, 1] = 18;
                            haarfarbe.werte[5, 0] = 19;
                            haarfarbe.werte[5, 1] = 20;

                            augenfarbe.farben = new string[6];
                            augenfarbe.farben[0] = "dunkelbraun";
                            augenfarbe.farben[1] = "braun";
                            augenfarbe.farben[2] = "grün";
                            augenfarbe.farben[3] = "blau";
                            augenfarbe.farben[4] = "grau";
                            augenfarbe.farben[5] = "schwarz";

                            augenfarbe.werte = new int[6, 2];
                            augenfarbe.werte[0, 0] = 1;
                            augenfarbe.werte[0, 1] = 2;
                            augenfarbe.werte[1, 0] = 3;
                            augenfarbe.werte[1, 1] = 9;
                            augenfarbe.werte[2, 0] = 10;
                            augenfarbe.werte[2, 1] = 11;
                            augenfarbe.werte[3, 0] = 12;
                            augenfarbe.werte[3, 1] = 17;
                            augenfarbe.werte[4, 0] = 18;
                            augenfarbe.werte[4, 1] = 19;
                            augenfarbe.werte[5, 0] = 20;
                            augenfarbe.werte[5, 1] = 20;


                            koerpergroesse.basisgroesse = 1.60;
                            koerpergroesse.wuerfel = new int[3];
                            koerpergroesse.wuerfel[0] = 2;
                            koerpergroesse.wuerfel[1] = 20;
                            koerpergroesse.wuerfel[2] = 0;

                            gewichtsabzug = 100;

                            eigenschaftsModifikationen = new eigenschaftsModifikationen[1];
                            eigenschaftsModifikationen[0].name = "";
                            eigenschaftsModifikationen[0].modifikator = 0;

                            leModifikator = 10;
                            auModifikator = 10;
                            mrModifikator = -4;

                            ungeeigneteVorteile = new string[1];
                            ungeeigneteVorteile[0] = "Herausragende Balance";
                            ungeeigneteNachteile = new string[1];
                            ungeeigneteNachteile[0] = "Nahrungsrestriktion";

                            //[Tom]: Listenbefüllung Variante 1:
                            // Wir füllen die Liste mittels der add-Methods der Klasse List
                            ueblicheKulturen = new List<string>();
                            ueblicheKulturen.Add("Mittelländische Städte");
                            ueblicheKulturen.Add("Mittelländische Landbevölkerung");
                            ueblicheKulturen.Add("Andergast und Nostria");
                            ueblicheKulturen.Add("Bornland");
                            ueblicheKulturen.Add("Svelttal");
                            ueblicheKulturen.Add( "Almada");
                            ueblicheKulturen.Add("Horasreich");
                            ueblicheKulturen.Add("Zyklopeninseln");
                            ueblicheKulturen.Add("Maraskan");
                            ueblicheKulturen.Add("Südaventurien");
                            ueblicheKulturen.Add("Bukanier");

                            //[Tom]: Listenbefüllung Variante 2:
                            // Wir füllen die Liste mittels eines sogenannten Collection Initializers
                            // siehe http://www.developer.com/net/csharp/article.php/3607421/New-in-C-30-Create-and-Initialize-Collection-Objects-in-One-Step.htm
                            unueblicheKulturen = new List<string> 
                            {
                                "Aranien", "Tulamidische Stadtstaaten", 
                                "Thorwal", "Mhanadistan", "Amazonenburg"
                            };

                            //[Tom]: Auch hier können wir ganz Prima einen Collection Initializer benutzen. Diesmal in der geschachtelten Ausführung
                            talentModifikatoren = new List<talentModifikatoren>
                            {
                                new talentModifikatoren{name="", modifikator=0}
                            };

                            break;
                        default:
                            throw new System.ArgumentOutOfRangeException();
                    }

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültige Rasse angegeben!");
                }
            }
        }
    }




    //////////////////////////////////////
    //  Substrukturen der Rassen-Struktur. TODO: Auräumen!
    //////////////////////////////////////



    public struct talentModifikatoren
    {
        // Ich brauche die Namen der Talente:
        public string name;
        // und den Modifikator:
        public int modifikator;
    }

    public struct eigenschaftsModifikationen
    {
        // Ich brauche den Namen der Eigenschaft:
        public string name;
        // Und den Modifikator:
        public int modifikator;
    }

    public struct koerpergroesse
    {
        public double basisgroesse;
        public int[] wuerfel;
    }

    public struct haarfarbe
    {
        public string[] farben;
        public int[,] werte;
    }

    public struct augenfarbe
    {
        public string[] farben;
        public int[,] werte;
    }


}