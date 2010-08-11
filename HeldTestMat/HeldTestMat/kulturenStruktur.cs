using System.Collections.Generic;
using listenStruktur;
using sfStruktur;

namespace kulturenStruktur
{
    //////////////////////////////////////
    //  Kulturen-Struktur. TODO: Ausgliedern!
    //////////////////////////////////////

    /// <summary>
    /// Struktur, die alle Kulturen in Aventurien enthält:
    /// </summary>
    public struct kulturenStruct
    {
        // Wir listen nun auf, welche Attribute eine Kultur hat:

        /// <summary>
        /// Name der Kultur
        /// </summary>
        public string name;

        /// <summary>
        /// Eine liste, die alle möglichen Subkulturen enthält. Falls es keine Subkulturen gibt, 
        /// bleibt die Liste leer.
        /// </summary>
        public List<string> moeglicheSubkulturen;

        /// <summary>
        /// Die Generierungskosten der Kultur in GP (Man kann eine Kultur NUR zur Generierung erwerben)
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Der Kultur-Modifikator auf die LE
        /// </summary>
        public int leModifikator;
        /// <summary>
        /// Der Kultur-Modifikator auf die Ausdauer
        /// </summary>
        public int auModifikator;
        /// <summary>
        /// Der Kultur-Modifikator auf die Magieresistenz
        /// </summary>
        public int mrModifikator;
        /// <summary>
        /// Der Kultur Modifikator auf die Eigenschaften inklusive Name der Eigenschaft
        /// </summary>
        public List<NameWertPaar> eigenschaftsModifikationen;
        /// <summary>
        /// Der Maximale Sozialstatus, den man für die Kulturzugehörigkeit besitzen darf
        /// </summary>
        public int soMaximum;
        /// <summary>
        /// Eine Liste aller automatischen Vorteile durch die Kultur (inklusive Wert)
        /// </summary>
        public List<NameWertPaar> automatischeVorteile;
        /// <summary>
        /// Eine Liste aller automatischen Nachteile durch die Kultur (inklusive Wert)
        /// </summary>
        public List<NameWertPaar> automatischeNachteile;
        /// <summary>
        /// Eine liste der empfohlenen Vorteile durch die Kultur (nicht bindend)
        /// </summary>
        public List<string> empfohleneVorteile;
        /// <summary>
        /// Eine liste der empfohlenen Nachteile durch die Kultur (nicht bindend)
        /// </summary>
        public List<string> empfohleneNachteile;
        /// <summary>
        /// Eine Liste der ungeeigneten Vorteile durch die Kultur (sollte bindend sein)
        /// </summary>
        public List<string> ungeeigneteVorteile;
        /// <summary>
        /// Eine Liste der ungeeigneten Nachteile durch die Kultur (sollte bindend sein)
        /// </summary>
        public List<string> ungeeigneteNachteile;
        /// <summary>
        /// Eine Liste der geeigneten Professionen durch die Kultur (ist nicht bindend, aber empfohlen)
        /// </summary>
        public List<string> geeigneteProfessionen;
        /// <summary>
        /// Eine Liste der durch die Kultur modifizierten Talente inklusive ihrem Wert
        /// </summary>
        public List<NameWertPaar> talente;
        /// <summary>
        /// Eine Liste der durch die Kultur erworbenen Sonderfertigkeiten
        /// </summary>
        public List<string> sonderfertigkeiten;

        /// <summary>
        /// Name der Kultur
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
                        // Testkultur
                        ///////////////////////////////////////
                        case "Testkultur":
                            name = value;

                            break;


                        default:
                            throw new System.ArgumentOutOfRangeException();


                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültige Kultur angegeben!");
                }
            }
        }
    };
}
