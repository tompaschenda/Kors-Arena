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

        private subkultur createSvelltSubFluecht()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createSvelltSubFern()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createSvelltSubKueste()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createSvelltSubKleinstadt()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createSvelltSubStadt()
        {
            throw new System.NotImplementedException();
        }

        private subkultur createSvelltSubKeine()
        {
            throw new System.NotImplementedException();
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
            subKeine.sprachen = new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true };

            // Jetzt die Auswahlmöglichkeiten:
            subKeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlSprache = new wahlmoeglichkeiten();
            wahlSprache.sprachen = new List<SprachenName>()
            {
                SprachenName.Alaani, SprachenName.Nujuka,
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
            subKeine.sprachen = new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true };

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
            wahlSprache.sprachen = new List<SprachenName>()
            {
                SprachenName.OrkischOloarkh, SprachenName.OrkischOloghaijan, SprachenName.Thorwalsch,
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
            subFluecht.wahlen[myIndex].sprachen.Add(SprachenName.Zhayad);
            subFluecht.wahlen[myIndex].sprachen.Add(SprachenName.Zhulchammaqra);

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
            subFern.wahlen[myIndex].sprachen.Add(SprachenName.Nujuka);
            subFern.wahlen[myIndex].sprachen.Add(SprachenName.OrkischOloarkh);
            subFern.wahlen[myIndex].sprachen.Add(SprachenName.Goblinisch);

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
            wahlSprache.sprachen = new List<SprachenName>()
            {
                SprachenName.Tulamidya, SprachenName.Rogolan, SprachenName.Isdira, SprachenName.Thorwalsch
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
            wahlSprache.sprachen = new List<SprachenName>()
            {
                SprachenName.Tulamidya, SprachenName.Rogolan, SprachenName.Isdira, SprachenName.Thorwalsch
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
            subKeine.sprachen = new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true };

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
            subFluecht.wahlen[myIndex].sprachen.Add(SprachenName.Zhayad);
            subFluecht.wahlen[myIndex].sprachen.Add(SprachenName.Zhulchammaqra);

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
            subKanne.sprachen = new SprachenIdentifier() { name = SprachenName.Tulamidya, zweitsprache = true };

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
            wahlSprache.sprachen = new List<SprachenName>()
            {
               SprachenName.Nujuka, SprachenName.Alaani, SprachenName.OrkischOloarkh
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
            wahlSprache.sprachen = new List<SprachenName>()
            {
                SprachenName.Tulamidya, SprachenName.Rogolan, SprachenName.Thorwalsch
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
            subKeine.sprachen = new SprachenIdentifier() { name = SprachenName.Garethi, muttersprache = true };

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
            wahlSprache.sprachen = new List<SprachenName>()
            {
                SprachenName.Tulamidya, SprachenName.Rogolan, SprachenName.Thorwalsch
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
        public SprachenIdentifier sprachen;

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



