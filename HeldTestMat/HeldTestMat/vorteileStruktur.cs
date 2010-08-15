using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace vorteileStruktur
{

    /// <summary>
    /// Struktur, in der alle Attribute für einen Vorteil festgelegt werden:
    /// </summary>
    public struct vorteileStruct
    {
        /// <summary>
        /// Name des Vorteils
        /// </summary>
        public string name;

        /// <summary>
        /// Eine Liste mit allen Voraussetzungen, die man erfüllen muss
        /// für einen Vorteil
        /// </summary>
        public vorteilsVoraussetzungen voraussetzungen;

        /// <summary>
        /// Eine liste mit allen möglichen Spezialisierungen eines Vorteils.
        /// Z.B. eine bestimmte "Talentgruppe", etc.
        /// </summary>
        public List<subVorteil> moeglicheSpezialisierungen;

        /// <summary>
        /// Die tatsächlich vom Spieler gewählte Spezialisierung
        /// </summary>
        public string gewaehtleSpezialisierung;

        /// <summary>
        /// Liste mit allen möglichen Ausbildungsstätten / Akademien
        /// </summary>
        public List<string> moeglicheAkademien;

        /// <summary>
        /// Enthält die tatsächlich vom Spieler gewählte Akademies
        /// </summary>
        public string gewaehlteAkademie;

        /// <summary>
        /// Kann der SPIELER entscheiden, wie HOCH der Wert für den Vorteil sein soll?
        /// Z.B. Ausdauernd 5, 6, etc.
        /// </summary>
        public bool skalierbar;

        /// <summary>
        /// Einfache GP-Kosten für den Fall ohne Skalierung
        /// </summary>
        public int gpKosten;

        /// <summary>
        /// Eventuell müssen Magiebegabte andere GP-Kosten zahlen!
        /// </summary>
        public int gpKostenMaegiebegabte;

        /// <summary>
        /// Wie viele GP muss ich investieren, um einen Vorteil um eine Stufe zu erhöhen?
        /// Eine "Stufe" entspricht einem Klick in der GUI auf die nächste Kombination
        /// von Wert und GP-Kosten.
        /// Beispiel:
        /// Stufe 1: Wert 2, GP-Kosten: 3, GP-Kosten pro Stufe: 3, Wert pro Skalierungsstufe: 2
        /// Stufe 2: Wert 4, GP-Kosten: 6
        /// usw.
        /// </summary>
        public int gpKostenProSkalierungsstufe;

        /// <summary>
        /// Wie viele WERT-Punkte bekomme ich, wenn ich einen Vorteil um eine Stufe erhöhe?
        /// </summary>
        public int wertProSkalierungsstufe;

        /// <summary>
        /// Für welche Stufe des Vorteils hat sich der SPIELER entschieden? Dadurch kann man den Wert bestimmen!
        /// </summary>
        public int gewaehtleStufe;

        /// <summary>
        /// Welchen WERT hat mein Vorteil genau? Dies ist der eigentlich relevante Wert, der mich hinterher interessiert!
        /// </summary>
        public int wert;

        /// <summary>
        /// Handelt es sich bei dem Vorteil um eine Gabe?
        /// </summary>
        public bool istEineGabe;

        /// <summary>
        /// Kann man diesen Vorteil mehrmals wählen?
        /// </summary>
        public bool istMehrfachWaehlbar;

        /// <summary>
        /// Enhält eine Liste mti Vor- und Nachteilen, die zum jeweiligen
        /// Vorteil nicht kompatibel sind!
        /// </summary>
        public List<string> inkompatibleVorUndNachteile;

        /// <summary>
        /// Zu welcher Art von Vorteilen gehört der jeweilige Vorteil?
        /// Z.B.: "magisch", "profan", "geweiht"
        /// </summary>
        public string art;

        /// <summary>
        /// Name des Vorteils
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
                        ///////////////////////////////////////
                        // Adlig
                        ///////////////////////////////////////
                        case "Adlig":
                            name = value;
                            art = "profan";

                            moeglicheSpezialisierungen = new List<subVorteil>()
                            {
                                new subVorteil()
                                {
                                    name = "Adlige Abstammung",
                                    gpKosten = 7,
                                    voraussetzungen = new vorteilsVoraussetzungen()
                                    {                                        
                                        eigenschaften = new List<NameWertPaar>(){ new NameWertPaar(){ name = "SO", wert = 8}},
                                    },
                                    
                                },

                                new subVorteil()
                                {
                                    name = "Adliges Erbe",
                                    gpKosten = 6,
                                    voraussetzungen = new vorteilsVoraussetzungen()
                                    {
                                        andereVorteile = new List<nameSubnamePaar>(){ new nameSubnamePaar(){ name = "Adlig",  nameSubname= "Adlige Abstammung"}},
                                        eigenschaften = new List<NameWertPaar>(){ new NameWertPaar(){ name = "SO", wert = 8}},
                                    },
                                },
                                new subVorteil()
                                {
                                    name = "Amtsadel",
                                    gpKosten = 5,
                                }

                            };

                            istMehrfachWaehlbar = true;
                            istEineGabe = false;
                            skalierbar = false;

                            break;
                        
                        case "Affinität zu":
                            name = value;
                            art = "profan";
                            moeglicheSpezialisierungen = new List<subVorteil>()
                            {
                                new subVorteil()
                                {
                                    name = "Geistern",
                                    gpKosten = 2,
                                    gpKostenMagiebegabter = 5,
                                },
                                new subVorteil()
                                {
                                    name = "Elementaren",
                                    gpKosten = 2,
                                    gpKostenMagiebegabter = 5,
                                },
                                new subVorteil()
                                {
                                    name = "Dämonen",
                                    gpKosten = 2,
                                    gpKostenMagiebegabter = 5,
                                },

                            };

                            istMehrfachWaehlbar = false;
                            istEineGabe = false;
                            skalierbar = false;

                            break;
                        
                        case "Akademische Ausbildung":
                            name = value;
                            art = "profan";
                            moeglicheSpezialisierungen = new List<subVorteil>()
                            {
                                new subVorteil()
                                {
                                    name = "Gelehrter",
                                    gpKosten = 7,
                                },
                                new subVorteil()
                                {
                                    name = "Magier",
                                    gpKosten = 25,
                                },
                                new subVorteil()
                                {
                                    name = "Krieger",
                                    gpKosten = 20,
                                },
                            };
                            // Einschränkung: Man kann nur EINE Akademische Ausbildung haben!
                            istMehrfachWaehlbar = false;

                            break;

                        case "Altersresistenz":
                            name = value;
                            art = "profan";
                            gpKosten = 3;
                            inkompatibleVorUndNachteile = new List<string>() {"Schneller Alternd"};
                            break;

                        case "Astrale Regeneration":
                            name = value;
                            art = "magisch";
                            moeglicheSpezialisierungen = new List<subVorteil>()
                            {
                                new subVorteil()
                                {
                                    name = "I",
                                    gpKosten = 4,
                                    voraussetzungen = new vorteilsVoraussetzungen()
                                    {
                                        zauberkundigkeiten = new List<string> (){"Z", "H"},
                                    }
                                },
                                new subVorteil()
                                {
                                    name = "II",
                                    gpKosten = 8,
                                    voraussetzungen = new vorteilsVoraussetzungen()
                                    {
                                        zauberkundigkeiten = new List<string> (){"Z", "H"},
                                    }
                                },
                                new subVorteil()
                                {
                                    name = "III",
                                    gpKosten = 12,
                                    voraussetzungen = new vorteilsVoraussetzungen()
                                    {
                                        zauberkundigkeiten = new List<string> (){"Z", "H"},
                                    }
                                },

                            };

                            break;

                        case "Astralmacht":
                            name = value;
                            art = "magisch";
                            skalierbar = true;
                            gpKostenProSkalierungsstufe = 1;
                            wertProSkalierungsstufe = 1;
                            voraussetzungen = new vorteilsVoraussetzungen()
                            {
                                zauberkundigkeiten = new List<string>() { "Z","H", "V"},
                            };
                            break;

                        case "Ausdauernd":
                            name = value;
                            art = "profan";
                            skalierbar = true;
                            gpKostenProSkalierungsstufe = 1;
                            wertProSkalierungsstufe = 2;
                            break;
                        case "Ausdauernder Zauber":
                            name = value;
                            art = "magisch";
                            gpKosten = 3;
                            voraussetzungen = new vorteilsVoraussetzungen()
                            {
                                zauberkundigkeiten = new List<string>() { "Z","H","V" },
                            };
                            break;

                        case "Ausrüstungsvorteil":
                            name = value;
                            art = "profan";
                            skalierbar = true;
                            gpKostenProSkalierungsstufe = 1;
                            wertProSkalierungsstufe = 1;
                            break;

                        case "Balance":
                            name = value;
                            art = "profan";
                            inkompatibleVorUndNachteile = new List<string>() { "Herausragende Balance" };
                            break;
                        case "Begabung für...":
                            name = value;
                            art = "magisch";
                            istMehrfachWaehlbar = true;
                            moeglicheSpezialisierungen = new List<subVorteil>()
                            {
                                new subVorteil()
                                {
                                    ///???
                                },
                            };
                            break;



                        default:
                            throw new System.ArgumentOutOfRangeException();


                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültigen Vorteil angegeben!");
                }
            }
        }

    }



    /// <summary>
    /// Struktur, in der alle Voraussetzungen für einen Vorteil definiert werden
    /// </summary>
    public struct vorteilsVoraussetzungen
    {
        /// <summary>
        /// Benötigte Eigenschaftswerte für einen Vorteil
        /// </summary>
        public List<NameWertPaar> eigenschaften;

        /// <summary>
        /// Welche andere Vorteile und welche Spezialisierungen davon muss ich bereits besitzen?
        /// </summary>
        public List<nameSubnamePaar> andereVorteile;

        /// <summary>
        /// Welche Zauberkundigkeiten muss ich haben? Z.B.
        /// "Z" (Vollzauberer), "H" (Halbzauberer), etc.
        /// </summary>
        public List<string> zauberkundigkeiten;
    }
    
    /// <summary>
    /// Eine Struktur, die eine Spezialiserungsmöglichkeit für einen Vorteil enthält.
    /// </summary>
    public struct subVorteil
    {
        /// <summary>
        /// Name der Spezialisierung: 
        /// </summary>
        public string name;

        /// <summary>
        /// GP-Kosten der Spezialisierung:
        /// </summary>
        public int gpKosten;

        /// <summary>
        /// GP-Kosten für einen Magiebegabten:
        /// </summary>
        public int gpKostenMagiebegabter;

        /// <summary>
        /// Enthält die jeweiligen Voraussetzungen eines Subvorteils:
        /// </summary>
        public vorteilsVoraussetzungen voraussetzungen;
    }



}
