using System.Collections.Generic;
using Listen;
using Common;
using vorteileStruktur;
using nachteileStruktur;
using wuerfelKlasse;
using sfStruktur;
using spielerAuswahl;
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace rassenStruktur
{
    /// <summary>
    /// Struktur, die alle Rassen in Aventurien enthält:
    /// </summary>
    public class rassenStruct
    {
        public rassenStruct(SpielerRassenName spielerRassenName)
        {
            this.rasse = spielerRassenName;
            this.moeglicheSubrassen = new ObservableCollection<subrasse>();
        }

        /// <summary>
        /// Eine Liste mit allen möglichen Subrassennamen. Enthält immer mindestens den
        /// Eintrag mit dem eigentlichen Rassennamen. Bei manchen Rassen (z.B. Thorwaler)
        /// können Subrassen gewählt werden.
        /// </summary>
        public ObservableCollection<subrasse> moeglicheSubrassen;

        public ObservableCollection<subrasse> MoeglicheSubrassen
        {
            get { return moeglicheSubrassen; }
        }

        /// <summary>
        /// Identifier der Rasse
        /// </summary>
        private SpielerRassenName rasse;
        public SpielerRassenName Identifier
        {
            get
            {
                return rasse;
            }
        }

        /// <summary>
        /// [Tom]: Der Name der Rasse.
        /// Dies ist eine sogenannte Property.
        /// </summary>
        public string Name
        {
            get
            {
                return EnumExtentions.GetDescription(rasse);
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

        public static List<rassenStruct> erzeugeAlleRassen()
        {
            List<rassenStruct> alleRassen = new List<rassenStruct>();
            alleRassen.Add(createMittellaender());
            alleRassen.Add(createTulamide());
            alleRassen.Add(createThorwaler());
            alleRassen.Add(createNivese());
            return alleRassen;
        }

        static public rassenStruct getRasseByIdentifier(SpielerRassenName identifier)
        {
            var alleRassen = erzeugeAlleRassen();
            var gesuchteRasse = alleRassen.Find(rasse => rasse.Identifier.Equals(identifier));
            return gesuchteRasse;
        }

        static rassenStruct createMittellaender()
        {
            rassenStruct mittellaender = new rassenStruct(SpielerRassenName.Mittellaender);
            mittellaender.moeglicheSubrassen.Add(createMittellaenderSubrasseKeine());
            return mittellaender;
        }

        static rassenStruct createTulamide()
        {
            rassenStruct tulamide = new rassenStruct(SpielerRassenName.Tulamiden);
            tulamide.moeglicheSubrassen.Add(createTulamideSubrasseKeine());
            return tulamide;
        }

        static rassenStruct createThorwaler()
        {
            rassenStruct thorwaler = new rassenStruct(SpielerRassenName.Thorwaler);
            thorwaler.moeglicheSubrassen.Add(createThorwalerSubrasseKeine());
            thorwaler.moeglicheSubrassen.Add(createThorwalerSubrasseFjarninger());
            thorwaler.moeglicheSubrassen.Add(createThorwalerSubrasseGjalskalaender());
            return thorwaler;
        }

        static rassenStruct createNivese()
        {
            var nivese = new rassenStruct(SpielerRassenName.Nivese);
            nivese.moeglicheSubrassen.Add(createNiveseSubrasseKeine());
            return nivese;
        }

        static rassenStruct createNorbarde()
        {
            var norbarde = new rassenStruct(SpielerRassenName.Norbarde);
            norbarde.moeglicheSubrassen.Add(createNorbardeSubrasseKeine());
            return norbarde;
        }

        static rassenStruct createTrollzacker()
        {
            var trollzacker = new rassenStruct(SpielerRassenName.Trollzacker);
            trollzacker.moeglicheSubrassen.Add(createTrollzackerSubrasseKeine());
            return trollzacker;
        }

        static rassenStruct createWaldmensch()
        {
            var waldmensch = new rassenStruct(SpielerRassenName.Waldmensch);
            waldmensch.moeglicheSubrassen.Add(createWaldmenschenSubrasseKeine());
            waldmensch.moeglicheSubrassen.Add(createWaldmenschenSubrasseTocamuyac());
            return waldmensch;
        }

        static rassenStruct createUtulu()
        {
            var utulu = new rassenStruct(SpielerRassenName.Utulu);
            utulu.moeglicheSubrassen.Add(createUtuluSubrasseKeine());
            return utulu;
        }

        static rassenStruct createElf()
        {
            var elf = new rassenStruct(SpielerRassenName.Elf);
            elf.moeglicheSubrassen.Add(createElfSubrasseAuelf());
            elf.moeglicheSubrassen.Add(createElfSubrasseWaldelf());
            elf.moeglicheSubrassen.Add(createElfSubrasseFirnelf());
            return elf;
        }

        static rassenStruct createHalbElf()
        {
            var halbElf = new rassenStruct(SpielerRassenName.Halbelf);
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseKeine());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseFirnelfischeAbstammung());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseNivesischeAbstammung());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseThorwalscheAbstammung());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseAuelfischeSippe());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseElfischeSiedlung());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseFirnelfischeSippe());
            halbElf.moeglicheSubrassen.Add(createHalbelfSubrasseWaldelfischeSippe());
            return halbElf;
        }

        static rassenStruct createZwerg()
        {
            var zwerg = new rassenStruct(SpielerRassenName.Zwerg);
            zwerg.moeglicheSubrassen.Add(createZwergSubrasseKeine());
            zwerg.moeglicheSubrassen.Add(createZwergSubrasseBrillantzwerg());
            zwerg.moeglicheSubrassen.Add(createZwergSubrasseAmbosszwerg());
            zwerg.moeglicheSubrassen.Add(createZwergSubrasseWilderZwerg());
            return zwerg;
        }

        static rassenStruct createOrk()
        {
            var ork = new rassenStruct(SpielerRassenName.Ork);
            ork.moeglicheSubrassen.Add(createOrkSubrasseKeine());
            ork.moeglicheSubrassen.Add(createOrkSubrasseOrkfrau());
            return ork;
        }

        static rassenStruct createHalbork()
        {
            var ork = new rassenStruct(SpielerRassenName.Ork);
            ork.moeglicheSubrassen.Add(createHalborkSubrasseKeine());
            return ork;
        }

        static rassenStruct createGoblin()
        {
            var goblin = new rassenStruct(SpielerRassenName.Goblin);
            goblin.moeglicheSubrassen.Add(createGoblinSubrasseKeine());
            goblin.moeglicheSubrassen.Add(createGoblinSubrasseGoblinfrau());
            return goblin;
        }

        static rassenStruct createAchaz()
        {
            var achaz = new rassenStruct(SpielerRassenName.Achaz);
            achaz.moeglicheSubrassen.Add(createAchazSubrasseKeine());
            achaz.moeglicheSubrassen.Add(createAchazSubrasseOrkland());
            achaz.moeglicheSubrassen.Add(createAchazSubrasseWaldinsel());
            achaz.moeglicheSubrassen.Add(createAchazSubrasseMaraskan());
            return achaz;
        }
        


