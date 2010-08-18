using System.Collections.Generic;
using Listen;
using Common;
using vorteileStruktur;
using nachteileStruktur;
using wuerfelKlasse;
using sfStruktur;
using spielerAuswahl;

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

                        ///////////////////////////////////////
                        // Nivese
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Nivese:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createNiveseSubrasseKeine());
                            break;
                        ///////////////////////////////////////
                        // Norbarde
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Norbarde:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createNorbardeSubrasseKeine());
                            break;
                        ///////////////////////////////////////
                        // Trollzacker
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Trollzacker:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createTrollzackerSubrasseKeine());
                            break;
                        ///////////////////////////////////////
                        // Waldmenschen
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Waldmensch:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createWaldmenschenSubrasseKeine());
                            moeglicheSubrassen.Add(createWaldmenschenSubrasseTocamuyac());
                            break;
                        ///////////////////////////////////////
                        // Utulus
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Utulu:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createUtuluSubrasseKeine());
                            break;
                        ///////////////////////////////////////
                        // Elfen
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Elf:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createElfSubrasseAuelf());
                            moeglicheSubrassen.Add(createElfSubrasseWaldelf());
                            moeglicheSubrassen.Add(createElfSubrasseFirnelf());
                            break;
                        ///////////////////////////////////////
                        // Halbelfen
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Halbelf:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createHalbelfSubrasseKeine());
                            moeglicheSubrassen.Add(createHalbelfSubrasseFirnelfischeAbstammung());
                            moeglicheSubrassen.Add(createHalbelfSubrasseNivesischeAbstammung());
                            moeglicheSubrassen.Add(createHalbelfSubrasseThorwalscheAbstammung());
                            moeglicheSubrassen.Add(createHalbelfSubrasseAuelfischeSippe());
                            moeglicheSubrassen.Add(createHalbelfSubrasseElfischeSiedlung());
                            moeglicheSubrassen.Add(createHalbelfSubrasseFirnelfischeSippe());
                            moeglicheSubrassen.Add(createHalbelfSubrasseWaldelfischeSippe());
                            break;
                        ///////////////////////////////////////
                        // Zwerge
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Zwerg:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createZwergSubrasseKeine());
                            moeglicheSubrassen.Add(createZwergSubrasseBrillantzwerg());
                            moeglicheSubrassen.Add(createZwergSubrasseAmbosszwerg());
                            moeglicheSubrassen.Add(createZwergSubrasseWilderZwerg());
                            break;
                        ///////////////////////////////////////
                        // Orks
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Ork:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createOrkSubrasseKeine());
                            moeglicheSubrassen.Add(createOrkSubrasseOrkfrau());
                            break;
                        ///////////////////////////////////////
                        // Halborks
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Halbork:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createHalborkSubrasseKeine());
                            break;
                        ///////////////////////////////////////
                        // Goblins
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Goblin:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createGoblinSubrasseKeine());
                            moeglicheSubrassen.Add(createGoblinSubrasseGoblinfrau());
                            break;
                        ///////////////////////////////////////
                        // Achaz
                        ///////////////////////////////////////
                        case SpielerRassenNamen.Achaz:
                            rasse = value;
                            moeglicheSubrassen = new List<subrasse>();
                            moeglicheSubrassen.Add(createAchazSubrasseKeine());
                            moeglicheSubrassen.Add(createAchazSubrasseOrkland());
                            moeglicheSubrassen.Add(createAchazSubrasseWaldinsel());
                            moeglicheSubrassen.Add(createAchazSubrasseMaraskan());
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
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 100;

            srKeine.leModifikator = 10;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -4;

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
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
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 105;
            srKeine.leModifikator = 10;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -4;

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
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
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

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

            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Jaehzorn,wert = 6},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Eisern},
                new VorteilsIdentifier(){name = VorteileNamen.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutdurst},
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
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
        private static subrasse createNiveseSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.generierungskosten = 4;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 15), "kupferrot");
            srKeine.haarfarbenMap.Add(new Range(16, 16), "blond");
            srKeine.haarfarbenMap.Add(new Range(17, 18), "braun");
            srKeine.haarfarbenMap.Add(new Range(19, 19), "dunkelblond");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "schwarz");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 2), "braun");
            srKeine.augenfarbenMap.Add(new Range(3, 9), "hellbraun");
            srKeine.augenfarbenMap.Add(new Range(10, 14), "bernsteinfarben");
            srKeine.augenfarbenMap.Add(new Range(15, 17), "grün");
            srKeine.augenfarbenMap.Add(new Range(18, 19), "blau");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "grau");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.55;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 110;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 1},
            };

            srKeine.leModifikator = 9;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -5;

            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Wolfskind},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
            };

            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
            };

            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kaelteempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst},
            };

            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Nivesenstaemme, KulturNamen.NuanaaeLie,
            };

            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.Bornland, KulturNamen.SvellttalUndNordlande, KulturNamen.Thorwal,
                KulturNamen.Gjalskerland, KulturNamen.Fjarninger, KulturNamen.Norbardensippe
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Selbstbeherrschung, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 1},
            };

            return srKeine;
        }
        private static subrasse createNorbardeSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 3;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 17), "scharz");
            srKeine.haarfarbenMap.Add(new Range(18, 19), "kupferrot");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "blond");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 3), "schwarz");
            srKeine.augenfarbenMap.Add(new Range(4, 13), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(14, 17), "braun");
            srKeine.augenfarbenMap.Add(new Range(18, 19), "grün");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "blau");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.58;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 100;
            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Charisma, wert = 1},
            };
            srKeine.leModifikator = 11;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -4;
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.GutesGedaechtnis},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst},
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Norbardensippe
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.Bornland, KulturNamen.Thorwal, KulturNamen.SvellttalUndNordlande,
                KulturNamen.Nivesenstaemme, KulturNamen.Gjalskerland,
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>{name = TalentNamen.Orientierung, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>{name = TalentNamen.Rechnen, wert = 1},
            };


            return srKeine;
        }
        private static subrasse createTrollzackerSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 7;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 15), "scharz");
            srKeine.haarfarbenMap.Add(new Range(16, 17), "dunkelbraun");
            srKeine.haarfarbenMap.Add(new Range(18, 18), "mittelbraun");
            srKeine.haarfarbenMap.Add(new Range(19, 19), "hellbraun");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "dunkelblond");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 16), "schwarz");
            srKeine.augenfarbenMap.Add(new Range(17, 17), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(18, 18), "braun");
            srKeine.augenfarbenMap.Add(new Range(19, 19), "grau");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "grün");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.95;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 1, wuerfelaugen = 20, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 100;
            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = 1},
            };
            srKeine.leModifikator = 11;
            srKeine.auModifikator = 18;
            srKeine.mrModifikator = -5;
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst, wert = 6},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.Eisern},
                new VorteilsIdentifier(){name = VorteileNamen.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutdurst},
                new NachteilsIdentifier(){name = NachteileNamen.Jaehzorn},
                new NachteilsIdentifier(){name = NachteileNamen.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileNamen.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.SchlechteRegeneration},
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Trollzacken
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Ferkina, KulturNamen.Aranien,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Athletik, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Selbstbeherrschung, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 1},
            };
            return srKeine;
        }
        private static subrasse createTrollzackerSubrasseRochshaz()
        {
            var srRoch = createTrollzackerSubrasseKeine();
            // Wir überschreiben nur, was sich ändert!
            srRoch.name = SpielerSubRassenNamen.Rochshaz;
            srRoch.generierungskosten = 6;

            srRoch.koerpergroesse = new koerpergroesse();
            srRoch.koerpergroesse.basisgroesse = 2.15;
            srRoch.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 1, wuerfelaugen = 20, wuerfeloffset = 0 };

            srRoch.gewichtsabzug = 95;
            srRoch.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = 2},
            };
            srRoch.leModifikator = 12;
            srRoch.auModifikator = 20;
            srRoch.mrModifikator = -5;
            srRoch.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst, wert = 6},
                new NachteilsIdentifier(){name = NachteileNamen.Jaehzorn, wert = 6},
            };
            srRoch.empfohleneNachteile.Add(new NachteilsIdentifier(){name = NachteileNamen.Randgruppe});
            srRoch.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Trollzacken
            };
            // Andere Kulturen gehen nicht!
            srRoch.unueblicheKulturen = new List<KulturNamen>(){};
            srRoch.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Athletik, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Selbstbeherrschung, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 1},
            };

            return srRoch;
        }
        private static subrasse createWaldmenschenSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 5;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 5), "schwarz");
            srKeine.haarfarbenMap.Add(new Range(6, 19), "blauschwarz");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "dunkelbraun");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 3), "hellbraun");
            srKeine.augenfarbenMap.Add(new Range(4, 10), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(11, 20), "schwarz");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.52;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 110;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Charisma, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srKeine.leModifikator = 8;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -6;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                // Durch die Besonderheit der Rasse gibt es noch ein paar Extra-Vorteile:
                // Diese sind intelligenterweise nur im Fließtext und nicht in der Box aufgeführt. BOONS! :)
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmtesGift, auspraegungSpezielleGifte = GiftNamen.Wuara},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenKrankheiten, auspraegungKrankheit = KrankheitsNamen.FlinkerDifar},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenKrankheiten, auspraegungKrankheit = KrankheitsNamen.BrabakerSchweiss},
            };

            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
            };

            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kaelteempfindlichkeit},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
            };

            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Dschungelstaemme, KulturNamen.VerloreneStaemme, KulturNamen.Miniwatu,
                KulturNamen.Darna, KulturNamen.Suedaventurien, KulturNamen.Bukanier,
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Tocamuyac, KulturNamen.Horasreich, KulturNamen.Aranien,
                KulturNamen.TulamidischeStadtstaaten,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 1},
            };

            return srKeine;
        }
        private static subrasse createWaldmenschenSubrasseTocamuyac()
        {
            var srToca = new subrasse();
            srToca.name = SpielerSubRassenNamen.Tocamuyac;

            srToca.generierungskosten = 3;

            srToca.haarfarbenMap = new RangeMap<string>();
            srToca.haarfarbenMap.Add(new Range(1, 2), "blauschwarz");
            srToca.haarfarbenMap.Add(new Range(3, 4), "schwarz");
            srToca.haarfarbenMap.Add(new Range(5, 10), "dunkelbraun");
            srToca.haarfarbenMap.Add(new Range(11, 20), "mittelbraun");

            srToca.augenfarbenMap = new RangeMap<string>();
            srToca.augenfarbenMap.Add(new Range(1, 3), "hellbraun");
            srToca.augenfarbenMap.Add(new Range(4, 10), "dunkelbraun");
            srToca.augenfarbenMap.Add(new Range(11, 20), "schwarz");

            srToca.koerpergroesse = new koerpergroesse();
            srToca.koerpergroesse.basisgroesse = 1.42;
            srToca.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srToca.gewichtsabzug = 110;

            srToca.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Charisma, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srToca.leModifikator = 8;
            srToca.auModifikator = 12;
            srToca.mrModifikator = -6;

            srToca.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                // Durch die Besonderheit der Rasse gibt es noch ein paar Extra-Vorteile:
                // Diese sind intelligenterweise nur im Fließtext und nicht in der Box aufgeführt. BOONS! :)
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmtesGift, auspraegungSpezielleGifte = GiftNamen.Wuara},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenKrankheiten, auspraegungKrankheit = KrankheitsNamen.FlinkerDifar},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenKrankheiten, auspraegungKrankheit = KrankheitsNamen.BrabakerSchweiss},
            };

            srToca.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
            };
            srToca.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
            };
            srToca.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kaelteempfindlichkeit},
            };
            srToca.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
            };
            srToca.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Meeresangst},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
            };
            srToca.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Tocamuyac,
            };
            srToca.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Dschungelstaemme, KulturNamen.Miniwatu, KulturNamen.WaldinselUtulus,
                KulturNamen.Suedaventurien, KulturNamen.Bukanier, KulturNamen.Aranien, 
                KulturNamen.TulamidischeStadtstaaten, KulturNamen.MittellaendischeStaedte,
            };
            srToca.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schwimmen, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 1},
            };

            return srToca;

        }
        private static subrasse createUtuluSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 9;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 17), "schwarz");
            srKeine.haarfarbenMap.Add(new Range(18, 20), "blauschwarz");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 3), "hellbraun");
            srKeine.augenfarbenMap.Add(new Range(4, 10), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(11, 20), "schwarz");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.65;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 110;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 1},
            };

            srKeine.leModifikator = 11;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -6;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
                // Durch die Besonderheit der Rasse gibt es noch ein paar Extra-Vorteile:
                // Diese sind intelligenterweise nur im Fließtext und nicht in der Box aufgeführt. BOONS! :)
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmtesGift, auspraegungSpezielleGifte = GiftNamen.Wuara},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenKrankheiten, auspraegungKrankheit = KrankheitsNamen.FlinkerDifar},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenKrankheiten, auspraegungKrankheit = KrankheitsNamen.BrabakerSchweiss},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
            };

            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kaelteempfindlichkeit},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.WaldinselUtulus, KulturNamen.Dschungelstaemme, KulturNamen.VerloreneStaemme,
                KulturNamen.Suedaventurien, KulturNamen.Bukanier,               
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Aranien, KulturNamen.Dschungelstaemme, KulturNamen.Tocamuyac, KulturNamen.TulamidischeStadtstaaten,
                KulturNamen.VerloreneStaemme
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 1},
            };


            return srKeine;
        }
        private static subrasse createElfSubrasseFirnelf()
        {
            var srFirnelf = new subrasse();
            srFirnelf.name = SpielerSubRassenNamen.Firnelf;

            srFirnelf.generierungskosten = 24;

            srFirnelf.haarfarbenMap = new RangeMap<string>();
            srFirnelf.haarfarbenMap.Add(new Range(1, 1), "blauschwarz");
            srFirnelf.haarfarbenMap.Add(new Range(2, 2), "schwarz");
            srFirnelf.haarfarbenMap.Add(new Range(3, 5), "silbern");
            srFirnelf.haarfarbenMap.Add(new Range(6, 9), "schneeweiß");
            srFirnelf.haarfarbenMap.Add(new Range(10, 14), "weißblond");
            srFirnelf.haarfarbenMap.Add(new Range(15, 17), "hellblond");
            srFirnelf.haarfarbenMap.Add(new Range(18, 19), "mittelblond");
            srFirnelf.haarfarbenMap.Add(new Range(20, 20), "dunkelblond");

            srFirnelf.augenfarbenMap = new RangeMap<string>();
            srFirnelf.augenfarbenMap.Add(new Range(1, 1), "schwarz");
            srFirnelf.augenfarbenMap.Add(new Range(2, 3), "silbergrau");
            srFirnelf.augenfarbenMap.Add(new Range(4, 7), "eisgrau");
            srFirnelf.augenfarbenMap.Add(new Range(8, 11), "saphirblau");
            srFirnelf.augenfarbenMap.Add(new Range(12, 15), "smaragdgrün");
            srFirnelf.augenfarbenMap.Add(new Range(16, 18), "bernsteinfarben");
            srFirnelf.augenfarbenMap.Add(new Range(19, 19), "goldgesprenkelt");
            srFirnelf.augenfarbenMap.Add(new Range(20, 20), "rubinrot");

            srFirnelf.koerpergroesse = new koerpergroesse();
            srFirnelf.koerpergroesse.basisgroesse = 1.56;
            srFirnelf.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srFirnelf.gewichtsabzug = 120;

            srFirnelf.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srFirnelf.leModifikator = 7;
            srFirnelf.auModifikator = 15;
            srFirnelf.aspModifikator = 12;
            srFirnelf.mrModifikator = -1;

            // Wir tragen die erste Wahlmöglichkeit ein: Zwischen den Sinnen darf aus drei Sinnen
            // einer ausgewählt werden:
            srFirnelf.wahlen = new List<wahlmoeglichkeiten>(){};
            var wahlSinn = new wahlmoeglichkeiten();
            wahlSinn.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Gehoer,},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Sicht, },
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Tastsinn, },
            };
            wahlSinn.anzahlWaehlbarerVorteile = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srFirnelf.wahlen.Add( wahlSinn);

            // Sonst gibt es nichts, was man auswählen müsste, also sind wir hier fertig.


            srFirnelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Altersresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
                new VorteilsIdentifier(){name = VorteileNamen.ZweistimmigerGesang},

                // Sowie die Rassenvorteile, die wieder einmal nur im Fließtext stehen *kotz*
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Tollwut},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.SchwarzeWut},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Lykanthrophie},
            };

            srFirnelf.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.SensiblerGeruchssinn, wert = 6},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Zechen},
            };
            srFirnelf.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.AstraleRegeneration},
                new VorteilsIdentifier(){name = VorteileNamen.Astralmacht},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Singen},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Sicht},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Geschmack},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
            };
            srFirnelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Albino},
                new NachteilsIdentifier(){name = NachteileNamen.Farbenblind},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
            };
            srFirnelf.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileNamen.Zwergennase},
            };
            srFirnelf.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Behaebig},
                new NachteilsIdentifier(){name = NachteileNamen.EingeschraenkterSinn},
                new NachteilsIdentifier(){name = NachteileNamen.Fettleibig},
                new NachteilsIdentifier(){name = NachteileNamen.Glasknochen},
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Kurzatmig},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst},
                new NachteilsIdentifier(){name = NachteileNamen.Stubenhocker},
                new NachteilsIdentifier(){name = NachteileNamen.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileNamen.Unansehnlich},
            };
            srFirnelf.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.FirnelfischeSippe,

            };
            srFirnelf.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.AuelfischeSippe, KulturNamen.SteppenelfischeSippe, KulturNamen.ElfischeSiedlung,
                KulturNamen.Fjarninger, KulturNamen.Gjalskerland, KulturNamen.Nivesenstaemme,
                KulturNamen.Norbardensippe, KulturNamen.Thorwal,
            };

            srFirnelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Athletik, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 5},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 2},
            };

            return srFirnelf;
        }
        private static subrasse createElfSubrasseAuelf()
        {
            var srAuelf = new subrasse();
            srAuelf.name = SpielerSubRassenNamen.Auelf;

            srAuelf.generierungskosten = 20;

            srAuelf.haarfarbenMap = new RangeMap<string>();
            srAuelf.haarfarbenMap.Add(new Range(1, 1), "blauschwarz");
            srAuelf.haarfarbenMap.Add(new Range(2, 3), "schwarz");
            srAuelf.haarfarbenMap.Add(new Range(4, 5), "silbern");
            srAuelf.haarfarbenMap.Add(new Range(6, 7), "weißblond");
            srAuelf.haarfarbenMap.Add(new Range(8, 11), "hellblond");
            srAuelf.haarfarbenMap.Add(new Range(12, 17), "mittelblond");
            srAuelf.haarfarbenMap.Add(new Range(18, 20), "dunkelblond");

            srAuelf.augenfarbenMap = new RangeMap<string>();
            srAuelf.augenfarbenMap.Add(new Range(1, 2), "schwarzbraun");
            srAuelf.augenfarbenMap.Add(new Range(3, 4), "graublau");
            srAuelf.augenfarbenMap.Add(new Range(5, 8), "saphirblau");
            srAuelf.augenfarbenMap.Add(new Range(9, 12), "smaragdgrün");
            srAuelf.augenfarbenMap.Add(new Range(13, 16), "dunkelviolet");
            srAuelf.augenfarbenMap.Add(new Range(17, 18), "bernsteinfarben");
            srAuelf.augenfarbenMap.Add(new Range(19, 19), "goldgesprenkelt");
            srAuelf.augenfarbenMap.Add(new Range(20, 20), "amethystfarben");

            srAuelf.koerpergroesse = new koerpergroesse();
            srAuelf.koerpergroesse.basisgroesse = 1.68;
            srAuelf.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 0 };

            srAuelf.gewichtsabzug = 120;

            srAuelf.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srAuelf.leModifikator = 6;
            srAuelf.auModifikator = 12;
            srAuelf.aspModifikator = 12;
            srAuelf.mrModifikator = -2;


            // Wir tragen die erste Wahlmöglichkeit ein: Zwischen den Sinnen darf aus drei Sinnen
            // einer ausgewählt werden:
            srAuelf.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlSinn = new wahlmoeglichkeiten();
            wahlSinn.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Gehoer,},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Geruch, },
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Sicht, },
            };
            wahlSinn.anzahlWaehlbarerVorteile = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srAuelf.wahlen.Add(wahlSinn);

            // Sonst gibt es nichts, was man auswählen müsste, also sind wir hier fertig.


            srAuelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Altersresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileNamen.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
                new VorteilsIdentifier(){name = VorteileNamen.ZweistimmigerGesang},

                // Sowie die Rassenvorteile, die wieder einmal nur im Fließtext stehen *kotz*
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Tollwut},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.SchwarzeWut},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Lykanthrophie},

            };
            srAuelf.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.SensiblerGeruchssinn, wert = 6},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Zechen},
            };

            srAuelf.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.AstraleRegeneration},
                new VorteilsIdentifier(){name = VorteileNamen.Astralmacht},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Singen},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Tastsinn},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
            };
            srAuelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.Raumangst},
            };
            srAuelf.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileNamen.Zwergennase},
            };
            srAuelf.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Behaebig},
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.EingeschraenkterSinn},
                new NachteilsIdentifier(){name = NachteileNamen.Fettleibig},
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Kurzatmig},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst},
                new NachteilsIdentifier(){name = NachteileNamen.UeblerGeruch},
            };
            srAuelf.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.AuelfischeSippe, KulturNamen.SteppenelfischeSippe, KulturNamen.ElfischeSiedlung,

            };
            srAuelf.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.WaldelfischeSippe, KulturNamen.AndergastUndNostria,
                KulturNamen.Bornland, KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.Norbardensippe, KulturNamen.SvellttalUndNordlande, KulturNamen.Almada
            };

            srAuelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 5},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -2},
            };

            return srAuelf;
        }
        private static subrasse createElfSubrasseWaldelf()
        {
            var srWaldelf = new subrasse();
            srWaldelf.name = SpielerSubRassenNamen.Waldelf;

            srWaldelf.generierungskosten = 20;

            srWaldelf.haarfarbenMap = new RangeMap<string>();
            srWaldelf.haarfarbenMap.Add(new Range(1, 3), "blauschwarz");
            srWaldelf.haarfarbenMap.Add(new Range(4, 7), "schwarz");
            srWaldelf.haarfarbenMap.Add(new Range(8, 10), "silbern");
            srWaldelf.haarfarbenMap.Add(new Range(11, 11), "weißblond");
            srWaldelf.haarfarbenMap.Add(new Range(12, 13), "hellblond");
            srWaldelf.haarfarbenMap.Add(new Range(14, 16), "mittelblond");
            srWaldelf.haarfarbenMap.Add(new Range(17, 19), "dunkelblond");
            srWaldelf.haarfarbenMap.Add(new Range(20, 20), "goldblond");

            srWaldelf.augenfarbenMap = new RangeMap<string>();
            srWaldelf.augenfarbenMap.Add(new Range(1, 2), "schwarz");
            srWaldelf.augenfarbenMap.Add(new Range(3, 4), "saphirblau");
            srWaldelf.augenfarbenMap.Add(new Range(5, 8), "smaragdgrün");
            srWaldelf.augenfarbenMap.Add(new Range(9, 12), "dunkelbraun");
            srWaldelf.augenfarbenMap.Add(new Range(13, 16), "bernsteinfarben");
            srWaldelf.augenfarbenMap.Add(new Range(17, 17), "goldgesprenkelt");
            srWaldelf.augenfarbenMap.Add(new Range(18, 19), "rubinrot");
            srWaldelf.augenfarbenMap.Add(new Range(20, 20), "amethystviolett");

            srWaldelf.koerpergroesse = new koerpergroesse();
            srWaldelf.koerpergroesse.basisgroesse = 1.66;
            srWaldelf.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 20, wuerfeloffset = 11 };

            srWaldelf.gewichtsabzug = 120;

            srWaldelf.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srWaldelf.leModifikator = 6;
            srWaldelf.auModifikator = 10;
            srWaldelf.aspModifikator = 12;
            srWaldelf.mrModifikator = -2;

            // Wir tragen die erste Wahlmöglichkeit ein: Zwischen den Sinnen darf aus 2 Sinnen
            // einer ausgewählt werden:
            srWaldelf.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlSinn = new wahlmoeglichkeiten();
            wahlSinn.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Gehoer,},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Geruch, },
            };
            wahlSinn.anzahlWaehlbarerVorteile = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srWaldelf.wahlen.Add(wahlSinn);

            srWaldelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Altersresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
                new VorteilsIdentifier(){name = VorteileNamen.ZweistimmigerGesang},

                // Sowie die Rassenvorteile, die wieder einmal nur im Fließtext stehen *kotz*
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Tollwut},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.SchwarzeWut},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Lykanthrophie},
            };

            srWaldelf.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.SensiblerGeruchssinn, wert = 6},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Zechen},
            };
            srWaldelf.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.AstraleRegeneration},
                new VorteilsIdentifier(){name = VorteileNamen.Astralmacht},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Singen},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Tastsinn},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Sicht},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
            };
            srWaldelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.Raumangst},
            };
            srWaldelf.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileNamen.Zwergennase},
            };
            srWaldelf.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.EingeschraenkterSinn},
                new NachteilsIdentifier(){name = NachteileNamen.Fettleibig},
                new NachteilsIdentifier(){name = NachteileNamen.Hoehenangst},
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Kurzatmig},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst},
                new NachteilsIdentifier(){name = NachteileNamen.UeblerGeruch},
            };
            srWaldelf.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.WaldelfischeSippe,

            };
            srWaldelf.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.AuelfischeSippe, KulturNamen.SteppenelfischeSippe, KulturNamen.ElfischeSiedlung,
                KulturNamen.MittellaendischeLandbevoelkerung, KulturNamen.MittellaendischeStaedte,
                KulturNamen.Norbardensippe, KulturNamen.SvellttalUndNordlande,
            };

            srWaldelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 4},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 5},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 2},
            };

            return srWaldelf;
        }

        private static subrasse createHalbelfSubrasseThorwalscheAbstammung()
        {
            var srThorwalisch = createHalbelfSubrasseKeine();
            // Wir passen nur das an, was sich ändert:
            srThorwalisch.name = SpielerSubRassenNamen.HalbelfThorwalElf;
            srThorwalisch.generierungskosten = 4;
            srThorwalisch.leModifikator = srThorwalisch.leModifikator + 1;
            // Keine Mods auf irgendwas:
            srThorwalisch.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>() { };

            return srThorwalisch;
        }
        private static subrasse createHalbelfSubrasseNivesischeAbstammung()
        {
            var srNivesisch = createHalbelfSubrasseKeine();
            // Wir passen nur das an, was sich ändert:
            srNivesisch.name = SpielerSubRassenNamen.HalbelfNivesenElf;
            srNivesisch.generierungskosten = 8;
            srNivesisch.auModifikator = srNivesisch.auModifikator + 1;
            srNivesisch.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name=EigenschaftenNamen.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name=EigenschaftenNamen.Koerperkraft, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name=EigenschaftenNamen.Intuition, wert = 1},
            };

            // Wir tragen die erste Wahlmöglichkeit ein: Zwischen den Vorteilen darf aus 2 Vorteilen
            // einer ausgewählt werden:
            srNivesisch.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlVorteil = new wahlmoeglichkeiten();
            wahlVorteil.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
                new VorteilsIdentifier(){name = VorteileNamen.ZweistimmigerGesang},
            };
            wahlVorteil.anzahlWaehlbarerVorteile = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srNivesisch.wahlen.Add(wahlVorteil);


            srNivesisch.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.Viertelzauberer},
            };

            srNivesisch.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name= NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent=TalentNamen.Zechen},
            };

            return srNivesisch;
        }
        private static subrasse createHalbelfSubrasseFirnelfischeAbstammung()
        {
            var srFirnelf = createHalbelfSubrasseKeine();
            srFirnelf.name = SpielerSubRassenNamen.HalbelfFirnelf;
            // Wir passen nur das an, was sich ändert:
            srFirnelf.generierungskosten = 5;
            srFirnelf.auModifikator = srFirnelf.auModifikator + 2;
            srFirnelf.mrModifikator = srFirnelf.mrModifikator + 1;
            srFirnelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Viertelzauberer},
            };
            srFirnelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.SensiblerGeruchssinn},
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
            };
            srFirnelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = 1},
            };

            return srFirnelf;
        }
        private static subrasse createHalbelfSubrasseFirnelfischeSippe()
        {
            var srHalbelfFirnelfischeSippe = createHalbelfSubrasseElfischeSiedlung();
            srHalbelfFirnelfischeSippe.name = SpielerSubRassenNamen.HalbelfAusFirnelfischerSippe;
            srHalbelfFirnelfischeSippe.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.FirnelfischeSippe,
            };

            return srHalbelfFirnelfischeSippe;
        }
        private static subrasse createHalbelfSubrasseWaldelfischeSippe()
        {
            var srHalbelfWaldelfischeSippe = createHalbelfSubrasseElfischeSiedlung();
            srHalbelfWaldelfischeSippe.name = SpielerSubRassenNamen.HalbelfAusWaldelfischerSippe;
            srHalbelfWaldelfischeSippe.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.WaldelfischeSippe,
            };

            return srHalbelfWaldelfischeSippe;
        }
        private static subrasse createHalbelfSubrasseAuelfischeSippe()
        {
            var srHalbelfAuelfischeSippe = createHalbelfSubrasseElfischeSiedlung();
            srHalbelfAuelfischeSippe.name = SpielerSubRassenNamen.HalbelfAusAuelfischerSippe;
            srHalbelfAuelfischeSippe.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.AuelfischeSippe,
            };

            return srHalbelfAuelfischeSippe;
        }
        private static subrasse createHalbelfSubrasseElfischeSiedlung()
        {
            var srHalbelfElfischeSiedlung = createHalbelfSubrasseKeine();
            srHalbelfElfischeSiedlung.name = SpielerSubRassenNamen.HalbelfAusElfischerSiedlung;

            // Wir brauchen nur die Dinge zu überschreiben, die sich ändern!
            srHalbelfElfischeSiedlung.generierungskosten = 10;
            srHalbelfElfischeSiedlung.aspModifikator = 12;
            srHalbelfElfischeSiedlung.mrModifikator = -2;

            srHalbelfElfischeSiedlung.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileNamen.ZweistimmigerGesang},
            };
            srHalbelfElfischeSiedlung.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.ElfischeSiedlung,
            };
            srHalbelfElfischeSiedlung.unueblicheKulturen = new List<KulturNamen>() { };


            return srHalbelfElfischeSiedlung;
        }
        private static subrasse createHalbelfSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 3), "rot");
            srKeine.haarfarbenMap.Add(new Range(4, 6), "braun");
            srKeine.haarfarbenMap.Add(new Range(7, 10), "dunkelblond");
            srKeine.haarfarbenMap.Add(new Range(11, 15), "hellblond");
            srKeine.haarfarbenMap.Add(new Range(16, 17), "weißblond");
            srKeine.haarfarbenMap.Add(new Range(18, 19), "schwarz");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "blauschwarz");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 3), "schwarz");
            srKeine.augenfarbenMap.Add(new Range(4, 6), "grau");
            srKeine.augenfarbenMap.Add(new Range(7, 10), "blau");
            srKeine.augenfarbenMap.Add(new Range(11, 14), "grün");
            srKeine.augenfarbenMap.Add(new Range(15, 16), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(17, 18), "hellbraun");
            srKeine.augenfarbenMap.Add(new Range(19, 19), "bernsteinfarben");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "goldgesprenkelt");

            srKeine.generierungskosten = 3;

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.58;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 4, wuerfelaugen = 6, wuerfeloffset = 11 };

            srKeine.gewichtsabzug = 120;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name=EigenschaftenNamen.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name=EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srKeine.leModifikator = 8;
            srKeine.auModifikator = 10;
            srKeine.aspModifikator = -6;
            srKeine.mrModifikator = -4;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.Viertelzauberer},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Singen},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.Magiegespuer},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
                new VorteilsIdentifier(){name = VorteileNamen.ZweistimmigerGesang},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.SensiblerGeruchssinn},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.Fettleibig},
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Krankheitsanfaellig},
                new NachteilsIdentifier(){name = NachteileNamen.UnangenehmeStimme},
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.AndergastUndNostria, KulturNamen.Almada, KulturNamen.SvellttalUndNordlande,
                KulturNamen.Nivesenstaemme, KulturNamen.Norbardensippe
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Aranien, KulturNamen.Thorwal, KulturNamen.Bornland, KulturNamen.Horasreich,
                KulturNamen.Fjarninger, KulturNamen.Gjalskerland
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -1},
            };

            return srKeine;
        }

        private static subrasse createZwergSubrasseWilderZwerg()
        {
            var srKeine = createZwergSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srKeine.name = SpielerSubRassenNamen.WilderZwerg;
            srKeine.generierungskosten = 16;
            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = +2},
            };
            srKeine.leModifikator = srKeine.leModifikator + 1;
            srKeine.auModifikator = srKeine.auModifikator + 3;
            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name= VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name= VorteileNamen.ResistenzGegenBestimmteGiftart, auspraegungGiftArten = GiftArten.MineralischeGifte},
                new VorteilsIdentifier(){name=VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name=VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.Linkshaender},

                // Und hier wieder einmal Vorteile aus dem Fließtext... :(
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmtesGift, auspraegungSpezielleGifte = GiftNamen.Tulmadron},
                new VorteilsIdentifier()
                {
                    name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Lykanthrophie
                },
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Brobim,
            };

            return srKeine;
        }
        private static subrasse createZwergSubrasseAmbosszwerg()
        {
            var srAmbosszwerg = createZwergSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srAmbosszwerg.name = SpielerSubRassenNamen.Ambosszwerg;
            srAmbosszwerg.generierungskosten = 16;
            srAmbosszwerg.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = +2},
            };
            srAmbosszwerg.leModifikator = srAmbosszwerg.leModifikator + 1;
            srAmbosszwerg.auModifikator = srAmbosszwerg.auModifikator + 3;
            srAmbosszwerg.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Ambosszwerge,
            };
            srAmbosszwerg.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Erzzwerge, KulturNamen.Brillantzwerge, KulturNamen.Huegelzwerge,
                KulturNamen.MittellaendischeStaedte, KulturNamen.MittellaendischeStaedte,
                KulturNamen.Thorwal, KulturNamen.AndergastUndNostria, KulturNamen.TulamidischeStadtstaaten,
                KulturNamen.SvellttalUndNordlande,
            };

            return srAmbosszwerg;
        }
        private static subrasse createZwergSubrasseBrillantzwerg()
        {
            var srBrilliantzwerg = createZwergSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srBrilliantzwerg.name = SpielerSubRassenNamen.Brilliantzwerg;
            srBrilliantzwerg.leModifikator = srBrilliantzwerg.leModifikator - 1;
            srBrilliantzwerg.auModifikator = srBrilliantzwerg.auModifikator + 3;
            srBrilliantzwerg.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Brillantzwerge,
            };
            srBrilliantzwerg.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Ambosszwerge, KulturNamen.Erzzwerge, KulturNamen.Huegelzwerge, KulturNamen.MittellaendischeStaedte,
                KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.TulamidischeStadtstaaten,
            };

            return srBrilliantzwerg;
        }
        private static subrasse createZwergSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 5), "blond");
            srKeine.haarfarbenMap.Add(new Range(6, 9), "schwarz");
            srKeine.haarfarbenMap.Add(new Range(10, 11), "dunkelgrau");
            srKeine.haarfarbenMap.Add(new Range(12, 13), "hellgrau");
            srKeine.haarfarbenMap.Add(new Range(14, 14), "salzweiß");
            srKeine.haarfarbenMap.Add(new Range(15, 15), "silberweiß");
            srKeine.haarfarbenMap.Add(new Range(16, 17), "feuerrot");
            srKeine.haarfarbenMap.Add(new Range(18, 20), "kupferrot");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 2), "dunkelbraun");
            srKeine.augenfarbenMap.Add(new Range(3, 5), "braun");
            srKeine.augenfarbenMap.Add(new Range(6, 9), "grün");
            srKeine.augenfarbenMap.Add(new Range(10, 10), "blau");
            srKeine.augenfarbenMap.Add(new Range(11, 14), "grau");
            srKeine.augenfarbenMap.Add(new Range(15, 20), "schwarz");

            srKeine.generierungskosten = 12;

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.28;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 2, wuerfelaugen = 6, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 80;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = +1},
            };

            srKeine.leModifikator = 11;
            srKeine.auModifikator = 15;
            srKeine.mrModifikator = -4;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name= VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name= VorteileNamen.ResistenzGegenBestimmteGiftart, auspraegungGiftArten = GiftArten.MineralischeGifte},
                new VorteilsIdentifier(){name=VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name=VorteileNamen.SchwerZuVerzaubern},

                // Und hier wieder einmal Vorteile aus dem Fließtext... :(
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmtesGift, auspraegungSpezielleGifte = GiftNamen.Tulmadron},
                new VorteilsIdentifier()
                {
                    name = VorteileNamen.ImmunitaetGegenBestimmteKrankheit, auspraegungKrankheit = KrankheitsNamen.Lykanthrophie
                },
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Goldgier, wert=5},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Schwimmen},
                new NachteilsIdentifier(){name = NachteileNamen.Zwergenwuchs},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Eisern},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.GutesGedaechtnis},
                new VorteilsIdentifier(){name = VorteileNamen.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileNamen.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
                new VorteilsIdentifier(){name = VorteileNamen.Zwergennase},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.Jaehzorn},
                new NachteilsIdentifier(){name = NachteileNamen.Lichtscheu},
                new NachteilsIdentifier(){name = NachteileNamen.Meeresangst},
                new NachteilsIdentifier(){name = NachteileNamen.Platzangst},
                new NachteilsIdentifier(){name = NachteileNamen.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.Koboldfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Magiegespuer},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileNamen.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Dunkelangst},
                new NachteilsIdentifier(){name = NachteileNamen.Glasknochen},
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileNamen.Raumangst},
                new NachteilsIdentifier(){name = NachteileNamen.Sucht, auspraegungSucht = Suchtmittel.Alkohol},
                new NachteilsIdentifier(){name = NachteileNamen.Unstet},
            };
            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Erzzwerge, KulturNamen.Huegelzwerge
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Ambosszwerge, KulturNamen.Brillantzwerge, KulturNamen.MittellaendischeStaedte,
                KulturNamen.MittellaendischeLandbevoelkerung, KulturNamen.Thorwal, KulturNamen.AndergastUndNostria,
                KulturNamen.TulamidischeStadtstaaten, KulturNamen.SvellttalUndNordlande,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Ringen , wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Reiten , wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Akrobatik , wert = -3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schwimmen , wert = -3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Selbstbeherrschung , wert = 2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen , wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung , wert = 1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Gesteinskunde , wert = 1},
            };

            return srKeine;
        }

        private static subrasse createOrkSubrasseOrkfrau()
        {
            var srOrkfrau = createOrkSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srOrkfrau.name = SpielerSubRassenNamen
                .Orkfrau;
            srOrkfrau.generierungskosten = 2;
            srOrkfrau.koerpergroesse = new koerpergroesse();
            srOrkfrau.koerpergroesse.basisgroesse = 1.45;
            srOrkfrau.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srOrkfrau.gewichtsabzug = 90;

            srOrkfrau.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Charisma, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = +1},
            };

            srOrkfrau.leModifikator = srOrkfrau.leModifikator - 2;
            srOrkfrau.auModifikator = srOrkfrau.auModifikator - 3;

            srOrkfrau.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier()
                {
                    name = NachteileNamen.UnfaehigkeitFuerTalentgruppe, 
                    auspraegungTalengruppe = TalentKategorie.SprachenUndSchriften
                },
                new NachteilsIdentifier(){name = NachteileNamen.Randgruppe},
                new NachteilsIdentifier(){name = NachteileNamen.Raubtiergeruch},
            };

            srOrkfrau.nurFuerFrauen = true;
            srOrkfrau.nurFuerMaenner = false;

            return srOrkfrau;

        }
        private static subrasse createOrkSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 5), "dunkelbraun");
            srKeine.haarfarbenMap.Add(new Range(6, 11), "braun-schwarz");
            srKeine.haarfarbenMap.Add(new Range(12, 19), "tiefsschwarz");
            srKeine.haarfarbenMap.Add(new Range(20, 20), "blausschwarz");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 4), "gelb");
            srKeine.augenfarbenMap.Add(new Range(5, 12), "rot");
            srKeine.augenfarbenMap.Add(new Range(13, 16), "grau");
            srKeine.augenfarbenMap.Add(new Range(17, 20), "schwarz");

            srKeine.generierungskosten = 12;

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.50;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 95;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Charisma, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = +2},
            };

            srKeine.leModifikator = 12;
            srKeine.auModifikator = 18;
            srKeine.mrModifikator = -7;

            // Wir brauchen noch einen Identifier für den "Biss". Wir tragen ihn
            // auch gleich als Vorteil ein!
            var Orkbiss = new natuerlicheWaffenIdentifier();
            Orkbiss.name = natuerlicheWaffenNamen.Biss;
            Orkbiss.schadensWuerfel.wuerfelanzahl = 1;
            Orkbiss.schadensWuerfel.wuerfelaugen = 6;
            Orkbiss.schadensWuerfel.wuerfeloffset = 1;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = Orkbiss },
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicherRuestungsschutz, wert = 1},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Jaehzorn, wert = 6},
                new NachteilsIdentifier(){name = NachteileNamen.Randgruppe},
                new NachteilsIdentifier(){name = NachteileNamen.Raubtiergeruch},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Eisern},
                new VorteilsIdentifier(){name = VorteileNamen.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileNamen.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileNamen.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileNamen.Unansehnlich},
                new NachteilsIdentifier(){name = NachteileNamen.Arkanophobie},
                new NachteilsIdentifier()
                {
                    name = NachteileNamen.UnfaehigkeitFuerTalentgruppe, 
                    auspraegungTalengruppe = TalentKategorie.Gesellschaftlich
                },
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Koboldfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.Tierfreund},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.AngstVor, auspraegungAngst = Aengste.Feuer},
                new NachteilsIdentifier(){name = NachteileNamen.AngstVor, auspraegungAngst = Aengste.Insekten},
                new NachteilsIdentifier(){name = NachteileNamen.AngstVor, auspraegungAngst = Aengste.Pelztieren},
                new NachteilsIdentifier(){name = NachteileNamen.AngstVor, auspraegungAngst = Aengste.Spinnen},
                new NachteilsIdentifier(){name = NachteileNamen.AngstVor, auspraegungAngst = Aengste.Wasser},
                new NachteilsIdentifier(){name = NachteileNamen.Glasknochen},
                new NachteilsIdentifier(){name = NachteileNamen.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.SchlechteRegeneration},
            };

            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Orkland, KulturNamen.Yurach, KulturNamen.SvellttalBesatzer,
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.AndergastUndNostria, KulturNamen.MittellaendischeStaedte,
                KulturNamen.Suedaventurien, KulturNamen.SvellttalUndNordlande, KulturNamen.Thorwal,
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = -2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Rechnen, wert = -1},
            };

            srKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Biss},
            };

            srKeine.nurFuerMaenner = true;

            return srKeine;

        }
        private static subrasse createHalborkSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 1;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 2), "blond");
            srKeine.haarfarbenMap.Add(new Range(3, 6), "rot");
            srKeine.haarfarbenMap.Add(new Range(7, 12), "braun");
            srKeine.haarfarbenMap.Add(new Range(13, 20), "schwarz");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 2), "rot");
            srKeine.augenfarbenMap.Add(new Range(3, 9), "grün");
            srKeine.augenfarbenMap.Add(new Range(10, 11), "braun");
            srKeine.augenfarbenMap.Add(new Range(12, 17), "schwarz");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.60;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 4, wuerfelaugen = 6, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 100;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Charisma, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = +1},
            };

            srKeine.leModifikator = 11;
            srKeine.auModifikator = 15;
            srKeine.mrModifikator = -6;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Jaehzorn, wert = 6},
                new NachteilsIdentifier(){name = NachteileNamen.Randgruppe},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileNamen.Eisern},
                new VorteilsIdentifier(){name = VorteileNamen.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){name = VorteileNamen.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileNamen.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileNamen.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileNamen.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.GutAussehend},
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Koboldfreund},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Glasknochen},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.SchlechteRegeneration},
            };

            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Yurach,
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.SvellttalBesatzer, KulturNamen.SvellttalUndNordlande, KulturNamen.AndergastUndNostria,
                KulturNamen.MittellaendischeStaedte, KulturNamen.Gjalskerland,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = -2},
            };

            return srKeine;
        }

        private static subrasse createGoblinSubrasseGoblinfrau()
        {
            var srGoblinfrau = createGoblinSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srGoblinfrau.name = SpielerSubRassenNamen.Goblinfrau;
            srGoblinfrau.nurFuerMaenner = false;
            srGoblinfrau.nurFuerFrauen = true;
            srGoblinfrau.generierungskosten = 4;

            // Außerdem müssen wir die natürliche Waffe anlegen:
            var Goblinbiss = new natuerlicheWaffenIdentifier();
            Goblinbiss.name = natuerlicheWaffenNamen.Biss;
            Goblinbiss.schadensWuerfel.wuerfelanzahl = 1;
            Goblinbiss.schadensWuerfel.wuerfelaugen = 6;
            Goblinbiss.schadensWuerfel.wuerfeloffset = 0;

            srGoblinfrau.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = Goblinbiss},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicherRuestungsschutz, wert = 1},
            };

            srGoblinfrau.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.Linkshaender},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
            };

            srGoblinfrau.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = +1},
            };

            srGoblinfrau.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Klettern, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Schleichen, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Selbstbeherrschung, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Singen, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Sinnesschaerfe, wert = +4},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Zechen, wert = -3},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Rechnen, wert = -1},
            };

            return srGoblinfrau;
        }
        private static subrasse createGoblinSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;
            srKeine.nurFuerMaenner = true;

            srKeine.generierungskosten = 3;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 2), "orangerot");
            srKeine.haarfarbenMap.Add(new Range(3, 7), "feuerrot");
            srKeine.haarfarbenMap.Add(new Range(8, 13), "rotbraun");
            srKeine.haarfarbenMap.Add(new Range(14, 18), "dunkelrot");
            srKeine.haarfarbenMap.Add(new Range(19, 20), "rot-grau");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 1), "grün");
            srKeine.augenfarbenMap.Add(new Range(2, 5), "geln");
            srKeine.augenfarbenMap.Add(new Range(6, 11), "hellrot");
            srKeine.augenfarbenMap.Add(new Range(12, 17), "dunkelrot");
            srKeine.augenfarbenMap.Add(new Range(18, 19), "rotbraun");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "rotviolett");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.35;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 4, wuerfelaugen = 6, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 100;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };
            srKeine.iniBasisbonus = 2;

            srKeine.leModifikator = 4;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -5;

            // Die Goblins dürfen wählen zwischen zwei herausragenden Sinnen:
            srKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlSinn = new wahlmoeglichkeiten();
            wahlSinn.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Gehoer,},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Geruch, },
            };
            wahlSinn.anzahlWaehlbarerVorteile = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srKeine.wahlen.Add(wahlSinn);

            // Außerdem müssen wir die natürliche Waffe anlegen:
            var Goblinbiss = new natuerlicheWaffenIdentifier();
            Goblinbiss.name = natuerlicheWaffenNamen.Biss;
            Goblinbiss.schadensWuerfel.wuerfelanzahl = 1;
            Goblinbiss.schadensWuerfel.wuerfelaugen = 6;
            Goblinbiss.schadensWuerfel.wuerfeloffset = 0;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.Flink},
                new VorteilsIdentifier(){name = VorteileNamen.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = Goblinbiss},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicherRuestungsschutz, wert = 1},
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileNamen.Randgruppe},
                new NachteilsIdentifier(){name = NachteileNamen.Unstet},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Eisern},
                new VorteilsIdentifier(){name = VorteileNamen.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Glueck},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn},
                new VorteilsIdentifier(){name = VorteileNamen.Magiegespuer},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileNamen.ImmunitaetGegenBestimmtesGift},
                new VorteilsIdentifier(){name = VorteileNamen.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileNamen.ZaeherHund},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Neugier},
                new NachteilsIdentifier(){name = NachteileNamen.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileNamen.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileNamen.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileNamen.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileNamen.Linkshaender},
                new VorteilsIdentifier(){name = VorteileNamen.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileNamen.Wohlklang},
                new VorteilsIdentifier(){name = VorteileNamen.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileNamen.Viertelzauberer},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Blutrausch},
                new NachteilsIdentifier(){name = NachteileNamen.Dunkelangst},
                new NachteilsIdentifier(){name = NachteileNamen.Glasknochen},
                new NachteilsIdentifier(){name = NachteileNamen.Hoehenangst},
                new NachteilsIdentifier(){name = NachteileNamen.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){name = NachteileNamen.Krankheitsanfaellig},
                new NachteilsIdentifier(){name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileNamen.Raumangst},
                new NachteilsIdentifier(){name = NachteileNamen.SchlechteRegeneration},
            };

            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Goblinstamm, KulturNamen.Goblinbande, KulturNamen.FestumerGhetto,
                KulturNamen.MittellaendischeStaedte
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.SvellttalUndNordlande, KulturNamen.MittellaendischeLandbevoelkerung,
                KulturNamen.AndergastUndNostria, KulturNamen.Orkland, KulturNamen.Yurach,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Klettern, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Schleichen, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Selbstbeherrschung, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Singen, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Sinnesschaerfe, wert = +4},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){ name = TalentNamen.Rechnen, wert = -1},
            };

            srKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){name = SFNamen.Biss},
            };

            return srKeine;
        }

        private subrasse createAchazSubrasseMaraskan()
        {
            var srMaraskan = createAchazSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srMaraskan.name = SpielerSubRassenNamen.MaraskanAchaz;

            srMaraskan.generierungskosten = 16;
            srMaraskan.leModifikator = 7;
            srMaraskan.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srMaraskan.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileNamen.Tierempathie });

            srMaraskan.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schwimmen, wert = +3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = -3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = +7},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.StimmenImitieren, wert = -3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Faehrtensuchen, wert = +3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.FischenUndAngeln, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Musizieren, wert = -3},
            };

            srMaraskan.sonderfertigkeiten.Add
            (
                new sfIdentifier() 
                {
                    name = SFNamen.Talentspezialisierung, 
                    talent  = TalentNamen.Sinnesschaerfe,
                    talentSubSpez = TalentSpezialisierungen.RiechenUndSchmecken, 
                }
            );


            return srMaraskan;

        }
        private subrasse createAchazSubrasseWaldinsel()
        {
            var srWaldinsel = createAchazSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srWaldinsel.name = SpielerSubRassenNamen.WaldinselAchaz;

            srWaldinsel.generierungskosten = 5;

            srWaldinsel.koerpergroesse = new koerpergroesse();
            srWaldinsel.koerpergroesse.basisgroesse = 2.07;
            srWaldinsel.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srWaldinsel.gewichtsabzug = 120;
            srWaldinsel.leModifikator = 7;

            srWaldinsel.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            return srWaldinsel;


        }
        private subrasse createAchazSubrasseOrkland()
        {
            var srOrkland = createAchazSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srOrkland.name = SpielerSubRassenNamen.OrklandAchaz;

            srOrkland.generierungskosten = 9;

            srOrkland.koerpergroesse = new koerpergroesse();
            srOrkland.koerpergroesse.basisgroesse = 1.59;
            srOrkland.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srOrkland.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            // Wir legen schon einmal die beiden natürlichen Waffen an:
            var Achazbiss = new natuerlicheWaffenIdentifier();
            Achazbiss.name = natuerlicheWaffenNamen.Biss;
            Achazbiss.schadensWuerfel.wuerfelanzahl = 1;
            Achazbiss.schadensWuerfel.wuerfelaugen = 6;
            Achazbiss.schadensWuerfel.wuerfeloffset = 0;
            Achazbiss.machtNurTPA = true;
            var AchazSchwanz = new natuerlicheWaffenIdentifier();
            AchazSchwanz.name = natuerlicheWaffenNamen.Schwanz;
            AchazSchwanz.schadensWuerfel.wuerfelanzahl = 1;
            AchazSchwanz.schadensWuerfel.wuerfelaugen = 6;
            AchazSchwanz.schadensWuerfel.wuerfeloffset = 0;
            AchazSchwanz.machtNurTPA = true;

            srOrkland.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Schwimmen},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Geruch},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = Achazbiss},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = AchazSchwanz},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicherRuestungsschutz, wert = 1},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZusaetzlicheGliedmassen, auspraegungGliedmasse = GliedmassenNamen.Schwanz},
            };

            srOrkland.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Dunkelangst, wert = 5},
                new NachteilsIdentifier(){name = NachteileNamen.EingeschraenkterSinn, auspraegungSinn = SinneNamen.Gehoer},
                new NachteilsIdentifier(){name = NachteileNamen.Randgruppe},
                new NachteilsIdentifier(){name = NachteileNamen.Raubtiergeruch},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Singen},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.StimmenImitieren},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
            };

            srOrkland.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.StammesAchaz,
            };

            return srOrkland;
        }
        private subrasse createAchazSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenNamen.keine;

            srKeine.generierungskosten = 14;

            srKeine.haarfarbenMap = new RangeMap<string>();
            srKeine.haarfarbenMap.Add(new Range(1, 5), "hellgrün");
            srKeine.haarfarbenMap.Add(new Range(6, 10), "olivgrün");
            srKeine.haarfarbenMap.Add(new Range(11, 15), "dunkelgrün");
            srKeine.haarfarbenMap.Add(new Range(16, 18), "braungrün");
            srKeine.haarfarbenMap.Add(new Range(19, 20), "braun");

            srKeine.augenfarbenMap = new RangeMap<string>();
            srKeine.augenfarbenMap.Add(new Range(1, 2), "golden");
            srKeine.augenfarbenMap.Add(new Range(3, 4), "gelb");
            srKeine.augenfarbenMap.Add(new Range(5, 9), "hellgrün");
            srKeine.augenfarbenMap.Add(new Range(10, 14), "olivgrün");
            srKeine.augenfarbenMap.Add(new Range(15, 17), "dunkelgrün");
            srKeine.augenfarbenMap.Add(new Range(18, 19), "hellbraun");
            srKeine.augenfarbenMap.Add(new Range(20, 20), "kupfern");

            srKeine.koerpergroesse = new koerpergroesse();
            srKeine.koerpergroesse.basisgroesse = 1.67;
            srKeine.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srKeine.gewichtsabzug = 120;

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenNamen>>()
            {
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Fingerfertigkeit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenNamen>(){name = EigenschaftenNamen.Koerperkraft, wert = -1},
            };

            srKeine.leModifikator = 8;
            srKeine.auModifikator = 7;
            srKeine.mrModifikator = -2;

            // Wir legen schon einmal die beiden natürlichen Waffen an:
            var Achazbiss = new natuerlicheWaffenIdentifier();
            Achazbiss.name = natuerlicheWaffenNamen.Biss;
            Achazbiss.schadensWuerfel.wuerfelanzahl = 1;
            Achazbiss.schadensWuerfel.wuerfelaugen = 6;
            Achazbiss.schadensWuerfel.wuerfeloffset = 0;
            Achazbiss.machtNurTPA = true;
            var AchazSchwanz = new natuerlicheWaffenIdentifier();
            AchazSchwanz.name = natuerlicheWaffenNamen.Schwanz;
            AchazSchwanz.schadensWuerfel.wuerfelanzahl = 1;
            AchazSchwanz.schadensWuerfel.wuerfelaugen = 6;
            AchazSchwanz.schadensWuerfel.wuerfeloffset = 0;
            AchazSchwanz.machtNurTPA = true;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileNamen.Balance},
                new VorteilsIdentifier(){name = VorteileNamen.BegabungFuerTalent, auspraegungTalent = TalentNamen.Schwimmen},
                new VorteilsIdentifier(){name = VorteileNamen.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileNamen.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Geruch},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = Achazbiss},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicheWaffen, natuerlicheWaffen = AchazSchwanz},
                new VorteilsIdentifier(){name = VorteileNamen.NatuerlicherRuestungsschutz, wert = 2},
                new VorteilsIdentifier(){name = VorteileNamen.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileNamen.ZusaetzlicheGliedmassen, auspraegungGliedmasse = GliedmassenNamen.Schwanz},
            };

            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileNamen.Dunkelangst, wert = 5},
                new NachteilsIdentifier(){name = NachteileNamen.EingeschraenkterSinn, auspraegungSinn = SinneNamen.Gehoer},
                new NachteilsIdentifier(){name = NachteileNamen.Kaeltestarre},
                new NachteilsIdentifier(){name = NachteileNamen.Randgruppe},
                new NachteilsIdentifier(){name = NachteileNamen.Raubtiergeruch},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Singen},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.StimmenImitieren},
                new NachteilsIdentifier(){name = NachteileNamen.UnfaehigkeitFuerTalent, auspraegungTalent = TalentNamen.Musizieren},
            };

            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileNamen.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileNamen.HerausragendeBalance},
                new VorteilsIdentifier(){ name = VorteileNamen.HoheMagieresistenz},
                new VorteilsIdentifier(){ name = VorteileNamen.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileNamen.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileNamen.ImmunitaetGegenGifte},
                new VorteilsIdentifier(){ name = VorteileNamen.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileNamen.Zeitgefuehl},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileNamen.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileNamen.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileNamen.Nahrungsrestriktion},
                new NachteilsIdentifier(){ name = NachteileNamen.Sonnensucht},
                new NachteilsIdentifier(){ name = NachteileNamen.UnangenehmeStimme},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileNamen.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileNamen.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileNamen.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Tastsinn},
                new VorteilsIdentifier(){ name = VorteileNamen.HerausragenderSinn, auspraegungSinn = SinneNamen.Gehoer},
                new VorteilsIdentifier(){ name = VorteileNamen.HerausragendesAussehen},
                new VorteilsIdentifier(){ name = VorteileNamen.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileNamen.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileNamen.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileNamen.BegabungFuerTalentgruppe, auspraegungTalentgruppe = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileNamen.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){ name = VorteileNamen.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileNamen.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileNamen.Kleinwuechsig},
                new NachteilsIdentifier(){ name = NachteileNamen.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileNamen.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileNamen.Lichtscheu},
            };

            srKeine.ueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.StammesAchaz, KulturNamen.ArchaischeAchaz,
            };
            srKeine.unueblicheKulturen = new List<KulturNamen>()
            {
                KulturNamen.Suedaventurien, KulturNamen.Maraskan
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentNamen>>()
            {
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Schwimmen, wert = +5},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Singen, wert = -3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Sinnesschaerfe, wert = +5},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.StimmenImitieren, wert = +3},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Faehrtensuchen, wert = +2},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.FischenUndAngeln, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentNamen>(){name = TalentNamen.Musizieren, wert = -3},
            };

            srKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Schwanzschlag},
                new sfIdentifier(){ name = SFNamen.Biss},
            };
            srKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){name = SFNamen.Schwanzfeger},
            };

            return srKeine;
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
        /// Rassen-Modifikator für die ASP
        /// </summary>
        public int aspModifikator;

        /// <summary>
        /// Automatische Vorteile durch die Rasse
        /// Substruktur enthält den Namen und ggfs. den Wert
        /// </summary>
        public List<VorteilsIdentifier> automatischeVorteile;
        /// <summary>
        ///  Automatische Nachteile durch die Rasse
        /// </summary>
        public List<NachteilsIdentifier> automatischeNachteile;
        /// <summary>
        ///  Empfohlene Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<VorteilsIdentifier> empfohleneVorteile;
        /// <summary>
        ///  Empfohlene Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI als grün 
        ///  hervorgehoben werden. Ist nicht bindend.
        /// </summary>
        public List<NachteilsIdentifier> empfohleneNachteile;
        /// <summary>
        ///  Nicht geeignere Vorteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public List<VorteilsIdentifier> ungeeigneteVorteile;
        /// <summary>
        ///  Nicht geeignere Nachteile für eine Rasse. Kann optisch bei der Generierung in der GUI
        ///  als rot hervorgehoben werden. Sollte bindend sein.
        /// </summary>
        public List<NachteilsIdentifier> ungeeigneteNachteile;
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

        /// <summary>
        /// Welche SF bekommt man automatisch?
        /// </summary>
        public List<sfIdentifier> sonderfertigkeiten;

        /// <summary>
        /// Welche SF bekommt man billiger?
        /// </summary>
        public List<sfIdentifier> verbilligteSonderfertigkeiten;

        /// <summary>
        /// Ist die (Sub-)Rasse nur für Männer wählbar?
        /// </summary>
        public bool nurFuerMaenner;

        /// <summary>
        /// Ist die (Sub-)Rasse nur für Frauen wählbar?
        /// </summary>
        public bool nurFuerFrauen;

        /// <summary>
        /// Eine Liste von verschiedenen Auswahlen für Vorteile, Talente, etc.
        /// </summary>
        public List<wahlmoeglichkeiten> wahlen;

        /// <summary>
        /// Bonuswert für den Basiswert der Initiative (nur Goblins)
        /// </summary>
        public int iniBasisbonus;

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
        /// Die entsprechenden Attribute müssen natürlich gesetzt werden!
        /// </summary>
        public wuerfel wuerfel;
    };       
}