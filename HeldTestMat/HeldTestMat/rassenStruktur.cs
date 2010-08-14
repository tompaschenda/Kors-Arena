using System.Collections.Generic;
using listenStruktur;

namespace rassenStruktur
{

    //////////////////////////////////////
    //  Rassen-Struktur. TODO: Ausgliedern!
    //////////////////////////////////////


    /// <summary>
    /// Struktur, die alle Rassen in Aventurien enthält:
    /// </summary>
    public struct rassenStruct
    {

        // Wir listen nun auf, welche Attribute eine Rasse hat:      
        /// <summary>
        ///  Generierungskosten für die jeweilige Rasse in GP
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Map, in der alle Haarfarben und ihre Wahrscheinlichkeiten abgelegt sind
        /// </summary>
        public RangeMap<string> haarfarbe;
        /// <summary>
        /// Map, die die möglichen Augenfarben und die jeweiligen Wahrscheinlichkeiten dafür enthält.
        /// </summary>
        public RangeMap<string> augenfarbe;
        /// <summary>
        /// Enthält die Basiskörpergröße eines Helden in Schritt sowie die nötigen Würfel-Modifikatoren, um die
        /// komplette Größe zu bestimmen.
        /// </summary>
        public koerpergroesse koerpergroesse;
        /// <summary>
        /// Enthält den Abzug (in Stein) vom Grundgewicht des Helden.
        /// </summary>
        public int gewichtsabzug;
        /// <summary>
        /// Substruktur. Enthält die jeweiligen Eigenschaften, die modifiziert werden, sowie den Modifikator 
        /// derselben.
        /// </summary>
        public List<NameWertPaar> eigenschaftsModifikationen;
        /// <summary>
        /// Rassen-Modifikator der Lebensenergie
        /// </summary>
        public int leModifikator;
        /// <summary>
        ///  Rassen-Modifikator der Ausdauer
        /// </summary>
        public int auModifikator;
        /// <summary>
        /// Rassen-Modifikator der Magieresistenz
        /// </summary>
        public int mrModifikator;
        /// <summary>
        /// Automatische Vorteile durch die Rasse
        /// Substruktur enthält den Namen und ggfs. den Wert
        /// </summary>
        public List<NameWertPaar> automatischeVorteile;
        /// <summary>
        ///  Automatische Nachteile durch die Rasse
        /// </summary>
        public List<NameWertPaar> automatischeNachteile;
        /// <summary>
        ///  Empfohlene Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<string> empfohleneVorteile;
        /// <summary>
        ///  Empfohlene Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<string> empfohleneNachteile;
        /// <summary>
        ///  Nicht geeignere Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public List<string> ungeeigneteVorteile;
        /// <summary>
        ///  Nicht geeignere Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public List<string> ungeeigneteNachteile;
        /// <summary>
        /// Übliche Kulturen für eine Rasse. Kann optisch bei der Generierung in der GUI als grün
        /// hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<string> ueblicheKulturen;
        /// <summary>
        /// Unübliche Kulturen für eine Rasse. Kann optisch bei der Generierung in der GUI als
        /// gelb hervorgehoben werden. Ist nicht bindend, sollte aber nur in Absprache mit dem
        /// Meister verwendet werden.
        /// </summary>
        public List<string> unueblicheKulturen;
        /// <summary>
        /// Die Talentmodifikatoren dieser Rasse. Enthält sowohl den jeweiligen Talentnamen als
        /// auch den Modifikator auf das Talent.
        /// </summary>
        public List<NameWertPaar> talentModifikatoren;

        /// <summary>
        /// Eine Liste mit allen möglichen Subrassennamen. Enthält immer mindestens den
        /// Eintrag mit dem eigentlichen Rassennamen. Bei manchen Rassen (z.B. Thorwaler)
        /// können Subrassen gewählt werden.
        /// </summary>
        public List<string> moeglicheSubrassen;

        /// <summary>
        /// Der Name der tatsächlich vom Helden gewählten Subrasse.
        /// </summary>
        public string gewaehlteSubrasse;

