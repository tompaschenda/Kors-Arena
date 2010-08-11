using System.Collections.Generic;
using listenStruktur;

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
        /// Ausprägung der SF. 
        /// </summary>
        public string auspraegung;
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
        ///  Stufe der Spezialisierung (z.B. bei mehrfacher Talentspezialisierung)
        /// </summary>
        public int spezialisierungsstufe;
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
                        // TestSF
                        ///////////////////////////////////////
                        case "TestSF":
                            name = value;
                            
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

}