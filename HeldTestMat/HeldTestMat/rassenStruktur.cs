using System.Collections.Generic;
using listenStruktur;

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
        /// <summary>
        ///  Generierungskosten für die jeweilige Rasse in GP
        /// </summary>
        public int generierungskosten;
        /// <summary>
        /// Substruktur, die die möglichen Haarfarben und die jeweiligen Wahrscheinlichkeiten dafür enthält.
        /// </summary>
        public haarfarbe haarfarbe;
        /// <summary>
        /// Substruktur, die die möglichen Augenfarben und die jeweiligen Wahrscheinlichkeiten dafür enthält.
        /// </summary>
        public augenfarbe augenfarbe;
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
        public eigenschaftsModifikationen eigenschaftsModifikationen;
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
        public automatischeVorteile automatischeVorteile;
        /// <summary>
        ///  Automatische Nachteile durch die Rasse
        /// </summary>
        public List<NameWertPaar> automatischeNachteile;
        /// <summary>
        ///  Empfohlene Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public empfohleneVorteile empfohleneVorteile;
        /// <summary>
        ///  Empfohlene Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public empfohleneNachteile empfohleneNachteile;
        /// <summary>
        ///  Nicht geeignere Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public ungeeigneteVorteile ungeeigneteVorteile;
        /// <summary>
        ///  Nicht geeignere Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public ungeeigneteNachteile ungeeigneteNachteile;
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
        public List<talentModifikatoren> talentModifikatoren;

        /// <summary>
        /// Eine Liste mit allen möglichen Subrassennamen. Enthält immer mindestens den
        /// Eintrag mit dem eigentlichen Rassennamen. Bei manchen Rassen (z.B. Thorwaler)
        /// können Subrassen gewählt werden.
        /// </summary>
        public List<string> moeglicheSubrassen;

        /// <summary>
        /// Der Name der Subrasse. Wird automatisch gesetzt, wenn der Name der Rasse gewählt wird.
        /// </summary>
        public string subrassenName;

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
            subrassenName = auswahlSubrasse();
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
                listenSammlung listen = new listenSammlung();

                try
                {
                    switch (value)
                    {
                        ///////////////////////////////////////
                        // Mittelreichler
                        ///////////////////////////////////////
                        case "Mittelreichler":

                            /////////////////////////////
                            //  TODO: Auslagern in "Rassenfabrik"
                            //////////////////////////////

                            name = value;

                            moeglicheSubrassen = new List<string>()
                            {
                                "Mittelreichler"
                            };

                            string gewaehlteSubrasse = auswahlSubrasse();
                            setzeSubrasse();

                            generierungskosten = 0;

                            haarfarbe.farben = new List<string>()
                            {
                                "schwarz","braun", "dunkelblond", "blond",
                                "weißblond", "rot"
                            };

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

                            augenfarbe.farben = new List<string>()
                            {
                                "dunkelbraun", "braun", "grün", 
                                "blau", "grau", "schwarz"
                            };

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

                            eigenschaftsModifikationen.name = new List<string>()
                            {};
                            eigenschaftsModifikationen.modifikator = new List<int>()
                            {};

                            leModifikator = 10;
                            auModifikator = 10;
                            mrModifikator = -4;

                            automatischeVorteile.name = new List<string>()
                            {};
                            automatischeVorteile.wert = new List<int>()
                            {};
                            /*
                            automatischeNachteile.name = new List<string>()
                            {};
                            automatischeNachteile.wert = new List<int>()
                            {};
                            */
                            automatischeNachteile = new List<NameWertPaar>()
                            {
                                new NameWertPaar{name="Blind", wert=5},
                                new NameWertPaar{name="Taub", wert=5}
                            };
                            
                            

                            empfohleneVorteile.name = new List<string>()
                            {};
                            empfohleneNachteile.name = new List<string>()
                            {};

                            ungeeigneteVorteile.name = new List<string>()
                            {
                                "Herausragende Balance"
                            };
                            ungeeigneteNachteile.name = new List<string>()
                            {
                                "Nahrungsrestriktion"
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
                            talentModifikatoren = new List<talentModifikatoren>
                            {
                                new talentModifikatoren{name="", modifikator=0}
                            };

                            break;

                        ///////////////////////////////////////
                        // Tulamiden
                        ///////////////////////////////////////
                        case "Tulamiden":

                            name = value;

                            moeglicheSubrassen = new List<string>()
                            {
                                "Tulamiden"
                            };

                            setzeSubrasse();

                            generierungskosten = 0;

                            haarfarbe.farben = new List<string>()
                            {
                                "schwarz","dunkelbraun", "mittelbraun", "hellbraun",
                                "blond", "rot"
                            };

                            haarfarbe.werte = new int[6, 2];
                            haarfarbe.werte[0, 0] = 1;
                            haarfarbe.werte[0, 1] = 6;
                            haarfarbe.werte[1, 0] = 7;
                            haarfarbe.werte[1, 1] = 12;
                            haarfarbe.werte[2, 0] = 13;
                            haarfarbe.werte[2, 1] = 14;
                            haarfarbe.werte[3, 0] = 15;
                            haarfarbe.werte[3, 1] = 17;
                            haarfarbe.werte[4, 0] = 18;
                            haarfarbe.werte[4, 1] = 19;
                            haarfarbe.werte[5, 0] = 20;
                            haarfarbe.werte[5, 1] = 20;

                            augenfarbe.farben = new List<string>()
                            {
                                "schwarz", "dunkelbraun", "braun", 
                                "grau", "grün", "blau"
                            };

                            augenfarbe.werte = new int[6, 2];
                            augenfarbe.werte[0, 0] = 1;
                            augenfarbe.werte[0, 1] = 4;
                            augenfarbe.werte[1, 0] = 5;
                            augenfarbe.werte[1, 1] = 12;
                            augenfarbe.werte[2, 0] = 13;
                            augenfarbe.werte[2, 1] = 16;
                            augenfarbe.werte[3, 0] = 17;
                            augenfarbe.werte[3, 1] = 18;
                            augenfarbe.werte[4, 0] = 19;
                            augenfarbe.werte[4, 1] = 19;
                            augenfarbe.werte[5, 0] = 20;
                            augenfarbe.werte[5, 1] = 20;

                            koerpergroesse.basisgroesse = 1.55;
                            koerpergroesse.wuerfel = new int[3];
                            koerpergroesse.wuerfel[0] = 2;
                            koerpergroesse.wuerfel[1] = 20;
                            koerpergroesse.wuerfel[2] = 0;

                            gewichtsabzug = 105;

                            eigenschaftsModifikationen.name = new List<string>()
                            {};
                            eigenschaftsModifikationen.modifikator = new List<int>()
                            {};

                            leModifikator = 10;
                            auModifikator = 10;
                            mrModifikator = -4;

                            automatischeVorteile.name = new List<string>()
                            {};
                            automatischeVorteile.wert = new List<int>()
                            {};
                            /*
                            automatischeNachteile.name = new List<string>()
                            {};
                            automatischeNachteile.wert = new List<int>()
                            {};
                            */
                            empfohleneVorteile.name = new List<string>()
                            {};
                            empfohleneNachteile.name = new List<string>()
                            {};

                            ungeeigneteVorteile.name = new List<string>()
                            {
                                "Herausragende Balance"
                            };
                            ungeeigneteNachteile.name = new List<string>()
                            {
                                "Nahrungsrestriktion"
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

                            talentModifikatoren = new List<talentModifikatoren>
                            {
                                new talentModifikatoren{name="", modifikator=0}
                            };

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

                            setzeSubrasse();

                            generierungskosten = 5;

                            try
                            {
                                if ( subrassenName == "Thorwaler" || subrassenName == "Fjarninger")
                                {

                                    haarfarbe.farben = new List<string>()
                                    {
                                        "blond", "rotblond", "weißblond", "rot", "dunkelblond", "braun", "schwarz"
                                    };

                                    haarfarbe.werte = new int[7, 2];
                                    haarfarbe.werte[0, 0] = 1;
                                    haarfarbe.werte[0, 1] = 8;
                                    haarfarbe.werte[1, 0] = 9;
                                    haarfarbe.werte[1, 1] = 13;
                                    haarfarbe.werte[2, 0] = 14;
                                    haarfarbe.werte[2, 1] = 15;
                                    haarfarbe.werte[3, 0] = 16;
                                    haarfarbe.werte[3, 1] = 17;
                                    haarfarbe.werte[4, 0] = 18;
                                    haarfarbe.werte[4, 1] = 18;
                                    haarfarbe.werte[5, 0] = 19;
                                    haarfarbe.werte[5, 1] = 19;
                                    haarfarbe.werte[6, 0] = 20;
                                    haarfarbe.werte[6, 1] = 20;

                                    augenfarbe.farben = new List<string>()
                                    {
                                        "dunkelbraun", "braun", "grün", "blau", "grau"
                                    };
                                    RangeMap<string> augenMap = new RangeMap<string>()
                                    {
                                      {new Range{lower=1, upper=2}, "braun"}
                                    };
                                    augenMap.Add(new Range(1, 2), "braun");
                                    int result = 5;
                                    augenMap.getValue(result);
                                    
                                    augenfarbe.werte = new int[5, 2];
                                    augenfarbe.werte[0, 0] = 1;
                                    augenfarbe.werte[0, 1] = 2;
                                    augenfarbe.werte[1, 0] = 3;
                                    augenfarbe.werte[1, 1] = 7;
                                    augenfarbe.werte[2, 0] = 8;
                                    augenfarbe.werte[2, 1] = 11;
                                    augenfarbe.werte[3, 0] = 12;
                                    augenfarbe.werte[3, 1] = 18;
                                    augenfarbe.werte[4, 0] = 19;
                                    augenfarbe.werte[4, 1] = 20;
                                }
                                else if ( subrassenName == "Gjalskerländer" )
                                {

                                    haarfarbe.farben = new List<string>()
                                    {
                                        "blond", "rotblond", "rot", "braun", "schwarz"
                                    };

                                    haarfarbe.werte = new int[5, 2];
                                    haarfarbe.werte[0, 0] = 1;
                                    haarfarbe.werte[0, 1] = 4;
                                    haarfarbe.werte[1, 0] = 5;
                                    haarfarbe.werte[1, 1] = 8;
                                    haarfarbe.werte[2, 0] = 9;
                                    haarfarbe.werte[2, 1] = 15;
                                    haarfarbe.werte[3, 0] = 16;
                                    haarfarbe.werte[3, 1] = 17;
                                    haarfarbe.werte[4, 0] = 18;
                                    haarfarbe.werte[4, 1] = 20;

                                    augenfarbe.farben = new List<string>()
                                    {
                                        "dunkelbraun", "braun", "grün", "blau"
                                    };

                                    augenfarbe.werte = new int[4, 2];
                                    augenfarbe.werte[0, 0] = 1;
                                    augenfarbe.werte[0, 1] = 2;
                                    augenfarbe.werte[1, 0] = 3;
                                    augenfarbe.werte[1, 1] = 10;
                                    augenfarbe.werte[2, 0] = 11;
                                    augenfarbe.werte[2, 1] = 18;
                                    augenfarbe.werte[3, 0] = 19;
                                    augenfarbe.werte[3, 1] = 20;
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
                            if( subrassenName == "Fjarninger" )
                            {
                                koerpergroesse.wuerfel[2] = 5;
                            }
                            else
                                koerpergroesse.wuerfel[2] = 0;

                            gewichtsabzug = 95;

                            eigenschaftsModifikationen.name = new List<string>()
                            {
                                "Mu", "Ko", "KK"
                            };
                            eigenschaftsModifikationen.modifikator = new List<int>()
                            {
                                1, 1, 1
                            };

                            leModifikator = 11;
                            auModifikator = 10;
                            mrModifikator = -5;

                            automatischeVorteile.name = new List<string>()
                            {};
                            automatischeVorteile.wert = new List<int>()
                            {};
                            //automatischeNachteile.name = new List<string>()
                            //{
                            //    "Jähzorn"
                            //};
                            //automatischeNachteile.wert = new List<int>()
                            //{
                            //    6
                            //};

                            empfohleneVorteile.name = new List<string>()
                            {
                                "Eisern", "Hohe Lebenskraft", "Innerer Kompass", "Kälteresistenz",
                                "Kampfrausch", "Richtungssinn", "Zäher Hund"
                            };
                            empfohleneNachteile.name = new List<string>()
                            {
                                "Blutrausch", "Hitzeempfindlich"
                            };

                            ungeeigneteVorteile.name = new List<string>()
                            {
                                "Herausragende Balance", "Hohe Magieresistenz"
                            };
                            ungeeigneteNachteile.name = new List<string>()
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

                            talentModifikatoren = new List<talentModifikatoren>
                            {
                                // TODO!!!
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

    /// <summary>
    /// Substruktur für die automatischen Vorteile durch eine Rasse
    /// </summary>
    public struct automatischeVorteile
    {       
       /// <summary>
       /// Ich habe den Namen des Vorteils
       /// </summary>
        public List<string> name;
        /// <summary>
        /// Und ggfs. einen Wert des Vorteils (z.B. Raumangst 4 => "4")
        /// </summary>
        public List<int> wert;
    }

    /// <summary>
    /// Substruktur für die automatischen Nachteile durch eine Rasse
    /// </summary>
    /**
    public struct automatischeNachteile
    {
        
        /// <summary>
        /// Ich habe den Namen des Nachteile
        /// </summary>
        public List<string> name;
        /// <summary>
        /// Und ggfs. einen Wert des Nachteile (z.B. Raumangst 4 => "4")
        /// </summary>
        public List<int> wert;
        
        List<Nachteil> nachteile;
    }
     */
    

    /// <summary>
    /// Substruktur für die empfohlenen Vorteile durch eine Rasse
    /// </summary>
    public struct empfohleneVorteile
    {
        /// <summary>
        /// Ich habe den Namen des Vorteils
        /// </summary>
        public List<string> name;
    }

    /// <summary>
    /// Substruktur für die empfohlenen Nachteile durch eine Rasse
    /// </summary>
    public struct empfohleneNachteile
    {
        /// <summary>
        /// Ich habe den Namen des Nachteile
        /// </summary>
        public List<string> name;
    }



    /// <summary>
    /// Substruktur für die ungeeigneten Vorteile durch eine Rasse
    /// </summary>
    public struct ungeeigneteVorteile
    {
        /// <summary>
        /// Ich habe den Namen des Vorteils
        /// </summary>
        public List<string> name;
    }

    /// <summary>
    /// Substruktur für die ungeeigneten Nachteile durch eine Rasse
    /// </summary>
    public struct ungeeigneteNachteile
    {
        /// <summary>
        /// Ich habe den Namen des Nachteile
        /// </summary>
        public List<string> name;
    }





    /// <summary>
    /// Substruktur für die Talentmodifikatoren:
    /// </summary>
    public struct talentModifikatoren
    {
        /// <summary>
        /// Ich brauche den Namen des jeweiligen Talents
        /// </summary>
        public string name;
        /// <summary>
        /// Und ich brauche den Modifiaktor auf das jeweilige Talent:
        /// </summary>
        public int modifikator;
    }


    /// <summary>
    /// Eigenschaftsmodifikatoren durch eine Rasse
    /// </summary>
    public struct eigenschaftsModifikationen
    {
        /// <summary>
        /// Ich brauche den Namen einer Eigenschaft:
        /// </summary>
        public List<string> name;
        /// <summary>
        /// Und den Modifikator:
        /// </summary>
        public List<int> modifikator;
    }

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

    /// <summary>
    /// Bestimmt die Haar-Farben-Attribute eines Helden in Abhängigkeit von der Rasse
    /// </summary>
    public struct haarfarbe
    {
        /// <summary>
        /// Eine Auflistung aller möglichen Farben
        /// </summary>
        public List<string> farben;
        /// <summary>
        /// Die jeweiligen W-Keiten auf einem W20 für das Auftreten der jewiligen Farbe
        /// </summary>
        public int[,] werte;
    }

    /// <summary>
    /// Bestimmt die Augen-Farben-Attribute eines Helden in Abhängigkeit von der Rasse
    /// </summary>
    public struct augenfarbe
    {
        /// <summary>
        /// Eine Auflistung aller möglichen Farben
        /// </summary>
        public List<string> farben;
        /// <summary>
        /// Die jeweiligen W-Keiten auf einem W20 für das Auftreten der jeweiligen Farbe
        /// </summary>
        public int[,] werte;
    }


}