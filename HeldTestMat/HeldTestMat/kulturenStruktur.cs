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

                        ///////////////////////////////////////
                        // Mittelländische Landbevölkerung
                        ///////////////////////////////////////
                        case KulturName.MittellaendischeLandbevoelkerung:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createMittelLandSubKeine());
                            moeglicheSubkulturen.Add(createMittelLandSubKueste());
                            moeglicheSubkulturen.Add(createMittelLandSubHandel());
                            moeglicheSubkulturen.Add(createMittelLandSubWeiden());
                            moeglicheSubkulturen.Add(createMittelLandSuGebirge());
                            moeglicheSubkulturen.Add(createMittelLandSubFern());
                            moeglicheSubkulturen.Add(createMittelLandSubLandadel());
                            moeglicheSubkulturen.Add(createMittelLandJilaskan());
                            moeglicheSubkulturen.Add(createMittelLandSubBorbi());
                            break;

                        ///////////////////////////////////////
                        // Andergast und Nostria
                        ///////////////////////////////////////
                        case KulturName.AndergastUndNostria:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createAndergastSubKeine());
                            moeglicheSubkulturen.Add(createAndergastSubStadt());
                            moeglicheSubkulturen.Add(createAndergastSubLandadel());
                            moeglicheSubkulturen.Add(createAndergastSubGebirge());
                            moeglicheSubkulturen.Add(createAndergastSubKueste());
                            moeglicheSubkulturen.Add(createAndergastSubTeshkalien());
                            break;

                        ///////////////////////////////////////
                        // Bornland
                        ///////////////////////////////////////
                        case KulturName.Bornland:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createBornlandSubKeine());
                            moeglicheSubkulturen.Add(createBornlandSubLand());
                            moeglicheSubkulturen.Add(createBornlandSubKueste());
                            moeglicheSubkulturen.Add(createBornlandSubLandadel());
                            break;

                        ///////////////////////////////////////
                        // SvelltTal und Nordlande
                        ///////////////////////////////////////
                        case KulturName.SvellttalUndNordlande:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createSvelltSubKeine());
                            moeglicheSubkulturen.Add(createSvelltSubStadt());
                            moeglicheSubkulturen.Add(createSvelltSubKleinstadt());
                            moeglicheSubkulturen.Add(createSvelltSubKueste());
                            moeglicheSubkulturen.Add(createSvelltSubFern());
                            moeglicheSubkulturen.Add(createSvelltSubFluecht());
                            break;
                        ///////////////////////////////////////
                        // Almada
                        ///////////////////////////////////////
                        case KulturName.Almada:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createAlmadaSubKeine());
                            moeglicheSubkulturen.Add(createAlmadaSubYaquir());
                            moeglicheSubkulturen.Add(createAlmadaSubTempel());
                            moeglicheSubkulturen.Add(createAlmadaSubAdel());
                            moeglicheSubkulturen.Add(createAlmadaSubHandel());
                            moeglicheSubkulturen.Add(createAlmadaSubGebrige());
                            moeglicheSubkulturen.Add(createAlmadaSubLandadel());
                            break;
                        ///////////////////////////////////////
                        // Horasreich
                        ///////////////////////////////////////
                        case KulturName.Horasreich:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createHorasSubKeine());
                            moeglicheSubkulturen.Add(createHorasSubHafen());
                            moeglicheSubkulturen.Add(createHorasSubTempel());
                            moeglicheSubkulturen.Add(createHorasSubAdel());
                            moeglicheSubkulturen.Add(createHorasSubKueste());
                            moeglicheSubkulturen.Add(createHorasSubHandel());
                            moeglicheSubkulturen.Add(createHorasGebirge());
                            moeglicheSubkulturen.Add(createHorasSubFern());
                            moeglicheSubkulturen.Add(createHorasSubLandadel());
                            break;
                        ///////////////////////////////////////
                        // Zyklopeninseln:
                        ///////////////////////////////////////
                        case KulturName.Zyklopeninseln:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createZykSubKeine());
                            moeglicheSubkulturen.Add(createZykSubLandadel());
                            break;
                        ///////////////////////////////////////
                        // Amazonenburg:
                        ///////////////////////////////////////
                        case KulturName.Amazonenburg:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createAmazKeine());
                            break;
                        ///////////////////////////////////////
                        // Aranien:
                        ///////////////////////////////////////
                        case KulturName.Aranien:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createAranienSubKeineFrau());
                            moeglicheSubkulturen.Add(createAranienSubKeineMann());
                            moeglicheSubkulturen.Add(createAranienSubStadt());
                            moeglicheSubkulturen.Add(createAranienSubKueste());
                            moeglicheSubkulturen.Add(createAranienSubAdel());
                            break;
                        ///////////////////////////////////////
                        // Mhanadistan:
                        ///////////////////////////////////////
                        case KulturName.Mhanadistan:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createMhaSubKeineMann());
                            moeglicheSubkulturen.Add(createMhaSubKeineFrau());
                            moeglicheSubkulturen.Add(createMhaSubHandel());
                            moeglicheSubkulturen.Add(createMhaSubFern());
                            moeglicheSubkulturen.Add(createMhaSubKueste());
                            moeglicheSubkulturen.Add(createMhaSubNomade());
                            break;
                        ///////////////////////////////////////
                        // Tulamidische Stadtstaaten:
                        ///////////////////////////////////////
                        case KulturName.TulamidischeStadtstaaten:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createTulaSubKeineMann());
                            moeglicheSubkulturen.Add(createTulaSubKeineFrau());
                            moeglicheSubkulturen.Add(createTulaSubSee());
                            moeglicheSubkulturen.Add(createTulaSubKasiMaenner());
                            moeglicheSubkulturen.Add(createTulaSubKasiFrauen());
                            break;
                        ///////////////////////////////////////
                        // Novadi
                        ///////////////////////////////////////
                        case KulturName.Novadi:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createNovadiSubKeineMann());
                            moeglicheSubkulturen.Add(createNovadiSubOaseMann());
                            moeglicheSubkulturen.Add(createNovadiSubKeineFrau());
                            moeglicheSubkulturen.Add(createNovadiSubOaseFrau());
                            break;
                        ///////////////////////////////////////
                        // Ferkina
                        ///////////////////////////////////////
                        case KulturName.Ferkina:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createFerkinaSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Zahori
                        ///////////////////////////////////////
                        case KulturName.Zahori:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createZahoriSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Thorwal
                        ///////////////////////////////////////
                        case KulturName.Thorwal:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createThorWalSubKeine());
                            moeglicheSubkulturen.Add(createThorWalSubBinnenland());
                            break;
                        ///////////////////////////////////////
                        // Gjalskerland
                        ///////////////////////////////////////
                        case KulturName.Gjalskerland:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createGjalskerSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Fjarninger
                        ///////////////////////////////////////
                        case KulturName.Fjarninger:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createFjarnSubKeine());
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

        private subkultur createFjarnSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 11;
            subKeine.soMaximum = 4;

            subKeine.leModifikator = +2;
            subKeine.auModifikator = +6;
            subKeine.mrModifikator = -1;

            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +1},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +1},
            };

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Gesellschaftlich},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Hitzeempfindlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.NiedrigeLebenskraft},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            // TOCHECK: Frunu?
            // subKeine.geeigneteProfessionen.Add(ProfessionsName.???);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wurfspeere, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.ZweihandHiebwaffen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Klettern, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = -2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Skifahren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +4},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tierkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Fjarninger},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Alaani},
                new SprachenIdentifier(){ name = SprachenName.Nujuka},
                new SprachenIdentifier(){ name = SprachenName.OrkischOloghaijan},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            return subKeine;
        }

        private subkultur createGjalskerSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 9;
            subKeine.soMaximum = 6;

            subKeine.auModifikator = +5;

            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +1},
            };

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name= NachteileName.Meeresangst , wert = +5},
                new NachteilsIdentifier(){ name= NachteileName.Totenangst , wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Dunkelangst},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.NiedrigeLebenskraft},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schaukaempfer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Karawanenhueter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Barde);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.BrenochDun);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.DurroDun);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Speere, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.ZweihandHiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Klettern, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Fallenstellen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FischenUndAngeln, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Fleischer, TalentName.GerberUndKuerschner, TalentName.Grobschmied,
                TalentName.StoffeFaerben, TalentName.Viehzucht,
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 2;
            wahlHandwerk.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlHandwerk);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.OrkischOloghaijan, modifikator = +6},
                new SprachenIdentifier(){ name = SprachenName.Alaani, modifikator = +4},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Gjalskerland},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Sumpf},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
            };

            return subKeine;
        }

        private subkultur createThorWalSubBinnenland()
        {
            var subBinnen = createNovadiSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subBinnen.name = SubKulturName.Binnenland;
            subBinnen.generierungskosten = 5;

            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.ZweihandHiebwaffen, wert = +1});
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Klettern, wert = +1 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = -1 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Faehrtensuchen, wert = +1 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = -2 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = -1 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +2 });

            // Boote fahren niedriger, Seefahrt raus:
            subBinnen.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +2 });
            subBinnen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = -1 });

            // Wahl:
            subBinnen.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Ackerbau, TalentName.Grobschmied, TalentName.Holzbearbeitung, TalentName.Lederarbeiten,
                TalentName.Schneidern, TalentName.StoffeFaerben, TalentName.Viehzucht, TalentName.Webkunst
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.anzahlZuWaehlen = 2;
            subBinnen.wahlen.Add(wahlHandwerk);

            var wahlBilliger = new wahlmoeglichkeiten();
            wahlBilliger.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
            };

            subBinnen.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };

            return subBinnen;
        }
        private subkultur createThorWalSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 4;
            subKeine.soMaximum = 10;

            subKeine.auModifikator = +2;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = 5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Krieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soldat);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Entdecker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fernhaendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schiffer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Seefahrer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Ausrufer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Barde);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gaukler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schelm);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesSwafnir);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesEfferd);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesFirun);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDerIfirn);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDerTravia);

            // Entfernt werden müssen:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Domestik);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Rattenfaenger);

            // Talente:

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +2}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wurfbeile, wert = +2}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +3}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = +3}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FesselnUndEntfesseln, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FischenUndAngeln, wert = +3}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +3}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +4}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sternkunde, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BooteFahren, wert = +2}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1}, 
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Seefahrt, wert = +2}, 
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Garethi, zweitsprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Thorwal},
            };
            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Meer},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };

            return subKeine;
        }

        private subkultur createZahoriSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 2;
            subKeine.soMaximum = 8;

            subKeine.mrModifikator = -1;

            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +1},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht, wert = 5},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.Koerperlich},
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GlueckImSpiel},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalentgruppe, auspraegung = TalentKategorie.SprachenUndSchriften},
                new VorteilsIdentifier(){ name = VorteileName.VomSchicksalBeguenstigt},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
                new VorteilsIdentifier(){ name = VorteileName.Prophezeien},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Gesucht},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                // TOCHECK: Titularadel???
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gladiator);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fernhaendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fuhrmann);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Karawanenhueter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schmuggler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Ausrufer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Barde);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bettler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Dieb);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Einbrecher);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gaukler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hofkuenstler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.KurtisaneGesellschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Streuner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bader);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wirt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesAves);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesPhex);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihteDerRahja);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDerTsa);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wurfmesser, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Singen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Betoeren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerkleiden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Geographie, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schaetzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sternkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FahrzeugLenken, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleuder, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<TalentName>()
            {
                TalentName.Akrobatik, TalentName.Gaukeleien, TalentName.Taschendiebstahl,
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = 2;
            wahlKampf.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlKampf);

            //SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Zahori},
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name = SprachenName.Atak, modifikator = +4},
            };

            return subKeine;
        }

        private subkultur createFerkinaSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 11;
            subKeine.soMaximum = 5;

            subKeine.leModifikator = +1;
            subKeine.auModifikator = +5;
            subKeine.mrModifikator = -2;

            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +2},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = -1},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +1},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht, wert = 5},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Speisegebote},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.NiedrigeLebenskraft},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gladiator);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Botenreiter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Barde);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Dieb);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Streuner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.FerkinaBesessener);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            // TOCHECK: Schamane?
            // subKeine.geeigneteProfessionen.Add(ProfessionsName.schamane);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Klettern, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Reiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Fallenstellen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Gesteinskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Pflanzenkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sternkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tierkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Viehzucht, wert = +2},

            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<TalentName>()
            {
                TalentName.Bogen, TalentName.Schleuder, TalentName.Wurfspeere, TalentName.Wurfbeile,
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = 1;
            wahlKampf.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlKampf);

            var wahlAbrichten = new wahlmoeglichkeiten();
            wahlAbrichten.talente = new List<TalentName>()
            {
                TalentName.Abrichten, TalentName.Fleischer, TalentName.GerberUndKuerschner, TalentName.HeilkundeGift
            };
            wahlAbrichten.talentWerte = new int[1];
            wahlAbrichten.talentWerte[0] = 2;
            wahlAbrichten.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlAbrichten);

            //SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Ferkina},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Ferkina, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, zweitsprache = true},
            };

            return subKeine;
        }

        private subkultur createNovadiSubOaseFrau()
        {
            var subOase = createNovadiSubKeineFrau();
            // Wir ändern nur, was sich unterscheidet:
            subOase.name = SubKulturName.Wuestenoase;
            subOase.generierungskosten = 0;

            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = -1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Koerperbeherrschung, wert = -1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = -1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = -2 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ackerbau, wert = +1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Hauswirtschaft, wert = +1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Lederarbeiten, wert = -1 });

            return subOase;
        }
        private subkultur createNovadiSubKeineFrau()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 1;
            subKeine.soMaximum = -1;

            subKeine.voraussetzungen = new subkulturVoraussetzungen() { };
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.weiblich;

            subKeine.auModifikator = +1;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Speisegebote, wert = +5},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var nachteilsWahl = new wahlmoeglichkeiten();
            nachteilsWahl.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht, wert = +5},
            };
            nachteilsWahl.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(nachteilsWahl);

            // Empfohlen:
            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Entdecker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fernhaendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Barde);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gaukler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Streuner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Domestik);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tageloehner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Reiten, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +3},

                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Betoeren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lehren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +1},

                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BrettUndKartenspiel, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechtskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schaetzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sternkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BooteFahren, wert = -1},

                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeGift, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeKrankheiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeSeele, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Kochen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schneidern, wert = +1},
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, muttersprache = true},
            };

            // SO:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Novadi},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Wueste},
            };

            return subKeine;
        }
        private subkultur createNovadiSubOaseMann()
        {
            var subOase = createNovadiSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subOase.name = SubKulturName.Wuestenoase;
            subOase.generierungskosten = 1;

            //Waffentalente raus:
            subOase.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Bogen, wert = +1 });
            subOase.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Lanzenreiten, wert = +1 });
            subOase.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wurfspeere, wert = +1 });

            // Und dies kommt dazu:
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Klettern, wert = +2 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = -2 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = -2 });
            subOase.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ackerbau, wert = +1 });

            return subOase;
        }
        private subkultur createNovadiSubKeineMann()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 3;
            subKeine.soMaximum = -1;

            subKeine.voraussetzungen = new subkulturVoraussetzungen() { };
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.maennlich;

            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +1},
            };

            subKeine.auModifikator = +2;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Speisegebote, wert = +5},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var nachteilsWahl = new wahlmoeglichkeiten();
            nachteilsWahl.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht, wert = +5},
            };
            nachteilsWahl.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(nachteilsWahl);

            // Empfohlen:
            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.SchwerZuVerzaubern},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hadjinim);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Krieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Entdecker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fernhaendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Karawanenhueter);            
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Barde);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Domestik);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gelehrter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tageloehner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Derwisch);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Bogen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lanzenreiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Saebel, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Speere, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wurfspeere, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Reiten, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sinnesschaerfe, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BrettUndKartenspiel, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechtskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schaetzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Sternkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BooteFahren, wert = -1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Viehzucht, wert = +2},
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, muttersprache = true},
            };

            // SO:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Novadi},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Wueste},
            };
            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };

            return subKeine;
        }

        private subkultur createTulaSubKasiFrauen()
        {
            var subKasi = createTulaSubKeineFrau();
            // Wir ändern nur, was sich unterscheidet:
            subKasi.name = SubKulturName.Kasimiten;
            subKasi.generierungskosten = 4;

            subKasi.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, wert = +5},
            };

            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ringen, wert = +2 });
            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +2 });
            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +2 });
            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SagenUndLegenden, wert = +2 });

            // Sprache:
            subKasi.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, muttersprache = true},
            };

            // Verb. so:
            subKasi.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                // TODO: Sollte Kampfstil mit Ausprägung sein!
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKasi.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Taenzer);

            // Die folgenden Professionen sind nicht erlaubt:
            subKasi.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKasi.ungeeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKasi.ungeeigneteProfessionen.Add(ProfessionsName.Kundschafter);

            return subKasi;
        }
        private subkultur createTulaSubKasiMaenner()
        {
            var subKasi = createTulaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subKasi.name = SubKulturName.Kasimiten;
            subKasi.generierungskosten = 4;

            subKasi.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, wert = +5},
            };

            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ringen, wert = +2 });
            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +2 });
            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +2 });
            subKasi.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SagenUndLegenden, wert = +2 });

            // Sprache:
            subKasi.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, muttersprache = true},
            };

            // Verb. so:
            subKasi.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                // TODO: Sollte Kampfstil mit Ausprägung sein!
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKasi.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKasi.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKasi.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKasi.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());

            subKasi.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Gardist);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.StammeskriegerDerBeniDervez);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Alchimist);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.MagiebegabterAlchimist);
            subKasi.geeigneteProfessionen.Add(ProfessionsName.Derwisch);
            subKasi.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht erlaubt:
            subKasi.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKasi.ungeeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKasi.ungeeigneteProfessionen.Add(ProfessionsName.Kundschafter);

            return subKasi;
        }
        private subkultur createTulaSubSee()
        {
            var subSee = createTulaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subSee.name = SubKulturName.SeeOderMhanadihafen;
            subSee.generierungskosten = 6;

            subSee.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +2 });
            subSee.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subSee.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subSee.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wettervorhersage, wert = +1 });
            subSee.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });

            // Zusatzwahl:
            var wahlBoot = new wahlmoeglichkeiten();
            wahlBoot.talente = new List<TalentName>()
            {
                TalentName.Seefahrt, TalentName.BooteFahren,
            };
            wahlBoot.talentWerte = new int[1];
            wahlBoot.talentWerte[0] = 1;
            wahlBoot.anzahlZuWaehlen = 1;
            subSee.wahlen.Add(wahlBoot);

            return subSee;
        }
        private subkultur createTulaSubKeineFrau()
        {
            var subKeine = createTulaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.weiblich;

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Amazone);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schwertgeselle);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Krieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Alchimist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.MagiebegabterAlchimist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Kundschafter);

            return subKeine;
        }
        private subkultur createTulaSubKeineMann()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 3;
            subKeine.soMaximum = -1;

            subKeine.voraussetzungen = new subkulturVoraussetzungen(){};
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.maennlich;

            subKeine.mrModifikator = +1;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.BesondererBesitz},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GlueckImSpiel},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Speisegebote},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Menschenmassen},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetKriegerische());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Alchimist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.MagiebegabterAlchimist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Kundschafter);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Saebel, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Gassenwissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerkleiden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BrettUndKartenspiel, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Geschichtswissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechtskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schaetzen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hauswirtschaft, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlDieb = new wahlmoeglichkeiten();
            wahlDieb.talente = new List<TalentName>()
            {
                TalentName.Taschendiebstahl, TalentName.Gaukeleien,
            };
            wahlDieb.talentWerte = new int[1];
            wahlDieb.talentWerte[0] = 1;
            wahlDieb.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlDieb);

            // Sprachen:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Garethi, zweitsprache = true},
            };

            //SO:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Tulamidenlande},
            };
            return subKeine;
        }

        private subkultur createMhaSubNomade()
        {
            var subNomade = createMhaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subNomade.name = SubKulturName.KuestengebieteOderAnGrossenFluessen;
            subNomade.generierungskosten = 2;

            subNomade.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subNomade.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subNomade.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +2 });
            subNomade.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = +1 });
            subNomade.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +1 });
            subNomade.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechnen, wert = +1 });

            // Überreden, Etikette, Ackerbau raus:
            subNomade.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subNomade.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +2 });
            subNomade.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ackerbau, wert = +1 });

            // Wahl der Zweitsrpache:
            // Muttersprache:
            subNomade.sprachen = new List<SprachenIdentifier>() { };
            subNomade.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, muttersprache = true });

            var wahlZweit = new wahlmoeglichkeiten();
            wahlZweit.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name = SprachenName.Ferkina, zweitsprache = true},
            };
            wahlZweit.talentWerte = new int[1];
            wahlZweit.talentWerte[0] = 1;
            wahlZweit.anzahlZuWaehlen = 1;
            subNomade.wahlen.Add(wahlZweit);


            // Wahl Bogen:
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<TalentName>()
            {
                TalentName.Bogen, TalentName.Schleuder,
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 1;
            wahlBogen.anzahlZuWaehlen = 1;
            subNomade.wahlen.Add(wahlBogen);

            return subNomade;
        }
        private subkultur createMhaSubKueste()
        {
            var subKueste = createMhaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subKueste.name = SubKulturName.KuestengebieteOderAnGrossenFluessen;
            subKueste.generierungskosten = 3;

            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wettervorhersage, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });

            // Wahl:
            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<TalentName>()
            {
                TalentName.Seefahrt, TalentName.BooteFahren,
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = 1;
            wahlBoote.anzahlZuWaehlen = 1;
            subKueste.wahlen.Add(wahlBoote);

            return subKueste;
        }
        private subkultur createMhaSubFern()
        {
            var subFern = createMhaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subFern.name = SubKulturName.FernDerZivilisation;
            subFern.generierungskosten = 1;

            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = -1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Kochen, wert = +1 });

            // Zweitsprache löschen:
            subFern.sprachen = new List<SprachenIdentifier>() { };
            subFern.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, muttersprache = true });

            // Wahl Bogen:
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<TalentName>()
            {
                TalentName.Bogen, TalentName.Schleuder, TalentName.Zweihandflegel,
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 1;
            wahlBogen.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlBogen);

            // Wahl Athletik:
            var wahlAth = new wahlmoeglichkeiten();
            wahlAth.talente = new List<TalentName>()
            {
                TalentName.Athletik, TalentName.Klettern,
            };
            wahlAth.talentWerte = new int[1];
            wahlAth.talentWerte[0] = 1;
            wahlAth.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlAth);

            return subFern;

        }
        private subkultur createMhaSubHandel()
        {
            var subHandel = createMhaSubKeineMann();
            // Wir ändern nur, was sich unterscheidet:
            subHandel.name = SubKulturName.AnEinerWichtigenHandelsroute;
            subHandel.generierungskosten = 1;

            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechnen, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schaetzen, wert = +1 });

            return subHandel;
        }
        private subkultur createMhaSubKeineFrau()
        {
            var subKeine = createMhaSubKeineMann();
            // Nur Änderungen festhalten!
            subKeine.voraussetzungen = new subkulturVoraussetzungen() { };
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.weiblich;

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };

            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Amazone);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Krieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Faehnrich);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Herold);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Schriftsteller);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gelehrter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Edelhandwerker);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.GeweihterDesFirun);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Seefahrer);

            return subKeine;
        }
        private subkultur createMhaSubKeineMann()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 0;
            subKeine.soMaximum = -1;

            subKeine.voraussetzungen = new subkulturVoraussetzungen() { };
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.maennlich;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetKriegerische());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Faehnrich);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Herold);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Schriftsteller);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gelehrter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Edelhandwerker);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.GeweihterDesFirun);

            // Talente:
            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BrettUndKartenspiel, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ackerbau, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Viehzucht, wert = +2},
            };

            // Sonder:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Mhanadistan},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlHIeb = new wahlmoeglichkeiten();
            wahlHIeb.talente = new List<TalentName>()
            {
                TalentName.Hiebwaffen, TalentName.Saebel, TalentName.Speere,
            };
            wahlHIeb.talentWerte = new int[1];
            wahlHIeb.talentWerte[0] = 1;
            wahlHIeb.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlHIeb);

            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Abrichten , TalentName.Fleischer, TalentName.GerberUndKuerschner, TalentName.Grobschmied,
                TalentName.Hauswirtschaft, TalentName.StoffeFaerben, TalentName.Toepfern, TalentName.Webkunst,
                TalentName.Winzer,
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlHandwerk);

            // Sprache:
            // Muttersprache:
            subKeine.sprachen = new List<SprachenIdentifier>() { };
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, muttersprache = true });
            // Zweitsprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, zweitsprache = true });

            return subKeine;
        }

        private subkultur createAranienSubAdel()
        {
            var subAdel = createAranienSubKeineFrau();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.StaedtischerAdel;
            subAdel.generierungskosten = 4;
            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };


            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Saebel, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Zu den Wahlen kommt eine dazu:
            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<TalentName>()
            {
                TalentName.Reiten, TalentName.FahrzeugLenken
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = 1;
            wahlReiten.anzahlZuWaehlen = 1;
            subAdel.wahlen.Add(wahlReiten);

            // Die Wahl der Schrift wird ergänzt:
            // TOCHECK: ERGÄNZUNG muss möglich sein, wenn man die Schrift schon hat (*ächz*)
            // Bei Sprachen nur möglich, wenn NICHT Mutter- oder Zweitsprache!
            var wahlSchrift = new wahlmoeglichkeiten();
            wahlSchrift.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen},
                new SchriftenIdentifier(){ name = SchriftName.Tulamidya},
            };
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 2;
            wahlSchrift.identifier = "SchriftwahlZusatz";
            subAdel.wahlen.Add(wahlSchrift);

            return subAdel;
        }
        private subkultur createAranienSubKueste()
        {
            var subKueste = createAranienSubKeineFrau();
            // Wir ändern nur, was sich unterscheidet:
            subKueste.name = SubKulturName.KuestengebieteOderAmBarunUlah;
            subKueste.generierungskosten = 4;

            subKueste.voraussetzungen = new subkulturVoraussetzungen() { };
            subKueste.voraussetzungen.geschlecht = GeschlechtNamen.beide;

            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });

            return subKueste;
        }
        private subkultur createAranienSubStadt()
        {
            var subStadt = createAranienSubKeineFrau();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.name = SubKulturName.Stadt;
            subStadt.generierungskosten = 4;

            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Anchopal, StadtName.Baburin, StadtName.Zorgan, StadtName.Elburum, StadtName.Llanka,
            };

            subStadt.voraussetzungen = new subkulturVoraussetzungen() { };
            subStadt.voraussetzungen.geschlecht = GeschlechtNamen.beide;

            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Gassenwissen, wert = +1 });
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });

            // TOCHECK:
            subStadt.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ortskenntnis});

            return subStadt;
        }
        private subkultur createAranienSubKeineMann()
        {
            var subKeine = createAranienSubKeineFrau();
            // Wir passen nur das an, was sich ändert:

            subKeine.voraussetzungen = new subkulturVoraussetzungen() { };
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.maennlich;

            // Die Männer haben manche Professionen nicht:
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Faehnrich);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Entdecker);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Fernhaendler);

            // Die Männer haben nur einen Bonus von +1 auf Etikette und Menschnenk.:
            subKeine.talentModifikatoren.Remove( new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +2});
            subKeine.talentModifikatoren.Remove( new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +2});
            subKeine.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subKeine.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });

            return subKeine;
        }
        private subkultur createAranienSubKeineFrau()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 2;
            subKeine.soMaximum = -1;

            subKeine.voraussetzungen = new subkulturVoraussetzungen(){};
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.weiblich;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
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
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);

            // Talente:
            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Saebel, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Reiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Gassenwissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BrettUndKartenspiel, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schaetzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hauswirtschaft, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlMagie = new wahlmoeglichkeiten();
            wahlMagie.talente = new List<TalentName>()
            {
                TalentName.Magiekunde, TalentName.Philosophie
            };
            wahlMagie.talentWerte = new int[1];
            wahlMagie.talentWerte[0] = 1;
            wahlMagie.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlMagie);

            var wahlAbrichten = new wahlmoeglichkeiten();
            wahlAbrichten.talente = new List<TalentName>()
            {
                TalentName.Abrichten, TalentName.Musizieren, TalentName.Webkunst
            };
            wahlAbrichten.talentWerte = new int[1];
            wahlAbrichten.talentWerte[0] = 1;
            wahlAbrichten.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlAbrichten);

            // Muttersprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, muttersprache = true},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 1;
            wahlSprache.identifier = "SpracheMutter";
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            // Wahl der zusätzlichen Sprache:
            var wahlNebenSprache = new wahlmoeglichkeiten();
            wahlNebenSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, zweitsprache = true},
            };
            wahlNebenSprache.talentWerte = new int[1];
            wahlNebenSprache.talentWerte[0] = 1;
            wahlNebenSprache.identifier = "SprachenWahl";
            wahlNebenSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlNebenSprache);

            // Wahl der Schrift:
            var wahlSchrift = new wahlmoeglichkeiten();
            wahlSchrift.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen},
                new SchriftenIdentifier(){ name = SchriftName.Tulamidya},
            };
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 3;
            wahlSchrift.identifier = "Schriftwahl";
            subKeine.wahlen.Add(wahlSchrift);

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Aranien},
            };

            return subKeine;
        }

        private subkultur createAmazKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 7;
            subKeine.soMaximum = -1;

            subKeine.voraussetzungen = new subkulturVoraussetzungen() { };
            subKeine.voraussetzungen.geschlecht = GeschlechtNamen.weiblich;

            subKeine.leModifikator = +1;
            subKeine.auModifikator = +3;
            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +1},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                // TOCHECK! Gegen Männer!
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.NiedrigeLebenskraft},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Amazone);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDerRondra);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Staebe, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Reiten, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Gassenwissen, wert = -2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Geschichtswissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Heraldik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Kriegskunst, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Abrichten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<TalentName>()
            {
                TalentName.Bogen, TalentName.Wurfspeere
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 4;
            wahlBogen.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBogen);

            var wahlSäbel = new wahlmoeglichkeiten();
            wahlSäbel.talente = new List<TalentName>()
            {
                TalentName.Saebel, TalentName.Schwerter,
            };
            wahlSäbel.talentWerte = new int[1];
            wahlSäbel.talentWerte[0] = 2;
            wahlSäbel.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSäbel);

            // Muttersprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Amazonenburg},
            };

            return subKeine;
        }

        private subkultur createZykSubLandadel()
        {
            var subAdel = createZykSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.Landadel;
            subAdel.generierungskosten = 6;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            // Schleuder raus, Bogen rein:
            subAdel.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleuder, wert = +1});
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Bogen, wert = +1 });

            // Mods:
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Hiebwaffen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Außerdem gibt's die Kusliker Zeichen dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createZykSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 4;
            subKeine.soMaximum = -1;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalent, auspraegung = TalentName.Schwimmen},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
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

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);

            // Talente:
            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleuder, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Klettern, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FischenUndAngeln, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Philosophie, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BooteFahren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Seefahrt, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Viehzucht, wert = +1},
            };

            // SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Zyklopeninseln},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Meereskundig},
            };

            // Muttersprache:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Zyklopaeisch, muttersprache = true},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 1;
            wahlSprache.identifier = "SpracheMutter";
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            // Wahl der zusätzlichen Sprache:
            var wahlNebenSprache = new wahlmoeglichkeiten();
            wahlNebenSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Zyklopaeisch, zweitsprache = true},
            };
            wahlNebenSprache.talentWerte = new int[1];
            wahlNebenSprache.talentWerte[0] = 1;
            wahlNebenSprache.identifier = "SprachenWahl";
            wahlNebenSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlNebenSprache);

            return subKeine;
        }

        private subkultur createHorasSubLandadel()
        {
            var subAdel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.Landadel;
            subAdel.generierungskosten = 5;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            // Infi raus, Schwerter rein:
            subAdel.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwerter, wert = +1 });

            //Mods:
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Außerdem gibt's die Kusliker Zeichen dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createHorasSubFern()
        {
            var subFern = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subFern.name = SubKulturName.FernDerZivilisation;
            subFern.generierungskosten = 4;

            // Orte:
            // TO CHECK: Chababien???

            // Armbrust raus, Wahl rein!
            subFern.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Armbrust, wert = +1 });
            var wahlArmbrust = new wahlmoeglichkeiten();
            wahlArmbrust.talente = new List<TalentName>()
            {
                TalentName.Bogen, TalentName.Armbrust
            };
            wahlArmbrust.talentWerte = new int[1];
            wahlArmbrust.talentWerte[0] = 1;
            wahlArmbrust.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlArmbrust);

            // Infi raus, Speere rein:
            subFern.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Speere, wert = +1 });

            // Fechtwaffen raus, Gassenwissen raus, Rechtskunde raus:
            subFern.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fechtwaffen, wert = +1 });
            subFern.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Gassenwissen, wert = +2 });
            subFern.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Mods:
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Raufen, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ringen, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = -1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Faehrtensuchen, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +2 });


            // Wahl der zusätzlichen Sprache erneuern:
            subFern.wahlen[0].loescheEintrag(subFern.wahlen, "Sprachenwahl");
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Tulamidya},
                new SprachenIdentifier(){ name= SprachenName.Mohisch},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 5;
            wahlSprache.identifier = "SprachenWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlSprache);

            // Viehzucht zur Wahl dazu:
            subFern.wahlen[0].loescheEintrag(subFern.wahlen, "WahlHandwerk");
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Ackerbau, TalentName.Hauswirtschaft, TalentName.Viehzucht
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.identifier = "WahlHandwerk";
            subFern.wahlen.Add(wahlHandwerk);

            return subFern;
        }
        private subkultur createHorasGebirge()
        {
            var subGebirge = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subGebirge.name = SubKulturName.Gebirge;
            subGebirge.generierungskosten = 4;

            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +1 });

            return subGebirge;
        }
        private subkultur createHorasSubHandel()
        {
            var subHandel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHandel.name = SubKulturName.AnEinerWichtigenHandelsroute;
            subHandel.generierungskosten = 5;

            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SagenUndLegenden, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FahrzeugLenken, wert = +1 });

            // Eine beliebige (!) Handelssprache. TOCHECK: Kann das wirklich JEDE Sprache sein??? Was sind "Handelssprachen"???
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 2;
            wahlSprache.identifier = "SprachenWahlHandel";
            wahlSprache.anzahlZuWaehlen = 1;
            subHandel.wahlen.Add(wahlSprache);

            return subHandel;
        }
        private subkultur createHorasSubKueste()
        {
            var subKueste = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subKueste.name = SubKulturName.DoerferAnKuesteOderAnGrossenFluessen;
            subKueste.generierungskosten = 6;

            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +1 });

            return subKueste;
        }

        private subkultur createHorasSubAdel()
        {
            var subAdel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.StaedtischerAdel;
            subAdel.generierungskosten = 4;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            // Infi raus, Wahl rein:
            subAdel.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<TalentName>() 
            { 
                TalentName.Schwerter, TalentName.Fechtwaffen,
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });

            // Außerdem gibt's die Kusliker Zeichen dazu - sie werden verbessert, weshalb wir überschrieben 
            // und "4" als Wert setzen:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 4 }, };

            return subAdel;
        }
        private subkultur createHorasSubTempel()
        {
            var subTempel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subTempel.name = SubKulturName.StaedteMitWichtigemTempelOderPilgerstaette;
            subTempel.generierungskosten = 5;

            subTempel.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Kuslik, StadtName.Bethana, StadtName.Neetha, StadtName.Arivor
            };

            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +2 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +2 });

            // Eine beliebige (!) Handelssprache. TOCHECK: Kann das wirklich JEDE Sprache sein??? Was sind "Handelssprachen"???
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.identifier = "SprachenWahlTempel";
            wahlSprache.anzahlZuWaehlen = 1;
            subTempel.wahlen.Add(wahlSprache);

            return subTempel;
        }
        private subkultur createHorasSubHafen()
        {
            var subHafen = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHafen.name = SubKulturName.HafenstaedteUndStaedteAnGroessenFluessen;
            subHafen.generierungskosten = 6;

            // Städte:
            subHafen.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Kuslik, StadtName.Grangor, StadtName.Vinsalt
            };

            // Talente:
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +1});
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +1});
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1});
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FesselnUndEntfesseln, wert = +1});
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.FischenUndAngeln, wert = +1});
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Geographie, wert = +1});
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.BooteFahren, wert = +1});
            subHafen.talentModifikatoren.Add( new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Seefahrt, wert = +1});
            return subHafen;
        }
        private subkultur createHorasSubKeine()
        {
            var subKeine = createAlmadaSubKeine();

            // Wir ändern nur das, was unterschiedlich ist:
            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Armbrust, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Fechtwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Infanteriewaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Betoeren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Gassenwissen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Geschichtswissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Mechanik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechtskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
            };

            // Außerdem gibt's die Kusliker Zeichen dazu:
            subKeine.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            // Wahlen:

            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            // Wahl der zusätzlichen Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Tulamidya},
                new SprachenIdentifier(){ name= SprachenName.Rogolan},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 5;
            wahlSprache.identifier = "SprachenWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Wahl von Handwerk:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Ackerbau, TalentName.Hauswirtschaft
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.identifier = "WahlHandwerk";
            subKeine.wahlen.Add(wahlHandwerk);

            // Muttersprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Horasreich},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.NandusgefaelligesWesen},
            };      

            return subKeine;
        }

        private subkultur createAlmadaSubLandadel()
        {
            var subAdel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.Landadel;
            subAdel.generierungskosten = 5;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };
            // Infi raus, Schwerter rein:
            subAdel.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwerter, wert = +1 });

            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Außerdem gibt's die Kusliker Zeichen dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createAlmadaSubGebrige()
        {
            var subGebirge = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subGebirge.name = SubKulturName.Gebirge;
            subGebirge.generierungskosten = 4;

            // Talente:
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +1 });

            return subGebirge;
        }
        private subkultur createAlmadaSubHandel()
        {
            var subHandel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHandel.name = SubKulturName.AnEinerWichtigenHandelsroute;
            subHandel.generierungskosten = 4;

            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SagenUndLegenden, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FahrzeugLenken, wert = +1 });

            // Eine beliebige (!) Handelssprache. TOCHECK: Kann das wirklich JEDE Sprache sein??? Was sind "Handelssprachen"???
            var wahlSprache = new wahlmoeglichkeiten();
            var SprachenSubsets = new SprachKategorien();
            wahlSprache.sprachen = new List<SprachenIdentifier>() {};
            wahlSprache.sprachen.AddRange(SprachenSubsets.GetHandel());
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subHandel.wahlen.Add(wahlSprache);

            return subHandel;
        }
        private subkultur createAlmadaSubAdel()
        {
            var subAdel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.StaedtischerAdel;
            subAdel.generierungskosten = 5;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            // Infi raus, Wahl rein:
            subAdel.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<TalentName>() 
            { 
                TalentName.Schwerter, TalentName.Fechtwaffen,
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            // Talente:
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +2 });

            // Außerdem gibt's die Kusliker Zeichen dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createAlmadaSubTempel()
        {
            var subTempel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subTempel.name = SubKulturName.StaedteMitWichtigemTempelOderPilgerstaette;
            subTempel.generierungskosten = 5;

            // Städte als auswahl:
            subTempel.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Punin, StadtName.BrigLo,
            };
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +2 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +2 });

            // Weitere Sprachwahl:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Tulamidya},
                new SprachenIdentifier(){ name= SprachenName.Rogolan},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.identifier = "SprachenWahlZusaetzlich";
            wahlSprache.anzahlZuWaehlen = 1;
            subTempel.wahlen.Add(wahlSprache);

            return subTempel;
        }
        private subkultur createAlmadaSubYaquir()
        {
            var subYaq = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subYaq.name = SubKulturName.StaedteAmYaquir;
            subYaq.generierungskosten = 5;

            // Städte als auswahl:
            subYaq.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Punin, StadtName.Ragath,
            };

            // Talente:
            subYaq.talentModifikatoren.Add( new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +1});
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });
            subYaq.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +1 });

            return subYaq;
        }
        private subkultur createAlmadaSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 3;
            subKeine.soMaximum = -1;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.BesondererBesitz},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Menschenmassen},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetKriegerische());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Entdecker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fernhaendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schiffer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schmuggler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);
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

            // Die folgenden Professionen sind nicht erlaubt:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Fechtwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Infanteriewaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Saebel, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Reiten, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Gassenwissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Geschichtswissen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Abrichten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Musizieren, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Viehzucht, wert = +1},
            };

            // Wahlen:

            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            // Wahl der zusätzlichen Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Tulamidya},
                new SprachenIdentifier(){ name= SprachenName.Rogolan},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 5;
            wahlSprache.identifier = "SprachenWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Wahl von Handwerk:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Ackerbau, TalentName.Hauswirtschaft, TalentName.Winzer
            };
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlHandwerk);

            // Muttersprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Almada},
            };

            return subKeine;
        }

        private subkultur createSvelltSubFluecht()
        {
            var subFluecht = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subFluecht.name = SubKulturName.FluechtlingeAusGlorania;
            subFluecht.generierungskosten = 6;

            subFluecht.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = -1},
            };
            subFluecht.leModifikator = 0;

            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = -1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Skifahren, wert = +2 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Faehrtensuchen, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Magiekunde, wert = +1 });
            // Pflanzenkunde raus, Magiekunde rein:
            subFluecht.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Pflanzenkunde, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Magiekunde, wert = +1 });

            subFluecht.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Eiskundig });

            // Verbilligte SF Sumpfkundig entfernen:
            subFluecht.verbilligteSonderfertigkeiten.Remove(new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Sumpfkundig});

            return subFluecht;
        }
        private subkultur createSvelltSubFern()
        {
            var subFern = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subFern.name = SubKulturName.FernDerZivilisation;
            subFern.generierungskosten = 9;

            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wettervorhersage, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FahrzeugLenken, wert = +1 });

            // Noch eine Sprachwahl:
            var wahlZusatzSprache = new wahlmoeglichkeiten();
            wahlZusatzSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi},
                new SprachenIdentifier(){ name= SprachenName.Alaani},
                new SprachenIdentifier(){ name = SprachenName.Nujuka},
                new SprachenIdentifier(){ name= SprachenName.OrkischOloarkh},
                new SprachenIdentifier(){ name= SprachenName.OrkischOloghaijan},
                new SprachenIdentifier(){ name= SprachenName.Isdira},
                new SprachenIdentifier(){ name= SprachenName.Goblinisch},
            };
            wahlZusatzSprache.talentWerte = new int[1];
            wahlZusatzSprache.talentWerte[0] = 2;
            wahlZusatzSprache.identifier = "SprachenWahlZusatzZwei";
            wahlZusatzSprache.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlZusatzSprache);

            return subFern;
        }
        private subkultur createSvelltSubKueste()
        {
            var subKueste = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subKueste.name = SubKulturName.KuestengebieteOderAnGrossenFluessen;
            subKueste.generierungskosten = 9;

            // Bogen raus, Wahl rein:
            subKueste.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Bogen, wert = +1 });
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.anzahlZuWaehlen = 1;
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 1;
            wahlBogen.talente = new List<TalentName>() 
            { 
                TalentName.Wurfbeile, TalentName.Bogen, TalentName.Wurfmesser,
            };
            subKueste.wahlen.Add(wahlBogen);

            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wettervorhersage, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Holzbearbeitung, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });

            return subKueste;

        }
        private subkultur createSvelltSubKleinstadt()
        {
            var subKlein = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subKlein.name = SubKulturName.Kleinstaedte;
            subKlein.generierungskosten = 6;

            // Bogen raus, Wahl rein:
            subKlein.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Bogen, wert = +1 });
            var Wahlarmbrust = new wahlmoeglichkeiten();
            Wahlarmbrust.anzahlZuWaehlen = 1;
            Wahlarmbrust.talentWerte = new int[1];
            Wahlarmbrust.talentWerte[0] = 1;
            Wahlarmbrust.talente = new List<TalentName>() 
            { 
                TalentName.Armbrust, TalentName.Bogen, TalentName.Wurfmesser,
            };
            subKlein.wahlen.Add(Wahlarmbrust);

            // Speere raus, Wahl rein:
            subKlein.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Speere, wert = +1 });
            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.anzahlZuWaehlen = 1;
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = 1;
            wahlInfi.talente = new List<TalentName>() 
            { 
                TalentName.Infanteriewaffen, TalentName.Speere,
            };
            subKlein.wahlen.Add(wahlInfi);

            // Mods:
            subKlein.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Koerperbeherrschung, wert = -1 });
            subKlein.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subKlein.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subKlein.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +1 });

            // Fallenstellen raus:
            subKlein.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });

            return subKlein;
        }
        private subkultur createSvelltSubStadt()
        {
            var subStadt = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.name = SubKulturName.Stadt;
            subStadt.generierungskosten = 7;

            // Speere raus, Infanterie rein:
            subStadt.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Speere, wert = +1});
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Infanteriewaffen, wert = +1});
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Koerperbeherrschung, wert = -1 });
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +1 });
            // Fallenstellen raus:
            subStadt.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });

            return subStadt;
        }
        private subkultur createSvelltSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 7;
            subKeine.soMaximum = 10;

            subKeine.leModifikator = 1;
            subKeine.auModifikator = 2;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            // Nun zu den Professionen:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schaukaempfer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gardist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soldat);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schelm);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Folgende Professionen lassen wir nicht zu:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Herold);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Hofkuenstler);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Hoefling);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Taugenichts);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gelehrter);


            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Bogen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Speere, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Koerperbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schwimmen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Fallenstellen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Pflanzenkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tierkunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schneidern, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Viehzucht, wert = +1},
            };

            // Jetzt die Auswahlmöglichkeiten:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl der Muttersprache:
            var wahlMutterSprache = new wahlmoeglichkeiten();
            wahlMutterSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Alaani, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Nujuka, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Thorwalsch, muttersprache = true},
            };
            wahlMutterSprache.identifier = "SprachenWahlMutter";
            wahlMutterSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlMutterSprache);

            // Wahl der zusätzlichen Sprache:
            var wahlZusatzSprache = new wahlmoeglichkeiten();
            wahlZusatzSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi},
                new SprachenIdentifier(){ name= SprachenName.Alaani},
                new SprachenIdentifier(){ name = SprachenName.Nujuka},
                new SprachenIdentifier(){ name= SprachenName.OrkischOloarkh},
                new SprachenIdentifier(){ name= SprachenName.OrkischOloghaijan},
                new SprachenIdentifier(){ name= SprachenName.Isdira},
            };
            wahlZusatzSprache.talentWerte = new int[1];
            wahlZusatzSprache.talentWerte[0] = 4;
            wahlZusatzSprache.identifier = "SprachenWahlZusatz";
            wahlZusatzSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlZusatzSprache);

            // Wahl Boote / Fahrzeug:
            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.anzahlZuWaehlen = 1;
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = 1;
            wahlBoote.talente = new List<TalentName>() 
            { 
                TalentName.BooteFahren, TalentName.Seefahrt,
            };
            subKeine.wahlen.Add(wahlBoote);

            // Wahl Handwerk:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.talente = new List<TalentName>() 
            { 
                TalentName.Abrichten, TalentName.Ackerbau, TalentName.Brauer, TalentName.FischenUndAngeln, 
                TalentName.Fleischer, TalentName.GerberUndKuerschner, TalentName.Grobschmied, TalentName.Kochen,
                TalentName.Seiler, TalentName.StoffeFaerben, TalentName.Toepfern, TalentName.Viehzucht,
                TalentName.Webkunst, TalentName.Zimmermann,
            };
            subKeine.wahlen.Add(wahlHandwerk);

            // Wahl SF:
            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.anzahlZuWaehlen = 1;
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>() 
            { 
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Svellttal},
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Nordlande},
            };
            subKeine.wahlen.Add(wahlSF);            

            // Verbilligte SF:
            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.MeisterDerImprovisation},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Steppenkundig},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Sumpfkundig},
            };

            return subKeine;
        }

        private subkultur createBornlandSubLandadel()
        {
            var subAdel = createBornlandSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subAdel.name = SubKulturName.Landadel;
            subAdel.generierungskosten = 5;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Bogen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Zechen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Hauswirtschaft, wert = +1 });

            // Weitere Wahl:
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<TalentName>() 
            { 
                TalentName.Schwerter, TalentName.Hiebwaffen,
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            return subAdel;

        }
        private subkultur createBornlandSubKueste()
        {
            var subKueste = createBornlandSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subKueste.name = SubKulturName.Kuestengebiete;
            subKueste.generierungskosten = 3;

            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +1 });

            return subKueste;
        }
        private subkultur createBornlandSubLand()
        {
            var subLand = createBornlandSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subLand.name = SubKulturName.Landstaedte;
            subLand.generierungskosten = 3;

            subLand.moeglicheStaedte = new List<StadtName>() 
            {
                StadtName.Firunen, StadtName.Norburg, StadtName.Notmark, StadtName.Ouvenmas, StadtName.Rodebrannt,
            };

            subLand.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Bogen, wert = +1 });
            subLand.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });
            subLand.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subLand.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });

            // Zusätzliche Wahl:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 2;
            wahlHandwerk.talente = new List<TalentName>() 
            { 
                TalentName.Abrichten, TalentName.Brauer, TalentName.Fleischer, TalentName.GerberUndKuerschner,
                TalentName.Grobschmied, TalentName.Kochen, TalentName.Seiler, TalentName.StoffeFaerben,
                TalentName.Toepfern, TalentName.Viehzucht, TalentName.Webkunst, TalentName.Winzer, TalentName.Zimmermann,
            };
            wahlHandwerk.identifier = "Handwerk";
            subLand.wahlen.Add(wahlHandwerk);

            return subLand;

        }
        private subkultur createBornlandSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 0;
            subKeine.soMaximum = -1;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
            };

            // Nun zu den Professionen:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Faehnrich);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gardist);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Ritter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Krieger);
            // TOCHECK! subKeine.geeigneteProfessionen.Add(ProfessionsName.ordenskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soldat);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetReisende());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetGesellschaft());
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetHandwerk());
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schelm);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wurfmesser, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Tanzen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Etikette, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},

                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ackerbau, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Kochen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schneidern, wert = +1},
            };

            // Muttersprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // Jetzt die Auswahlmöglichkeiten:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){name = SprachenName.Alaani}, 
                new SprachenIdentifier(){name= SprachenName.Nujuka},
            };
            wahlSprache.identifier = "SprachenWahl";
            wahlSprache.anzahlZuWaehlen = 2;
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = 6;
            wahlSprache.talentWerte[1] = 2;
            subKeine.wahlen.Add(wahlSprache);

            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.identifier = "SFWahl";
            wahlSF.anzahlZuWaehlen = 1;
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>() 
            {                
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Sumpfkundig},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Waldkundig},
            };
            subKeine.wahlen.Add(wahlSF);

            // SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){name = SFNamen.Kulturkunde, auspraegung = KulturName.Bornland},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Eiskundig},
            };

            return subKeine;
        }

        private subkultur createAndergastSubTeshkalien()
        {
            var subTesh = createAndergastSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subTesh.name = SubKulturName.Teshkalien;
            subTesh.generierungskosten = 10;

            // Mods:
            subTesh.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +2 });
            subTesh.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Faehrtensuchen, wert = +2 });
            subTesh.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });
            subTesh.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = +1 });
            subTesh.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Abrichten, wert = +2 });
            subTesh.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FahrzeugLenken, wert = +2 });

            // Außerdem gibt's die SF Steppenkundig dazu:
            subTesh.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Steppenkundig });

            return subTesh;
        }
        private subkultur createAndergastSubKueste()
        {
            var subKueste = createAndergastSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subKueste.name = SubKulturName.Kuestengebiete;
            subKueste.generierungskosten = 8;

            // Mods:
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +2 });

            // Neue Wahl: seefahrt / boote fahren:
            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.anzahlZuWaehlen = 1;
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = 2;
            wahlBoote.talente = new List<TalentName>() 
            { 
                TalentName.BooteFahren, TalentName.Seefahrt,
            };
            subKueste.wahlen.Add(wahlBoote);

            // Die SFs werden zurück gesetzt:
            subKueste.sonderfertigkeiten = new List<sfIdentifier>() 
            { 
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.AndergastUndNostria} 
            };
            // Dafür darf man zwischen Meereskundig und Waldkundig wählen ("nach Bedarf" - geht's noch schwammiger???):
            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.anzahlZuWaehlen = 1;
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>() 
            {
                new sfIdentifier(){name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Waldkundig},
                new sfIdentifier(){name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Meereskundig},
            };
            subKueste.wahlen.Add(wahlSF);

            return subKueste;
        }
        private subkultur createAndergastSubGebirge()
        {
            var subGebirge = createAndergastSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subGebirge.name = SubKulturName.Gebirge;
            subGebirge.generierungskosten = 7;

            // Mods:
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Faehrtensuchen, wert = +1 });

            // Die SFs werden zurück gesetzt:
            subGebirge.sonderfertigkeiten = new List<sfIdentifier>() 
            { 
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.AndergastUndNostria} 
            };
            // Dafür darf man zwischen Gebirgskundig und Waldkundig wählen ("nach Bedarf" - geht's noch schwammiger???):
            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.anzahlZuWaehlen = 1;
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>() 
            {
                new sfIdentifier(){name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Waldkundig},
                new sfIdentifier(){name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Gebirgskundig},
            };
            subGebirge.wahlen.Add(wahlSF);

            return subGebirge;
        }
        private subkultur createAndergastSubLandadel()
        {
            var subAdel = createAndergastSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subAdel.name = SubKulturName.Landadel;
            subAdel.generierungskosten = 9;

            // Es gibt Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            //  Die Speere fliegen raus. Dafür gibt's Schwerter oder Hiebwaffen als Wahl!
            subAdel.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Speere, wert = +1 });
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<TalentName>() 
            { 
                TalentName.Schwerter, TalentName.Hiebwaffen,
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            // Zu noch folgende Mods:
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +2 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Und die Kusliker Zeichen dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createAndergastSubStadt()
        {
            var subStadt = createAndergastSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subStadt.name = SubKulturName.Stadt;
            subStadt.generierungskosten = 6;

            // Der Bonus auf Wurfspeere fällt heraus:
            subStadt.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wurfspeere, wert = +1 });
            // Dafür gibt es Armbrust oder Bogen +1 als Wahl:
            var wahlArmbrust = new wahlmoeglichkeiten();
            wahlArmbrust.anzahlZuWaehlen = 1;
            wahlArmbrust.talentWerte = new int[1];
            wahlArmbrust.talentWerte[0] = 1;
            wahlArmbrust.talente = new List<TalentName>() 
            { 
                TalentName.Armbrust, TalentName.Bogen,
            };
            wahlArmbrust.identifier = "Armbrust";
            subStadt.wahlen.Add(wahlArmbrust);

            // Der Bonus auf Speere fällt hinaus:
            subStadt.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Speere, wert = +1 });
            // Dafür gibt es Infanteriewaffen dazu:
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Infanteriewaffen, wert = +1 });

            // Fallenstellen wird entfernt:
            subStadt.talentModifikatoren.Remove(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });

            // Und die folgenden Mods:
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subStadt.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = -1 });

            // Moegliche Städte:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Andergast, StadtName.Nostria, StadtName.Salza, StadtName.Joborn,
            };

            return subStadt;

        }
        private subkultur createAndergastSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 6;
            subKeine.soMaximum = 12;
            subKeine.leModifikator = 1;
            subKeine.auModifikator = 2;

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Magiegespuer},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
            };

            // Nun zu den Professionen:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
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
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Amazone);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gladiator);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Schwertgeselle);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gelehrter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Edelhandwerker);

            // Jetzt die Talente:
            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Speere, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wurfspeere, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schleichen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SichVerstecken, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Fallenstellen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Orientierung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},

                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ackerbau, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schneidern, wert = +1},
            };

            // Muttersprache:
            subKeine.sprachen = new List<SprachenIdentifier>() { };
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // Jetzt die Auswahlmöglichkeiten:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl Handwerk:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.talente = new List<TalentName>() 
            { 
                TalentName.Abrichten, TalentName.Brauer, TalentName.Fleischer, TalentName.GerberUndKuerschner,
                TalentName.Grobschmied, TalentName.Kochen, TalentName.Seiler, TalentName.StoffeFaerben,
                TalentName.Toepfern, TalentName.Viehzucht, TalentName.Webkunst, TalentName.Winzer, TalentName.Zimmermann,
            };
            wahlHandwerk.identifier = "Handwerk";
            subKeine.wahlen.Add(wahlHandwerk);

            // Und die Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){name = SprachenName.OrkischOloarkh},
                new SprachenIdentifier(){name = SprachenName.OrkischOloghaijan},
                new SprachenIdentifier(){name = SprachenName.Thorwalsch},
            };
            wahlSprache.identifier = "SprachenWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            subKeine.wahlen.Add(wahlSprache);

            // Es gibt zwei SF dazu:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.AndergastUndNostria},
                new sfIdentifier(){ name = SFNamen.MeisterDerImprovisation},
            };

            // Es gibt auch noch eine SF billiger:
            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = SFSubNamen.Waldkundig},
            };

            return subKeine;
        }

        private subkultur createMittelLandSubBorbi()
        {
            var subFluecht = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subFluecht.name = SubKulturName.BorbaradianischBesetzteGebiete;
            subFluecht.generierungskosten = 0;
            subFluecht.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
            };

            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SichVerstecken, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Zechen, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = -1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Magiekunde, wert = +1 });

            // Wir müssen noch die Sprachenauswahl erneuern!
            // Holen wir uns zunächst die Sprachauswahl:
            var myIndex = subFluecht.wahlen.FindIndex(FindSprache);
            subFluecht.wahlen[myIndex].sprachen.Add( new SprachenIdentifier(){name = SprachenName.Zhayad} );
            subFluecht.wahlen[myIndex].sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });

            // Zu den empfohlenen Vor- und Nachteilen kommt jeweils etwas dazu:
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.AffinitaetZu, auspraegung = AffinitaetenName.Daemonen });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Gefahreninstinkt });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Glueck });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Magiegespuer });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.ResistenzGegenKrankheiten });

            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Aberglaube });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Dunkelangst });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Einbildungen });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Goldgier });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Schlafstoerungen });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Stigma });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Unstet });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Wahnvorstellungen });

            // Nun fehlen noch die Regionen:
            subFluecht.moeglicheRegionen = new List<Region>()
            {
                Region.Tobrien, Region.OstDarpatien, Region.Warunk, Region.Beilunk,
            };

            return subFluecht;

        }
        private subkultur createMittelLandJilaskan()
        {
            var subJilas = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subJilas.name = SubKulturName.Jilaskan;
            subJilas.generierungskosten = 4;
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Dolche, wert = -1 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Hiebwaffen, wert = +1 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Singen, wert = +2 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Zechen, wert = -1 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = -1 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = +2 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Pflanzenkunde, wert = +1 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +2 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Tierkunde, wert = +1 });
            subJilas.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.HeilkundeGift, wert = +1 });

            // Die Wahl der zweiten Sprache fällt heraus, daher müssen wir die Wahlen erneuern!
            // Wir müssen noch die Sprachenauswahl erneuern!
            subJilas.wahlen.RemoveAt(subJilas.wahlen.FindIndex(FindSprache));


            return subJilas;
        }
        private subkultur createMittelLandSubLandadel()
        {
            var subAdel = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subAdel.name = SubKulturName.Landadel;
            subAdel.generierungskosten = 3;

            // Voraussetzungen:
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            // Die Wahl der Infi fällt heraus, daher müssen wir die Wahlen erneuern!
            subAdel.wahlen[0].loescheEintrag(subAdel.wahlen, "Infi");

            // Talente:
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Reiten, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechtskunde, wert = +1 });

            // Außerdem gibt's die Kusliker Zeichen dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createMittelLandSubFern()
        {
            var subFern = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subFern.name = SubKulturName.FernDerZivilisation;
            subFern.generierungskosten = 4;
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = -1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = -1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Faehrtensuchen, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Orientierung, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wettervorhersage, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +2 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Pflanzenkunde, wert = +1 });
            subFern.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Tierkunde, wert = +1 });

            // Bei den Auswahlen ändern sich die möglichen Sprachen. Also fügen wir die neuen Sprachen hinzu:
            var myIndex = subFern.wahlen.FindIndex(FindSprache);
            subFern.wahlen[myIndex].sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            subFern.wahlen[myIndex].sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            subFern.wahlen[myIndex].sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });

            // Und die SF:
            subFern.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde},
            };

            return subFern;
        }
        private subkultur createMittelLandSuGebirge()
        {
            var subGebirge = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subGebirge.name = SubKulturName.Gebirge;
            subGebirge.generierungskosten = 1;
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +1 });

            return subGebirge;
        }
        private subkultur createMittelLandSubWeiden()
        {
            var subWeiden = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subWeiden.name = SubKulturName.RegionenWeidenUndGreifenfurt;
            subWeiden.generierungskosten = 2;
            subWeiden.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subWeiden.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Fallenstellen, wert = +1 });
            subWeiden.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = +1 });
            subWeiden.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Viehzucht, wert = +1 });

            return subWeiden;
        }
        private subkultur createMittelLandSubHandel()
        {
            var subHandel = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subHandel.name = SubKulturName.AnWichtigerHandelsrouteOderReichsstrasse;
            subHandel.generierungskosten = 2;

            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SagenUndLegenden, wert = +1 });
            subHandel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FahrzeugLenken, wert = +1 });

            // Es darf noch eine beliebige andere Sprache gewählt werden ("Handelssprache").
            // TOCHECK: Ich gehe davon aus, dass damit eine weitere Sprache aus der Kategorie der Muttersprachen gemeint ist!
            // Also fügen wir eine weitere Auswahl hinzu:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
                new SprachenIdentifier(){ name = SprachenName.Rogolan},
                new SprachenIdentifier(){ name = SprachenName.Isdira},
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch},
            };
            
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 2;
            subHandel.wahlen.Add(wahlSprache);

            return subHandel;
        }
        private subkultur createMittelLandSubKueste()
        {
            var subKueste = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subKueste.name = SubKulturName.KuestengebieteOderAnGrossenFluessen;
            subKueste.generierungskosten = 3;

            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +1 });

            return subKueste;
        }
        private subkultur createMittelLandSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 0;
            subKeine.soMaximum = -1;
            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){name = VorteileName.ZaeherHund},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){name = NachteileName.Platzangst},
            };

            // Vorbereiten der Professions-Kategorienklasse. @Tom: Kann man das
            // auch global machen? Sonst kommt diese Zeile in JEDER Subkultur immer wieder vor...
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
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
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gladiator);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Schwertgeselle);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Bettler);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Einbrecher);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Spitzel);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Taugenichts);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Gelehrter);
            subKeine.ungeeigneteProfessionen.Add(ProfessionsName.Edelhandwerker);

            // Nun folgen die Talentboni:
            subKeine.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Hiebwaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ringen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Athletik, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Selbstbeherrschung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Zechen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Faehrtensuchen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wettervorhersage, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Wildnisleben, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.GoetterUndKulte, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.SagenUndLegenden, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Ackerbau, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.HeilkundeWunden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Holzbearbeitung, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Lederarbeiten, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){ name = TalentName.Schneidern, wert = +1},
            };

            // Jetzt die Auswahlmöglichkeiten:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl Infi/2HandHiebwaffen
            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.anzahlZuWaehlen = 1;
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = 1;
            wahlInfi.talente = new List<TalentName>() { TalentName.Infanteriewaffen, TalentName.ZweihandHiebwaffen };
            wahlInfi.identifier = "Infi";
            subKeine.wahlen.Add(wahlInfi);

            // Wahl aus Handwerken: 2 aus der Liste!
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 2;
            wahlHandwerk.talentWerte = new int[2];
            wahlHandwerk.talentWerte[0] = 2;
            wahlHandwerk.talentWerte[1] = 1;
            wahlHandwerk.talente = new List<TalentName>() 
            { 
                TalentName.Abrichten, TalentName.Brauer, TalentName.Fleischer, TalentName.GerberUndKuerschner,
                TalentName.Grobschmied, TalentName.Kochen, TalentName.Seiler, TalentName.StoffeFaerben,
                TalentName.Toepfern, TalentName.Viehzucht, TalentName.Webkunst, TalentName.Winzer,
                TalentName.Zimmermann,
            };
            subKeine.wahlen.Add(wahlHandwerk);
            // Nun die Wahl zwischen einer von vier Sprachen:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
                new SprachenIdentifier(){ name = SprachenName.Rogolan},
                new SprachenIdentifier(){ name = SprachenName.Isdira},
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch},
            };
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            subKeine.wahlen.Add(wahlSprache);

            // Es fehlen noch die SF:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){name = SFNamen.Kulturkunde, auspraegung = KulturName.Mittelreich},
            };

            // Muttersprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            return subKeine;

        }

        private subkultur createMittelStaedteSubFluechtlinge()
        {
            var subFluecht = createMittelStaedteSubKeine();
            // Wir ändern nur das, was sich unterscheidet!
            subFluecht.name = SubKulturName.FluechtlingeAusBorbaradianischenStaedten;
            subFluecht.generierungskosten = 0;
            subFluecht.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){name = EigenschaftenName.Mut, wert = -1},
            };

            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.SichVerstecken, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Zechen, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = -1 });
            subFluecht.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Magiekunde, wert = +1 });

            // Zur Auswahl der Sprachen kommt etwas hinzu:
            // Holen wir uns zunächst die Sprachauswahl:
            var myIndex = subFluecht.wahlen.FindIndex(FindSprache);
            subFluecht.wahlen[myIndex].sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            subFluecht.wahlen[myIndex].sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });

            // Zu den empfohlenen Vor- und Nachteilen kommt jeweils etwas dazu:
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.AffinitaetZu, auspraegung = AffinitaetenName.Daemonen });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Gefahreninstinkt });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Glueck });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Magiegespuer });
            subFluecht.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.ResistenzGegenKrankheiten });

            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Aberglaube });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Dunkelangst });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Einbildungen });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Goldgier });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Schlafstoerungen });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Stigma });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Unstet });
            subFluecht.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Wahnvorstellungen });

            // Fehlen noch die Regionen:
            subFluecht.moeglicheRegionen = new List<Region>()
            {
                Region.Ysilia, Region.Mendena, Region.Ilsur, Region.Warunk, Region.Beilunk,
            };

            return subFluecht;
        }
        private subkultur createMittelStaedteSubKanne()
        {
            var subKanne = createMittelStaedteSubKeine();
            // Wir ändern nur das, was sich unterscheidet!
            subKanne.name = SubKulturName.KannemuendeMhanerhaven;
            subKanne.generierungskosten = 3;

            // Zuerst die Talente:
            subKanne.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subKanne.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subKanne.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subKanne.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Rechnen, wert = +1 });


            // Bei den Wahlmöglichkeiten wird die Auswahl der Sprachen entfernt,
            // da der Held eine Zweitsprache erhält!
            var myIndex = subKanne.wahlen.FindIndex(FindSprache);
            subKanne.wahlen.RemoveAt(myIndex);

            // Zu den Auswahlen kommt eine hinzu:
            var wahlTalentHandwerk = new wahlmoeglichkeiten();
            wahlTalentHandwerk.talente = new List<TalentName>()
            {
                TalentName.BooteFahren, TalentName.FischenUndAngeln, TalentName.Kochen,
            };
            wahlTalentHandwerk.anzahlZuWaehlen = 1;
            wahlTalentHandwerk.talentWerte = new int[1];
            wahlTalentHandwerk.talentWerte[0] = 1;
            subKanne.wahlen.Add(wahlTalentHandwerk);

            // Tulamidya wird zur Zweitsprache. Dadurch wird die Wahl eingeschränkt
            // für die dritte Sprache (s.o.)
            subKanne.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, zweitsprache = true });

            subKanne.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){name = SFNamen.Kulturkunde, auspraegung = KulturName.Tulamidenlande},
            };

            return subKanne;
        }
        private subkultur createMittelStaedteSubAdel()
        {
            var subAdel = createMittelStaedteSubKeine();
            // Wir ändern nur das, was sich unterscheidet!
            subAdel.name = SubKulturName.StaedtischerAdel;
            subAdel.generierungskosten = 1;

            // Diese Kultur ist an die Voraussetzung des Vorteils "Adelig"
            // gekoppelt.
            subAdel.voraussetzungen = new subkulturVoraussetzungen();
            subAdel.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){name = VorteileName.Adlig},
            };
            subAdel.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Sozialstatus, wert = 7},
            };

            // Nun noch die Talentmods: Wir müssen leider alles überschreiben...
            subAdel.talentModifikatoren = new List<GenericListenNameWertPaar<TalentName>>()
            {
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Dolche, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Infanteriewaffen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Raufen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Zechen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Etikette, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Menschenkenntnis, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Ueberreden, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.GoetterUndKulte, wert = +2},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Heraldik, wert = +3},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Rechnen, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.Rechtskunde, wert = +1},
                new GenericListenNameWertPaar<TalentName>(){name = TalentName.SagenUndLegenden, wert = +2},
            };

            // Die Wahlmöglichkeiten werden ergänzt um eine Wahl:
            var wahlTalentKampf2 = new wahlmoeglichkeiten();
            wahlTalentKampf2.talente = new List<TalentName>()
            {
                TalentName.Fechtwaffen, TalentName.Schwerter,
            };
            wahlTalentKampf2.anzahlZuWaehlen = 1;
            wahlTalentKampf2.talentWerte = new int[1];
            wahlTalentKampf2.talentWerte[0] = 1;
            subAdel.wahlen.Add(wahlTalentKampf2);

            // Außerdem gibt es die Kusliker Zeichen gratis dazu:
            subAdel.schriften = new List<SchriftenIdentifier>() { new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = 2 }, };

            return subAdel;
        }
        private subkultur createMittelStaedteSubSiedler()
        {
            var subSiedler = createMittelStaedteSubKeine();
            // Wir ändern nur das, was sich unterscheidet!
            subSiedler.name = SubKulturName.SiedlerstaedteDesNordens;
            subSiedler.generierungskosten = 1;
            subSiedler.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Wildnisleben, wert = 1 });
            subSiedler.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ackerbau, wert = 1 });
            subSiedler.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Viehzucht, wert = 1 });

            // Außerdem ändern sich die Sprachen, aus denen man wählen darf. Wir überschrieben daher die
            // die Wahlsprache nachdem wir sie gelöscht haben:
            var myIndex = subSiedler.wahlen.FindIndex(FindSprache);
            subSiedler.wahlen.RemoveAt(myIndex);
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Nujuka},
                new SprachenIdentifier(){ name = SprachenName.Alaani},
                new SprachenIdentifier(){ name = SprachenName.OrkischOloarkh},
            };
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            subSiedler.wahlen.Add(wahlSprache);

            // Nun noch die Städte:
            subSiedler.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Uhdenberg, StadtName.Donnerbach, StadtName.Riva, StadtName.Lowangen, StadtName.Norburg,
            };

            return subSiedler;
        }
        private subkultur createMittelStaedteSubTempel()
        {
            var subTempel = createMittelStaedteSubKeine();
            // Wir ändern nur das, was sich unterscheidet!
            subTempel.name = SubKulturName.StaedteMitWichtigemTempelOderPilgerstaette;
            subTempel.generierungskosten = 2;
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = 2 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = 1 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geschichtswissen, wert = 1 });
            subTempel.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.GoetterUndKulte, wert = 2 });

            // Außerdem gibt es noch eine beliebige Sprache dazu!
            // Das bedeutet im Klartext: Aus der ursprünglichen Sprachenliste der Hauptkukur mit
            // drei Einträgen können statt EINER nun ZWEI Sprachen ausgewählt werden.
            var myIndex = subTempel.wahlen.FindIndex(FindSprache);
            // Wir  löschen die Sprachwahl und schreiben sie neu:
            subTempel.wahlen.RemoveAt(myIndex);
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
                new SprachenIdentifier(){ name = SprachenName.Rogolan},
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch},
            };
            wahlSprache.anzahlZuWaehlen = 2;
            wahlSprache.talentWerte = new int[2];
            wahlSprache.talentWerte[0] = 3;
            wahlSprache.talentWerte[1] = 4;
            subTempel.wahlen.Add(wahlSprache);

            // Nun noch die möglichen Städte:
            subTempel.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Angbar, StadtName.Gareth, StadtName.Rommilys,
            };

            return subTempel;
        }
        private subkultur createMittelStaedteSubHafen()
        {
            var subHafen = createMittelStaedteSubKeine();
            // Wir ändern nur das, was sich unterscheidet!
            subHafen.name = SubKulturName.HafenstaedteUndStaedteAnGroessenFluessen;
            subHafen.generierungskosten = 3;
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Schwimmen, wert = 1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Menschenkenntnis, wert = +1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Ueberreden, wert = +1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.FischenUndAngeln, wert = +1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Geographie, wert = +1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.BooteFahren, wert = +1 });
            subHafen.talentModifikatoren.Add(new GenericListenNameWertPaar<TalentName>() { name = TalentName.Seefahrt, wert = +1 });

            subHafen.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Elenvina, StadtName.Ferdok, StadtName.Festum, StadtName.Harben, StadtName.Havena, StadtName.Perricum,
            };

            return subHafen;
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
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
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
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // Wir bereiten die Wahlmöglichkeiten vor:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Beginnen wir mit Der Wahl der Kampftalente:
            var wahlTalentKampf = new wahlmoeglichkeiten();
            wahlTalentKampf.talente = new List<TalentName>()
            {
                TalentName.Armbrust, TalentName.Bogen, TalentName.Wurfmesser,
            };
            wahlTalentKampf.identifier = "ArmburstWahl";
            wahlTalentKampf.anzahlZuWaehlen = 1;
            wahlTalentKampf.talentWerte = new int[1];
            wahlTalentKampf.talentWerte[0] = 1;
            subKeine.wahlen.Add(wahlTalentKampf);

            // Nun die Wahl aus dem Handwerksbereich:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<TalentName>()
            {
                TalentName.Ackerbau, TalentName.Hauswirtschaft,
            };
            wahlHandwerk.identifier = "AckerbauWahl";
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            subKeine.wahlen.Add(wahlHandwerk);

            // Nun die Wahl zwischen einer von drei Sprachen:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
                new SprachenIdentifier(){ name = SprachenName.Rogolan},
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch},
            };
            wahlSprache.identifier = "SprachWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            subKeine.wahlen.Add(wahlSprache);

            // Nun die SFs:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Mittelreich},
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            return subKeine;
        }

        /// <summary>
        /// Sucht in der Wahlliste nach der Auswahl eine Sprache.
        /// Wir als Delegat genutzt, nach dem man eine Liste durchsuchen kann.
        /// </summary>
        /// <param name="wahl"></param>
        /// <returns></returns>
        private static bool FindSprache(wahlmoeglichkeiten wahl)
        {
            // Wenn Sprachen definiert sind, haben wir unser Ziel entdeckt!
            if (wahl.sprachen != null)
            {
                return true;
            }
            {
                return false;
            }
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
        /// Sprachen, die mit der Kultur verknüpft sind:
        /// (kann auch sein, dass sie erst zwischen mehreren gewählt werden muss!)
        /// </summary>
        public List<SprachenIdentifier> sprachen;

        /// <summary>
        /// Eine Liste aller Schriften, die man durch die Kultur kennt:
        /// </summary>
        public List<SchriftenIdentifier> schriften;

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
        public List<StadtName> moeglicheStaedte;

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