        /// <summary>
        /// Ermöglicht die Auswahl einer der möglichen Subrassen durch den Spieler. 
        /// TODO: Muss noch implementiert werden! Momentan wird einfach immer die erstmögliche,
        /// also die "Standardvariante" gewählt. Erfordert GUI- oder Eingabeninteraktion mit Spieler.
        /// </summary>
        /// <returns></returns>
        public string auswahlSubrasse()
        {
            string ausgewaehlteSubrasse = moeglicheSubrassen[0];
            return ausgewaehlteSubrasse;
        }

        /// <summary>
        /// Setzt die Subrasse auf eine vom Spieler ausgewählte Subrasse
        /// </summary>
        /// <returns> Gibt momentan immer "true" zurück </returns>
        public bool setzeSubrasse()
        {
            gewaehlteSubrasse = auswahlSubrasse();
            return true;
        }

        /// <summary>
        /// Name der Rasse.
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

                // Wir legen uns zunächst eine Struktur mit allen Listen an. Darauf greifen wird
                // dann ständig zu:
                // TODO!!!!! @ Tom: WIE!? :)

                // Definition der Maps für die Farben:
                RangeMap<string> haarfabenMap = new RangeMap<string>();
                RangeMap<string> augenfarbenMap = new RangeMap<string>();