/*
        /// <summary>
        /// Der Identifier dieser Rasse. Der Setter definiert die Attribute der Rasse
        /// Dazu werden jeweils alle möglichen Subrassen angelegt und mit in der Struktur verankert.
        /// Wenn die Rasse über keine Subrasse verfügt, erhält sie die Rubrasse "keine", die alle
        /// Eigenschaften und Attribute der "Mutterrasse" enthält.
        /// </summary>
        public SpielerRassenName Rasse
        {
            set
            {
                try
                {
                    var r = getRasseByIdentifier(value);
                    if (r != null)
                    {
                        rasse = value;
                        moeglicheSubrassen = r.moeglicheSubrassen;
                    }
                    else
                    {
                        switch (value)
                        {
                            ///////////////////////////////////////
                            // Norbarde
                            ///////////////////////////////////////
                            case SpielerRassenName.Norbarde:
                                rasse = value;
                                moeglicheSubrassen = new ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createNorbardeSubrasseKeine());
                                break;
                            ///////////////////////////////////////
                            // Trollzacker
                            ///////////////////////////////////////
                            case SpielerRassenName.Trollzacker:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createTrollzackerSubrasseKeine());
                                break;
                            ///////////////////////////////////////
                            // Waldmenschen
                            ///////////////////////////////////////
                            case SpielerRassenName.Waldmensch:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createWaldmenschenSubrasseKeine());
                                moeglicheSubrassen.Add(createWaldmenschenSubrasseTocamuyac());
                                break;
                            ///////////////////////////////////////
                            // Utulus
                            ///////////////////////////////////////
                            case SpielerRassenName.Utulu:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createUtuluSubrasseKeine());
                                break;
                            ///////////////////////////////////////
                            // Elfen
                            ///////////////////////////////////////
                            case SpielerRassenName.Elf:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createElfSubrasseAuelf());
                                moeglicheSubrassen.Add(createElfSubrasseWaldelf());
                                moeglicheSubrassen.Add(createElfSubrasseFirnelf());
                                break;
                            ///////////////////////////////////////
                            // Halbelfen
                            ///////////////////////////////////////
                            case SpielerRassenName.Halbelf:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
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
                            case SpielerRassenName.Zwerg:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createZwergSubrasseKeine());
                                moeglicheSubrassen.Add(createZwergSubrasseBrillantzwerg());
                                moeglicheSubrassen.Add(createZwergSubrasseAmbosszwerg());
                                moeglicheSubrassen.Add(createZwergSubrasseWilderZwerg());
                                break;
                            ///////////////////////////////////////
                            // Orks
                            ///////////////////////////////////////
                            case SpielerRassenName.Ork:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createOrkSubrasseKeine());
                                moeglicheSubrassen.Add(createOrkSubrasseOrkfrau());
                                break;
                            ///////////////////////////////////////
                            // Halborks
                            ///////////////////////////////////////
                            case SpielerRassenName.Halbork:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createHalborkSubrasseKeine());
                                break;
                            ///////////////////////////////////////
                            // Goblins
                            ///////////////////////////////////////
                            case SpielerRassenName.Goblin:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(createGoblinSubrasseKeine());
                                moeglicheSubrassen.Add(createGoblinSubrasseGoblinfrau());
                                break;
                            ///////////////////////////////////////
                            // Achaz
                            ///////////////////////////////////////
                            case SpielerRassenName.Achaz:
                                rasse = value;
                                moeglicheSubrassen = new  ObservableCollection<subrasse>();
                                moeglicheSubrassen.Add(());
                                moeglicheSubrassen.Add(());
                                moeglicheSubrassen.Add(());
                                moeglicheSubrassen.Add(());
                                break;

                            default:
                                throw new System.ArgumentOutOfRangeException();
                        }
                    }

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültige Rasse angegeben!");
                }
            }
        }
 * */

        private static subrasse createMittellaenderSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.MittellaendischeStaedte, KulturName.MittellaendischeLandbevoelkerung, 
                KulturName.AndergastUndNostria,
                KulturName.Bornland, KulturName.SvellttalUndNordlande, KulturName.Almada, 
                KulturName.Horasreich,
                KulturName.Zyklopeninseln, KulturName.Maraskan, KulturName.Suedaventurien, 
                KulturName.Bukanier,
            };
            // [Tom]: oder auch so:
            // ueblicheKulturen.Add("Bukanier");
            //[Tom]: Listenbefüllung:
            // Wir füllen die Liste mittels eines sogenannten Collection Initializers
            // siehe http://www.developer.com/net/csharp/article.php/3607421/New-in-C-30-Create-and-Initialize-Collection-Objects-in-One-Step.htm

            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Aranien, KulturName.TulamidischeStadtstaaten, KulturName.Thorwal,
                KulturName.Mhanadistan, KulturName.Amazonenburg,
            };
            //[Tom]: Auch hier können wir ganz Prima einen Collection Initializer benutzen. Diesmal in der geschachtelten Ausführung
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>() { };

            return srKeine;
        }
        private static subrasse createTulamideSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Aranien, KulturName.Mhanadistan, KulturName.TulamidischeStadtstaaten, KulturName.Novadi,
                KulturName.Ferkina, KulturName.Zahori, KulturName.Maraskan, KulturName.Suedaventurien, KulturName.Bukanier,
            };
            srKeine.unueblicheKulturen = new List<KulturName> 
            {
                KulturName.MittellaendischeStaedte, KulturName.Almada, KulturName.Amazonenburg,
            };
            return srKeine;
        }
        private static subrasse createThorwalerSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>{name= EigenschaftenName.MU, wert=1},
                new GenericListenNameWertPaar<EigenschaftenName>{name= EigenschaftenName.KO, wert=1},
                new GenericListenNameWertPaar<EigenschaftenName>{name= EigenschaftenName.KK, wert=1},
            };

            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Jaehzorn,wert = 6},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Eisern},
                new VorteilsIdentifier(){name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutdurst},
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Thorwal, KulturName.Fjarninger, KulturName.Gjalskerland
            };
            srKeine.unueblicheKulturen = new List<KulturName> 
            {
                KulturName.MittellaendischeStaedte, KulturName.MittellaendischeLandbevoelkerung,
                KulturName.AndergastUndNostria, KulturName.Bornland, KulturName.SvellttalUndNordlande, 
                KulturName.Suedaventurien, KulturName.TulamidischeStadtstaaten, KulturName.Bukanier,
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Athletik, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Wettervorhersage, wert = 1},
            };

            return srKeine;
        }
        private static subrasse createThorwalerSubrasseFjarninger()
        {
            var srFjarn = createThorwalerSubrasseKeine();
            // Wir brauchen nur die Unterschiede zwischen den Subrassen zu ändern:
            srFjarn.name = SpielerSubRassenName.Fjarninger;
            srFjarn.koerpergroesse.basisgroesse = 1.68 + 0.05;
            return srFjarn;
        }
        private static subrasse createThorwalerSubrasseGjalskalaender()
        {
            var srGjal = createThorwalerSubrasseKeine();
            // Wir brauchen nur die Unterschiede zwischen den Subrassen zu ändern:
            srGjal.name = SpielerSubRassenName.Gjalskerlaender;
            srGjal.haarfarbenMap.Clear(); //Tom: Einige der Werte, die unten stehen sind auch schon in der Oberrasse enthalten. 
                                          //Das gibt einen Absturz. Um den zu verhindern wird die Liste hier geleeert.
                                          //@Mat: Bitte ansehen
            srGjal.haarfarbenMap.Add(new Range(1, 4), "blond");
            srGjal.haarfarbenMap.Add(new Range(5, 8), "rotblond");
            srGjal.haarfarbenMap.Add(new Range(9, 15), "rot");
            srGjal.haarfarbenMap.Add(new Range(16, 17), "braun");
            srGjal.haarfarbenMap.Add(new Range(18, 20), "schwarz");
            srGjal.augenfarbenMap.Clear(); //Tom: Siehe oben, @Mat: Bitte ansehen.
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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 1},
            };

            srKeine.leModifikator = 9;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -5;

            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.Wolfskind},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };

            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
            };

            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kaelteempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
            };

            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Nivesenstaemme, KulturName.NuanaaeLie,
            };

            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.MittellaendischeStaedte, KulturName.MittellaendischeLandbevoelkerung,
                KulturName.Bornland, KulturName.SvellttalUndNordlande, KulturName.Thorwal,
                KulturName.Gjalskerland, KulturName.Fjarninger, KulturName.Norbardensippe
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Selbstbeherrschung, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 1},
            };

            return srKeine;
        }
        private static subrasse createNorbardeSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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
            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Charisma, wert = 1},
            };
            srKeine.leModifikator = 11;
            srKeine.auModifikator = 10;
            srKeine.mrModifikator = -4;
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Norbardensippe
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.MittellaendischeStaedte, KulturName.MittellaendischeLandbevoelkerung,
                KulturName.Bornland, KulturName.Thorwal, KulturName.SvellttalUndNordlande,
                KulturName.Nivesenstaemme, KulturName.Gjalskerland,
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>{name = TalentName.Orientierung, wert = 1},
                new GenericListenNameWertPaar<TalentName>{name = TalentName.Rechnen, wert = 1},
            };


            return srKeine;
        }
        private static subrasse createTrollzackerSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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
            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = 1},
            };
            srKeine.leModifikator = 11;
            srKeine.auModifikator = 18;
            srKeine.mrModifikator = -5;
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Platzangst, wert = 6},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.Eisern},
                new VorteilsIdentifier(){name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutdurst},
                new NachteilsIdentifier(){name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){name = NachteileName.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileName.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.SchlechteRegeneration},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Trollzacken
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Ferkina, KulturName.Aranien,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Athletik, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Selbstbeherrschung, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 1},
            };
            return srKeine;
        }
        private static subrasse createTrollzackerSubrasseRochshaz()
        {
            var srRoch = createTrollzackerSubrasseKeine();
            // Wir überschreiben nur, was sich ändert!
            srRoch.name = SpielerSubRassenName.Rochshaz;
            srRoch.generierungskosten = 6;

            srRoch.koerpergroesse = new koerpergroesse();
            srRoch.koerpergroesse.basisgroesse = 2.15;
            srRoch.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 1, wuerfelaugen = 20, wuerfeloffset = 0 };

            srRoch.gewichtsabzug = 95;
            srRoch.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = 2},
            };
            srRoch.leModifikator = 12;
            srRoch.auModifikator = 20;
            srRoch.mrModifikator = -5;
            srRoch.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Platzangst, wert = 6},
                new NachteilsIdentifier(){name = NachteileName.Jaehzorn, wert = 6},
            };
            srRoch.empfohleneNachteile.Add(new NachteilsIdentifier(){name = NachteileName.Randgruppe});
            srRoch.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Trollzacken
            };
            // Andere Kulturen gehen nicht!
            srRoch.unueblicheKulturen = new List<KulturName>(){};
            srRoch.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Athletik, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Selbstbeherrschung, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 1},
            };

            return srRoch;
        }
        private static subrasse createWaldmenschenSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Charisma, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
            };

            srKeine.leModifikator = 8;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -6;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                // Durch die Besonderheit der Rasse gibt es noch ein paar Extra-Vorteile:
                // Diese sind intelligenterweise nur im Fließtext und nicht in der Box aufgeführt. BOONS! :)
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmtesGift, auspraegung = GiftName.Wuara},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenKrankheiten, auspraegung = KrankheitsName.FlinkerDifar},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenKrankheiten, auspraegung = KrankheitsName.BrabakerSchweiss},
            };

            if (srKeine.automatischeVorteile[0].auspraegung.GetType()==typeof(GiftName))
            {
                System.Console.Write("Juhu");
            }

            if (srKeine.automatischeVorteile[0].name.GetType() == typeof(VorteileName))
            {
                
            }


            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
            };

            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kaelteempfindlichkeit},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };

            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Dschungelstaemme, KulturName.VerloreneStaemme, KulturName.Miniwatu,
                KulturName.Darna, KulturName.Suedaventurien, KulturName.Bukanier,
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Tocamuyac, KulturName.Horasreich, KulturName.Aranien,
                KulturName.TulamidischeStadtstaaten,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 1},
            };

            return srKeine;
        }
        private static subrasse createWaldmenschenSubrasseTocamuyac()
        {
            var srToca = new subrasse();
            srToca.name = SpielerSubRassenName.Tocamuyac;

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

            srToca.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Charisma, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
            };

            srToca.leModifikator = 8;
            srToca.auModifikator = 12;
            srToca.mrModifikator = -6;

            srToca.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                // Durch die Besonderheit der Rasse gibt es noch ein paar Extra-Vorteile:
                // Diese sind intelligenterweise nur im Fließtext und nicht in der Box aufgeführt. BOONS! :)
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmtesGift, auspraegung = GiftName.Wuara},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenKrankheiten, auspraegung = KrankheitsName.FlinkerDifar},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenKrankheiten, auspraegung = KrankheitsName.BrabakerSchweiss},
            };

            srToca.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
            };
            srToca.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
            };
            srToca.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kaelteempfindlichkeit},
            };
            srToca.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
            };
            srToca.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };
            srToca.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Tocamuyac,
            };
            srToca.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Dschungelstaemme, KulturName.Miniwatu, KulturName.WaldinselUtulus,
                KulturName.Suedaventurien, KulturName.Bukanier, KulturName.Aranien, 
                KulturName.TulamidischeStadtstaaten, KulturName.MittellaendischeStaedte,
            };
            srToca.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schwimmen, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 1},
            };

            return srToca;

        }
        private static subrasse createUtuluSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 1},
            };

            srKeine.leModifikator = 11;
            srKeine.auModifikator = 12;
            srKeine.mrModifikator = -6;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
                // Durch die Besonderheit der Rasse gibt es noch ein paar Extra-Vorteile:
                // Diese sind intelligenterweise nur im Fließtext und nicht in der Box aufgeführt. BOONS! :)
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmtesGift, auspraegung = GiftName.Wuara},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenKrankheiten, auspraegung = KrankheitsName.FlinkerDifar},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenKrankheiten, auspraegung = KrankheitsName.BrabakerSchweiss},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Musizieren},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
            };

            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kaelteempfindlichkeit},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.WaldinselUtulus, KulturName.Dschungelstaemme, KulturName.VerloreneStaemme,
                KulturName.Suedaventurien, KulturName.Bukanier,               
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Aranien, KulturName.Dschungelstaemme, KulturName.Tocamuyac, KulturName.TulamidischeStadtstaaten,
                KulturName.VerloreneStaemme
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Klettern, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 1},
            };


            return srKeine;
        }
        private static subrasse createElfSubrasseFirnelf()
        {
            var srFirnelf = new subrasse();
            srFirnelf.name = SpielerSubRassenName.Firnelf;

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

            srFirnelf.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
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
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer,},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Sicht, },
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Tastsinn, },
            };
            wahlSinn.anzahlZuWaehlen = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srFirnelf.wahlen.Add( wahlSinn);

            // Sonst gibt es nichts, was man auswählen müsste, also sind wir hier fertig.


            srFirnelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Altersresistenz},
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){name = VorteileName.ZweistimmigerGesang},

                // Sowie die Rassenvorteile, die wieder einmal nur im Fließtext stehen *kotz*
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Tollwut},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.SchwarzeWut},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Lykanthrophie},
            };

            srFirnelf.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.SensiblerGeruchssinn, wert = 6},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Zechen},
            };
            srFirnelf.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.AstraleRegeneration},
                new VorteilsIdentifier(){name = VorteileName.Astralmacht},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Singen},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Musizieren},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Sicht},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Geschmack},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
            };
            srFirnelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Albino},
                new NachteilsIdentifier(){name = NachteileName.Farbenblind},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
            };
            srFirnelf.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileName.Zwergennase},
            };
            srFirnelf.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Behaebig},
                new NachteilsIdentifier(){name = NachteileName.EingeschraenkterSinn},
                new NachteilsIdentifier(){name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
                new NachteilsIdentifier(){name = NachteileName.Stubenhocker},
                new NachteilsIdentifier(){name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileName.Unansehnlich},
            };
            srFirnelf.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.FirnelfischeSippe,

            };
            srFirnelf.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.AuelfischeSippe, KulturName.SteppenelfischeSippe, KulturName.ElfischeSiedlung,
                KulturName.Fjarninger, KulturName.Gjalskerland, KulturName.Nivesenstaemme,
                KulturName.Norbardensippe, KulturName.Thorwal,
            };

            srFirnelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Athletik, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 5},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 2},
            };

            return srFirnelf;
        }
        private static subrasse createElfSubrasseAuelf()
        {
            var srAuelf = new subrasse();
            srAuelf.name = SpielerSubRassenName.Auelf;

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

            srAuelf.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
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
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer,},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Geruch, },
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Sicht, },
            };
            wahlSinn.anzahlZuWaehlen = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srAuelf.wahlen.Add(wahlSinn);

            // Sonst gibt es nichts, was man auswählen müsste, also sind wir hier fertig.


            srAuelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Altersresistenz},
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileName.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){name = VorteileName.ZweistimmigerGesang},

                // Sowie die Rassenvorteile, die wieder einmal nur im Fließtext stehen *kotz*
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Tollwut},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.SchwarzeWut},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Lykanthrophie},

            };
            srAuelf.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.SensiblerGeruchssinn, wert = 6},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Zechen},
            };

            srAuelf.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.AstraleRegeneration},
                new VorteilsIdentifier(){name = VorteileName.Astralmacht},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Singen},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Musizieren},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Tastsinn},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
            };
            srAuelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.Raumangst},
            };
            srAuelf.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileName.Zwergennase},
            };
            srAuelf.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Behaebig},
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.EingeschraenkterSinn},
                new NachteilsIdentifier(){name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
                new NachteilsIdentifier(){name = NachteileName.UeblerGeruch},
            };
            srAuelf.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.AuelfischeSippe, KulturName.SteppenelfischeSippe, KulturName.ElfischeSiedlung,

            };
            srAuelf.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.WaldelfischeSippe, KulturName.AndergastUndNostria,
                KulturName.Bornland, KulturName.MittellaendischeStaedte, KulturName.MittellaendischeLandbevoelkerung,
                KulturName.Norbardensippe, KulturName.SvellttalUndNordlande, KulturName.Almada
            };

            srAuelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 5},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -2},
            };

            return srAuelf;
        }
        private static subrasse createElfSubrasseWaldelf()
        {
            var srWaldelf = new subrasse();
            srWaldelf.name = SpielerSubRassenName.Waldelf;

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

            srWaldelf.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
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
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer,},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Geruch, },
            };
            wahlSinn.anzahlZuWaehlen = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srWaldelf.wahlen.Add(wahlSinn);

            srWaldelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Altersresistenz},
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){name = VorteileName.ZweistimmigerGesang},

                // Sowie die Rassenvorteile, die wieder einmal nur im Fließtext stehen *kotz*
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Tollwut},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.SchwarzeWut},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Lykanthrophie},
            };

            srWaldelf.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.SensiblerGeruchssinn, wert = 6},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Zechen},
            };
            srWaldelf.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.AstraleRegeneration},
                new VorteilsIdentifier(){name = VorteileName.Astralmacht},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Singen},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Musizieren},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Tastsinn},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Sicht},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
            };
            srWaldelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.Raumangst},
            };
            srWaldelf.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileName.Zwergennase},
            };
            srWaldelf.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.EingeschraenkterSinn},
                new NachteilsIdentifier(){name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
                new NachteilsIdentifier(){name = NachteileName.UeblerGeruch},
            };
            srWaldelf.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.WaldelfischeSippe,

            };
            srWaldelf.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.AuelfischeSippe, KulturName.SteppenelfischeSippe, KulturName.ElfischeSiedlung,
                KulturName.MittellaendischeLandbevoelkerung, KulturName.MittellaendischeStaedte,
                KulturName.Norbardensippe, KulturName.SvellttalUndNordlande,
            };

            srWaldelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 4},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 5},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 2},
            };

            return srWaldelf;
        }

        private static subrasse createHalbelfSubrasseThorwalscheAbstammung()
        {
            var srThorwalisch = createHalbelfSubrasseKeine();
            // Wir passen nur das an, was sich ändert:
            srThorwalisch.name = SpielerSubRassenName.HalbelfThorwalElf;
            srThorwalisch.generierungskosten = 4;
            srThorwalisch.leModifikator = srThorwalisch.leModifikator + 1;
            // Keine Mods auf irgendwas:
            srThorwalisch.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>() { };

            return srThorwalisch;
        }
        private static subrasse createHalbelfSubrasseNivesischeAbstammung()
        {
            var srNivesisch = createHalbelfSubrasseKeine();
            // Wir passen nur das an, was sich ändert:
            srNivesisch.name = SpielerSubRassenName.HalbelfNivesenElf;
            srNivesisch.generierungskosten = 8;
            srNivesisch.auModifikator = srNivesisch.auModifikator + 1;
            srNivesisch.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name=EigenschaftenName.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name=EigenschaftenName.Koerperkraft, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name=EigenschaftenName.Intuition, wert = 1},
            };

            // Wir tragen die erste Wahlmöglichkeit ein: Zwischen den Vorteilen darf aus 2 Vorteilen
            // einer ausgewählt werden:
            srNivesisch.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlVorteil = new wahlmoeglichkeiten();
            wahlVorteil.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){name = VorteileName.ZweistimmigerGesang},
            };
            wahlVorteil.anzahlZuWaehlen = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srNivesisch.wahlen.Add(wahlVorteil);


            srNivesisch.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.Viertelzauberer},
            };

            srNivesisch.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name= NachteileName.UnfaehigkeitFuerTalent, auspraegung=TalentName.Zechen},
            };

            return srNivesisch;
        }
        private static subrasse createHalbelfSubrasseFirnelfischeAbstammung()
        {
            var srFirnelf = createHalbelfSubrasseKeine();
            srFirnelf.name = SpielerSubRassenName.HalbelfFirnelf;
            // Wir passen nur das an, was sich ändert:
            srFirnelf.generierungskosten = 5;
            srFirnelf.auModifikator = srFirnelf.auModifikator + 2;
            srFirnelf.mrModifikator = srFirnelf.mrModifikator + 1;
            srFirnelf.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.Viertelzauberer},
            };
            srFirnelf.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.SensiblerGeruchssinn},
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
            };
            srFirnelf.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = 1},
            };

            return srFirnelf;
        }
        private static subrasse createHalbelfSubrasseFirnelfischeSippe()
        {
            var srHalbelfFirnelfischeSippe = createHalbelfSubrasseElfischeSiedlung();
            srHalbelfFirnelfischeSippe.name = SpielerSubRassenName.HalbelfAusFirnelfischerSippe;
            srHalbelfFirnelfischeSippe.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.FirnelfischeSippe,
            };

            return srHalbelfFirnelfischeSippe;
        }
        private static subrasse createHalbelfSubrasseWaldelfischeSippe()
        {
            var srHalbelfWaldelfischeSippe = createHalbelfSubrasseElfischeSiedlung();
            srHalbelfWaldelfischeSippe.name = SpielerSubRassenName.HalbelfAusWaldelfischerSippe;
            srHalbelfWaldelfischeSippe.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.WaldelfischeSippe,
            };

            return srHalbelfWaldelfischeSippe;
        }
        private static subrasse createHalbelfSubrasseAuelfischeSippe()
        {
            var srHalbelfAuelfischeSippe = createHalbelfSubrasseElfischeSiedlung();
            srHalbelfAuelfischeSippe.name = SpielerSubRassenName.HalbelfAusAuelfischerSippe;
            srHalbelfAuelfischeSippe.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.AuelfischeSippe,
            };

            return srHalbelfAuelfischeSippe;
        }
        private static subrasse createHalbelfSubrasseElfischeSiedlung()
        {
            var srHalbelfElfischeSiedlung = createHalbelfSubrasseKeine();
            srHalbelfElfischeSiedlung.name = SpielerSubRassenName.HalbelfAusElfischerSiedlung;

            // Wir brauchen nur die Dinge zu überschreiben, die sich ändern!
            srHalbelfElfischeSiedlung.generierungskosten = 10;
            srHalbelfElfischeSiedlung.aspModifikator = 12;
            srHalbelfElfischeSiedlung.mrModifikator = -2;

            srHalbelfElfischeSiedlung.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileName.ZweistimmigerGesang},
            };
            srHalbelfElfischeSiedlung.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.ElfischeSiedlung,
            };
            srHalbelfElfischeSiedlung.unueblicheKulturen = new List<KulturName>() { };


            return srHalbelfElfischeSiedlung;
        }
        private static subrasse createHalbelfSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name=EigenschaftenName.Gewandtheit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name=EigenschaftenName.Koerperkraft, wert = -1},
            };

            srKeine.leModifikator = 8;
            srKeine.auModifikator = 10;
            srKeine.aspModifikator = -6;
            srKeine.mrModifikator = -4;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.Viertelzauberer},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Singen},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Musizieren},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.Magiegespuer},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){name = VorteileName.ZweistimmigerGesang},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.SensiblerGeruchssinn},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){name = NachteileName.UnangenehmeStimme},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.MittellaendischeStaedte, KulturName.MittellaendischeLandbevoelkerung,
                KulturName.AndergastUndNostria, KulturName.Almada, KulturName.SvellttalUndNordlande,
                KulturName.Nivesenstaemme, KulturName.Norbardensippe
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Aranien, KulturName.Thorwal, KulturName.Bornland, KulturName.Horasreich,
                KulturName.Fjarninger, KulturName.Gjalskerland
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Tanzen, wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -1},
            };

            return srKeine;
        }

        private static subrasse createZwergSubrasseWilderZwerg()
        {
            var srKeine = createZwergSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srKeine.name = SpielerSubRassenName.WilderZwerg;
            srKeine.generierungskosten = 16;
            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = +2},
            };
            srKeine.leModifikator = srKeine.leModifikator + 1;
            srKeine.auModifikator = srKeine.auModifikator + 3;
            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name= VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name= VorteileName.ResistenzGegenBestimmteGiftart, auspraegung = GiftArt.MineralischeGifte},
                new VorteilsIdentifier(){name=VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name=VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.Linkshaender},

                // Und hier wieder einmal Vorteile aus dem Fließtext... :(
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmtesGift, auspraegung = GiftName.Tulmadron},
                new VorteilsIdentifier()
                {
                    name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Lykanthrophie
                },
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Brobim,
            };

            return srKeine;
        }
        private static subrasse createZwergSubrasseAmbosszwerg()
        {
            var srAmbosszwerg = createZwergSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srAmbosszwerg.name = SpielerSubRassenName.Ambosszwerg;
            srAmbosszwerg.generierungskosten = 16;
            srAmbosszwerg.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = +2},
            };
            srAmbosszwerg.leModifikator = srAmbosszwerg.leModifikator + 1;
            srAmbosszwerg.auModifikator = srAmbosszwerg.auModifikator + 3;
            srAmbosszwerg.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Ambosszwerge,
            };
            srAmbosszwerg.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Erzzwerge, KulturName.Brillantzwerge, KulturName.Huegelzwerge,
                KulturName.MittellaendischeStaedte, KulturName.MittellaendischeStaedte,
                KulturName.Thorwal, KulturName.AndergastUndNostria, KulturName.TulamidischeStadtstaaten,
                KulturName.SvellttalUndNordlande,
            };

            return srAmbosszwerg;
        }
        private static subrasse createZwergSubrasseBrillantzwerg()
        {
            var srBrilliantzwerg = createZwergSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srBrilliantzwerg.name = SpielerSubRassenName.Brilliantzwerg;
            srBrilliantzwerg.leModifikator = srBrilliantzwerg.leModifikator - 1;
            srBrilliantzwerg.auModifikator = srBrilliantzwerg.auModifikator + 3;
            srBrilliantzwerg.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Brillantzwerge,
            };
            srBrilliantzwerg.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Ambosszwerge, KulturName.Erzzwerge, KulturName.Huegelzwerge, KulturName.MittellaendischeStaedte,
                KulturName.MittellaendischeLandbevoelkerung,
                KulturName.TulamidischeStadtstaaten,
            };

            return srBrilliantzwerg;
        }
        private static subrasse createZwergSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = 1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = +1},
            };

            srKeine.leModifikator = 11;
            srKeine.auModifikator = 15;
            srKeine.mrModifikator = -4;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name= VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name= VorteileName.ResistenzGegenBestimmteGiftart, auspraegung = GiftArt.MineralischeGifte},
                new VorteilsIdentifier(){name=VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name=VorteileName.SchwerZuVerzaubern},

                // Und hier wieder einmal Vorteile aus dem Fließtext... :(
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmtesGift, auspraegung = GiftName.Tulmadron},
                new VorteilsIdentifier()
                {
                    name = VorteileName.ImmunitaetGegenBestimmteKrankheit, auspraegung = KrankheitsName.Lykanthrophie
                },
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Goldgier, wert=5},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Schwimmen},
                new NachteilsIdentifier(){name = NachteileName.Zwergenwuchs},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Eisern},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileName.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
                new VorteilsIdentifier(){name = VorteileName.Zwergennase},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
                new NachteilsIdentifier(){name = NachteileName.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){name = VorteileName.Magiegespuer},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileName.Raumangst},
                new NachteilsIdentifier(){name = NachteileName.Sucht, auspraegung = Suchtmittel.Alkohol},
                new NachteilsIdentifier(){name = NachteileName.Unstet},
            };
            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Erzzwerge, KulturName.Huegelzwerge
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Ambosszwerge, KulturName.Brillantzwerge, KulturName.MittellaendischeStaedte,
                KulturName.MittellaendischeLandbevoelkerung, KulturName.Thorwal, KulturName.AndergastUndNostria,
                KulturName.TulamidischeStadtstaaten, KulturName.SvellttalUndNordlande,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Ringen , wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Reiten , wert = -1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Akrobatik , wert = -3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schwimmen , wert = -3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Selbstbeherrschung , wert = 2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen , wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung , wert = 1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Gesteinskunde , wert = 1},
            };

            return srKeine;
        }

        private static subrasse createOrkSubrasseOrkfrau()
        {
            var srOrkfrau = createOrkSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srOrkfrau.name = SpielerSubRassenName
                .Orkfrau;
            srOrkfrau.generierungskosten = 2;
            srOrkfrau.koerpergroesse = new koerpergroesse();
            srOrkfrau.koerpergroesse.basisgroesse = 1.45;
            srOrkfrau.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srOrkfrau.gewichtsabzug = 90;

            srOrkfrau.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Charisma, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = +1},
            };

            srOrkfrau.leModifikator = srOrkfrau.leModifikator - 2;
            srOrkfrau.auModifikator = srOrkfrau.auModifikator - 3;

            srOrkfrau.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier()
                {
                    name = NachteileName.UnfaehigkeitFuerTalentgruppe, 
                    auspraegung = TalentKategorie.SprachenUndSchriften
                },
                new NachteilsIdentifier(){name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){name = NachteileName.Raubtiergeruch},
            };

            srOrkfrau.nurFuerFrauen = true;
            srOrkfrau.nurFuerMaenner = false;

            return srOrkfrau;

        }
        private static subrasse createOrkSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = 2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Charisma, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = +2},
            };

            srKeine.leModifikator = 12;
            srKeine.auModifikator = 18;
            srKeine.mrModifikator = -7;

            // Wir brauchen noch einen Identifier für den "Biss". Wir tragen ihn
            // auch gleich als Vorteil ein!
            var Orkbiss = new natuerlicheWaffenIdentifier();
            Orkbiss.name = natuerlicheWaffenName.Biss;
            Orkbiss.schadensWuerfel.wuerfelanzahl = 1;
            Orkbiss.schadensWuerfel.wuerfelaugen = 6;
            Orkbiss.schadensWuerfel.wuerfeloffset = 1;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = Orkbiss },
                new VorteilsIdentifier(){name = VorteileName.NatuerlicherRuestungsschutz, wert = 1},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Jaehzorn, wert = 6},
                new NachteilsIdentifier(){name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){name = NachteileName.Raubtiergeruch},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Eisern},
                new VorteilsIdentifier(){name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){name = NachteileName.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileName.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){name = NachteileName.Arkanophobie},
                new NachteilsIdentifier()
                {
                    name = NachteileName.UnfaehigkeitFuerTalentgruppe, 
                    auspraegung = TalentKategorie.Gesellschaftlich
                },
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.AngstVor, auspraegung = Angst.Feuer},
                new NachteilsIdentifier(){name = NachteileName.AngstVor, auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){name = NachteileName.AngstVor, auspraegung = Angst.Pelztieren},
                new NachteilsIdentifier(){name = NachteileName.AngstVor, auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){name = NachteileName.AngstVor, auspraegung = Angst.Wasser},
                new NachteilsIdentifier(){name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.SchlechteRegeneration},
            };

            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.OrklandDrasdech, KulturName.OrklandErgoch, KulturName.OrklandGrishik, 
                KulturName.OrklandKhurkach, KulturName.OrklandOkwach,
                KulturName.Yurach, KulturName.SvellttalBesatzer,
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.AndergastUndNostria, KulturName.MittellaendischeStaedte,
                KulturName.Suedaventurien, KulturName.SvellttalUndNordlande, KulturName.Thorwal,
            };
            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = -2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Rechnen, wert = -1},
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
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Charisma, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = +1},
            };

            srKeine.leModifikator = 11;
            srKeine.auModifikator = 15;
            srKeine.mrModifikator = -6;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };



            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Jaehzorn, wert = 6},
                new NachteilsIdentifier(){name = NachteileName.Randgruppe},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Eisern},
                new VorteilsIdentifier(){name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileName.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileName.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.SchlechteRegeneration},
            };

            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Yurach,
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.SvellttalBesatzer, KulturName.SvellttalUndNordlande, KulturName.AndergastUndNostria,
                KulturName.MittellaendischeStaedte, KulturName.Gjalskerland,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = -2},
            };

            return srKeine;
        }

        private static subrasse createGoblinSubrasseGoblinfrau()
        {
            var srGoblinfrau = createGoblinSubrasseKeine();
            // Wir müssen nur das ändern, was sich unterscheidet:
            srGoblinfrau.name = SpielerSubRassenName.Goblinfrau;
            srGoblinfrau.nurFuerMaenner = false;
            srGoblinfrau.nurFuerFrauen = true;
            srGoblinfrau.generierungskosten = 4;

            // Außerdem müssen wir die natürliche Waffe anlegen:
            var Goblinbiss = new natuerlicheWaffenIdentifier();
            Goblinbiss.name = natuerlicheWaffenName.Biss;
            Goblinbiss.schadensWuerfel.wuerfelanzahl = 1;
            Goblinbiss.schadensWuerfel.wuerfelaugen = 6;
            Goblinbiss.schadensWuerfel.wuerfeloffset = 0;

            srGoblinfrau.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Nachtsicht},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = Goblinbiss},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicherRuestungsschutz, wert = 1},
            };

            srGoblinfrau.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.Linkshaender},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
            };

            srGoblinfrau.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = +1},
            };

            srGoblinfrau.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Klettern, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleichen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Singen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = -3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = -1},
            };

            return srGoblinfrau;
        }
        private static subrasse createGoblinSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;
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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Klugheit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
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
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer,},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Geruch, },
            };
            wahlSinn.anzahlZuWaehlen = 1;
            // Jetzt fügen wir diese Auswahl hinzu:
            srKeine.wahlen.Add(wahlSinn);

            // Außerdem müssen wir die natürliche Waffe anlegen:
            var Goblinbiss = new natuerlicheWaffenIdentifier();
            Goblinbiss.name = natuerlicheWaffenName.Biss;
            Goblinbiss.schadensWuerfel.wuerfelanzahl = 1;
            Goblinbiss.schadensWuerfel.wuerfelaugen = 6;
            Goblinbiss.schadensWuerfel.wuerfeloffset = 0;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.Flink},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = Goblinbiss},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicherRuestungsschutz, wert = 1},
            };
            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){name = NachteileName.Unstet},
            };
            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Eisern},
                new VorteilsIdentifier(){name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){name = VorteileName.Glueck},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn},
                new VorteilsIdentifier(){name = VorteileName.Magiegespuer},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){name = VorteileName.ImmunitaetGegenBestimmtesGift},
                new VorteilsIdentifier(){name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Neugier},
                new NachteilsIdentifier(){name = NachteileName.NiedrigeMagieresistenz},
                new NachteilsIdentifier(){name = NachteileName.UeblerGeruch},
                new NachteilsIdentifier(){name = NachteileName.UnangenehmeStimme},
                new NachteilsIdentifier(){name = NachteileName.Unansehnlich},
            };
            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){name = VorteileName.Linkshaender},
                new VorteilsIdentifier(){name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){name = VorteileName.Vollzauberer},
                new VorteilsIdentifier(){name = VorteileName.Viertelzauberer},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){name = NachteileName.Raumangst},
                new NachteilsIdentifier(){name = NachteileName.SchlechteRegeneration},
            };

            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.Goblinstamm, KulturName.Goblinbande, KulturName.FestumerGhetto,
                KulturName.MittellaendischeStaedte
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.SvellttalUndNordlande, KulturName.MittellaendischeLandbevoelkerung,
                KulturName.AndergastUndNostria, KulturName.Yurach,
                KulturName.OrklandOkwach, KulturName.OrklandKhurkach, KulturName.OrklandGrishik,
                KulturName.OrklandErgoch, KulturName.OrklandDrasdech,
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Klettern, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleichen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Singen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +4},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = -1},
            };

            srKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){name = SFNamen.Biss},
            };

            return srKeine;
        }

        private static subrasse createAchazSubrasseMaraskan()
        {
            var srMaraskan = createAchazSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srMaraskan.name = SpielerSubRassenName.MaraskanAchaz;

            srMaraskan.generierungskosten = 16;
            srMaraskan.leModifikator = 7;
            srMaraskan.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
            };

            srMaraskan.automatischeVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Tierempathie });

            srMaraskan.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schwimmen, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = -3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = +7},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.StimmenImitieren, wert = -3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Faehrtensuchen, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.FischenUndAngeln, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Musizieren, wert = -3},
            };

            srMaraskan.sonderfertigkeiten.Add
            (
                new sfIdentifier() 
                {
                    name = SFNamen.Talentspezialisierung, 
                    auspraegung  = TalentName.Sinnesschaerfe,
                    subAuspraegung = TalentSpezialisierung.RiechenUndSchmecken, 
                }
            );


            return srMaraskan;

        }
        private static subrasse createAchazSubrasseWaldinsel()
        {
            var srWaldinsel = createAchazSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srWaldinsel.name = SpielerSubRassenName.WaldinselAchaz;

            srWaldinsel.generierungskosten = 5;

            srWaldinsel.koerpergroesse = new koerpergroesse();
            srWaldinsel.koerpergroesse.basisgroesse = 2.07;
            srWaldinsel.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srWaldinsel.gewichtsabzug = 120;
            srWaldinsel.leModifikator = 7;

            srWaldinsel.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = -2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
            };

            return srWaldinsel;


        }
        private static subrasse createAchazSubrasseOrkland()
        {
            var srOrkland = createAchazSubrasseKeine();
            // Wir ändern nur das, was sich unterscheidet:
            srOrkland.name = SpielerSubRassenName.OrklandAchaz;

            srOrkland.generierungskosten = 9;

            srOrkland.koerpergroesse = new koerpergroesse();
            srOrkland.koerpergroesse.basisgroesse = 1.59;
            srOrkland.koerpergroesse.wuerfel = new wuerfel() { wuerfelanzahl = 3, wuerfelaugen = 6, wuerfeloffset = 0 };

            srOrkland.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
            };

            // Wir legen schon einmal die beiden natürlichen Waffen an:
            var Achazbiss = new natuerlicheWaffenIdentifier();
            Achazbiss.name = natuerlicheWaffenName.Biss;
            Achazbiss.schadensWuerfel.wuerfelanzahl = 1;
            Achazbiss.schadensWuerfel.wuerfelaugen = 6;
            Achazbiss.schadensWuerfel.wuerfeloffset = 0;
            Achazbiss.machtNurTPA = true;
            var AchazSchwanz = new natuerlicheWaffenIdentifier();
            AchazSchwanz.name = natuerlicheWaffenName.Schwanz;
            AchazSchwanz.schadensWuerfel.wuerfelanzahl = 1;
            AchazSchwanz.schadensWuerfel.wuerfelaugen = 6;
            AchazSchwanz.schadensWuerfel.wuerfeloffset = 0;
            AchazSchwanz.machtNurTPA = true;

            srOrkland.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Schwimmen},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Geruch},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = Achazbiss},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = AchazSchwanz},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicherRuestungsschutz, wert = 1},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZusaetzlicheGliedmassen, auspraegung = GliedmassenName.Schwanz},
            };

            srOrkland.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Dunkelangst, wert = 5},
                new NachteilsIdentifier(){name = NachteileName.EingeschraenkterSinn, auspraegung = SinneName.Gehoer},
                new NachteilsIdentifier(){name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){name = NachteileName.Raubtiergeruch},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Singen},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.StimmenImitieren},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Musizieren},
            };

            srOrkland.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.StammesAchaz,
            };

            return srOrkland;
        }
        private static subrasse createAchazSubrasseKeine()
        {
            var srKeine = new subrasse();
            srKeine.name = SpielerSubRassenName.keine;

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

            srKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Intuition, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Fingerfertigkeit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Gewandtheit, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Koerperkraft, wert = -1},
            };

            srKeine.leModifikator = 8;
            srKeine.auModifikator = 7;
            srKeine.mrModifikator = -2;

            // Wir legen schon einmal die beiden natürlichen Waffen an:
            var Achazbiss = new natuerlicheWaffenIdentifier();
            Achazbiss.name = natuerlicheWaffenName.Biss;
            Achazbiss.schadensWuerfel.wuerfelanzahl = 1;
            Achazbiss.schadensWuerfel.wuerfelaugen = 6;
            Achazbiss.schadensWuerfel.wuerfeloffset = 0;
            Achazbiss.machtNurTPA = true;
            var AchazSchwanz = new natuerlicheWaffenIdentifier();
            AchazSchwanz.name = natuerlicheWaffenName.Schwanz;
            AchazSchwanz.schadensWuerfel.wuerfelanzahl = 1;
            AchazSchwanz.schadensWuerfel.wuerfelaugen = 6;
            AchazSchwanz.schadensWuerfel.wuerfeloffset = 0;
            AchazSchwanz.machtNurTPA = true;

            srKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Balance},
                new VorteilsIdentifier(){name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Schwimmen},
                new VorteilsIdentifier(){name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){name = VorteileName.Daemmerungssicht},
                new VorteilsIdentifier(){name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Geruch},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = Achazbiss},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicheWaffen, natuerlicheWaffen = AchazSchwanz},
                new VorteilsIdentifier(){name = VorteileName.NatuerlicherRuestungsschutz, wert = 2},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZusaetzlicheGliedmassen, auspraegung = GliedmassenName.Schwanz},
            };

            srKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Dunkelangst, wert = 5},
                new NachteilsIdentifier(){name = NachteileName.EingeschraenkterSinn, auspraegung = SinneName.Gehoer},
                new NachteilsIdentifier(){name = NachteileName.Kaeltestarre},
                new NachteilsIdentifier(){name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){name = NachteileName.Raubtiergeruch},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Singen},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.StimmenImitieren},
                new NachteilsIdentifier(){name = NachteileName.UnfaehigkeitFuerTalent, auspraegung = TalentName.Musizieren},
            };

            srKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.HerausragendeBalance},
                new VorteilsIdentifier(){ name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.ImmunitaetGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.Zeitgefuehl},
            };
            srKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Nahrungsrestriktion},
                new NachteilsIdentifier(){ name = NachteileName.Sonnensucht},
                new NachteilsIdentifier(){ name = NachteileName.UnangenehmeStimme},
            };

            srKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Tastsinn},
                new VorteilsIdentifier(){ name = VorteileName.HerausragenderSinn, auspraegung = SinneName.Gehoer},
                new VorteilsIdentifier(){ name = VorteileName.HerausragendesAussehen},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };
            srKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Kleinwuechsig},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
            };

            srKeine.ueblicheKulturen = new List<KulturName>()
            {
                KulturName.StammesAchaz, KulturName.ArchaischeAchaz,
            };
            srKeine.unueblicheKulturen = new List<KulturName>()
            {
                KulturName.Suedaventurien, KulturName.Maraskan
            };

            srKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Schwimmen, wert = +5},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Singen, wert = -3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Sinnesschaerfe, wert = +5},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.StimmenImitieren, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Faehrtensuchen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.FischenUndAngeln, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Musizieren, wert = -3},
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
    //  Substrukturen der Rassen-Struktur.
    //////////////////////////////////////
    /// <summary>
    /// Struktur, die die eigentlichen Informationen zur Subrasse enthält. Jede Rasse wird
    /// als Subrasse "keine" bezeichnet, wenn sie keine Subrasse hat!
    /// </summary>
    public class subrasse
    {
        /// <summary>
        /// Name der Subrasse. Ist "keine", falls die Rasse keine Subrasse besitzt.
        /// </summary>
        public SpielerSubRassenName name;
        public SpielerSubRassenName Identifier
        {
            get
            {
                return name;
            }
        }
            

        /// <summary>
        /// Der Name der Subrasse als String für die GUI
        /// </summary>
        public string Name
        {
            get
            {
                return EnumExtentions.GetDescription(name);
            }
        }

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
        public List<GenericListenNameWertPaar<EigenschaftenName>> eigenschaftsModifikationen;
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
        public List<KulturName> ueblicheKulturen;
        /// <summary>
        /// Unübliche Kulturen für eine Rasse. Kann optisch bei der Generierung in der GUI als
        /// gelb hervorgehoben werden. Ist nicht bindend, sollte aber nur in Absprache mit dem
        /// Meister verwendet werden.
        /// </summary>
        public List<KulturName> unueblicheKulturen;
        /// <summary>
        /// Die Talentmodifikatoren dieser Rasse. Enthält sowohl den jeweiligen Talentnamen als
        /// auch den Modifikator auf das Talent.
        /// </summary>
        public List<GenericListenNameWertPaar<TalentName>> talentModifikatoren;

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