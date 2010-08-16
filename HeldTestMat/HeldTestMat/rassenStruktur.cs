using System.Collections.Generic;
using Listen;
using Common;
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
        /// <summary>
        /// Eine Liste mit allen möglichen Subrassennamen. Enthält immer mindestens den
        /// Eintrag mit dem eigentlichen Rassennamen. Bei manchen Rassen (z.B. Thorwaler)
        /// können Subrassen gewählt werden.
        /// </summary>
        public List<subrasse> moeglicheSubrassen;

        /// <summary>
        /// Der Name der tatsächlich vom Helden gewählten Subrasse.
        /// </summary>
        public SpielerSubRassenNamen gewaehlteSubrasse;

        /// <summary>
        /// Identifier der Rasse
        /// </summary>
        private SpielerRassenNamen rasse;

        /// <summary>
        /// [Tom]: Der Name der Rasse. Beim Setzen des Namens werden die anderen Felder automatisch gefüllt.
        /// Dies ist eine sogenannte Property.
        /// </summary>
        public string Name
        {
            get
            {
                return EnumExtentions.GetDescription<SpielerRassenNamen>(rasse);
            }
        }

        /// <summary>
        /// Überschreiben der To-String Methode
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
        /// <summary>
        /// Der Identifier dieser Rasse. Der Setter definiert die Attribute der Rasse
        /// </summary>
        public SpielerRassenNamen Rasse
        {
            set
            {
                try
                {

                    switch (value)
                    {
                        ///////////////////////////////////////
                        // Mittelreichler
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Mittellaender:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createMittellaenderSubrasseKeine());
                            break;

                        ///////////////////////////////////////
                        // Tulamiden
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Tulamiden:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createTulamideSubrasseKeine());                      
                            break;

                        ///////////////////////////////////////
                        // Thorwaler
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Thorwaler:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createThorwalerSubrasseKeine());
                            moeglicheSubrassen.Add(createThorwalerSubrasseFjarninger());
                            moeglicheSubrassen.Add(createThorwalerSubrasseGjalskalaender());
                            break;

                        /*
                    case SpielerRassenNamen.Nivese:
                        #region
                        rasse = value;
                        generierungskosten = 4;
                        augenfarbenMap.Add(new Range(1, 15), "kupferrot");
                        augenfarbenMap.Add(new Range(16, 16), "blond");
                        augenfarbenMap.Add(new Range(17, 18), "braun");
                        augenfarbenMap.Add(new Range(19, 19), "dunkelblond");
                        augenfarbenMap.Add(new Range(20, 20), "schwarz");

                        augenfarbenMap.Add(new Range(1, 2), "braun");
                        augenfarbenMap.Add(new Range(3, 9), "hellbraun");
                        augenfarbenMap.Add(new Range(10, 14), "bernsteinfarben");
                        augenfarbenMap.Add(new Range(15, 17), "grün");
                        augenfarbenMap.Add(new Range(18, 19), "blau");
                        augenfarbenMap.Add(new Range(20, 20), "grau");

                        koerpergroesse.basisgroesse = 1.55;
                        koerpergroesse.wuerfel = new int[3];
                        koerpergroesse.wuerfel[0] = 2;
                        koerpergroesse.wuerfel[1] = 20;
                        koerpergroesse.wuerfel[2] = 0;

                        gewichtsabzug = 110;
                        eigenschaftsModifikationen = new List<EigenschaftsNameWertPaar>() 
                        {
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.IN, wert = 1},
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.KO, wert = 1},
                        };
                        leModifikator = 9;
                        auModifikator = 12;
                        mrModifikator = -5;

                        empfohleneVorteile = new List<VorteileNamen>()
                        {
                            VorteileNamen.Ausdauernd, VorteileNamen.Entfernugssinn, VorteileNamen.Gefahreninstinkt,
                            VorteileNamen.InnererKompass, VorteileNamen.Kaelteresistenz, VorteileNamen.Richtungssinn,
                            VorteileNamen.Wolfskind, VorteileNamen.ZaeherHund,
                        };
                        empfohleneNachteile = new List<NachteileNamen>()
                        {
                            NachteileNamen.Hitzeempfindlichkeit,
                        };
                        ungeeigneteVorteile = new List<VorteileNamen>()
                        {
                            VorteileNamen.HerausragendeBalance, VorteileNamen.Hitzeresistenz,
                        };
                        ungeeigneteNachteile = new List<NachteileNamen>()
                        {
                            NachteileNamen.Kaelteempfindlichkeit, NachteileNamen.Nahrungsrestriktion,
                            NachteileNamen.Platzangst
                        };
                        ueblicheKulturen = new List<KulturNamen>()
                        {
                            KulturNamen.Nivesenstaemme, KulturNamen.NuanaaeLie,
                        };
                        unueblicheKulturen = new List<KulturNamen>()
                        {
                            KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                            KulturNamen.Bornland, KulturNamen.SvellttalUndNordlande, KulturNamen.Thorwal,
                            KulturNamen.Gjalskerland, KulturNamen.Fjarninger, KulturNamen.Norbardensippe
                        };
                        talentModifikatoren = new List<TalentNameWertPaar>()
                        {
                            new TalentNameWertPaar(){name = TalentNamen.Schleichen, wert = 1},
                            new TalentNameWertPaar(){name = TalentNamen.Selbstbeherrschung, wert = 1},
                            new TalentNameWertPaar(){name = TalentNamen.Orientierung, wert = 1},
                        };
                        #endregion
                        break;
                    case SpielerRassenNamen.Norbarde:
                        #region
                        rasse = value;
                        generierungskosten = 3;
                        augenfarbenMap.Add(new Range(1, 17), "scharz");
                        augenfarbenMap.Add(new Range(18, 19), "kupferrot");
                        augenfarbenMap.Add(new Range(20, 20), "blond");

                        augenfarbenMap.Add(new Range(1, 3), "schwarz");
                        augenfarbenMap.Add(new Range(4, 13), "dunkelbraun");
                        augenfarbenMap.Add(new Range(14, 17), "braun");
                        augenfarbenMap.Add(new Range(18, 19), "grün");
                        augenfarbenMap.Add(new Range(20, 20), "blau");

                        koerpergroesse.basisgroesse = 1.58;
                        koerpergroesse.wuerfel = new int[3];
                        koerpergroesse.wuerfel[0] = 2;
                        koerpergroesse.wuerfel[1] = 20;
                        koerpergroesse.wuerfel[2] = 0;
                        gewichtsabzug = 100;
                        eigenschaftsModifikationen = new List<EigenschaftsNameWertPaar>()
                        {
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.Charisma, wert = 1},
                        };
                        leModifikator = 11;
                        auModifikator = 10;
                        mrModifikator = -4;
                        empfohleneVorteile = new List<VorteileNamen>()
                        {
                            VorteileNamen.Gefahreninstinkt, VorteileNamen.GutesGedaechtnis, VorteileNamen.InnererKompass,
                            VorteileNamen.Kaelteresistenz, VorteileNamen.Richtungssinn, VorteileNamen.ZaeherHund,
                        };
                        ungeeigneteVorteile = new List<VorteileNamen>()
                        {
                            VorteileNamen.HerausragendeBalance, VorteileNamen.Hitzeresistenz,
                        };
                        ungeeigneteNachteile = new List<NachteileNamen>()
                        {
                            NachteileNamen.Nahrungsrestriktion, NachteileNamen.Platzangst,
                        };
                        ueblicheKulturen = new List<KulturNamen>()
                        {
                            KulturNamen.Norbardensippe
                        };
                        unueblicheKulturen = new List<KulturNamen>()
                        {
                            KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                            KulturNamen.Bornland, KulturNamen.Thorwal, KulturNamen.SvellttalUndNordlande,
                            KulturNamen.Nivesenstaemme, KulturNamen.Gjalskerland,
                        };
                        talentModifikatoren = new List<TalentNameWertPaar>()
                        {
                            new TalentNameWertPaar(){name = TalentNamen.Orientierung, wert = 1},
                            new TalentNameWertPaar(){name = TalentNamen.Rechnen, wert = 1},
                        };
                        #endregion
                        break;

                    case SpielerRassenNamen.Trollzacker:
                        rasse = value;
                        generierungskosten = 7;
                        augenfarbenMap.Add(new Range(1, 15), "scharz");
                        augenfarbenMap.Add(new Range(16, 17), "dunkelbraun");
                        augenfarbenMap.Add(new Range(18, 18), "mittelbraun");
                        augenfarbenMap.Add(new Range(19, 19), "hellbraun");
                        augenfarbenMap.Add(new Range(20, 20), "dunkelblond");

                        augenfarbenMap.Add(new Range(1, 16), "schwarz");
                        augenfarbenMap.Add(new Range(17, 17), "dunkelbraun");
                        augenfarbenMap.Add(new Range(18, 18), "braun");
                        augenfarbenMap.Add(new Range(19, 19), "grau");
                        augenfarbenMap.Add(new Range(20, 20), "grün");

                        koerpergroesse.basisgroesse = 1.95;
                        koerpergroesse.wuerfel = new int[3];
                        koerpergroesse.wuerfel[0] = 1;
                        koerpergroesse.wuerfel[1] = 20;
                        koerpergroesse.wuerfel[2] = 0;
                        gewichtsabzug = 100;
                        eigenschaftsModifikationen = new List<EigenschaftsNameWertPaar>()
                        {
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.Mut, wert = 2},
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.Klugheit, wert = -1},
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.Konstitution, wert = 1},
                            new EigenschaftsNameWertPaar(){name = EigenschaftenNamen.Koerperkraft, wert = 1},
                        };
                        leModifikator = 11;
                        auModifikator = 18;
                        mrModifikator = -5;
                        automatischeNachteile = new List<NachteilNameWertPaar>()
                        {
                            new NachteilNameWertPaar(){name = NachteileNamen.Platzangst, wert = 6},
                        };
                        empfohleneVorteile = new List<VorteileNamen>()
                        {
                            VorteileNamen.Ausdauernd, VorteileNamen.Balance, VorteileNamen.Eisern, VorteileNamen.Entfernugssinn,
                            VorteileNamen.Kampfrausch, VorteileNamen.HoheLebenskraft, VorteileNamen.ResistenzGegenGift,
                            VorteileNamen.ResistenzGegenKrankheiten, VorteileNamen.Richtungssinn,
                        };
                        empfohleneNachteile = new List<NachteileNamen>()
                        {
                            NachteileNamen.Blutdurst, NachteileNamen.Jaehzorn, NachteileNamen.UnangenehmeStimme,
                            NachteileNamen.Unansehnlich,
                        };
                        ungeeigneteVorteile = new List<VorteileNamen>()
                        {
                            VorteileNamen.GutAussehend, VorteileNamen.HerausragendeBalance, VorteileNamen.Wohlklang
                        };
                        ungeeigneteNachteile = new List<NachteileNamen>()
                        {
                            NachteileNamen.Kleinwuechsig, NachteileNamen.Nahrungsrestriktion, 
                            NachteileNamen.SchlechteRegeneration
                        };
                        ueblicheKulturen = new List<KulturNamen>()
                        {
                            KulturNamen.Trollzacken
                        };
                        unueblicheKulturen = new List<KulturNamen>()
                        {
                            KulturNamen.Ferkina, KulturNamen.Aranien,
                        };

                        talentModifikatoren = new List<TalentNameWertPaar>()
                        {
                            new TalentNameWertPaar(){name = TalentNamen.Athletik, wert = 1},
                            new TalentNameWertPaar(){name = TalentNamen.Klettern, wert = 1},
                            new TalentNameWertPaar(){name = TalentNamen.Selbstbeherrschung, wert = 1},
                            new TalentNameWertPaar(){name = TalentNamen.Sinnesschaerfe, wert = 1},
                        };

                        moeglicheSubrassen = new List<SpielerSubRassenNamen>()
                        {
                            SpielerSubRassenNamen.Rochshaz,
                        };

                        break;
                */

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

        private static subrasse createMittellaenderSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 3), "schwarz");
            srKeine.haarfarbenMap.Add(new Range(4, 7), "braun");
            srKeine.haarfarbenMap.Add(new Range(8, 12), "dunkelblond");
            srKeine.haarfarbenMap.Add(new Range(13, 16), "blond");
            srKeine.haarfarbenMap.Add(new Range(17, 18), "weißblond");
            srKeine.haarfarbenMap.Add(new Range(19, 20), "rot");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(3, 9), "braun");
            srKeine.augenfarbenMap.Add(new Range(10, 11), "grün");
            srKeine.augenfarbenMap.Add(new Range(12, 17), "blau");
            srKeine.augenfarbenMap.Add(new Range(18, 19), "grau");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "schwarz");

            srKeine.generierungskosten = 0;

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.60;
            srKeine.koerpergroesse.wuerfel = new int[3];
            srKeine.koerpergroesse.wuerfel[0] = 2;
            srKeine.koerpergroesse.wuerfel[1] = 20;
            srKeine.koerpergroesse.wuerfel[2] = 0;

            srKeine.gewichtsabzug = 100;

            srKeine.leModifikator = 10;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -4;

            srKeine.ungeeigneteVorteile = new List<VorteileNamen>()
            {
                VorteileNamen.HerausragendeBalance,
            };
            srKeine.ungeeigneteNachteile = new List<NachteileNamen>()
            {
                NachteileNamen.Nahrungsrestriktion,
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung, 
                KulturNamen.AndergastUndNostria,
                KulturNamen.Bornland, KulturNamen.SvellttalUndNordlande, KulturNamen.Almada, 
                KulturNamen.Horasreich,
                KulturNamen.Zyklopeninseln, KulturNamen.Maraskan, KulturNamen.Suedaventurien, 
                KulturNamen.Bukanier,
            };
            // [Tom]: oder auch so:
            // ueblicheKulturen.Add("Bukanier");
            //[Tom]: Listenbefüllung:
            // Wir füllen die Liste mittels eines sogenannten Collection Initializers
            // siehe http://www.developer.com/net/csharp/article.php/3607421/New-in-C-30-Create-and-Initialize-Collection-Objects-in-One-Step.htm

            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Aranien, KulturNamen.TulamidischeStadtstaaten, KulturNamen.Thorwal,
                KulturNamen.Mhanadistan, KulturNamen.Amazonenburg,
            };
            //[Tom]: Auch hier können wir ganz Prima einen Collection Initializer benutzen. Diesmal in der geschachtelten Ausführung
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>() { };

            return srKeine;
        }
        private static subrasse createTulamideSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 0;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 6), "schwarz");
            srKeine.haarfarbenMap.Add(new Range(7, 12), "dunkelbraun");
            srKeine.haarfarbenMap.Add(new Range(13, 14), "mittelbraun");
            srKeine.haarfarbenMap.Add(new Range(15, 17), "hellbraun");
            srKeine.haarfarbenMap.Add(new Range(18, 19), "blond");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "rot");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 4), "schwarz");
            srKeine.augenfarbenMap.Add(new Range(5, 12), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(13, 16), "braun");
            srKeine.augenfarbenMap.Add(new Range(17, 18), "grau");
            srKeine.augenfarbenMap.Add(new Range(19, 19), "grün");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "blau");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.55;
            srKeine.koerpergroesse.wuerfel = new int[3];
            srKeine.koerpergroesse.wuerfel[0] = 2;
            srKeine.koerpergroesse.wuerfel[1] = 20;
            srKeine.koerpergroesse.wuerfel[2] = 0;

            srKeine.gewichtsabzug = 105;
            srKeine.leModifikator = 10;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -4;

            srKeine.ungeeigneteVorteile = new List<VorteileNamen>()
            {
                VorteileNamen.HerausragendeBalance,
            };
            srKeine.ungeeigneteNachteile = new List<NachteileNamen>()
            {
                NachteileNamen.Nahrungsrestriktion,
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Aranien, KulturNamen.Mhanadistan, KulturNamen.TulamidischeStadtstaaten, KulturNamen.Novadi,
                KulturNamen.Ferkina, KulturNamen.Zahori, KulturNamen.Maraskan, KulturNamen.Suedaventurien, KulturNamen.Bukanier,
            };
            srKeine.unueblicheKulturen = new List<KulturNamen> 
            {
                KulturNamen.MittellaendischeStaedte, KulturNamen.Almada, KulturNamen.Amazonenburg,
            };
            return srKeine;
        }
        private static subrasse createThorwalerSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 8), "blond");
            srKeine.haarfarbenMap.Add(new Range(9, 13), "rotblond");
            srKeine.haarfarbenMap.Add(new Range(14, 15), "weißblond");
            srKeine.haarfarbenMap.Add(new Range(16, 17), "rot");
            srKeine.haarfarbenMap.Add(new Range(18, 18), "dunkelblond");
            srKeine.haarfarbenMap.Add(new Range(19, 19), "braun");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "schwarz");

            srKeine.augenfarbenMap = new RangeMap<string>() { };
            srKeine.augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(3, 7), "braun");
            srKeine.augenfarbenMap.Add(new Range(8, 11), "grün");
            srKeine.augenfarbenMap.Add(new Range(12, 18), "blau");
            srKeine.augenfarbenMap.Add(new Range(19, 20), "grau");

            srKeine.generierungskosten = 5;

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.68;
            srKeine.koerpergroesse.wuerfel = new int[3];
            srKeine.koerpergroesse.wuerfel[0] = 2;
            srKeine.koerpergroesse.wuerfel[1] = 20;
            srKeine.koerpergroesse.wuerfel[2] = 0;

            srKeine.gewichtsabzug = 95;
            srKeine.leModifikator = 11;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -5;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>{name= EigenschaftenNamen.MU, wert=1},
                new GenericListenNameWertPaar<EigenschaftenNamen>{name= EigenschaftenNamen.KO, wert=1},
                new GenericListenNameWertPaar<EigenschaftenNamen>{name= EigenschaftenNamen.KK, wert=1},
            };

            srKeine.automatischeNachteile = new List<GenericListenNameWertPaar<NachteileNamen>>()
            {
                new GenericListenNameWertPaar<NachteileNamen>{name= NachteileNamen.Jaehzorn, wert=6},
            };
            srKeine.empfohleneVorteile = new List<VorteileNamen>()
            {
                VorteileNamen.Eisern, VorteileNamen.HoheLebenskraft, VorteileNamen.InnererKompass,
                VorteileNamen.Kaelteresistenz, VorteileNamen.Kampfrausch, VorteileNamen.Richtungssinn,
                VorteileNamen.ZaeherHund,
            };
            srKeine.empfohleneNachteile = new List<NachteileNamen>()
            {
                NachteileNamen.Blutrausch, NachteileNamen.Hitzeempfindlichkeit
            };
            srKeine.ungeeigneteVorteile = new List<VorteileNamen>()
            {
                VorteileNamen.HerausragendeBalance, VorteileNamen.HoheMagieresistenz,
            };
            srKeine.ungeeigneteNachteile = new List<NachteileNamen>()
            {
                NachteileNamen.Kleinwuechsig, NachteileNamen.Nahrungsrestriktion,
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Thorwal, KulturNamen.Fjarninger, KulturNamen.Gjalskerland
            };
            srKeine.unueblicheKulturen = new List<KulturNamen> 
            {
                KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.AndergastUndNostria, KulturNamen.Bornland, KulturNamen.SvellttalUndNordlande, 
                KulturNamen.Suedaventurien, KulturNamen.TulamidischeStadtstaaten, KulturNamen.Bukanier,
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Athletik, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Wettervorhersage, wert = 1},
            };

            return srKeine;
        }
        private static subrasse createThorwalerSubrasseFjarninger()
        {
            var srFjarn = createThorwalerSubrasseKeine();
            // Wir brauchen nur die Unterschiede zwischen den Subrassen zu ändern:
            srFjarn.name = SpielerSubRassenNamen.Fjarninger;
            srFjarn.koerpergroesse.basisgroesse = 1.68 + 0.05;
            return srFjarn;
        }
        private static subrasse createThorwalerSubrasseGjalskalaender()
        {
            var srGjal = createThorwalerSubrasseKeine();
            // Wir brauchen nur die Unterschiede zwischen den Subrassen zu ändern:
            srGjal.name = SpielerSubRassenNamen.Gjalskerlaender;
            srGjal.haarfarbenMap.Add(new Range(1, 4), "blond");
            srGjal.haarfarbenMap.Add(new Range(5, 8), "rotblond");
            srGjal.haarfarbenMap.Add(new Range(9, 15), "rot");
            srGjal.haarfarbenMap.Add(new Range(16, 17), "braun");
            srGjal.haarfarbenMap.Add(new Range(18, 20), "schwarz");
            srGjal.augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
            srGjal.augenfarbenMap.Add(new Range(3, 10), "braun");
            srGjal.augenfarbenMap.Add(new Range(11, 18), "grün");
            srGjal.augenfarbenMap.Add(new Range(19, 20), "blau");

            return srGjal;
        }
    }

    //////////////////////////////////////
    //  Substrukturen der Rassen-Struktur. TODO: Auräumen!
    //////////////////////////////////////
    /// <summary>
    /// Struktur, die die eigentlichen Informationen zur Subrasse enthält. Jede Rasse wird
    /// als Subrasse "keine" bezeichnet, wenn sie keine Subrasse hat!
    /// </summary>
    public struct subrasse
    {
        /// <summary>
        /// Name der Subrasse. Ist "keine", falls die Rasse keine Subrasse besitzt.
        /// </summary>
        public SpielerSubRassenNamen name;

        // Wir listen nun auf, welche Attribute eine Rasse hat:      
        /// <summary>
        ///  Generierungskosten für die jeweilige Rasse in GP
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Map, in der alle Haarfarben und ihre Wahrscheinlichkeiten abgelegt sind
        /// </summary>
        public RangeMap<string> haarfarbenMap;
        /// <summary>
        /// Map, die die möglichen Augenfarben und die jeweiligen Wahrscheinlichkeiten dafür enthält.
        /// </summary>
        public RangeMap<string> augenfarbenMap;
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
        public List<GenericListenNameWertPaar<EigenschaftenNamen>> eigenschaftsModifikationen;
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
        public List<GenericListenNameWertPaar<VorteileNamen>> automatischeVorteile;
        /// <summary>
        ///  Automatische Nachteile durch die Rasse
        /// </summary>
        public List<GenericListenNameWertPaar<NachteileNamen>> automatischeNachteile;
        /// <summary>
        ///  Empfohlene Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<VorteileNamen> empfohleneVorteile;
        /// <summary>
        ///  Empfohlene Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<NachteileNamen> empfohleneNachteile;
        /// <summary>
        ///  Nicht geeignere Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public List<VorteileNamen> ungeeigneteVorteile;
        /// <summary>
        ///  Nicht geeignere Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public List<NachteileNamen> ungeeigneteNachteile;
        /// <summary>
        /// Übliche Kulturen für eine Rasse. Kann optisch bei der Generierung in der GUI als grün
        /// hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<KulturNamen> ueblicheKulturen;
        /// <summary>
        /// Unübliche Kulturen für eine Rasse. Kann optisch bei der Generierung in der GUI als
        /// gelb hervorgehoben werden. Ist nicht bindend, sollte aber nur in Absprache mit dem
        /// Meister verwendet werden.
        /// </summary>
        public List<KulturNamen> unueblicheKulturen;
        /// <summary>
        /// Die Talentmodifikatoren dieser Rasse. Enthält sowohl den jeweiligen Talentnamen als
        /// auch den Modifikator auf das Talent.
        /// </summary>
        public List<GenericListenNameWertPaar<TalentNamen>> talentModifikatoren;
    };

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