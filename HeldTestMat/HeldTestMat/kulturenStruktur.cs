using System.Collections.Generic;
using listenStruktur;
using sfStruktur;
using spielerAuswahl;
 

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
        public List<subkultur> moeglicheSubkulturen;

        /// <summary>
        /// Die Subkultur, die der Held tatsächlich ausgewählt hat.
        /// </summary>
        public subkultur gewaehlteSubkultur;

        /// <summary>
        /// Die Generierungskosten der Kultur in GP (Man kann eine Kultur NUR zur Generierung erwerben)
        /// </summary>
        public int generierungskostenKultur;

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
        /// Eine Liste der ungeeigneten Professionen durch die Kultur (sollte bindend sein)
        /// </summary>
        public List<string> ungeeigneteProfessionen;

        /// <summary>
        /// Eine Liste der durch die Kultur fixen Talentboni inklusive ihrem Wert
        /// </summary>
        public List<NameWertPaar> talentBoni;

        /// <summary>
        /// Eine Liste der durch die Kultur wählbaren Talentboni inklusive ihrem Wert
        /// </summary>
        public List<NamenslisteWertPaar> talentWahlBoniMoeglich;

        /// <summary>
        /// Eine Liste, die tatsächlich vom Spieler gewählten Talentboni endhält (endgültig)
        /// </summary>
        public List<NameWertPaar> talentWahlBoniGewählt;

        /// <summary>
        /// Enthält die Muttersprache des Helden. Der Wert ist IMMER KL-2
        /// und wird erst zu späterer Zeit besimmt, wenn der Held endgültig
        /// zusammen gebastelt wird.
        /// </summary>
        public string muttersprache;

        /// <summary>
        /// Wie Muttersprache, aber der Wert ist IMMER KL-4.
        /// </summary>
        public string zweitsprache;

        /// <summary>
        /// Eine Liste, die mögliche Verkehrssprachen enthält, für die sich ein
        /// Held entscheiden kann.
        /// </summary>
        public List<NameWertPaar> moeglicheVerkehrssprachen;

        /// <summary>
        /// Eine Liste, die die Verkehrssprachen enthält, für die sich ein Spieler
        /// auch wirklich entschieden hat (endgültig)
        /// </summary>
        public List<string> gewaehlteVerkehrssprachen;

        /// <summary>
        /// Eine Liste der durch die Kultur erworbenen Sonderfertigkeiten
        /// </summary>
        public List<nameSubnamePaar> sonderfertigkeiten;

        /// <summary>
        /// Eine Liste der verbilligten Sonderfertigkeiten, die ein Held günstiger beziehen kann.
        /// </summary>
        public List<nameSubnamePaar> verbilligteSonderfertigkeiten;

        /// <summary>
        /// Eine Auswahlliste, aus der sich ein Spieler jeweils bestimmte Talente auswählen kann.
        /// </summary>
        public List<string> auswahlListe;

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
                        // Mittelländische Städte
                        ///////////////////////////////////////
                        case "Mittelländische Städte":
                            name = value;

                            generierungskostenKultur = 0;

                            leModifikator = 0;
                            auModifikator = 0;
                            mrModifikator = 0;
                            eigenschaftsModifikationen = new List<NameWertPaar>() { };
                            soMaximum = 99;
                            automatischeVorteile = new List<NameWertPaar>() { };
                            automatischeNachteile = new List<NameWertPaar>() { };
                            empfohleneVorteile = new List<string>()
                            {
                                "Ausrüstungsvorteil", "BesondererBesitz", "Soziale Anpassungsfähigkeit", "Verbindungen"
                            };
                            empfohleneNachteile = new List<string>()
                            {
                                "Schulden", "Verpflichtungen", "Vorurteile"
                            };
                            ungeeigneteVorteile = new List<string>()
                            {
                                "Feenfreund"
                            };
                            ungeeigneteNachteile = new List<string>()
                            {
                                "Angst vor Menschenmassen", "Raumangst"
                            };

                            geeigneteProfessionen = new List<string>()
                            {
                                // TODO:
                                "alle kriegerischen", "alle reisenden", "alle gesellschaftlichen", "alle handwerklichen",
                                "Alchimist", "Druide", "Hexe", "Magier", "Scharlatan", "Schelm", "Geweihter",
                            };
                            ungeeigneteProfessionen = new List<string>()
                            {
                                "Stammeskrieger", "Straßenräuber"
                            };

                            // Wir tragen zunächst die fixen Talentboni ein, die der Held in jedem
                            // Fall bekommt:
                            talentBoni = new List<NameWertPaar>()
                            {
                                new NameWertPaar() { name = "Dolche" , wert = 1 },
                                new NameWertPaar() { name = "Infanteriewaffen", wert = 1 },
                                new NameWertPaar() { name = "Raufen", wert = 1 },
                                new NameWertPaar() { name = "Zechen", wert = 1 },
                                new NameWertPaar() { name = "Etikette", wert = 1 },
                                new NameWertPaar() { name = "Gassenwissen", wert = 1 },
                                new NameWertPaar() { name = "Menschenkenntnis", wert = 1 },
                                new NameWertPaar() { name = "Überreden", wert = 1 },
                                new NameWertPaar() { name = "Götter und Kulte", wert = 2 },
                                new NameWertPaar() { name = "Heraldik", wert = 1 },
                                new NameWertPaar() { name = "Rechnen", wert = 1 },
                                new NameWertPaar() { name = "Rechtskunde", wert = 1 },
                                new NameWertPaar() { name = "Sagen und Legenden", wert = 2 },
                            };

                            // Nun kommen die Talentboni hinzu, für die der Held sich später
                            // entschieden muss:
                            talentWahlBoniMoeglich = new List<NamenslisteWertPaar>()
                            {
                                new NamenslisteWertPaar()
                                { 
                                    namensListe = new List<string>(){"Armburst", "Bogen", "Wurfmesser",},
                                    wert = 1,
                                },
                                new NamenslisteWertPaar()
                                { 
                                    namensListe = new List<string>(){"Ackerbau", "Hauswirtschaft"},
                                    wert = 1,
                                },
                            };
                            
                            // Eine Muttersprache wird automatisch festgelegt:
                            muttersprache = "Garethi";
                            // Eine Zweitsprache gibt es in diesem Fall nicht.
                            zweitsprache = "";

                            // Nun darf der Held sich noch eine zusätzliche auswählen:
                            moeglicheVerkehrssprachen = new List<NameWertPaar>()
                            { 
                                new NameWertPaar(){name = "Tulamidya", wert = 3},
                                new NameWertPaar(){name = "Rogolan", wert = 3},
                                new NameWertPaar(){name = "Thorwalsch", wert = 3},
                            };

                            // Jetzt kann es losgehen!
                            sonderfertigkeiten = new List<nameSubnamePaar>()
                            {
                                new nameSubnamePaar (){name = "Kulturkunde", nameSubname = "je nach Region"},
                                new nameSubnamePaar (){name = "Ortskenntnis", nameSubname = "je nach Stadt/Dorf"},
                            };


                            // Wir führen nun alle möglichen Subkulturen auf. Eine Entscheidung wird hier noch nicht
                            // getroffen.

                            moeglicheSubkulturen = new List<subkultur>() 
                            {

                                // Wir beginnen mit den Hafenstädten:
                                new subkultur ()
                                {
                                    name = "Hafenstädte und Städte and großen Flüssen",
                                    generierungskosten = 3,
                                    staedteMoeglich = new List<string>(){"Elenvina", "Ferdok", "Festum", "Harben", "Havena", "Perricum"},
                                    talentBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){name = "Schwimmen", wert = 1},
                                        new NameWertPaar(){name = "Menschenkenntnis", wert = 1},
                                        new NameWertPaar(){name = "Überreden", wert = 1},
                                        new NameWertPaar(){name = "Fesseln/Entfesseln", wert = 1},
                                        new NameWertPaar(){name = "Fischen/Angeln", wert = 1},
                                        new NameWertPaar(){name = "Geographie", wert = 1},
                                        new NameWertPaar(){name = "Boote Fahren", wert = 1},
                                        new NameWertPaar(){name = "Seefahrt", wert = 1},
                                    },
                                },


                                new subkultur ()
                                {
                                    name = "Städte mit wichtigen Tempeln/Pilgerstätte",
                                    generierungskosten = 2,
                                    staedteMoeglich = new List<string>(){"Angbar", "Gareth/Neu-Gareth", "Rommilys"},
                                    talentBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){name = "Überreden", wert = 2},
                                        new NameWertPaar(){name = "Geographie", wert = 1},
                                        new NameWertPaar(){name = "Geschichtswissen", wert = 1},
                                        new NameWertPaar(){name = "Götter/Kulte", wert = 1},
                                    },

                                    moeglicheVerkehrssprachen = new List<NameWertPaar>()
                                    {
                                        // TODO!
                                        new NameWertPaar(){ name = "alle", wert = 4},
                                    },                                   

                                },


                                new subkultur ()
                                {
                                    name = "Siedlerstädte des Nordens",
                                    generierungskosten = 1,
                                    staedteMoeglich = new List<string>(){"Uhlenberg", "Donnerbach", "Riva", "Lowangen", "Norburg"},
                                    talentBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){name = "Wildnisleben", wert = 1},
                                        new NameWertPaar(){name = "Ackerbau", wert = 1},
                                        new NameWertPaar(){name = "Viehzucht", wert = 1},
                                        new NameWertPaar(){name = "Wildnisleben", wert = 1},
                                    },

                                    moeglicheVerkehrssprachen = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar() {name = "Nujuka", wert = 3},
                                        new NameWertPaar() {name = "Alaani", wert = 3},
                                        new NameWertPaar() {name = "Oloarkh", wert = 3},
                                    },

                                    verkehrssprachenDerHauptKulturErsetzen = true,
                                },

                                new subkultur ()
                                {
                                    name = "Städtischer Adel",
                                    generierungskosten = 1,
                                    voraussetzungen = new subkulturVoraussetzungen()
                                    {
                                        eigenschaften = new List<NameWertPaar>(){ new NameWertPaar() {name = "SO", wert = 7}},
                                        vorteile = new List<NameWertPaar>(){ new NameWertPaar() {name = "adlig", wert = 0}},
                                    },
                                    talentBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){ name = "Etikette", wert = 2},
                                        new NameWertPaar(){ name = "Heraldik", wert = 2},
                                    },
                                    talentWahlBoniMoeglich = new List<NamenslisteWertPaar>()
                                    {
                                        new NamenslisteWertPaar() { namensListe = new List<string>(){"Fechtwaffen","Schwerter"} , wert = 1},
                                    },

                                    schriftBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){ name = "Kusliker Zeichen", wert = 2},
                                    },

                                    zuEntfernendeTalentBoni = new List<string>()
                                    {
                                        "Infanteriewaffen", "Gassenwissen",
                                    },
                                },

                                new subkultur()
                                {
                                    name = "Kannemünde/Mhanerhaven",
                                    generierungskosten = 3,
                                    talentBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){name = "Menschenkenntnis", wert = 1},
                                        new NameWertPaar(){name = "Überreden", wert = 1},
                                        new NameWertPaar(){name = "Geographie", wert = 1},
                                        new NameWertPaar(){name = "Rechnen", wert = 1},
                                    },

                                    talentWahlBoniMoeglich = new List<NamenslisteWertPaar>()
                                    {
                                        new NamenslisteWertPaar() { namensListe = new List<string>(){"Boote Fahren","Fischen/Angeln", "Kochen"} , wert = 1},
                                    },

                                    verbilligteSonderfertigkeiten = new List<nameSubnamePaar>()
                                    {
                                        new nameSubnamePaar() {name = "Kulturkunde", nameSubname = "Tulamidenlande"},
                                    },

                                    zweitsprache = "Tulamidya",

                                    verkehrssprachenDerHauptKulturErsetzen = true,

                                },

                                new subkultur()
                                {
                                    name = "Flüchtlinge aus borbaradianisch besetzten Städten",
                                    generierungskosten = 0,
                                    staedteMoeglich = new List<string>(){"Ysilia", "Mendena", "Ilsur", "Warunk", "Beilunk"},
                                    eigenschaften = new List<NameWertPaar>() { new NameWertPaar(){name = "MU", wert = -1}},
                                    talentBoni = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar(){name = "Selbstbeherrschung", wert = 1},
                                        new NameWertPaar(){name = "Sich Verstecken", wert = 1},
                                        new NameWertPaar(){name = "Sinnesschärfe", wert = 1},
                                        new NameWertPaar(){name = "Zechen", wert = 1},
                                        new NameWertPaar(){name = "Menschenkenntnis", wert = 1},
                                        new NameWertPaar(){name = "Götter/Kulte", wert = -1},
                                        new NameWertPaar(){name = "Magiekunde", wert = 1},
                                    },


                                    verkehrssprachenDerHauptKulturErsetzen = true,

                                    moeglicheVerkehrssprachen = new List<NameWertPaar>()
                                    {
                                        new NameWertPaar() {name = "Tulamidya", wert = 3},
                                        new NameWertPaar() {name = "Rogolan", wert = 3},
                                        new NameWertPaar() {name = "Thorwalsch", wert = 3},
                                        new NameWertPaar() {name = "Zhayad", wert = 3},
                                        new NameWertPaar() {name = "Zhulchammaqra", wert = 3}
                                    },

                                    empfohleneVorteile = new List<string>()
                                    {"Affinität zu Dämonen", "Gefahreninstinkt", "Glück", "Magiegespür", "Resistenz gegen Krankheiten"},
                                    empfohleneNachteile = new List<string>()
                                    {"Aberglaube", "Dunkelangst", "Einbildungen", "Goldgier", "Schlafstörungen", "Stimga", "Unstet", "Wahnvorstellungen"},

                                },

                            };


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


    //////////////////////////////////////
    //  Subkulturen-Struktur
    //////////////////////////////////////

    /// <summary>
    /// Enthält eine Subkultur mit allen zugehörigen Attributen
    /// </summary>
    public struct subkultur
    {
        /// <summary>
        /// Name der Subkultur (bzw. Variante)
        /// </summary>
        public string name;

        /// <summary>
        /// Zusätzliche Generierungskosten für die Variante in GP
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Enthält die Voraussetzungen für eine Subkultur in einer eigenen Struktur
        /// </summary>
        public subkulturVoraussetzungen voraussetzungen;

        /// <summary>
        /// Enthält eine Liste von Beispielregionen, zwischen denen man sich entscheiden kann (eigene möglich!)
        /// </summary>
        public List<string> regionenMoeglich;

        /// <summary>
        /// Enthält alle vom Spieler tatsächlich gewählten Regionen
        /// </summary>
        public List<string> regionenGewaehlt;

        /// <summary>
        /// Enthält eine Liste von Beispielstädten, zwischen denen man sich entscheiden kann (eigene möglich!)
        /// </summary>
        public List<string> staedteMoeglich;

        /// <summary>
        /// Enthält alle vom Spieler tatsächlich gewählten Städte
        /// </summary>
        public List<string> staedteGewaehlt;

        /// <summary>
        /// Einthält eine Liste mit allen fixen Talentboni (Name, Modifikator)
        /// </summary>
        public List<NameWertPaar> talentBoni;

        /// <summary>
        /// Enthält eine Liste mit allen flexiblen Talentboni zwischen denen man sich entscheiden muss
        /// </summary>
        public List<NamenslisteWertPaar> talentWahlBoniMoeglich;

        /// <summary>
        /// Enthält die tatsächlich vom Spieler gewählten flexiblen Talentboni
        /// </summary>
        public List<NameWertPaar> talentWahlBoniGewaehlt;

        /// <summary>
        /// Enthält eine Liste möglicher Vekehrssprachen, die man durch eine Subkultur zusätzlich erhält
        /// inklusive des Modifikators, den man darauf bekommt als Start-Talentwert.
        /// </summary>
        public List<NameWertPaar> moeglicheVerkehrssprachen;

        /// <summary>
        /// Eine Zweitsprache, die exklusiv durch die Subkultur festgelegt wird.
        /// </summary>
        public string zweitsprache;

        /// <summary>
        /// Dieser Bool gibt an, ob die Verkehrssprache der Subkultur die Auswahl aus der
        /// Hauptkultur ersetzt.
        /// </summary>
        public bool verkehrssprachenDerHauptKulturErsetzen;

        /// <summary>
        /// Enthält eine Liste von Talentboni, die aus der Hauptkultur wiederum durch
        /// die Wahl der Subkultur ENTFERNT werden können!
        /// </summary>
        public List<string> zuEntfernendeTalentBoni;

        /// <summary>
        /// Enthält eine Liste von Boni auf verschiedene Schriften
        /// </summary>
        public List<NameWertPaar> schriftBoni;

        /// <summary>
        /// Eine Liste, die die verbilligten SF inklusive ihrer Ausprägungen enthält.
        /// </summary>
        public List<nameSubnamePaar> verbilligteSonderfertigkeiten;

        /// <summary>
        /// Eine Liste, in der alle Modifikatoren auf die Eigenschaften durch die Subrasse 
        /// aufgeführt sind
        /// </summary>
        public List<NameWertPaar> eigenschaften;

        /// <summary>
        /// Eine Liste mit allen empfohlenen Vorteilen für eine Subkultur
        /// </summary>
        public List<string> empfohleneVorteile;
        /// <summary>
        /// Eine Liste mit allen empfohlenen Nachteilen für eine Subkultur
        /// </summary>
        public List<string> empfohleneNachteile;

    };


    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer SF aufgelistet sein können:
    /// </summary>
    public struct subkulturVoraussetzungen
    {
        /// <summary>
        /// Eigenschaftenvoraussetzung für Profession
        /// </summary>
        public List<NameWertPaar> eigenschaften;
        /// <summary>
        /// Talentwertvoraussetzung für Profession
        /// </summary>
        public List<NameWertPaar> talentwerte;
        /// <summary>
        /// SF-Voraussetzung für Profession
        /// </summary>
        public List<string> SF;
        /// <summary>
        /// Beschreibt, welches Geschlecht ein Held/eine Helden haben muss, um die Profession
        /// ausüben zu können. "männlich", "weiblich", "beide"
        /// Ist z.B. wichtig für: Amazonen
        /// </summary>
        public string geschlechtstyp;

        /// <summary>
        /// Vorteile, die man für die Subkultur mitbringen muss
        /// </summary>
        public List<NameWertPaar> vorteile;

    };

}



