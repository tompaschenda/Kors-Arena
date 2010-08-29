using System.Collections.Generic;
using Listen;
using Common;

namespace talentStruktur
{
    //////////////////////////////////////
    //  Talent-Struktur. TODO: Ausgliedern!
    //////////////////////////////////////

    /// <summary>
    /// Struktur, die alle Talente in Aventurien enthält:
    /// </summary>
    public struct talentStruct
    {
        // Wir listen nun auf, welche Attribute eine Talent hat:

        /// <summary>
        /// Name der Talente
        /// </summary>
        public string name;

        /// <summary>
        /// Talentwert, den ein Talent beim Helden aktuell hat. Ein Talentwert von "0" bedeutet, dass der Held
        /// das Talent bereits nutzen kann, aber NUR, wenn es bereits aktiviert wurde (s.u.), ODER ein Basistalent
        /// ist UND der Held die nötigen Voraussetzungen dafür erfüllt!
        /// </summary>
        public int talentwert;

        /// <summary>
        /// Wurde das Talent bereits aktiviert? Basistalente sind immer aktiviert (s.u.)
        /// </summary>
        public bool aktiviert;

        /// <summary>
        /// Handelt es sich um ein Basistalent? Wenn ja, ist es immer aktiviert!
        /// </summary>
        public bool istBasisTalent;

        /// <summary>
        /// Ist das Talent momentan überhaupt nutzbar (sprich: ist es aktiviert UND sind die Voraussetzungen erfüllt?)
        /// </summary>
        public bool nutzbar;

        /// <summary>
        /// Von welchem Typ ist das Talent? (Nahkampf, Fernkampf, Körperlich, etc.)
        /// </summary>
        public string talenttyp;

        /// <summary>
        /// Gibt die Spalte an, nach der das Talent gesteigert wird. Spezielisierungen oder Nachteile können
        /// die Spalte für den Helden verändern; diese grundlegende Spalte bleibt jedoch immer gleich!
        /// </summary>
        public string steigerungsspalte;

        /// <summary>
        /// Eine Liste, die jeweils Namen der jeweiligen Eigenschaften für die Talentprobe enthält.
        /// Im Fall von Kampftalenten sind AT/PA, bzw. FK-Basis und Ausweichen zu wählen.
        /// </summary>
        public List<string> eigenschaften;

        /// <summary>
        /// Eine Struktur, die alle nötigen Voraussetzungen enthält, die man für ein Talent erfüllt haben muss.
        /// Man kann ein Talent zwar aktiviert haben und besitzen (z.B. durch eine Rasse oder Kultur), es aber
        /// dennoch nicht nutzen, wenn die Voraussetzungen nicht erfüllt sind!
        /// </summary>
        public talentVorausssetzungen voraussetzungen;

        /// <summary>
        /// Effektive Behinderung, die bei Nutzung des Talents zum Tragen kommt. Der Wert wird IMMER
        /// von der Behinderung des Helden abgezogen. "0" entspricht daher eBE = BE. Beim Abzug muss man
        /// aufpassen, da der Held durch die eBE trotzdem natürlich niemals einen Bonus bekommen kann!
        /// </summary>
        public int effektiveBEAbzug;

        /// <summary>
        /// Ein Multiplikator, mit dem die normale BE multipliziert wird, um die eBE zu erhalten.
        /// </summary>
        public int effektiveBEMultiplikator;

        /// <summary>
        /// Eine Liste, die alle möglichen Spezialisierungen eines Talents enthält:
        /// </summary>
        public List<string> spezialisierungen;

        /// <summary>
        /// Eine Liste, die alle Fertigkeiten (genauer: "Talente") enthält, die anstelle dieses Talents
        /// genutzt werden können (z.B., falls der Held dieses Talent nicht aktiviert hat). Außerdem ist 
        /// jeweils auch der Aufschlagsmodifikator mit enthalten (positiv), der als Erschwernis hinzukommt.
        /// </summary>
        public List<NameWertPaar> ersatzweiseFertigkeiten;

        /// <summary>
        /// Eine Liste die alle gewählten Spezialisierungen inklusive ihrer Spezielisierunsstufe enthält:
        /// </summary>
        public List<NameWertPaar> gewaehlteSpezialisierungen;



        /// <summary>
        /// Name des Talents
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
                        // Akrobatik
                        ///////////////////////////////////////
                        case "Akrobatik":
                            name = value;

                            talentwert = 0;
                            aktiviert = false;
                            istBasisTalent = false;
                            nutzbar = false;
                            talenttyp = "körperlich";
                            steigerungsspalte = "D";

                            eigenschaften = new List<string>()
                            {
                                "Mu", "GE", "KK"
                            };

                            voraussetzungen = new talentVorausssetzungen();
                            // @ Tom: TODO: Wie kann ich nun in meiner Sturktur syntaktisch korrekt die
                            // Liste von Name-Wert-Paaren für Voraussetzungen setzen, z.B.
                            // "Körperbeherrschung", 4
                            // "CoolesTalent", 1
                            // ?

                            effektiveBEAbzug = 0;
                            effektiveBEMultiplikator = 2;

                            spezialisierungen = new List<string>()
                            {
                                "Balancieren", "Bodenakrobatik", "Schwingen", "Sprünge", "Winden"
                            };

                            ersatzweiseFertigkeiten = new List<NameWertPaar>()
                            {
                                new NameWertPaar{ name = "Körperbeherrschung", wert = 5 },
                                new NameWertPaar{ name = "Athletik", wert = 10 }
                            };

                            gewaehlteSpezialisierungen = new List<NameWertPaar>() {};

                            break;


                        default:
                            throw new System.ArgumentOutOfRangeException();


                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültiges Talent angegeben!");
                }
            }
        }

    }

    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen eines Talents aufgelistet sein können:
    /// </summary>
    public struct talentVorausssetzungen
    {
        /// <summary>
        /// Vorausgesetzte Eigenschaften
        /// </summary>
        public List<NameWertPaar> eigenschaften;
        /// <summary>
        /// Vorausgesetzte Talentwerte
        /// </summary>
        public List<NameWertPaar> talentwerte;
        /// <summary>
        /// Vorausgesetzte SF
        /// </summary>
        public List<string> andereSF;

    };


    /// <summary>
    /// Ermöglicht die eindeutige Identifizierung eines Talents.
    /// </summary>
    public struct talentIdentifier
    {
        /// <summary>
        /// Name des Talents
        /// </summary>
        public TalentName name;

        /// <summary>
        /// Wert des Talents (kann auch negativ sein!)
        /// </summary>
        public int wert;

        /// <summary>
        /// Handelt es sich um ein Leittalent (Elfen) oder nicht?
        /// Default: False!
        /// </summary>
        public bool leittalent;

    };

}