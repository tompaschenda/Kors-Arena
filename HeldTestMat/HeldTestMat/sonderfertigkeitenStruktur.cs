using System.Collections.Generic;
using listenStruktur;
using Common;
using Listen;
using wuerfelKlasse;

namespace sfStruktur
{
    //////////////////////////////////////
    //  Sonderfertigkeiten-Struktur. TODO: Ausgliedern!
    //////////////////////////////////////

    /// <summary>
    /// Struktur, die alle Sonderfertigkeiten in Aventurien enthält:
    /// </summary>
    public struct sfStruct
    {
        // Wir listen nun auf, welche Attribute eine Sonderfertigkeit hat:

        /// <summary>
        /// Name der SFs
        /// </summary>
        public string name;

        /// <summary>
        /// Typ der SF. Kann z.B. "allgemein", "Kampf", "klerikal", "magisch" sein, etc.
        /// </summary>
        public string typ;
        /// <summary>
        /// Kosten der SF in AP
        /// </summary>
        public int apKosten;
        /// <summary>
        /// Kosten der SF in GP
        /// </summary>
        public int gpKosten;

        /// <summary>
        /// Eine Liste mit allen möglichen Spezialisierungen. Das können z.B. Talente, Zauber oder Merkmale sein (u.v.m.)
        /// </summary>
        public List<string> moeglicheSpezialisierungen;

        /// <summary>
        /// Eine Liste mit allen vom Held tatsächlich gewählten Spezialisierungen, Dazu kommt jeweils (Wert) die
        /// STUFE der Spezialisierung, denn auf bestimmte Talente kann man sich z.B. mehrmals spezialisieren.
        /// </summary>
        public List<NameWertPaar> gewaehlteSpezialisierungen;

        /// <summary>
        /// Verbreitung der SF
        /// </summary>
        public int verbreitung;
        /// <summary>
        /// Ist die SF momentan aktiviert, bzw. überhaupt nutzbar?
        /// </summary>
        public bool nutzbar;

        /// <summary>
        /// Enthält die Voraussetzungen für die jeweilige Sonderfertigkeit (s.u.)
        /// </summary>
        public sfVorausssetzungen voraussetzungen;

        /// <summary>
        /// Name der SF
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
                        // Akklimatisierung
                        ///////////////////////////////////////
                        case "Akklimatisierung":
                            name = value;

                            typ = "allgemein";

                            moeglicheSpezialisierungen = new List<string>()
                            {
                                "Hitze","Kälte"
                            };

                            gewaehlteSpezialisierungen = new List<NameWertPaar>(){};

                            voraussetzungen = new sfVorausssetzungen();
                            // @ Tom: TODO: Wie kann ich nun in meiner Sturktur syntaktisch korrekt die
                            // Liste von Name-Wert-Paaren für Voraussetzungen setzen, z.B.
                            // "Körperbeherrschung", 4
                            // "CoolesTalent", 1
                            // ?

                            verbreitung = 7;
                            apKosten = 150;
                            gpKosten = 999; // Kann nicht zu Spielgewinn genommen werden!
                            nutzbar = false;                            
                            
                            break;

                                                
                        default:
                            throw new System.ArgumentOutOfRangeException();


                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültige Sonderfertigkeit angegeben!");
                }
            }
        }

    }

    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer SF aufgelistet sein können:
    /// </summary>
    public struct sfVorausssetzungen
    {
        /// <summary>
        /// Voraussetzungen von Eigenschaften
        /// </summary>
        public List<NameWertPaar> eigenschaften;
        /// <summary>
        /// Vorausgesetzte Talentwerte
        /// </summary>
        public List<NameWertPaar> talentwerte;
        /// <summary>
        /// Vorausgesetzte, andere SF
        /// </summary>
        public List<string> andereSF;
    };

    /// <summary>
    /// Eine Sturktur, die das eindeutige Identifizieren einer SF ermöglicht:
    /// </summary>
    public struct sfIdentifier
    {
        /// <summary>
        /// Name der SF
        /// </summary>
        public SFNamen name;

        /// <summary>
        /// Talentspeziealisierung, die man sich auswählt.
        /// </summary>
        public TalentSpezialisierung talentSubSpez;

        /// <summary>
        /// Talent, das man sich für die Spezialisierung auswählt:
        /// </summary>
        public TalentName talent;
    }

}