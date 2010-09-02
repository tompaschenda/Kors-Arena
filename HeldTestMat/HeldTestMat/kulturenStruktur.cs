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
using talentStruktur;
using zauberStruktur;

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
                        ///////////////////////////////////////
                        // Dschungelstämme
                        ///////////////////////////////////////
                        case KulturName.Dschungelstaemme:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createDschungelSubKeine());
                            moeglicheSubkulturen.Add(createDschungelSubTschop());
                            moeglicheSubkulturen.Add(createDschungelSubBerg());
                            moeglicheSubkulturen.Add(createDschungelSubHaipu());
                            break;
                        ///////////////////////////////////////
                        // Darna
                        ///////////////////////////////////////
                        case KulturName.Darna:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createDarnaSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Verlorene Stämme
                        ///////////////////////////////////////
                        case KulturName.VerloreneStaemme:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createStaemmeSubKeine());
                            moeglicheSubkulturen.Add(createStaemmeSubShoku());
                            moeglicheSubkulturen.Add(createStaemmeSubChira());
                            break;
                        ///////////////////////////////////////
                        // Waldinsel-Utulus
                        ///////////////////////////////////////
                        case KulturName.WaldinselUtulus:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createUtuluSubkeine());
                            break;
                        ///////////////////////////////////////
                        // Miniwatu
                        ///////////////////////////////////////
                        case KulturName.Miniwatu:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createMiniSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Tocamuyac
                        ///////////////////////////////////////
                        case KulturName.Tocamuyac:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createTocaSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Maraskan
                        ///////////////////////////////////////
                        case KulturName.Maraskan:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createMaraskanSubKeine());
                            moeglicheSubkulturen.Add(createMaraskanSubDschungel());
                            moeglicheSubkulturen.Add(createMaraskanSubKueste());
                            moeglicheSubkulturen.Add(createMaraskanSubStadt());
                            break;
                        ///////////////////////////////////////
                        // Südaventurien
                        ///////////////////////////////////////
                        case KulturName.Suedaventurien:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createSuedSubKeine());
                            moeglicheSubkulturen.Add(createSuedSubStaatenAlAnfa());
                            moeglicheSubkulturen.Add(createSuedSubStaatenBrabak());
                            moeglicheSubkulturen.Add(createSuedSubStaatenCharypso());
                            moeglicheSubkulturen.Add(createSuedSubStaatenChorhop());
                            moeglicheSubkulturen.Add(createSuedSubStaatenHotAlem());
                            moeglicheSubkulturen.Add(createSuedSubStaatenKhefu());
                            moeglicheSubkulturen.Add(createSuedSubStaatenMengbilla());
                            moeglicheSubkulturen.Add(createSuedSubStaatenMirham());
                            moeglicheSubkulturen.Add(createSuedSubStaatenSylla());
                            moeglicheSubkulturen.Add(createSuedSubHaefen());
                            moeglicheSubkulturen.Add(createSuedSubPlantage());
                            moeglicheSubkulturen.Add(createSuedSubSelem());
                            break;
                        ///////////////////////////////////////
                        // Bukanier
                        ///////////////////////////////////////
                        case KulturName.Bukanier:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createBukanierSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Nivesenstämme
                        ///////////////////////////////////////
                        case KulturName.Nivesenstaemme:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createNiveseSubKeine());
                            moeglicheSubkulturen.Add(createNiveseSubSesshaft());
                            break;
                        ///////////////////////////////////////
                        // Nuanaä-Lie
                        ///////////////////////////////////////
                        case KulturName.NuanaaeLie:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createNuanaSubKeine());
                            moeglicheSubkulturen.Add(createNuanaSubNauoke());
                            break;
                        ///////////////////////////////////////
                        // Norbardensippe
                        ///////////////////////////////////////
                        case KulturName.Norbardensippe:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createNorbardeSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Trollzacken
                        ///////////////////////////////////////
                        case KulturName.Trollzacken:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createTrollZackenSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Auelfische Sippe
                        ///////////////////////////////////////
                        case KulturName.AuelfischeSippe:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createAuelfischSubKeine());
                            moeglicheSubkulturen.Add(createAuelfischSubHoherNorden());
                            break;
                        ///////////////////////////////////////
                        // Elfische Siedling
                        ///////////////////////////////////////
                        case KulturName.ElfischeSiedlung:
                            kultur = value;
                            moeglicheSubkulturen = new List<subkultur>();
                            moeglicheSubkulturen.Add(createElfischeSiedlungSubKeine());
                            moeglicheSubkulturen.Add(createElfischeSiedlungSubSuedlich());
                            moeglicheSubkulturen.Add(createElfischeSiedlungSubGroess());
                            moeglicheSubkulturen.Add(createElfischeSiedlungSubFirn());
                            moeglicheSubkulturen.Add(createElfischeSiedlungSubWald());
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

        private subkultur createElfischeSiedlungSubWald()
        {
            var subWald = createAuelfischSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subWald.name = SubKulturName.WaldelfischBeeinflussteSiedlung;
            subWald.generierungskosten = 5;

            subWald.automatischeNachteile.Remove(new NachteilsIdentifier() { name = NachteileName.Neugier, wert = +5 });
            subWald.geeigneteProfessionen.Remove(ProfessionsName.Hirte);
            subWald.geeigneteProfessionen.Remove(ProfessionsName.Hofkuenstler);
            subWald.geeigneteProfessionen.Remove(ProfessionsName.Taugenichts);
            subWald.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });

            // zu den sonstigen Zaubern kommen noch ein paar dazu:
            var hauszauber = new zauberVorauswahlen();
            var wahlSonstZauber = new wahlmoeglichkeiten();
            wahlSonstZauber.zauber = new List<ZauberIdentifier>() { };
            wahlSonstZauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlSonstZauber.zauber.Remove(new ZauberIdentifier() { name = ZauberName.Zaubernahrung });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.HerrUeberDasTierreich });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Katzenaugen });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Kroetensprung });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.LeibDerErde });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Memorabia });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.SeidenzungeElfenwort });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Wipfellauf });
            wahlSonstZauber.anzahlZuWaehlen = 4;
            wahlSonstZauber.identifier = "wahlSonstigeZauber";
            subWald.wahlen.Add(wahlSonstZauber);

            return subWald;
        }
        private subkultur createElfischeSiedlungSubFirn()
        {
            var subFirn = createAuelfischSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subFirn.name = SubKulturName.FirnelfischBeeinflussteSiedlung;
            subFirn.generierungskosten = 4;

            subFirn.moeglicheStaedte = new List<StadtName>() { StadtName.Olport, StadtName.Keamonmund};

            subFirn.geeigneteProfessionen.Remove(ProfessionsName.Bauer);
            subFirn.geeigneteProfessionen.Remove(ProfessionsName.Botenreiter);
            subFirn.geeigneteProfessionen.Remove(ProfessionsName.Gaukler);
            subFirn.geeigneteProfessionen.Remove(ProfessionsName.Hirte);
            subFirn.geeigneteProfessionen.Remove(ProfessionsName.Hofkuenstler);
            subFirn.geeigneteProfessionen.Remove(ProfessionsName.Taugenichts);
            subFirn.geeigneteProfessionen.Add(ProfessionsName.Seefahrer);

            subFirn.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = -1});
            subFirn.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Skifahren, wert = +1 });
            subFirn.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Betoeren, wert = -2 });
            subFirn.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subFirn.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });

            return subFirn;
        }
        private subkultur createElfischeSiedlungSubGroess()
        {
            var substadt = createAuelfischSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            substadt.name = SubKulturName.Grossstadt;
            substadt.generierungskosten = 2;

            substadt.moeglicheStaedte = new List<StadtName>() { StadtName.Lowangen, StadtName.Punin };

            substadt.geeigneteProfessionen.Add(ProfessionsName.Einbrecher);
            substadt.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            substadt.geeigneteProfessionen.Add(ProfessionsName.KurtisaneGesellschafter);
            substadt.geeigneteProfessionen.Add(ProfessionsName.Bader);
            substadt.geeigneteProfessionen.Add(ProfessionsName.Edelhandwerker);

            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Bogen, wert = -2});
            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = -2 });
            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +1 });
            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -1 });
            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = -2 });
            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +2 });
            substadt.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +1 });

            return substadt;
        }
        private subkultur createElfischeSiedlungSubSuedlich()
        {
            var subSued = createAuelfischSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subSued.name = SubKulturName.SuedlicheMittellande;
            subSued.generierungskosten = 4;

            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Bogen, wert = -1 });
            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = -1 });
            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subSued.talentModifikatoren.Remove(new talentIdentifier() { name = TalentName.Wildnisleben, leittalent = true , wert = +3 });
            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +2 });
            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, leittalent = true , wert = +1 });
            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subSued.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Ackerbau, wert = +2 });

            // Wahl zwischen Schrift und Sprache:
            var wahlSchrift = new wahlmoeglichkeiten();
            wahlSchrift.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.LesenUndSchreiben, auspraegung = SchriftName.IsdiraAsdharia, wert = 4},
                new talentIdentifier(){ name = TalentName.SprachenKennen, auspraegung = SprachenName.Asdharia, wert = 4},
            };
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;

            return subSued;
        }
        private subkultur createElfischeSiedlungSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 3;
            subKeine.soMaximum = 10;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.ElfischeWeltsicht},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Besitz , wert = +6},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Religion , wert = +6},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Adelsherrschaft , wert = +6},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.Zauberhaar},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AnimalischeMagie},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Artefaktgebunden},
                // TODO: Ausprägung! Menschen oder Zwerge!
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
                new NachteilsIdentifier(){ name = NachteileName.WahrerName},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd},
            };


            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Thesisgebunden},
            };

            // Professionen:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() 
            { 
                ProfessionsName.Bewahrer, ProfessionsName.Former, ProfessionsName.Kaempfer,
                ProfessionsName.Legendensaenger, ProfessionsName.Wildnislaeufer, ProfessionsName.Zauberweber,
                ProfessionsName.Botenreiter, ProfessionsName.Fischer, ProfessionsName.Großwildjaeger, ProfessionsName.Hirte,
                ProfessionsName.Karawanenhueter, ProfessionsName.Kundschafter, ProfessionsName.Prospektor, ProfessionsName.Schiffer,
                ProfessionsName.Schmuggler, ProfessionsName.Barde, ProfessionsName.Gaukler, ProfessionsName.Hofkuenstler,
                ProfessionsName.Taugenichts, ProfessionsName.Bauer, ProfessionsName.Handwerker, ProfessionsName.Edelhandwerker,
                ProfessionsName.Tierbaendiger, ProfessionsName.Wundarzt
            };

            // Leittalente und normale Talente:
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen, leittalent = true, wert = +3},
                new talentIdentifier(){ name = TalentName.Dolche, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Athletik, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Klettern, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Schleichen, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Schwimmen, leittalent = true, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerstecken, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Singen, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Betoeren, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Ueberreden, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, leittalent = true, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, leittalent = true, wert = +3},
                new talentIdentifier(){ name = TalentName.Magiekunde, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, leittalent = false, wert = -1},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, leittalent = true, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Musizieren, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Schneidern, leittalent = false, wert = +2},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen, leittalent = false},
                new talentIdentifier(){ name = TalentName.Saebel, leittalent = false},
                new talentIdentifier(){ name = TalentName.Schwerter, leittalent = false},
                new talentIdentifier(){ name = TalentName.Speere, leittalent = false},
                new talentIdentifier(){ name = TalentName.Staebe, leittalent = false},
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = 2;
            wahlKampf.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlKampf);

            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten, leittalent = true},
                new talentIdentifier(){ name = TalentName.Bogenbau, leittalent = true},
                new talentIdentifier(){ name = TalentName.BooteFahren, leittalent = true},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, leittalent = true},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, leittalent = true},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, leittalent = true},
            };
            wahlHandwerk.talentWerte = new int[2];
            wahlHandwerk.talentWerte[0] = 3;
            wahlHandwerk.talentWerte[1] = 3;
            wahlHandwerk.anzahlZuWaehlen = 2;
            subKeine.wahlen.Add(wahlHandwerk);

            // Sprache:
           subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Isdira, muttersprache = true},
            };

            // Wahl der Sprache:
            var wahlZweitsprache = new wahlmoeglichkeiten();
            wahlZweitsprache.sprachen = new List<SprachenIdentifier>() { };
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit, zweitsprache = true });
            wahlZweitsprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch, zweitsprache = true });
            wahlZweitsprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlZweitsprache);

            // Wahl der Drittsprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Hauszauber:
            var wahlHausZauber = new wahlmoeglichkeiten();
            wahlHausZauber.zauber = new List<ZauberIdentifier>() { };
            var hauszauber = new zauberVorauswahlen();
            wahlHausZauber.zauber.AddRange(hauszauber.GetElfenHauszauber());
            wahlHausZauber.anzahlZuWaehlen = 3;
            wahlHausZauber.zauberHaus = true;
            subKeine.wahlen.Add(wahlHausZauber);

            // Leitzauber:
            var wahlLeitzauber = new wahlmoeglichkeiten();
            wahlLeitzauber.zauber = new List<ZauberIdentifier>() { };
            wahlLeitzauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlLeitzauber.anzahlZuWaehlen = 3;
            wahlLeitzauber.zauberHaus = true;
            subKeine.wahlen.Add(wahlLeitzauber);

            // Maximal 4 weitere:
            var wahlSonstZauber = new wahlmoeglichkeiten();
            wahlSonstZauber.zauber = new List<ZauberIdentifier>() { };
            wahlSonstZauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlSonstZauber.zauber.Remove(new ZauberIdentifier() { name = ZauberName.WeisseMaehn });
            wahlSonstZauber.zauber.Remove(new ZauberIdentifier() { name = ZauberName.Zaubernahrung });
            wahlSonstZauber.anzahlZuWaehlen = 4;
            wahlSonstZauber.identifier = "wahlSonstigeZauber";
            subKeine.wahlen.Add(wahlSonstZauber);

            // SO:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.GrosseMeditation},
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Auelfen},
                new sfIdentifier(){ name = SFNamen.Repraesentation, auspraegung = Zauberreprasentation.Elfisch},
                new sfIdentifier(){ name = SFNamen.Salasandra},
                new sfIdentifier(){ name = SFNamen.Elfenlieder, auspraegung = Elfenlieder.Freundschaftslied},
            };


            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Regeneration, auspraegung = SFSubNamen.I},
            };

            // TODO: Spezielle Ausrüstung!

            return subKeine;
        }

        private subkultur createAuelfischSubHoherNorden()
        {
            var subHoch = createAuelfischSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHoch.name = SubKulturName.HoherNorden;

            subHoch.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.ElfischeWeltsicht},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Besitz , wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Religion , wert = +5},
            };

            subHoch.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.Kaelteresistenz });

            subHoch.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Raumangst });
            subHoch.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Weltfremd, auspraegung = Weltfremd.Besitz });
            subHoch.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Weltfremd, auspraegung = Weltfremd.WaherungUndGeld });
            subHoch.empfohleneNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Weltfremd, auspraegung = Weltfremd.StaedtischesLeben });

            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = -2 });
            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.SichVerstecken, wert = -1 });
            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Skifahren, wert = +1 });
            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = -2 });
            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = -1 });
            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subHoch.talentModifikatoren.Add(new talentIdentifier() { name = TalentName.BooteFahren, leittalent = true, wert = +2 });
            // Betören raus:
            subHoch.talentModifikatoren.Remove(new talentIdentifier(){ name = TalentName.Betoeren, leittalent = false, wert = +3});


            // Wahlen:
            subHoch.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBogenbau = new wahlmoeglichkeiten();
            wahlBogenbau.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogenbau, leittalent = true},
                new talentIdentifier(){ name = TalentName.BooteFahren, leittalent = true}
            };
            wahlBogenbau.talentWerte = new int[1];
            wahlBogenbau.talentWerte[0] = 2;
            wahlBogenbau.anzahlZuWaehlen = 1;
            subHoch.wahlen.Add(wahlBogenbau);

            // Wahl dazu:
            subHoch.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlSpeere = new wahlmoeglichkeiten();
            wahlSpeere.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Wurfspeere}
            };
            wahlSpeere.talentWerte = new int[1];
            wahlSpeere.talentWerte[0] = 2;
            wahlSpeere.anzahlZuWaehlen = 1;
            subHoch.wahlen.Add(wahlSpeere);

            // Hauszauber:
            var wahlHausZauber = new wahlmoeglichkeiten();
            wahlHausZauber.zauber = new List<ZauberIdentifier>() { };
            var hauszauber = new zauberVorauswahlen();
            wahlHausZauber.zauber.AddRange(hauszauber.GetElfenHauszauber());
            wahlHausZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Firnlauf });
            wahlHausZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.MetamorphoGletscherform });
            wahlHausZauber.anzahlZuWaehlen = 3;
            wahlHausZauber.zauberHaus = true;
            subHoch.wahlen.Add(wahlHausZauber);

            // Leitzauber:
            var wahlLeitzauber = new wahlmoeglichkeiten();
            wahlLeitzauber.zauber = new List<ZauberIdentifier>() { };
            wahlLeitzauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlLeitzauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Firnlauf });
            wahlLeitzauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.MetamorphoGletscherform });
            wahlLeitzauber.anzahlZuWaehlen = 3;
            wahlLeitzauber.zauberHaus = true;
            subHoch.wahlen.Add(wahlLeitzauber);

            // Maximal 4 weitere:
            var wahlSonstZauber = new wahlmoeglichkeiten();
            wahlSonstZauber.zauber = new List<ZauberIdentifier>() { };
            wahlSonstZauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.Firnlauf });
            wahlSonstZauber.zauber.Add(new ZauberIdentifier() { name = ZauberName.MetamorphoGletscherform });
            wahlSonstZauber.anzahlZuWaehlen = 4;
            subHoch.wahlen.Add(wahlSonstZauber);

            return subHoch;

        }
        private subkultur createAuelfischSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 4;
            subKeine.soMaximum = 8;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.ElfischeWeltsicht},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Besitz , wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Religion , wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Tierfreund},
                new VorteilsIdentifier(){ name = VorteileName.Zauberhaar},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AnimalischeMagie},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Artefaktgebunden},
                // TODO: Ausprägung! Menschen oder Zwerge!
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
                new NachteilsIdentifier(){ name = NachteileName.WahrerName},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {            
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier },
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht },
                new NachteilsIdentifier(){ name = NachteileName.Thesisgebunden },
            };

            // Professionen:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() 
            { 
                ProfessionsName.Bewahrer, ProfessionsName.Former, ProfessionsName.Kaempfer,
                ProfessionsName.Legendensaenger, ProfessionsName.Wildnislaeufer, ProfessionsName.Zauberweber,
            };

            // Leittalente und normale Talente:
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen, leittalent = true, wert = +4},
                new talentIdentifier(){ name = TalentName.Dolche, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Klettern, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Schleichen, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Schwimmen, leittalent = true, wert = +4},
                new talentIdentifier(){ name = TalentName.SichVerstecken, leittalent = true, wert = +5},
                new talentIdentifier(){ name = TalentName.Singen, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.Tanzen, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Betoeren, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Gassenwissen, leittalent = false, wert = -2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, leittalent = true, wert = +3},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln, leittalent = true, wert = +3},
                new talentIdentifier(){ name = TalentName.Orientierung, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, leittalent = true, wert = +5},
                new talentIdentifier(){ name = TalentName.Magiekunde, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Pflanzenkunde, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Rechtskunde, leittalent = false, wert = -2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeGift, leittalent = false, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, leittalent = true, wert = +1},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, leittalent = false, wert = +2},
                new talentIdentifier(){ name = TalentName.Musizieren, leittalent = false, wert = +3},
                new talentIdentifier(){ name = TalentName.Schneidern, leittalent = false, wert = +2},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBogenbau = new wahlmoeglichkeiten();
            wahlBogenbau.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogenbau, leittalent = true},
                new talentIdentifier(){ name = TalentName.BooteFahren, leittalent = true}
            };
            wahlBogenbau.talentWerte = new int[1];
            wahlBogenbau.talentWerte[0] = 2;
            wahlBogenbau.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBogenbau);

            // Hauszauber:
            var wahlHausZauber = new wahlmoeglichkeiten();
            wahlHausZauber.zauber = new List<ZauberIdentifier>() { };
            var hauszauber = new zauberVorauswahlen();
            wahlHausZauber.zauber.AddRange(hauszauber.GetElfenHauszauber());
            wahlHausZauber.anzahlZuWaehlen = 3;
            wahlHausZauber.zauberHaus = true;
            subKeine.wahlen.Add(wahlHausZauber);

            // Leitzauber:
            var wahlLeitzauber = new wahlmoeglichkeiten();
            wahlLeitzauber.zauber = new List<ZauberIdentifier>() { };
            wahlLeitzauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlLeitzauber.anzahlZuWaehlen = 3;
            wahlLeitzauber.zauberHaus = true;
            subKeine.wahlen.Add(wahlLeitzauber);

            // Maximal 4 weitere:
            var wahlSonstZauber = new wahlmoeglichkeiten();
            wahlSonstZauber.zauber = new List<ZauberIdentifier>() { };
            wahlSonstZauber.zauber.AddRange(hauszauber.GetElfenBasisZauber());
            wahlSonstZauber.anzahlZuWaehlen = 4;
            subKeine.wahlen.Add(wahlSonstZauber);

            // SO:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Auelfen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Sumpf},
                new sfIdentifier(){ name = SFNamen.GrosseMeditation},
                new sfIdentifier(){ name = SFNamen.Repraesentation, auspraegung = Zauberreprasentation.Elfisch},
                new sfIdentifier(){ name = SFNamen.Salasandra},
                new sfIdentifier(){ name = SFNamen.Elfenlieder, auspraegung = Elfenlieder.Freundschaftslied},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Regeneration, auspraegung = SFSubNamen.I},
            };

            subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Isdira, muttersprache = true},
            };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>() { };
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.AlteKemi });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Angram });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Asdharia });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Atak });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Aureliani });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Bosparano });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Drachisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ferkina });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Fuechsisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Goblinisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Grolmisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Hjaldingsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Koboldisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mahrisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Molochisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Neckergesang });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloarkh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.OrkischOloghaijan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rabensprache });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rissoal });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rssahh });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Ruuz });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Trollisch });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.UrTulamidya });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zelemja });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhayad });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zhulchammaqra });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.ZLit });
            wahlSprache.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Zyklopaeisch });
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            return subKeine;
        }

        private subkultur createTrollZackenSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 10;
            subKeine.soMaximum = 4;
            subKeine.auModifikator = +2;
            subKeine.leModifikator = +1;

            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +1},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
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
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},               
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig },
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen },
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig },
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig },
                new NachteilsIdentifier(){ name = NachteileName.NiedrigeLebenskraft },
                new NachteilsIdentifier(){ name = NachteileName.Schulden },
                new NachteilsIdentifier(){ name = NachteileName.Totenangst },
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur },
            };

            // Professionen:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() 
            { 
                ProfessionsName.Stammeskrieger, ProfessionsName.Hirte, ProfessionsName.Jaeger, ProfessionsName.Kundschafter,
                ProfessionsName.Straßenraeuber, ProfessionsName.Haendler, ProfessionsName.Bauer, ProfessionsName.Handwerker,
                ProfessionsName.Druide,
                // TOCHECK: Schamane???
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlSpeere = new wahlmoeglichkeiten();
            wahlSpeere.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlSpeere.talentWerte = new int[2];
            wahlSpeere.talentWerte[0] = 3;
            wahlSpeere.talentWerte[1] = 1;
            wahlSpeere.anzahlZuWaehlen = 2;
            subKeine.wahlen.Add(wahlSpeere);

            // Sprachen:
            subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Zhulchammaqra, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Garethi, modifikator = +4},
                new SprachenIdentifier(){ name = SprachenName.Trollisch, modifikator = +4},
            };

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +3},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Schleuder, wert = +2},
                new talentIdentifier{ name = TalentName.Wurfbeile, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Klettern, wert = +2},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +2},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = -1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Trollzacken},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Gebirge},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Trolle},
            };

            return subKeine;
        }

        private subkultur createNorbardeSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 8;
            subKeine.soMaximum = 10;
            subKeine.auModifikator = +2;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.GutesGedaechtnis},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz },
                new NachteilsIdentifier(){ name = NachteileName.Platzangst },
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue },
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile },
            };

            // Profession:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() 
            { 
                ProfessionsName.Gladiator, ProfessionsName.Schaukaempfer, ProfessionsName.Soeldner,
                ProfessionsName.Entdecker, ProfessionsName.Fernhaendler, ProfessionsName.Fuhrmann,
                ProfessionsName.Großwildjaeger, ProfessionsName.Jaeger, ProfessionsName.Kundschafter,
                ProfessionsName.Prospektor, ProfessionsName.Schiffer, ProfessionsName.Schmuggler,
                ProfessionsName.Ausrufer, ProfessionsName.Barde, ProfessionsName.Gaukler, ProfessionsName.Haendler,
                ProfessionsName.Streuner, ProfessionsName.Bader, ProfessionsName.Gelehrter, ProfessionsName.Handwerker,
                ProfessionsName.Tierbaendiger, ProfessionsName.Wirt, ProfessionsName.Wundarzt, ProfessionsName.Hexe,
                ProfessionsName.GeweihterDesAves, ProfessionsName.GeweihterDesFirun, ProfessionsName.GeweihterDerHesinde,
                ProfessionsName.GeweihterDesNandus, ProfessionsName.GeweihterDesPhex, ProfessionsName.Scharlatan,
                ProfessionsName.Zibilja,
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlArmbrust = new wahlmoeglichkeiten();
            wahlArmbrust.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
            };
            wahlArmbrust.talentWerte = new int[1];
            wahlArmbrust.talentWerte[0] = 1;
            wahlArmbrust.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlArmbrust);

            var wahlSpeere = new wahlmoeglichkeiten();
            wahlSpeere.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlSpeere.talentWerte = new int[1];
            wahlSpeere.talentWerte[0] = 1;
            wahlSpeere.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSpeere);

            // Sprachen:
            subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Alaani, muttersprache = true },
            };

            // Wahl Zweitsprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Nujuka, zweitsprache = true},
            };
            wahlSprache.identifier = "Zweitsprachwahl";
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 5;
            subKeine.wahlen.Add(wahlSprache);

            // Wahl Dritt- bis Fünftsprache:
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi},
                new SprachenIdentifier(){ name= SprachenName.Nujuka},
                new SprachenIdentifier(){ name= SprachenName.Thorwalsch},
                new SprachenIdentifier(){ name= SprachenName.OrkischOloghaijan},
            };
            wahlSprache.identifier = "Zweitsprachwahl";
            wahlSprache.anzahlZuWaehlen = 3;
            wahlSprache.talentWerte = new int[3];
            wahlSprache.talentWerte[0] = 5;
            wahlSprache.talentWerte[1] = 5;
            wahlSprache.talentWerte[2] = 5;
            subKeine.wahlen.Add(wahlSprache);

            // Wahl der SF:
            var wahlSF = new wahlmoeglichkeiten();
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Steppe},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Wald},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSF);

            // Und nochmal verbilligt:
            wahlSF = new wahlmoeglichkeiten();
            wahlSF.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Steppe},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Wald},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSF);

            // Talente:
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Reiten, wert = +1},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.Singen, wert = +1},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +2},
                new talentIdentifier{ name = TalentName.Zechen, wert = +3},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +3},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier{ name = TalentName.Geographie, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier{ name = TalentName.FahrzeugLenken, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Musizieren, wert = +1},
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Norbarden},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Bornland},
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Nivesen},
            };

            return subKeine;
        }

        private subkultur createNuanaSubNauoke()
        {
            var subNauo = createNuanaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subNauo.name = SubKulturName.Nauoke;
            subNauo.generierungskosten = 25;

            subNauo.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Wolfskind, auspraegung = VorteilsAuspraegung.Willentlich},
                // TOCHECK: Vierteilzauberer automatisch dabei, daher höhere GP!
                new VorteilsIdentifier(){ name = VorteileName.Viertelzauberer,},
            };

            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Raufen, wert = +2 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ringen, wert = +3 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Speere, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schleichen, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Selbstbeherrschung, wert = +2 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Sinnesschaerfe, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = +1 });
            subNauo.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +2 });

            return subNauo;
        }
        private subkultur createNuanaSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 7;
            subKeine.soMaximum = 5;
            subKeine.auModifikator = +5;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Gesellschaftlich},
            };

            // Zu den Wahlen kommt auf jeden Fall dreimal Weltfremd hinzu!
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlNachteile = new wahlmoeglichkeiten();
            wahlNachteile.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Religion},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.Adelsherrschaft},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.RechtssprechungUndGesetze},
                new NachteilsIdentifier(){ name = NachteileName.Weltfremd, auspraegung = Weltfremd.WaherungUndGeld},
            };
            wahlNachteile.talentWerte = new int[3];
            wahlNachteile.talentWerte[0] = 5;
            wahlNachteile.talentWerte[1] = 5;
            wahlNachteile.talentWerte[2] = 5;
            wahlNachteile.anzahlZuWaehlen = 3;
            subKeine.wahlen.Add(wahlNachteile);

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Viertelzauberer},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
                new VorteilsIdentifier(){ name = VorteileName.Wolfskind},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Feuer},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
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
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            // Profession:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            // TOCHECK: Wolfskind, Magiedilettant
            //subKeine.geeigneteProfessionen.Add(ProfessionsName.);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +4},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Speere, wert = +3},
                new talentIdentifier{ name = TalentName.Athletik, wert = +3},
                new talentIdentifier{ name = TalentName.Klettern, wert = +3},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +3},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl Talent:
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 2;
            wahlBogen.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBogen);

            var wahlBogenbau = new wahlmoeglichkeiten();
            wahlBogenbau.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogenbau},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Feuersteinbearbeitung},
                new talentIdentifier(){ name = TalentName.Fleischer},
            };
            wahlBogenbau.talentWerte = new int[1];
            wahlBogenbau.talentWerte[0] = 2;
            wahlBogenbau.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBogenbau);

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Nivesen},
            };

            subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Nujuka, muttersprache = true},
            };

            return subKeine;
        }

        private subkultur createNiveseSubSesshaft()
        {
            var subSess = createNiveseSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subSess.name = SubKulturName.HalbsesshafteKuestenstaemme;
            subSess.generierungskosten = 11;

            subSess.talentModifikatoren.Add( new talentIdentifier{ name = TalentName.Schwimmen, wert = +1});
            subSess.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });

            subSess.geeigneteProfessionen.Add(ProfessionsName.Seefahrer);

            return subSess;
        }
        private subkultur createNiveseSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 10;
            subKeine.soMaximum = 8;
            subKeine.auModifikator = +5;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Totenangst, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Wolfskind},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
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
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.NiedrigeLebenskraft},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            // Profession:
            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kaskjua);

            // Talente: 
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1 },
                new talentIdentifier{ name = TalentName.Raufen, wert = +2 },
                new talentIdentifier{ name = TalentName.Ringen, wert = +2 },
                new talentIdentifier{ name = TalentName.Speere, wert = +2 },
                new talentIdentifier{ name = TalentName.Wurfbeile, wert = +1 },
                new talentIdentifier{ name = TalentName.Athletik, wert = +1 },
                new talentIdentifier{ name = TalentName.Klettern, wert = +1 },
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1 },
                new talentIdentifier{ name = TalentName.Schleichen, wert = +1 },
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +1 },
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1 },
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2 },
                new talentIdentifier{ name = TalentName.Skifahren, wert = +2 },
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +3 },
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1 },
                new talentIdentifier{ name = TalentName.Orientierung, wert = +2 },
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +2 },
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +2 },
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1 },
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2 },
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +2 },
                new talentIdentifier{ name = TalentName.Abrichten, wert = +1 },
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +1 },
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1 },
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1 },
                new talentIdentifier{ name = TalentName.FahrzeugLenken, wert = +2 },
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +2 },
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1 },
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +2 },
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Nujuka, muttersprache = true},
            };

            // Wahl Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, modifikator = 5},
                new SprachenIdentifier(){ name= SprachenName.Alaani, modifikator = 5},
            };
            wahlSprache.identifier = "MutterSprachenwahl";
            wahlSprache.anzahlZuWaehlen = 1;
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 5;
            subKeine.wahlen.Add(wahlSprache);

            // Sonder:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Nivesen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Steppe},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Eis},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier()
                { 
                    name = SFNamen.Talentspezialisierung, 
                    auspraegung = TalentName.FahrzeugLenken, 
                    subAuspraegung = TalentSpezialisierung.HundeUndDachsschlitten
                },
            };

            return subKeine;
        }

        private subkultur createBukanierSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 2;
            subKeine.soMaximum = 6;

            subKeine.leModifikator = +1;
            subKeine.auModifikator = +2;
            subKeine.mrModifikator = -1;

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                // TODO: Ausprägung!
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, wert = +6},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Gesucht},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gladiator);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schaukaempfer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Großwildjaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schmuggler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schiffer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Seefahrer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);

            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bettler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Dieb);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Einbrecher);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Streuner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Rattenfaenger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tageloehner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wirt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Wundarzt);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesPhex);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesEfferd);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.GeweihterDesSwafnir);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{name = TalentName.Bogen, wert = +1},
                new talentIdentifier{name = TalentName.Dolche, wert = +1},
                new talentIdentifier{name = TalentName.Raufen, wert = +2},
                new talentIdentifier{name = TalentName.Ringen, wert = +2},
                new talentIdentifier{name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{name = TalentName.Schleichen, wert = +1},
                new talentIdentifier{name = TalentName.Schwimmen, wert = +3},
                new talentIdentifier{name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier{name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier{name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier{name = TalentName.BooteFahren, wert = +2},
                new talentIdentifier{name = TalentName.Fleischer, wert = +1},
                new talentIdentifier{name = TalentName.GerberUndKuerschner, wert = +1},
                new talentIdentifier{name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{name = TalentName.Kochen, wert = +1},
                new talentIdentifier{name = TalentName.Lederarbeiten, wert = +1},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Bukanier},
            };

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, modifikator = +2},
                new SprachenIdentifier(){ name = SprachenName.Mohisch, modifikator = +2},
                new SprachenIdentifier(){ name = SprachenName.Thorwalsch, modifikator = +2},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = 1;
            wahlHieb.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlHieb);

            return subKeine;
        }

        private subkultur createSuedSubSelem()
        {
            var subSelem = createSuedSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subSelem.name = SubKulturName.Selem;
            subSelem.generierungskosten = 4;

            var wahlPhilo = new wahlmoeglichkeiten();
            wahlPhilo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Philosophie},
                new talentIdentifier(){ name = TalentName.HeilkundeSeele},
            };
            wahlPhilo.talentWerte = new int[1];
            wahlPhilo.talentWerte[0] = 1;
            wahlPhilo.anzahlZuWaehlen = 1;
            subSelem.wahlen.Add(wahlPhilo);

            // Alle Spracheninfos werden überschrieben:
            // Sprachen:
            subSelem.sprachen = new List<SprachenIdentifier>() { };

            // Muttersprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Rssahh, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Zelemja, muttersprache = true},
            };
            wahlSprache.identifier = "MutterSprachenwahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subSelem.wahlen.Add(wahlSprache);

            // Zweitsprache:
            wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Rssahh, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Zelemja, zweitsprache = true},
            };
            wahlSprache.identifier = "ZweitSprachenWahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subSelem.wahlen.Add(wahlSprache);

            // Dritte Sprache:
            wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, modifikator = +4},
                new SprachenIdentifier(){ name= SprachenName.Rssahh, modifikator = +4},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, modifikator = +4},
                new SprachenIdentifier(){ name= SprachenName.Zelemja, modifikator = +4},
                new SprachenIdentifier(){ name= SprachenName.Mohisch, modifikator = +4},
            };
            wahlSprache.identifier = "Drittsprachenwahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subSelem.wahlen.Add(wahlSprache);

            subSelem.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.StammesAchaz},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Sumpf},
            };

            return subSelem;
        }
        private subkultur createSuedSubPlantage()
        {
            var subPlantage = createSuedSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subPlantage.name = SubKulturName.DschungeldorfOderPlantage;
            subPlantage.generierungskosten = 2;

            subPlantage.automatischeVorteile = new List<VorteilsIdentifier>(){};
            subPlantage.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Hiebwaffen, wert = +1 });
            subPlantage.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Saebel, wert = +1 });
            subPlantage.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +2 });
            subPlantage.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Gassenwissen, wert = +1 });
            subPlantage.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Pflanzenkunde, wert = +2 });
            subPlantage.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +1 });

            var wahlAcker = new wahlmoeglichkeiten();
            wahlAcker.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Fallenstellen},
            };
            wahlAcker.talentWerte = new int[1];
            wahlAcker.talentWerte[0] = 1;
            wahlAcker.anzahlZuWaehlen = 1;
            subPlantage.wahlen.Add(wahlAcker);

            return subPlantage;
        }
        private subkultur createSuedSubHaefen()
        {
            var subHafen = createSuedSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHafen.name = SubKulturName.Kolonialhaefen;
            subHafen.generierungskosten = 5;

            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Hiebwaffen, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +2 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Holzbearbeitung, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Lederarbeiten, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +2 });

            subHafen.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Mohisch, modifikator = +2 });

            return subHafen;
        }
        private subkultur createSuedSubStaatenSylla()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Sylla,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenMirham()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Mirham,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenMengbilla()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Mengbilla,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.HeilkundeGift, wert = +1 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenKhefu()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Khefu,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +2 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenHotAlem()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.HotAlem,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +1 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenChorhop()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Chorhop,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Holzbearbeitung, wert = +2 });
            subStadt.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, modifikator = +2 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenCharypso()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Charypso,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            return subStadt;
        }
        private subkultur createSuedSubStaatenBrabak()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.Brabak,
            };

            subStadt.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Thorwalsch, modifikator = +2 });

            return subStadt;
        }
        private subkultur createSuedSubStaatenAlAnfa()
        {
            var subStadt = createSuedSubStaatenBlank();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.moeglicheStaedte = new List<StadtName>()
            {
                StadtName.AlAnfa,
            };
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Gassenwissen, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +2 });

            return subStadt;
        }
        private subkultur createSuedSubStaatenBlank()
        {
            var subStadt = createSuedSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.name = SubKulturName.SuedlicheStadtstaaten;
            subStadt.generierungskosten = 4;

            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Gassenwissen, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +2 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

            return subStadt;

        }
        private subkultur createSuedSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 2;
            subKeine.soMaximum = -1;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
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
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Menschenmassen},
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
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Druide);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hexe);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Magier);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Scharlatan);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Schelm);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Taenzer);
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Die folgenden Professionen sind nicht geeignet:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>()
            {
                ProfessionsName.Amazone, ProfessionsName.Ritter, ProfessionsName.StammeskriegerDerBeniDervez, ProfessionsName.Stammeskrieger,
                ProfessionsName.GeweihterDesFirun, ProfessionsName.GeweihterDesAngrosch,
            };

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Saebel, wert = +1},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 1;
            wahlBogen.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBogen);

            // Sprachen:
            subKeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya, modifikator = +4},
                new SprachenIdentifier(){ name = SprachenName.Mohisch, modifikator = +4},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Suedaventurien},
            };

            return subKeine;
        }

        private subkultur createMaraskanSubStadt()
        {
            var subStadt = createMaraskanSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.name = SubKulturName.MaraskanischeStaedte;
            subStadt.generierungskosten = 6;

            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +2 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schaetzen, wert = +1 });

            return subStadt;
        }
        private subkultur createMaraskanSubKueste()
        {
            var subKueste = createMaraskanSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subKueste.name = SubKulturName.Kuestengebiete;
            subKueste.generierungskosten = 8;

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wurfspeere, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Sinnesschaerfe, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +2 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

            return subKueste;
        }
        private subkultur createMaraskanSubDschungel()
        {
            var subDschungel = createMaraskanSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subDschungel.name = SubKulturName.Dschungel;
            subDschungel.generierungskosten = 10;

            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schleichen, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SichVerstecken, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Sinnesschaerfe, wert = +2 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +2 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Pflanzenkunde, wert = +1 });
            subDschungel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +1 });

            subDschungel.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Maraskan},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Maraskan},
            };
            subDschungel.verbilligteSonderfertigkeiten = new List<sfIdentifier>(){};

            return subDschungel;
        }
        private subkultur createMaraskanSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 5;
            subKeine.soMaximum = -1;

            subKeine.mrModifikator = +1;
            subKeine.eigenschaftsModifikationen = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Intuition, wert = +1},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.BreitgefaecherteBildung},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenKrankheiten},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };
            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Einbildungen},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
            };
            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.Farbenblind},
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
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
            subKeine.geeigneteProfessionen.AddRange(professionsSubsets.GetZwoelfgoetterkulte());

            // Folgende Professionen sind nicht möglich:
            subKeine.ungeeigneteProfessionen = new List<ProfessionsName>() 
            { 
                ProfessionsName.Amazone, ProfessionsName.Ritter, ProfessionsName.Stammeskrieger, ProfessionsName.StammeskriegerDerBeniDervez
            };

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Diskus, wert = +2},
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Philosophie, wert = +2},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Ackerbau, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.StoffeFaerben, wert = +1},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Maraskan},
            };
            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Maraskan},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlSchwert = new wahlmoeglichkeiten();
            wahlSchwert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSchwert.talentWerte = new int[1];
            wahlSchwert.talentWerte[0] = 1;
            wahlSchwert.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSchwert);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = 1;
            wahlInfi.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlInfi);

            var wahlMusi = new wahlmoeglichkeiten();
            wahlMusi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlMusi.talentWerte = new int[1];
            wahlMusi.talentWerte[0] = 2;
            wahlMusi.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlMusi);

            // Weitere Sprachwahl:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, muttersprache = true},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, muttersprache = true},
            };
            wahlSprache.identifier = "MutterSprachenwahl";
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            var wahlSpracheZwei = new wahlmoeglichkeiten();
            wahlSpracheZwei.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name= SprachenName.Garethi, zweitsprache = true},
                new SprachenIdentifier(){ name= SprachenName.Tulamidya, zweitsprache = true},
            };
            wahlSpracheZwei.identifier = "ZweitSprachenwahl";
            wahlSpracheZwei.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSpracheZwei);

            return subKeine;
        }

        private subkultur createTocaSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 9;
            subKeine.soMaximum = 4;

            subKeine.mrModifikator = +1;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.BegabungFuerTalent , auspraegung = TalentName.Schwimmen},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Reptilien},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Medizinmann);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +3},
                new talentIdentifier{ name = TalentName.Ringen, wert = +3},
                new talentIdentifier{ name = TalentName.Speere, wert = +2},
                new talentIdentifier{ name = TalentName.Wurfspeere, wert = +2},
                new talentIdentifier{ name = TalentName.Klettern, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +5},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier{ name = TalentName.Zechen, wert = -2},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = -1},

                new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +4},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +4},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +3},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +5},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 5;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Mohisch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Tocamuyac},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Meer},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.FischenUndAngeln, subAuspraegung = TalentSpezialisierung.Seefischerei},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hruruzat},
            };

            return subKeine;
        }

        private subkultur createMiniSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 6;
            subKeine.soMaximum = 6;

            subKeine.auModifikator = -2;
            subKeine.mrModifikator = +1;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Jaehzorn},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Reptilien},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Medizinmann);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +2},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +4},
                new talentIdentifier{ name = TalentName.Ringen, wert = +4},
                new talentIdentifier{ name = TalentName.Speere, wert = +3},
                new talentIdentifier{ name = TalentName.Klettern, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +3},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +4},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier{ name = TalentName.Zechen, wert = -2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +3},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +2},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +2},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +3},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +2},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +2},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +4},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBlasrohr = new wahlmoeglichkeiten();
            wahlBlasrohr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBlasrohr.talentWerte = new int[1];
            wahlBlasrohr.talentWerte[0] = 3;
            wahlBlasrohr.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBlasrohr);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Mohisch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Waldmenschen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hruruzat},
            };

            return subKeine;
        }

        private subkultur createUtuluSubkeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 10;
            subKeine.soMaximum = 4;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Reptilien},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Gladiator);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Medizinmann);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Speere, wert = +3},
                new talentIdentifier{ name = TalentName.Klettern, wert = +2},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +2},
                new talentIdentifier{ name = TalentName.Zechen, wert = -2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +3},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +2},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +2},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +3},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +2},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Musizieren, wert = +3},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBlasrohr = new wahlmoeglichkeiten();
            wahlBlasrohr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBlasrohr.talentWerte = new int[1];
            wahlBlasrohr.talentWerte[0] = 2;
            wahlBlasrohr.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBlasrohr);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Mohisch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Waldmenschen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
            };

            return subKeine;
        }

        private subkultur createStaemmeSubChira()
        {
            var subChira = createStaemmeSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subChira.name = SubKulturName.Shokubunga;
            subChira.generierungskosten = 10;

            subChira.mrModifikator = +1;

            subChira.geeigneteProfessionen.Add(ProfessionsName.Soldat);
            subChira.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subChira.geeigneteProfessionen.Add(ProfessionsName.Tageloehner);

            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ringen, wert = -1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = -1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schleichen, wert = -2 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = -1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SichVerstecken, wert = -2 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Zechen, wert = +1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = -2 });
            subChira.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = -2 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = -1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.HeilkundeGift, wert = -1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.HeilkundeKrankheiten, wert = +1 });
            subChira.talentModifikatoren.Add(new talentIdentifier { name = TalentName.HeilkundeWunden, wert = +1 });


            // Wahl:
            subChira.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBlasrohr = new wahlmoeglichkeiten();
            wahlBlasrohr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBlasrohr.talentWerte = new int[1];
            wahlBlasrohr.talentWerte[0] = 1;
            wahlBlasrohr.anzahlZuWaehlen = 1;
            subChira.wahlen.Add(wahlBlasrohr);

            var wahlAcker = new wahlmoeglichkeiten();
            wahlAcker.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Viehzucht},
            };
            wahlAcker.talentWerte = new int[1];
            wahlAcker.talentWerte[0] = 1;
            wahlAcker.anzahlZuWaehlen = 1;
            subChira.wahlen.Add(wahlAcker);


            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subChira.wahlen.Add(wahlSprache);

            return subChira;
        }
        private subkultur createStaemmeSubShoku()
        {
            var subShoku = createStaemmeSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subShoku.name = SubKulturName.Shokubunga;
            subShoku.generierungskosten = 11;
            subShoku.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subShoku.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Singen, wert = +1 });
            subShoku.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Musizieren, wert = +2 });

            return subShoku;
        }
        private subkultur createStaemmeSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 12;
            subKeine.soMaximum = 4;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
            };
            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Reptilien},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Soeldner);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Straßenraeuber);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Medizinmann);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +12},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +3},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Speere, wert = +2},
                new talentIdentifier{ name = TalentName.Klettern, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +4},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier{ name = TalentName.Zechen, wert = -2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +4},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +3},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +2},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBlasrohr = new wahlmoeglichkeiten();
            wahlBlasrohr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBlasrohr.talentWerte = new int[1];
            wahlBlasrohr.talentWerte[0] = 2;
            wahlBlasrohr.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBlasrohr);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 4;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Mohisch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Waldmenschen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hruruzat},
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.SuedlicheStadtstaaten},
            };

            return subKeine;
        }

        private subkultur createDarnaSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 9;
            subKeine.soMaximum = 4;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Viertelzauberer},
            };
            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AffinitaetZu, auspraegung = AffinitaetenName.Geistern},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Meisterhandwerk},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Schutzgeist},
                new VorteilsIdentifier(){ name = VorteileName.UebernatürlicheBegabung},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Medium},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                // TOCHECK! Titularadel???
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Reptilien},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor, auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Bauer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Medizinmann);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +2},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Speere, wert = +2},
                new talentIdentifier{ name = TalentName.Wurfspeere, wert = +1},
                new talentIdentifier{ name = TalentName.Klettern, wert = +3},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = -2},
                new talentIdentifier{ name = TalentName.SichVerkleiden, wert = -1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +3},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier{ name = TalentName.Gesteinskunde, wert = +2},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +3},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +3},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +3},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.MalenUndZeichnen, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlAckerbau = new wahlmoeglichkeiten();
            wahlAckerbau.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.SteinschneiderUndJuwelier},
            };
            wahlAckerbau.talentWerte = new int[1];
            wahlAckerbau.talentWerte[0] = 2;
            wahlAckerbau.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlAckerbau);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Mohisch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Waldmenschen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hruruzat},
            };

            // Zauber:
            subKeine.moeglicheUebernatuerlicheBegabungen = new List<ZauberName>()
            {
                ZauberName.Adlerauge, ZauberName.AengsteLindern, ZauberName.Armatrutz, ZauberName.Attributo,
                ZauberName.Axxeleratus, ZauberName.Balsam, ZauberName.Bannbaladin, ZauberName.BlickAufsWesen,
                ZauberName.BlickInDieGedanken, ZauberName.BlitzDichFind, ZauberName.BoeserBlick, ZauberName.Chamaelioni,
                ZauberName.Eiseskaelte, ZauberName.ExposamiLebenskraft, ZauberName.FalkenaugeMeisterschuss, ZauberName.Gefunden,
                ZauberName.GrosseVerwirrung, ZauberName.HarmloseGestalt, ZauberName.Hexenspeichel, ZauberName.Hoellenpein,
                ZauberName.Katzenaugen, ZauberName.KlarumPurum, ZauberName.Kroetensprung, ZauberName.Kusch,
                ZauberName.LungeDesLeviatan, ZauberName.Memorans, ZauberName.Movimento, ZauberName.Odem,
                ZauberName.Penetrizzel, ZauberName.PestilenzErspueren,ZauberName.Psychostabilis, 
                ZauberName.RuheKoerper, ZauberName.Sanftmut, ZauberName.SeidenzungeElfenwort, ZauberName.Sensattacco,
                ZauberName.Sensibar, ZauberName.Spinnenlauf, ZauberName.SpurlosTrittlos, ZauberName.StandfestKatzengleich,
                ZauberName.SumusElixiere, ZauberName.TiereBesprechen, ZauberName.Unitatio, ZauberName.Vipernblick,
                ZauberName.Visibili, ZauberName.Wipfellauf,
            };

            return subKeine;
        }

        private subkultur createDschungelSubHaipu()
        {
            var subHaipu = createDschungelSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHaipu.name = SubKulturName.Haipu;
            subHaipu.generierungskosten = 13;

            subHaipu.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = -2 });
            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +3 });
            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SichVerstecken, wert = -1 });
            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = -1 });
            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = -1 });
            subHaipu.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +2 });

            return subHaipu;
        }
        private subkultur createDschungelSubBerg()
        {
            var subBerg = createDschungelSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subBerg.name = SubKulturName.Bergstaemme;
            subBerg.generierungskosten = 10;

            subBerg.auModifikator = +2;

            subBerg.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subBerg.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +2 });
            subBerg.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = -1 });
            subBerg.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = -1 });
            subBerg.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Feuersteinbearbeitung, wert = +1 });

            return subBerg;
        }
        private subkultur createDschungelSubTschop()
        {
            var subTschop = createDschungelSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subTschop.name = SubKulturName.Tschopukikuha;
            subTschop.generierungskosten = 10;

            subTschop.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
            };

            subTschop.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Singen, wert = +1 });
            subTschop.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Musizieren, wert = +2 });

            return subTschop;
        }
        private subkultur createDschungelSubKeine()
        {
            var subKeine = new subkultur();
            subKeine.name = SubKulturName.Keine;
            subKeine.generierungskosten = 11;
            subKeine.soMaximum = 4;

            subKeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.Hitzeresistenz},
            };
            subKeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst, wert = +5},
                new NachteilsIdentifier(){ name = NachteileName.Neugier, wert = +5},
            };

            subKeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.Entfernungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Glueck},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.ResistenzGegenGifte},
                new VorteilsIdentifier(){ name = VorteileName.Richtungssinn},
                new VorteilsIdentifier(){ name = VorteileName.Schlangenmensch},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.Wohlklang},
            };

            subKeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Platzangst},
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subKeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Kaelteresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
            };

            subKeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Spinnen},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Insekten},
                new NachteilsIdentifier(){ name = NachteileName.AngstVor , auspraegung = Angst.Reptilien},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Goldgier},
                new NachteilsIdentifier(){ name = NachteileName.Hoehenangst},
                new NachteilsIdentifier(){ name = NachteileName.KrankhafteReinlichkeit},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Kurzatmig},
                new NachteilsIdentifier(){ name = NachteileName.Nachtblind},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
                new NachteilsIdentifier(){ name = NachteileName.UnfaehigkeitFuerTalentgruppe, auspraegung = TalentKategorie.Natur},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            var professionsSubsets = new ProfessionsKategorien();
            subKeine.geeigneteProfessionen = new List<ProfessionsName>() { };
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Stammeskrieger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Fischer);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Hirte);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Jaeger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Kundschafter);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Prospektor);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Haendler);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Handwerker);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Tierbaendiger);
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Medizinmann);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Speere, wert = +2},
                new talentIdentifier{ name = TalentName.Klettern, wert = +2},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +3},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +3},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = -2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +4},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +5},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +4},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +4},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.MalenUndZeichnen, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlBlasrohr = new wahlmoeglichkeiten();
            wahlBlasrohr.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Blasrohr},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBlasrohr.talentWerte = new int[1];
            wahlBlasrohr.talentWerte[0] = 2;
            wahlBlasrohr.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBlasrohr);

            // Wahl der Sprache:
            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Garethi},
                new SprachenIdentifier(){ name = SprachenName.Tulamidya},
            };
            wahlSprache.talentWerte = new int[1];
            wahlSprache.talentWerte[0] = 3;
            wahlSprache.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlSprache);

            // Sprache:
            subKeine.sprachen = new List<SprachenIdentifier>() 
            { 
                new SprachenIdentifier(){ name = SprachenName.Mohisch, muttersprache = true},
            };

            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Waldmenschen},
                new sfIdentifier(){ name = SFNamen.Gelaendekunde, auspraegung = GelaendeArt.Dschungel},
            };

            subKeine.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hruruzat},
            };

            return subKeine;
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Wurfspeere, wert = +1},
                new talentIdentifier{ name = TalentName.ZweihandHiebwaffen, wert = +2},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Klettern, wert = +2},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = -2},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{ name = TalentName.Skifahren, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = -1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +4},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +3},
                new talentIdentifier{ name = TalentName.Speere, wert = +2},
                new talentIdentifier{ name = TalentName.ZweihandHiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +2},
                new talentIdentifier{ name = TalentName.Klettern, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +2},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +3},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Viehzucht},
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
            var subBinnen = createThorWalSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subBinnen.name = SubKulturName.Binnenland;
            subBinnen.generierungskosten = 5;

            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.ZweihandHiebwaffen, wert = +1});
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = -1 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = -2 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = -1 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +2 });

            // Boote fahren niedriger, Seefahrt raus:
            subBinnen.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Seefahrt, wert = +2 });
            subBinnen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = -1 });

            // Wahl:
            subBinnen.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Holzbearbeitung},
                new talentIdentifier(){ name = TalentName.Lederarbeiten},
                new talentIdentifier(){ name = TalentName.Schneidern},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1}, 
                new talentIdentifier{ name = TalentName.Raufen, wert = +2}, 
                new talentIdentifier{ name = TalentName.Wurfbeile, wert = +2}, 
                new talentIdentifier{ name = TalentName.Athletik, wert = +1}, 
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1}, 
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +3}, 
                new talentIdentifier{ name = TalentName.Zechen, wert = +3}, 
                new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +1}, 
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +3}, 
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3}, 
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1}, 
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +4}, 
                new talentIdentifier{ name = TalentName.Sternkunde, wert = +1}, 
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +2}, 
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1}, 
                new talentIdentifier{ name = TalentName.Seefahrt, wert = +2}, 
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Wurfmesser, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Singen, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Geographie, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier{ name = TalentName.Sternkunde, wert = +1},
                new talentIdentifier{ name = TalentName.FahrzeugLenken, wert = +2},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Schleuder, wert = +1},
            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik},
                new talentIdentifier(){ name = TalentName.Gaukeleien},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl},
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
            subKeine.geeigneteProfessionen.Add(ProfessionsName.Nuranshar);

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Klettern, wert = +2},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Reiten, wert = +1},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +2},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +3},
                new talentIdentifier{ name = TalentName.Gesteinskunde, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Sternkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier{ name = TalentName.Feuersteinbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +2},

            };

            // Wahl:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };
            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
                new talentIdentifier(){ name = TalentName.Wurfbeile},
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = 1;
            wahlKampf.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlKampf);

            var wahlAbrichten = new wahlmoeglichkeiten();
            wahlAbrichten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.HeilkundeGift},
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

            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = -1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = -1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = -1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = -2 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ackerbau, wert = +1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Hauswirtschaft, wert = +1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Lederarbeiten, wert = -1 });

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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Reiten, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = -1},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +3},

                new talentIdentifier{ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier{ name = TalentName.Lehren, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +1},

                new talentIdentifier{ name = TalentName.BrettUndKartenspiel, wert = +3},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +3},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier{ name = TalentName.Sternkunde, wert = +1},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = -1},

                new talentIdentifier{ name = TalentName.HeilkundeGift, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeKrankheiten, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeSeele, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Kochen, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +2},
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1},
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
            subOase.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Bogen, wert = +1 });
            subOase.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Lanzenreiten, wert = +1 });
            subOase.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Wurfspeere, wert = +1 });

            // Und dies kommt dazu:
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +2 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = -2 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = -2 });
            subOase.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ackerbau, wert = +1 });

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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Bogen, wert = +1},
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Lanzenreiten, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Saebel, wert = +1},
                new talentIdentifier{ name = TalentName.Speere, wert = +1},
                new talentIdentifier{ name = TalentName.Wurfspeere, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Reiten, wert = +3},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = -1},
                new talentIdentifier{ name = TalentName.Sinnesschaerfe, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +3},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier{ name = TalentName.BrettUndKartenspiel, wert = +2},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier{ name = TalentName.Sternkunde, wert = +1},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = -1},
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +2},
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

            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ringen, wert = +2 });
            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +2 });
            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +2 });
            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SagenUndLegenden, wert = +2 });

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

            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ringen, wert = +2 });
            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +2 });
            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +2 });
            subKasi.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SagenUndLegenden, wert = +2 });

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

            subSee.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +2 });
            subSee.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subSee.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subSee.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wettervorhersage, wert = +1 });
            subSee.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });

            // Zusatzwahl:
            var wahlBoot = new wahlmoeglichkeiten();
            wahlBoot.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Seefahrt},
                new talentIdentifier(){ name = TalentName.BooteFahren},
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Saebel, wert = +1},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Etikette, wert = +1},
                new talentIdentifier{ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +2},
                new talentIdentifier{ name = TalentName.SichVerkleiden, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.BrettUndKartenspiel, wert = +2},
                new talentIdentifier{ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +2},
                new talentIdentifier{ name = TalentName.Hauswirtschaft, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlDieb = new wahlmoeglichkeiten();
            wahlDieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Taschendiebstahl},
                new talentIdentifier(){ name = TalentName.Gaukeleien},
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

            subNomade.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subNomade.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = +1 });
            subNomade.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +2 });
            subNomade.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = +1 });
            subNomade.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });
            subNomade.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechnen, wert = +1 });

            // Überreden, Etikette, Ackerbau raus:
            subNomade.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subNomade.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Ueberreden, wert = +2 });
            subNomade.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Ackerbau, wert = +1 });

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
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Schleuder},
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

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wettervorhersage, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });

            // Wahl:
            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Seefahrt},
                new talentIdentifier(){ name = TalentName.BooteFahren},
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

            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Selbstbeherrschung, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = -1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Kochen, wert = +1 });

            // Zweitsprache löschen:
            subFern.sprachen = new List<SprachenIdentifier>() { };
            subFern.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Tulamidya, muttersprache = true });

            // Wahl Bogen:
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Schleuder},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 1;
            wahlBogen.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlBogen);

            // Wahl Athletik:
            var wahlAth = new wahlmoeglichkeiten();
            wahlAth.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Athletik},
                new talentIdentifier(){ name = TalentName.Klettern},
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

            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechnen, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schaetzen, wert = +1 });

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
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Etikette, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier{ name = TalentName.BrettUndKartenspiel, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +3},
                new talentIdentifier{ name = TalentName.Ackerbau, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +2},
            };

            // Sonder:
            subKeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kulturkunde, auspraegung = KulturName.Mhanadistan},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlHIeb = new wahlmoeglichkeiten();
            wahlHIeb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlHIeb.talentWerte = new int[1];
            wahlHIeb.talentWerte[0] = 1;
            wahlHIeb.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlHIeb);

            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Toepfern},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
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


            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Saebel, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

            // Zu den Wahlen kommt eine dazu:
            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
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

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });

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

            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Gassenwissen, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });

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
            subKeine.talentModifikatoren.Remove( new talentIdentifier{ name = TalentName.Etikette, wert = +2});
            subKeine.talentModifikatoren.Remove( new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +2});
            subKeine.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subKeine.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });

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
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Saebel, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Reiten, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Etikette, wert = +2},
                new talentIdentifier{ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +2},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.BrettUndKartenspiel, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier{ name = TalentName.Hauswirtschaft, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();

            var wahlMagie = new wahlmoeglichkeiten();
            wahlMagie.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Magiekunde},
                new talentIdentifier(){ name = TalentName.Philosophie},
            };
            wahlMagie.talentWerte = new int[1];
            wahlMagie.talentWerte[0] = 1;
            wahlMagie.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlMagie);

            var wahlAbrichten = new wahlmoeglichkeiten();
            wahlAbrichten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Musizieren},
                new talentIdentifier(){ name = TalentName.Webkunst},
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +2},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Staebe, wert = +2},
                new talentIdentifier{ name = TalentName.Athletik, wert = +2},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier{ name = TalentName.Reiten, wert = +3},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +3},
                new talentIdentifier{ name = TalentName.Etikette, wert = +1},
                new talentIdentifier{ name = TalentName.Gassenwissen, wert = -2},
                new talentIdentifier{ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier{ name = TalentName.Kriegskunst, wert = +2},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Abrichten, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
            };

            // Wahlen:
            subKeine.wahlen = new List<wahlmoeglichkeiten>();
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 4;
            wahlBogen.anzahlZuWaehlen = 1;
            subKeine.wahlen.Add(wahlBogen);

            var wahlSäbel = new wahlmoeglichkeiten();
            wahlSäbel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
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
            subAdel.talentModifikatoren.Remove(new talentIdentifier{ name = TalentName.Schleuder, wert = +1});
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Bogen, wert = +1 });

            // Mods:
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Hiebwaffen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

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
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +2},
                new talentIdentifier{ name = TalentName.Ringen, wert = +2},
                new talentIdentifier{ name = TalentName.Schleuder, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Klettern, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +2},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{ name = TalentName.Philosophie, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.BooteFahren, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Seefahrt, wert = +1},
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +1},
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
            subAdel.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwerter, wert = +1 });

            //Mods:
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

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
            subFern.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Armbrust, wert = +1 });
            var wahlArmbrust = new wahlmoeglichkeiten();
            wahlArmbrust.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
            };
            wahlArmbrust.talentWerte = new int[1];
            wahlArmbrust.talentWerte[0] = 1;
            wahlArmbrust.anzahlZuWaehlen = 1;
            subFern.wahlen.Add(wahlArmbrust);

            // Infi raus, Speere rein:
            subFern.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Speere, wert = +1 });

            // Fechtwaffen raus, Gassenwissen raus, Rechtskunde raus:
            subFern.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Fechtwaffen, wert = +1 });
            subFern.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Gassenwissen, wert = +2 });
            subFern.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

            // Mods:
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Raufen, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ringen, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = -1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +2 });


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
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Viehzucht},
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

            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });

            return subGebirge;
        }
        private subkultur createHorasSubHandel()
        {
            var subHandel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHandel.name = SubKulturName.AnEinerWichtigenHandelsroute;
            subHandel.generierungskosten = 5;

            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SagenUndLegenden, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FahrzeugLenken, wert = +1 });

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

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

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
            subAdel.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });

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

            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +2 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +2 });

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
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.Schwimmen, wert = +1});
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1});
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.Ueberreden, wert = +1});
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.FesselnUndEntfesseln, wert = +1});
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.FischenUndAngeln, wert = +1});
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.Geographie, wert = +1});
            subHafen.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.BooteFahren, wert = +1});
            subHafen.talentModifikatoren.Add( new talentIdentifier{ name = TalentName.Seefahrt, wert = +1});
            return subHafen;
        }
        private subkultur createHorasSubKeine()
        {
            var subKeine = createAlmadaSubKeine();

            // Wir ändern nur das, was unterschiedlich ist:
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Armbrust, wert = +1},
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Fechtwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Infanteriewaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Betoeren, wert = +1},
                new talentIdentifier{ name = TalentName.Etikette, wert = +2},
                new talentIdentifier{ name = TalentName.Gassenwissen, wert = +2},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +2},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.Mechanik, wert = +1},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier{ name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
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
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
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
            subAdel.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwerter, wert = +1 });

            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

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
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });

            return subGebirge;
        }
        private subkultur createAlmadaSubHandel()
        {
            var subHandel = createAlmadaSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subHandel.name = SubKulturName.AnEinerWichtigenHandelsroute;
            subHandel.generierungskosten = 4;

            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SagenUndLegenden, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FahrzeugLenken, wert = +1 });

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
            subAdel.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            // Talente:
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +2 });

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
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +2 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +2 });

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
            subYaq.talentModifikatoren.Add( new talentIdentifier{ name = TalentName.Schwimmen, wert = +1});
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            subYaq.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Fechtwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Infanteriewaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Saebel, wert = +1},
                new talentIdentifier{ name = TalentName.Reiten, wert = +2},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = +1},
                new talentIdentifier{ name = TalentName.Etikette, wert = +1},
                new talentIdentifier{ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.Geschichtswissen, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Abrichten, wert = +1},
                new talentIdentifier{ name = TalentName.Musizieren, wert = +1},
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +1},
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
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Winzer},
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

            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = -1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Skifahren, wert = +2 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Sinnesschaerfe, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Magiekunde, wert = +1 });
            // Pflanzenkunde raus, Magiekunde rein:
            subFluecht.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Pflanzenkunde, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Magiekunde, wert = +1 });

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

            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wettervorhersage, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FahrzeugLenken, wert = +1 });

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
            subKueste.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Bogen, wert = +1 });
            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.anzahlZuWaehlen = 1;
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = 1;
            wahlBogen.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Wurfbeile},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            subKueste.wahlen.Add(wahlBogen);

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wettervorhersage, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Holzbearbeitung, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });

            return subKueste;

        }
        private subkultur createSvelltSubKleinstadt()
        {
            var subKlein = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subKlein.name = SubKulturName.Kleinstaedte;
            subKlein.generierungskosten = 6;

            // Bogen raus, Wahl rein:
            subKlein.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Bogen, wert = +1 });
            var Wahlarmbrust = new wahlmoeglichkeiten();
            Wahlarmbrust.anzahlZuWaehlen = 1;
            Wahlarmbrust.talentWerte = new int[1];
            Wahlarmbrust.talentWerte[0] = 1;
            Wahlarmbrust.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            subKlein.wahlen.Add(Wahlarmbrust);

            // Speere raus, Wahl rein:
            subKlein.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Speere, wert = +1 });
            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.anzahlZuWaehlen = 1;
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = 1;
            wahlInfi.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            subKlein.wahlen.Add(wahlInfi);

            // Mods:
            subKlein.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = -1 });
            subKlein.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subKlein.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subKlein.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +1 });

            // Fallenstellen raus:
            subKlein.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });

            return subKlein;
        }
        private subkultur createSvelltSubStadt()
        {
            var subStadt = createSvelltSubKeine();
            // Wir ändern nur, was sich unterscheidet:
            subStadt.name = SubKulturName.Stadt;
            subStadt.generierungskosten = 7;

            // Speere raus, Infanterie rein:
            subStadt.talentModifikatoren.Remove(new talentIdentifier{ name = TalentName.Speere, wert = +1});
            subStadt.talentModifikatoren.Add(new talentIdentifier{ name = TalentName.Infanteriewaffen, wert = +1});
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Koerperbeherrschung, wert = -1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +1 });
            // Fallenstellen raus:
            subStadt.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });

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


            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Bogen, wert = +1},
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Speere, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Koerperbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier{ name = TalentName.Schwimmen, wert = +1},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = +1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier{ name = TalentName.Pflanzenkunde, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1},
                new talentIdentifier{ name = TalentName.Viehzucht, wert = +1},
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
            wahlBoote.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.Seefahrt},
            };
            subKeine.wahlen.Add(wahlBoote);

            // Wahl Handwerk:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 1;
            wahlHandwerk.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Toepfern},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Zimmermann},
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

            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Bogen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Zechen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Hauswirtschaft, wert = +1 });

            // Weitere Wahl:
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
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

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

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

            subLand.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Bogen, wert = +1 });
            subLand.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });
            subLand.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subLand.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });

            // Zusätzliche Wahl:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 1;
            wahlHandwerk.talentWerte = new int[1];
            wahlHandwerk.talentWerte[0] = 2;
            wahlHandwerk.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Toepfern},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
                new talentIdentifier(){ name = TalentName.Zimmermann},
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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Wurfmesser, wert = +1},
                new talentIdentifier{ name = TalentName.Tanzen, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = +2},
                new talentIdentifier{ name = TalentName.Etikette, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},

                new talentIdentifier{ name = TalentName.Ackerbau, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.Kochen, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1},
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
            subTesh.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +2 });
            subTesh.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +2 });
            subTesh.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });
            subTesh.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = +1 });
            subTesh.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Abrichten, wert = +2 });
            subTesh.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FahrzeugLenken, wert = +2 });

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
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +2 });

            // Neue Wahl: seefahrt / boote fahren:
            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.anzahlZuWaehlen = 1;
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = 2;
            wahlBoote.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.Seefahrt},
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
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });

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
            subAdel.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Speere, wert = +1 });
            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.anzahlZuWaehlen = 1;
            wahlSchwerter.talentWerte = new int[1];
            wahlSchwerter.talentWerte[0] = 1;
            wahlSchwerter.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
            };
            wahlSchwerter.identifier = "Schwerter";
            subAdel.wahlen.Add(wahlSchwerter);

            // Zu noch folgende Mods:
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +2 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

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
            subStadt.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Wurfspeere, wert = +1 });
            // Dafür gibt es Armbrust oder Bogen +1 als Wahl:
            var wahlArmbrust = new wahlmoeglichkeiten();
            wahlArmbrust.anzahlZuWaehlen = 1;
            wahlArmbrust.talentWerte = new int[1];
            wahlArmbrust.talentWerte[0] = 1;
            wahlArmbrust.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlArmbrust.identifier = "Armbrust";
            subStadt.wahlen.Add(wahlArmbrust);

            // Der Bonus auf Speere fällt hinaus:
            subStadt.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Speere, wert = +1 });
            // Dafür gibt es Infanteriewaffen dazu:
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Infanteriewaffen, wert = +1 });

            // Fallenstellen wird entfernt:
            subStadt.talentModifikatoren.Remove(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });

            // Und die folgenden Mods:
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subStadt.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = -1 });

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
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Speere, wert = +1},
                new talentIdentifier{ name = TalentName.Wurfspeere, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Schleichen, wert = +1},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.SichVerstecken, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = +1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.Fallenstellen, wert = +1},
                new talentIdentifier{ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +2},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},

                new talentIdentifier{ name = TalentName.Ackerbau, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +2},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1},
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
            wahlHandwerk.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Toepfern},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
                new talentIdentifier(){ name = TalentName.Zimmermann},
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

            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Selbstbeherrschung, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SichVerstecken, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Sinnesschaerfe, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Zechen, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = -1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Magiekunde, wert = +1 });

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
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Dolche, wert = -1 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Hiebwaffen, wert = +1 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Selbstbeherrschung, wert = +2 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Singen, wert = +2 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Zechen, wert = -1 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = -1 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = +2 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Pflanzenkunde, wert = +1 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +2 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +1 });
            subJilas.talentModifikatoren.Add(new talentIdentifier { name = TalentName.HeilkundeGift, wert = +1 });

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
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Reiten, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Heraldik, wert = +1 });
            subAdel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechtskunde, wert = +1 });

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
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = -1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = -1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Faehrtensuchen, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Orientierung, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wettervorhersage, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +2 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Pflanzenkunde, wert = +1 });
            subFern.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Tierkunde, wert = +1 });

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
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Athletik, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Klettern, wert = +1 });
            subGebirge.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });

            return subGebirge;
        }
        private subkultur createMittelLandSubWeiden()
        {
            var subWeiden = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subWeiden.name = SubKulturName.RegionenWeidenUndGreifenfurt;
            subWeiden.generierungskosten = 2;
            subWeiden.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Selbstbeherrschung, wert = +1 });
            subWeiden.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Fallenstellen, wert = +1 });
            subWeiden.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = +1 });
            subWeiden.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Viehzucht, wert = +1 });

            return subWeiden;
        }
        private subkultur createMittelLandSubHandel()
        {
            var subHandel = createMittelLandSubKeine();
            // Wir ändern nur das, was sich unterscheidet:
            subHandel.name = SubKulturName.AnWichtigerHandelsrouteOderReichsstrasse;
            subHandel.generierungskosten = 2;

            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Etikette, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SagenUndLegenden, wert = +1 });
            subHandel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FahrzeugLenken, wert = +1 });

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

            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = +2 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            subKueste.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

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
            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{ name = TalentName.Dolche, wert = +1},
                new talentIdentifier{ name = TalentName.Hiebwaffen, wert = +1},
                new talentIdentifier{ name = TalentName.Raufen, wert = +1},
                new talentIdentifier{ name = TalentName.Ringen, wert = +1},
                new talentIdentifier{ name = TalentName.Athletik, wert = +1},
                new talentIdentifier{ name = TalentName.Selbstbeherrschung, wert = +1},
                new talentIdentifier{ name = TalentName.Zechen, wert = +1},
                new talentIdentifier{ name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{ name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{ name = TalentName.Faehrtensuchen, wert = +1},
                new talentIdentifier{ name = TalentName.Wettervorhersage, wert = +1},
                new talentIdentifier{ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier{ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier{ name = TalentName.SagenUndLegenden, wert = +2},
                new talentIdentifier{ name = TalentName.Ackerbau, wert = +1},
                new talentIdentifier{ name = TalentName.HeilkundeWunden, wert = +1},
                new talentIdentifier{ name = TalentName.Holzbearbeitung, wert = +1},
                new talentIdentifier{ name = TalentName.Lederarbeiten, wert = +1},
                new talentIdentifier{ name = TalentName.Schneidern, wert = +1},
            };

            // Jetzt die Auswahlmöglichkeiten:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Wahl Infi/2HandHiebwaffen
            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.anzahlZuWaehlen = 1;
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = 1;
            wahlInfi.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlInfi.identifier = "Infi";
            subKeine.wahlen.Add(wahlInfi);

            // Wahl aus Handwerken: 2 aus der Liste!
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.anzahlZuWaehlen = 2;
            wahlHandwerk.talentWerte = new int[2];
            wahlHandwerk.talentWerte[0] = 2;
            wahlHandwerk.talentWerte[1] = 1;
            wahlHandwerk.talente = new List<talentIdentifier>() 
            { 
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Brauer},
                new talentIdentifier(){ name = TalentName.Fleischer},
                new talentIdentifier(){ name = TalentName.GerberUndKuerschner},
                new talentIdentifier(){ name = TalentName.Grobschmied},
                new talentIdentifier(){ name = TalentName.Kochen},
                new talentIdentifier(){ name = TalentName.Seiler},
                new talentIdentifier(){ name = TalentName.StoffeFaerben},
                new talentIdentifier(){ name = TalentName.Toepfern},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Webkunst},
                new talentIdentifier(){ name = TalentName.Winzer},
                new talentIdentifier(){ name = TalentName.Zimmermann},
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

            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Selbstbeherrschung, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.SichVerstecken, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Sinnesschaerfe, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Zechen, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = -1 });
            subFluecht.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Magiekunde, wert = +1 });

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
            subKanne.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subKanne.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subKanne.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subKanne.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Rechnen, wert = +1 });


            // Bei den Wahlmöglichkeiten wird die Auswahl der Sprachen entfernt,
            // da der Held eine Zweitsprache erhält!
            var myIndex = subKanne.wahlen.FindIndex(FindSprache);
            subKanne.wahlen.RemoveAt(myIndex);

            // Zu den Auswahlen kommt eine hinzu:
            var wahlTalentHandwerk = new wahlmoeglichkeiten();
            wahlTalentHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FischenUndAngeln},
                new talentIdentifier(){ name = TalentName.Kochen},
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
            subAdel.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{name = TalentName.Dolche, wert = +1},
                new talentIdentifier{name = TalentName.Infanteriewaffen, wert = +1},
                new talentIdentifier{name = TalentName.Raufen, wert = +1},
                new talentIdentifier{name = TalentName.Zechen, wert = +1},
                new talentIdentifier{name = TalentName.Etikette, wert = +3},
                new talentIdentifier{name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{name = TalentName.Heraldik, wert = +3},
                new talentIdentifier{name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier{name = TalentName.SagenUndLegenden, wert = +2},
            };

            // Die Wahlmöglichkeiten werden ergänzt um eine Wahl:
            var wahlTalentKampf2 = new wahlmoeglichkeiten();
            wahlTalentKampf2.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
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
            subSiedler.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Wildnisleben, wert = 1 });
            subSiedler.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ackerbau, wert = 1 });
            subSiedler.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Viehzucht, wert = 1 });

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
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = 2 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = 1 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geschichtswissen, wert = 1 });
            subTempel.talentModifikatoren.Add(new talentIdentifier { name = TalentName.GoetterUndKulte, wert = 2 });

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
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Schwimmen, wert = 1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Menschenkenntnis, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Ueberreden, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.FischenUndAngeln, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Geographie, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.BooteFahren, wert = +1 });
            subHafen.talentModifikatoren.Add(new talentIdentifier { name = TalentName.Seefahrt, wert = +1 });

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

            subKeine.talentModifikatoren = new List<talentIdentifier>()
            {
                new talentIdentifier{name = TalentName.Dolche, wert = +1},
                new talentIdentifier{name = TalentName.Infanteriewaffen, wert = +1},
                new talentIdentifier{name = TalentName.Raufen, wert = +1},
                new talentIdentifier{name = TalentName.Zechen, wert = +1},
                new talentIdentifier{name = TalentName.Etikette, wert = +1},
                new talentIdentifier{name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier{name = TalentName.Menschenkenntnis, wert = +1},
                new talentIdentifier{name = TalentName.Ueberreden, wert = +1},
                new talentIdentifier{name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier{name = TalentName.Heraldik, wert = +1},
                new talentIdentifier{name = TalentName.Rechnen, wert = +1},
                new talentIdentifier{name = TalentName.Rechtskunde, wert = +1},
                new talentIdentifier{name = TalentName.SagenUndLegenden, wert = +2},
            };

            // Wahl der Muttersprache:
            subKeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true });

            // Wir bereiten die Wahlmöglichkeiten vor:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            // Beginnen wir mit Der Wahl der Kampftalente:
            var wahlTalentKampf = new wahlmoeglichkeiten();
            wahlTalentKampf.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfmesser},
            };
            wahlTalentKampf.identifier = "ArmburstWahl";
            wahlTalentKampf.anzahlZuWaehlen = 1;
            wahlTalentKampf.talentWerte = new int[1];
            wahlTalentKampf.talentWerte[0] = 1;
            subKeine.wahlen.Add(wahlTalentKampf);

            // Nun die Wahl aus dem Handwerksbereich:
            var wahlHandwerk = new wahlmoeglichkeiten();
            wahlHandwerk.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
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
        public List<talentIdentifier> talentModifikatoren;

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

        /// <summary>
        /// Eine Liste von Zaubern, die für eine übernatürliche Begabung zur Verfügung stehen (Viertelzauber)
        /// </summary>
        public List<ZauberName> moeglicheUebernatuerlicheBegabungen;

        /// <summary>
        /// Mögliche Hauszauber (z.B. Elfen)
        /// </summary>
        public List<ZauberIdentifier> moeglicheHauszauber;

        /// <summary>
        /// Mögliche generelle Zauber.
        /// </summary>
        public List<ZauberIdentifier> moeglicheZauber;

    };


    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer Subkultur aufgelistet sein können:
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
        public List<talentIdentifier> talentwerte;
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


    /// <summary>
    /// Enthält Listen von Zauberauswahlen (z.B. für Elfensippen, etc.)
    /// </summary>
    public class zauberVorauswahlen
    {
        /// <summary>
        /// Gibt eine List mit allen möglichen Hauszaubern der Elfen zurück!
        /// </summary>
        /// <returns></returns>
        public List<ZauberIdentifier> GetElfenHauszauber()
        { 
            var elfenHauszauber = new List<ZauberIdentifier>()
            {
                new ZauberIdentifier(){ name = ZauberName.Abveneum},
                new ZauberIdentifier(){ name = ZauberName.Adlerauge},
                new ZauberIdentifier(){ name = ZauberName.Adlerschwinge},
                new ZauberIdentifier(){ name = ZauberName.Aeolitus},
                new ZauberIdentifier(){ name = ZauberName.Armatrutz},
                new ZauberIdentifier(){ name = ZauberName.Attributo},
                new ZauberIdentifier(){ name = ZauberName.Axxeleratus},
                new ZauberIdentifier(){ name = ZauberName.Balsam},
                new ZauberIdentifier(){ name = ZauberName.BandUndFessel},
                new ZauberIdentifier(){ name = ZauberName.Bannbaladin},
                new ZauberIdentifier(){ name = ZauberName.Baerenruhe},
                new ZauberIdentifier(){ name = ZauberName.BeherrschungBrechen},
                new ZauberIdentifier(){ name = ZauberName.BewegungStoeren},
                new ZauberIdentifier(){ name = ZauberName.BlickAufsWesen},
                new ZauberIdentifier(){ name = ZauberName.BlickInDieGedanken},
                new ZauberIdentifier(){ name = ZauberName.BlitzDichFind},
                new ZauberIdentifier(){ name = ZauberName.Chamaelioni},
                new ZauberIdentifier(){ name = ZauberName.EinflussBannen},
                new ZauberIdentifier(){ name = ZauberName.ExposamiLebenskraft},
                new ZauberIdentifier(){ name = ZauberName.FalkenaugeMeisterschuss},
                new ZauberIdentifier(){ name = ZauberName.FlimFlam},
                new ZauberIdentifier(){ name = ZauberName.Fulminictus},
                new ZauberIdentifier(){ name = ZauberName.Gedankenbilder},
                new ZauberIdentifier(){ name = ZauberName.Haselbusch},
                new ZauberIdentifier(){ name = ZauberName.HellsichtTrueben},
                new ZauberIdentifier(){ name = ZauberName.HilfreicheTatze},
                new ZauberIdentifier(){ name = ZauberName.KlarumPurum},
                new ZauberIdentifier(){ name = ZauberName.Kroetensprung},
                new ZauberIdentifier(){ name = ZauberName.LeibDerErde},
                new ZauberIdentifier(){ name = ZauberName.Motoricus},
                new ZauberIdentifier(){ name = ZauberName.Movimento},
                new ZauberIdentifier(){ name = ZauberName.Nebelwand},
                new ZauberIdentifier(){ name = ZauberName.Objectovoco},
                new ZauberIdentifier(){ name = ZauberName.Odem},
                new ZauberIdentifier(){ name = ZauberName.Penetrizzel},
                new ZauberIdentifier(){ name = ZauberName.PestilenzErspueren},
                new ZauberIdentifier(){ name = ZauberName.PfeilDesElements, auspraegung = Element.Luft},
                new ZauberIdentifier(){ name = ZauberName.PfeilDesElements, auspraegung = Element.Humus},
                new ZauberIdentifier(){ name = ZauberName.Plumbumbarum},
                new ZauberIdentifier(){ name = ZauberName.Respondami},
                new ZauberIdentifier(){ name = ZauberName.RuheKoerper},
                new ZauberIdentifier(){ name = ZauberName.Sanftmut},
                new ZauberIdentifier(){ name = ZauberName.SeidenzungeElfenwort},
                new ZauberIdentifier(){ name = ZauberName.Sensibar},
                new ZauberIdentifier(){ name = ZauberName.Silentium},
                new ZauberIdentifier(){ name = ZauberName.Solidirid},
                new ZauberIdentifier(){ name = ZauberName.Somnigravis},
                new ZauberIdentifier(){ name = ZauberName.SpurlosTrittlos},
                new ZauberIdentifier(){ name = ZauberName.Tiergedanken},
                new ZauberIdentifier(){ name = ZauberName.Traumgestalt},
                new ZauberIdentifier(){ name = ZauberName.Unitatio},
                new ZauberIdentifier(){ name = ZauberName.VerstaendigungStoeren},
                new ZauberIdentifier(){ name = ZauberName.Visibili},
                new ZauberIdentifier(){ name = ZauberName.Wasseratem},
                new ZauberIdentifier(){ name = ZauberName.WeisseMaehn},
                new ZauberIdentifier(){ name = ZauberName.Wellenlauf},
                new ZauberIdentifier(){ name = ZauberName.Windstille},
                new ZauberIdentifier(){ name = ZauberName.Zaubernahrung},
            };
            return elfenHauszauber;
        }

        /// <summary>
        /// Gibt eine Liste mit allen Basis-Zaubern der Elfen zurück!
        /// </summary>
        /// <returns></returns>
        public List<ZauberIdentifier> GetElfenBasisZauber()
        {
            var elfenBasisZauber = new List<ZauberIdentifier>()
            {
                new ZauberIdentifier(){ name = ZauberName.Abveneum},
                new ZauberIdentifier(){ name = ZauberName.Adlerauge},
                new ZauberIdentifier(){ name = ZauberName.Adlerschwinge},
                new ZauberIdentifier(){ name = ZauberName.Aeolitus},
                new ZauberIdentifier(){ name = ZauberName.Armatrutz},
                new ZauberIdentifier(){ name = ZauberName.Attributo},
                new ZauberIdentifier(){ name = ZauberName.Axxeleratus},
                new ZauberIdentifier(){ name = ZauberName.Balsam},
                new ZauberIdentifier(){ name = ZauberName.BandUndFessel},
                new ZauberIdentifier(){ name = ZauberName.Bannbaladin},
                new ZauberIdentifier(){ name = ZauberName.Baerenruhe},
                new ZauberIdentifier(){ name = ZauberName.BeherrschungBrechen},
                new ZauberIdentifier(){ name = ZauberName.BewegungStoeren},
                new ZauberIdentifier(){ name = ZauberName.BlickAufsWesen},
                new ZauberIdentifier(){ name = ZauberName.BlickInDieGedanken},
                new ZauberIdentifier(){ name = ZauberName.BlitzDichFind},
                new ZauberIdentifier(){ name = ZauberName.Chamaelioni},
                new ZauberIdentifier(){ name = ZauberName.Eigenschaft},
                new ZauberIdentifier(){ name = ZauberName.EinflussBannen},
                new ZauberIdentifier(){ name = ZauberName.ExposamiLebenskraft},
                new ZauberIdentifier(){ name = ZauberName.FalkenaugeMeisterschuss},
                new ZauberIdentifier(){ name = ZauberName.FlimFlam},
                new ZauberIdentifier(){ name = ZauberName.Fulminictus},
                new ZauberIdentifier(){ name = ZauberName.Gedankenbilder},
                new ZauberIdentifier(){ name = ZauberName.Haselbusch},
                new ZauberIdentifier(){ name = ZauberName.HellsichtTrueben},
                new ZauberIdentifier(){ name = ZauberName.HilfreicheTatze},
                new ZauberIdentifier(){ name = ZauberName.Motoricus},
                new ZauberIdentifier(){ name = ZauberName.Movimento},
                new ZauberIdentifier(){ name = ZauberName.Nebelwand},
                new ZauberIdentifier(){ name = ZauberName.Objectovoco},
                new ZauberIdentifier(){ name = ZauberName.Odem},
                new ZauberIdentifier(){ name = ZauberName.Penetrizzel},
                new ZauberIdentifier(){ name = ZauberName.PfeilDesElements, auspraegung = Element.Luft},
                new ZauberIdentifier(){ name = ZauberName.PfeilDesElements, auspraegung = Element.Humus},
                new ZauberIdentifier(){ name = ZauberName.Plumbumbarum},
                new ZauberIdentifier(){ name = ZauberName.Respondami},
                new ZauberIdentifier(){ name = ZauberName.RuheKoerper},
                new ZauberIdentifier(){ name = ZauberName.Sanftmut},
                new ZauberIdentifier(){ name = ZauberName.Sensibar},
                new ZauberIdentifier(){ name = ZauberName.Silentium},
                new ZauberIdentifier(){ name = ZauberName.Solidirid},
                new ZauberIdentifier(){ name = ZauberName.Somnigravis},
                new ZauberIdentifier(){ name = ZauberName.SpurlosTrittlos},
                new ZauberIdentifier(){ name = ZauberName.Tiergedanken},
                new ZauberIdentifier(){ name = ZauberName.Unitatio},
                new ZauberIdentifier(){ name = ZauberName.VerstaendigungStoeren},
                new ZauberIdentifier(){ name = ZauberName.Visibili},
                new ZauberIdentifier(){ name = ZauberName.Wasseratem},
                new ZauberIdentifier(){ name = ZauberName.Windstille},
            };

            return elfenBasisZauber;
        }

    };

}
