using System.Collections.Generic;
using listenStruktur;
using sfStruktur;
using spielerAuswahl;
using Common;
using Listen;
using vorteileStruktur;
using nachteileStruktur;
using SprachenUndSchriften;
using professionenStruktur;

namespace kulturenStruktur
{
    /// <summary>
    /// Struktur, die alle Kulturen in Aventurien enthält:
    /// </summary>
    public struct kulturenStruct
    {
        // Wir listen nun auf, welche Attribute eine Kultur hat:

        /// <summary>
        /// Identifier der Kultur
        /// </summary>
        public KulturName kultur;

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
        /// Der Identifier dieser Kultur. Der Setter definiert die Attribute der Kultur
        /// </summary>        
        public KulturName Kultur
        {
            get
            {
                return kultur;
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
                        case KulturName.MittellaendischeStaedte:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createMittelStaedteSubKeine());
                            moeglicheSubkulturen.Add(createMittelStaedteSubHafen());
                            moeglicheSubkulturen.Add(createMittelStaedteSubTempel());
                            moeglicheSubkulturen.Add(createMittelStaedteSubSiedler());
                            moeglicheSubkulturen.Add(createMittelStaedteSubAdel());
                            moeglicheSubkulturen.Add(createMittelStaedteSubKanne());
                            moeglicheSubkulturen.Add(createMittelStaedteSubFluechtlinge());
                            break;

/*

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

                            */
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

        private subkultur createMittelStaedteSubFluechtlinge()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createMittelStaedteSubKanne()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createMittelStaedteSubAdel()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createMittelStaedteSubSiedler()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createMittelStaedteSubTempel()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createMittelStaedteSubHafen()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createMittelStaedteSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 0;
            subKeine.soMaximum = -1;
            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){name = VorteileName.BesondererBesitz},
                new VorteilsIdentifier(){name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){name = VorteileName.Verbindungen},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Schulden},
                new NachteilsIdentifier(){name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){name = NachteileName.Vorurteile},
            };
            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.AngstVor, auspraegung = Angst.Menschenmassen},
                new NachteilsIdentifier(){name = NachteileName.Raumangst},
            };

            // Vorbereiten der Professions-Kategorienklasse. @Tom: Kann man das
            // auch global machen? Sonst kommt diese Zeile in JEDER Subkultur immer wieder vor...
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() {};
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetKriegerische());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Alchimist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.MagiebegabterAlchimist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schelm);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());
            
            // Die folgenden Professionen lassen wir nicht zu:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Infanteriewaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Etikette, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Gassenwissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.GoetterUndKulte, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Heraldik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Rechtskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.SagenUndLegenden, wert = +2},
            };

            // Wahl der Muttersprache:
            subKeine.muttersprache = new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true, modifikator = 0 };

            // Wir bereiten die Wahlmöglichkeiten vor:
            subKeine.wahlen = new List<wahlmoeglichkeiten>(){};

            // Beginnen wir mit Der Wahl der Kampftalente:
            var wahlTalentKampf = new wahlmoeglichkeiten();
            wahlTalentKampf.talente = new List<TalentName>()
            {
                TalentName.Armbrust, TalentName.Bogen, TalentName.Wurfmesser,
            };
            wahlTalentKampf.anzahlWaehlbarerTalente = 1;
            wahlTalentKampf.talentWerte = new int[1];
            wahlTalentKampf.talentWerte[0] = 1;
            subKeine.wahlen.Add(wahlTalentKampf);

            // Nun die Wahl aus dem Handwerksbereich:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Ackerbau, TalentName.Hauswirtschaft,
            };
            wahlHandwerk.anzahlWaehlbarerTalente = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            subKeine.wahlen.Add(wahlHandwerk);

            // Nun die Wahl zwischen einer von drei Sprachen:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlHandwerk.sprachen= new List<SprachenName>()
            {
                SprachenName.Tulamidya, SprachenName.Rogolan, SprachenName.Thorwalsch
            };
            wahlSprache.anzahlWaehlbarerTalente = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            subKeine.wahlen.Add(wahlSprache);

            return subKeine;
        }
    };


    //////////////////////////////////////
    //  Subkulturen-Struktur
    //////////////////////////////////////

    /// <summary>
    /// Struktur, die die eigentlichen Informationen zur Kultur enthält. Jede Kultur wird
    /// als Subkultur "keine" bezeichnet, wenn sie keine Subkultur hat!
    /// </summary>
    public struct subkultur
    {
        /// <summary>
        /// Name der Subkultur (bzw. Variante)
        /// </summary>
        public SubKulturName name;

        /// <summary>
        /// Zusätzliche Generierungskosten für die Variante in GP
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Der Maximale Sozialstatus, den man für die Kulturzugehörigkeit besitzen darf
        /// Wenn es keinen gibt, sollte der Wert "-1" betragen!
        /// </summary>
        public int soMaximum;

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
        /// Enthält die Voraussetzungen für eine Subkultur in einer eigenen Struktur
        /// </summary>
        public subkulturVoraussetzungen voraussetzungen;

        /// <summary>
        /// Eine Liste, in der alle Modifikatoren auf die Eigenschaften durch die Subrasse 
        /// aufgeführt sind
        /// </summary>
        public List<GenericListenNameWertPaar<EigenschaftenName>> eigenschaftsModifikationen;

        /// <summary>
        /// Eine Liste aller automatischen Vorteile durch die Kultur (inklusive Wert)
        /// </summary>
        public List<VorteilsIdentifier> automatischeVorteile;

        /// <summary>
        /// Eine Liste aller automatischen Nachteile durch die Kultur (inklusive Wert)
        /// </summary>
        public List<NachteilsIdentifier> automatischeNachteile;

        /// <summary>
        /// Eine liste der empfohlenen Vorteile durch die Kultur (nicht bindend)
        /// </summary>
        public List<VorteilsIdentifier> empfohleneVorteile;

        /// <summary>
        /// Eine liste der empfohlenen Nachteile durch die Kultur (nicht bindend)
        /// </summary>
        public List<NachteilsIdentifier> empfohleneNachteile;

        /// <summary>
        /// Eine Liste der ungeeigneten Vorteile durch die Kultur (sollte bindend sein)
        /// </summary>
        public List<VorteilsIdentifier> ungeeigneteVorteile;

        /// <summary>
        /// Eine Liste der ungeeigneten Nachteile durch die Kultur (sollte bindend sein)
        /// </summary>
        public List<NachteilsIdentifier> ungeeigneteNachteile;

        /// <summary>
        /// Eine Liste der geeigneten Professionen durch die Kultur (ist nicht bindend, aber empfohlen)
        /// </summary>
        public List<ProfessionsName> geeigneteProfessionen;

        /// <summary>
        /// Eine Liste der ungeeigneten Professionen durch die Kultur (sollte bindend sein)
        /// </summary>
        public List<ProfessionsName> ungeeigneteProfessionen;

        /// <summary>
        /// Einthält eine Liste mit allen fixen Talentboni (Name, Modifikator)
        /// </summary>
        public List<GenericListenNameWertPaar<TalentName>> talentModifikatoren;

        /// <summary>
        /// Die mit der Kultur verbundene Muttersprache:
        /// (kann auch sein, dass sie erst zwischen mehreren gewählt werden muss!)
        /// </summary>
        public SprachenIdentifier muttersprache;

        /// <summary>
        /// Enthält eine Liste möglicher Zweitsprachen.
        /// </summary>
        public List<SprachenIdentifier> zweitsprachen;

        /// <summary>
        /// Eine Liste der durch die Kultur erworbenen Sonderfertigkeiten
        /// </summary>
        public List<sfIdentifier> sonderfertigkeiten;

        /// <summary>
        /// Eine Liste, die die verbilligten SF inklusive ihrer Ausprägungen enthält.
        /// </summary>
        public List<sfIdentifier> verbilligteSonderfertigkeiten;

        /// <summary>
        /// Enthält eine Liste von Beispielregionen, zwischen denen man sich entscheiden kann (eigene möglich!)
        /// </summary>
        public List<Region> moeglicheRegionen;

        /// <summary>
        /// Enthält eine Liste von Beispielstädten, zwischen denen man sich entscheiden kann (eigene möglich!)
        /// </summary>
        public List<Stadt> moeglicheStaedte;

        /// <summary>
        /// Eine Liste von verschiedenen Auswahlen für Vorteile, Talente, etc.
        /// </summary>
        public List<wahlmoeglichkeiten> wahlen;
    };


    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer SF aufgelistet sein können:
    /// </summary>
    public struct subkulturVoraussetzungen
    {
        /// <summary>
        /// Eigenschaftenvoraussetzung für Profession
        /// </summary>
        public List<GenericListenNameWertPaar<EigenschaftenName>> eigenschaften;
        /// <summary>
        /// Talentwertvoraussetzung für Profession
        /// </summary>
        public List<GenericListenNameWertPaar<TalentName>> talentwerte;
        /// <summary>
        /// SF-Voraussetzung für Profession
        /// </summary>
        public List<sfIdentifier> SF;
        /// <summary>
        /// Beschreibt, welches Geschlecht ein Held/eine Helden haben muss, um die Profession
        /// ausüben zu können. "männlich", "weiblich", "beide"
        /// Ist z.B. wichtig für: Amazonen
        /// </summary>
        public GeschlechtNamen geschlecht;

        /// <summary>
        /// Vorteile, die man für die Subkultur mitbringen muss
        /// </summary>
        public List<VorteilsIdentifier> vorteile;
    };
}