                try
                {

                    switch (value)
                    {
                        ///////////////////////////////////////
                        // Mittelreichler
                        ///////////////////////////////////////
                        case "Mittelreichler":

                            name = value;

                            moeglicheSubrassen = new List<string>(){};

                            generierungskosten = 0;

                            haarfabenMap.Add(new Range(1, 3), "schwarz");
                            haarfabenMap.Add(new Range(4, 7), "braun");
                            haarfabenMap.Add(new Range(8, 12), "dunkelblond");
                            haarfabenMap.Add(new Range(13, 16), "blond");
                            haarfabenMap.Add(new Range(17, 18), "weißblond");
                            haarfabenMap.Add(new Range(19, 20), "rot");

                            augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
                            augenfarbenMap.Add(new Range(3, 9), "braun");
                            augenfarbenMap.Add(new Range(10, 11), "grün");
                            augenfarbenMap.Add(new Range(12, 17), "blau");
                            augenfarbenMap.Add(new Range(18, 19), "grau");
                            augenfarbenMap.Add(new Range(20, 20), "schwarz");

                            koerpergroesse.basisgroesse = 1.60;
                            koerpergroesse.wuerfel = new int[3];
                            koerpergroesse.wuerfel[0] = 2;
                            koerpergroesse.wuerfel[1] = 20;
                            koerpergroesse.wuerfel[2] = 0;

                            gewichtsabzug = 100;

                            eigenschaftsModifikationen = new List<NameWertPaar>() { };

                            leModifikator = 10;
                            auModifikator = 10;
                            mrModifikator = -4;

                            automatischeVorteile = new List<NameWertPaar>(){};

                            automatischeNachteile = new List<NameWertPaar>(){};

                            empfohleneVorteile = new List<string>() { };
                            empfohleneNachteile = new List<string>() { };
                            ungeeigneteVorteile = new List<string>() 
                            {
                                "Herausragende Balance",
                            };
                            ungeeigneteNachteile = new List<string>() 
                            {
                                "Nahrungsrestriktion",
                            };                            
                           
                            ueblicheKulturen = new List<string>()
                            {
                                "Mittelländische Städte", "Mittelländische Landbevölkerung", "Andergast und Nostria",
                                "Bornland", "Svelttal", "Almada", "Horasreich", "Zyklopeninseln",
                                "Maraskan", "Südaventurien", "Bukanier"
                            };
                            // [Tom]: oder auch so:
                            // ueblicheKulturen.Add("Bukanier");

                            //[Tom]: Listenbefüllung:
                            // Wir füllen die Liste mittels eines sogenannten Collection Initializers
                            // siehe http://www.developer.com/net/csharp/article.php/3607421/New-in-C-30-Create-and-Initialize-Collection-Objects-in-One-Step.htm
                            unueblicheKulturen = new List<string> 
                            {
                                "Aranien", "Tulamidische Stadtstaaten", 
                                "Thorwal", "Mhanadistan", "Amazonenburg"
                            };

                            //[Tom]: Auch hier können wir ganz Prima einen Collection Initializer benutzen. Diesmal in der geschachtelten Ausführung
                            talentModifikatoren = new List<NameWertPaar>(){};

                            break;

                        ///////////////////////////////////////
                        // Tulamiden
                        ///////////////////////////////////////
                        case "Tulamiden":

                            name = value;

                            moeglicheSubrassen = new List<string>(){};

                            generierungskosten = 0;

                            haarfabenMap.Add(new Range(1, 6), "schwarz");
                            haarfabenMap.Add(new Range(7, 12), "dunkelbraun");
                            haarfabenMap.Add(new Range(13, 14), "mittelbraun");
                            haarfabenMap.Add(new Range(15, 17), "hellbraun");
                            haarfabenMap.Add(new Range(18, 19), "blond");
                            haarfabenMap.Add(new Range(20, 20), "rot");

                            augenfarbenMap.Add(new Range(1, 4), "schwarz");
                            augenfarbenMap.Add(new Range(5, 4), "dunkelbraun");
                            augenfarbenMap.Add(new Range(13, 4), "braun");
                            augenfarbenMap.Add(new Range(17, 4), "grau");
                            augenfarbenMap.Add(new Range(19, 4), "grün");
                            augenfarbenMap.Add(new Range(20, 4), "blau");

                            koerpergroesse.basisgroesse = 1.55;
                            koerpergroesse.wuerfel = new int[3];
                            koerpergroesse.wuerfel[0] = 2;
                            koerpergroesse.wuerfel[1] = 20;
                            koerpergroesse.wuerfel[2] = 0;

                            gewichtsabzug = 105;

                            eigenschaftsModifikationen = new List<NameWertPaar>() {};

                            leModifikator = 10;
                            auModifikator = 10;
                            mrModifikator = -4;

                            automatischeVorteile = new List<NameWertPaar>() {};
                            automatischeNachteile = new List<NameWertPaar>() {};
                            empfohleneVorteile = new List<string>() {};
                            empfohleneNachteile = new List<string>() {};
                            ungeeigneteVorteile = new List<string>() 
                            {
                                "Herausragende Balance",
                            };

                            ungeeigneteNachteile = new List<string>()
                            {
                                "Nahrungsrestriktion",
                            };

                            ueblicheKulturen = new List<string>()
                            {
                                "Aranien", "Mhenadistan", "Tulamidische Stadtstaaten", "Novadi", "Ferkina",
                                "Zahori", "Maraskan", "Südaventurien", "Bukanier"
                            };

                            unueblicheKulturen = new List<string> 
                            {
                                "Mittelländische Städte", "Almada", "Amazonenburg"
                            };

                            talentModifikatoren = new List<NameWertPaar>(){};

                            break;

                        ///////////////////////////////////////
                        // Thorwaler
                        ///////////////////////////////////////
                        case "Thorwaler":

                            name = value;

                            moeglicheSubrassen = new List<string>()
                            {
                                "Thorwaler", "Fjarninger", "Gjalskerländer"
                            };

                            generierungskosten = 5;

                            try
                            {
                                if (gewaehlteSubrasse == "Thorwaler" || gewaehlteSubrasse == "Fjarninger")
                                {
                                    haarfabenMap.Add(new Range(1, 8), "blond");
                                    haarfabenMap.Add(new Range(9, 13), "rotblond");
                                    haarfabenMap.Add(new Range(14, 15), "weißblond");
                                    haarfabenMap.Add(new Range(16, 17), "rot");
                                    haarfabenMap.Add(new Range(18, 18), "dunkelblond");
                                    haarfabenMap.Add(new Range(19, 19), "braun");
                                    haarfarbe.Add(new Range(20, 20), "schwarz");

                                    augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
                                    augenfarbenMap.Add(new Range(3, 7), "braun");
                                    augenfarbenMap.Add(new Range(8, 11), "grün");
                                    augenfarbenMap.Add(new Range(12, 18), "blau");
                                    augenfarbenMap.Add(new Range(19, 20), "grau");

                                }
                                else if (gewaehlteSubrasse == "Gjalskerländer")
                                {
                                    haarfarbe.Add(new Range(1, 4), "blond");
                                    haarfarbe.Add(new Range(5, 8), "rotblond");
                                    haarfarbe.Add(new Range(9, 15), "rot");
                                    haarfarbe.Add(new Range(16, 17), "braun");
                                    haarfarbe.Add(new Range(18, 20), "schwarz");

                                    augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
                                    augenfarbenMap.Add(new Range(3, 10), "braun");
                                    augenfarbenMap.Add(new Range(11, 18), "grün");
                                    augenfarbenMap.Add(new Range(19, 20), "blau");
                                }
                                else
                                {
                                    throw new System.ArgumentOutOfRangeException();
                                }
                            }
                            catch (System.ArgumentOutOfRangeException)
                            {
                                System.Console.WriteLine("Ungültige Subrasse angegeben!");
                            }

                            koerpergroesse.basisgroesse = 1.55;
                            koerpergroesse.wuerfel = new int[3];
                            koerpergroesse.wuerfel[0] = 2;
                            koerpergroesse.wuerfel[1] = 20;
                            if (gewaehlteSubrasse == "Fjarninger")
                                koerpergroesse.wuerfel[2] = 5;
                            else
                                koerpergroesse.wuerfel[2] = 0;

                            gewichtsabzug = 95;

                            eigenschaftsModifikationen = new List<NameWertPaar>()
                            {
                                new NameWertPaar{name="Mu", wert=1},
                                new NameWertPaar{name="Ko", wert=1},
                                new NameWertPaar{name="KK", wert=1},
                            };

                            leModifikator = 11;
                            auModifikator = 10;
                            mrModifikator = -5;

                            automatischeVorteile = new List<NameWertPaar>(){};
                            automatischeNachteile = new List<NameWertPaar>()
                            {
                                new NameWertPaar{name="Jähzorn", wert=6},
                            };

                            empfohleneVorteile = new List<string>()
                            {
                                "Eisern", "Hohe Lebenskraft", "Innerer Kompass", "Kälteresistenz",
                                "Kampfrausch", "Richtungssinn", "Zäher Hund"
                            };
                            empfohleneNachteile = new List<string>()
                            {
                                "Blutrausch", "Hitzeempfindlich"
                            };

                            ungeeigneteVorteile = new List<string>()
                            {
                                "Herausragende Balance", "Hohe Magieresistenz"
                            };
                            ungeeigneteNachteile = new List<string>()
                            {
                                "Kleinwüchsig", "Nahrungsrestriktion"
                            };

                            ueblicheKulturen = new List<string>()
                            {
                                "Thorwal", "Fjarninger", "Gjalskerland"
                            };

                            unueblicheKulturen = new List<string> 
                            {
                                "Mittelländische Städte", "Mittelländische Landbevölkerung",
                                "Andergast und Nostria", "Bornland", "Svellttal", "südaventurien", "Tulamidische Stadtstaaten",
                                "Bukanier"
                            };

                            talentModifikatoren = new List<NameWertPaar>(){};

                            break;


                        default:
                            throw new System.ArgumentOutOfRangeException();
                    }


                    // Jetzt übernehmenw ir in jedem Fall die Maps für die Augen- und Haarfarben:
                    augenfarbe = augenfarbenMap;
                    haarfarbe = haarfabenMap;


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

    /// <summary>
    /// Bestimmt die Körpergrößen-Attribute in Abhängigkeit von der Rasse
    /// </summary>
    public struct koerpergroesse
    {
        /// <summary>
        /// Die Basisgröße in Schritt
        /// </summary>
        public double basisgroesse;
        /// <summary>
        /// Bestimmt mir den Würfel, den ich nutzen muss, um die Größe zu errechnen.
        /// </summary>
        public int[] wuerfel;
    }
}