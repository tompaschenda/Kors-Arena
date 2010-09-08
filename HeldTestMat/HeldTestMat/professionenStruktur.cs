using System.Collections.Generic;
using listenStruktur;
using Common;
using Listen;
using professionenStruktur;
using System;
using System.Linq;
using System.Text;
using sfStruktur;
using vorteileStruktur;
using nachteileStruktur;
using zauberStruktur;
using talentStruktur;
using spielerAuswahl;
using SprachenUndSchriften;

namespace professionenStruktur
{
    //////////////////////////////////////
    //  Professionsstruktur. TODO: Ausgliedern!
    //////////////////////////////////////


    /// <summary>
    /// Eine Struktur, die lediglich ALLE Attribute enthält, mit denen sich eine Profession
    /// mit ALLEN Ausprägungen EINDEUTIG identifizieren lässt.
    /// </summary>
    public struct ProfessionsIdentifier
    {
        /// <summary>
        ///  Name eines Zaubers
        /// </summary>
        public ProfessionsName name;

        /// <summary>
        /// Subprofession
        /// </summary>
        public SubProfessionsName subname;
    };



    /// <summary>
    /// Versschiedenen Kategorien von Professionen inklusive aller zugehörigen Professionen.
    /// </summary>
    public class ProfessionsKategorien
    {
        /// <summary>
        /// Gibt ALLE Professionen zurück:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetAlle()
        {
            var alleProfs = new List<ProfessionsIdentifier>() { };
            alleProfs.AddRange(GetKriegerische());
            alleProfs.AddRange(GetReisende());
            alleProfs.AddRange(GetGesellschaft());
            alleProfs.AddRange(GetHandwerk());
            alleProfs.AddRange(GetMagisch());
            alleProfs.AddRange(GetKlerikal());
            return alleProfs;
        }

        /// <summary>
        /// Gibt nur zwölfgöttliche Geweihte Professionen zurück:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetZwoelfgoetterkulte()
        {
            var zwoelfeProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPraios},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerRondra},
                new ProfessionsIdentifier(){ name = ProfessionsName.RondrageweihteAmazone},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesEfferd},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTravia},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronAlAnfanerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronPuninerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerHesinde},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesFirun},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTsa},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPhex},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerPeraine},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesIngerimm},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihteDerRahja},
                new ProfessionsIdentifier(){ name = ProfessionsName.PredigerVomBundDesWahrenGlaubens},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAves},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesKor},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesNandus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerIfirn},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesSwafnir},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAngrosch},
            };
            return zwoelfeProfs;
        }

        /// <summary>
        ///  Alle Gesellschaftlichen Professionen
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetKriegerische()
        {
            var kriegerischeProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Amazone},            
                new ProfessionsIdentifier(){ name = ProfessionsName.Faehnrich},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gladiator},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schaukaempfer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gardist},
                new ProfessionsIdentifier(){ name = ProfessionsName.Jahrmarktskaempfer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Krieger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Ritter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schwertgeselle},
                new ProfessionsIdentifier(){ name = ProfessionsName.Soldat},
                new ProfessionsIdentifier(){ name = ProfessionsName.Soeldner},
                new ProfessionsIdentifier(){ name = ProfessionsName.Stammeskrieger}
            };
    
            return kriegerischeProfs;
        }

        /// <summary>
        /// Alle Reisenden Professionen
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetReisende()
        {
            var reisendeProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Botenreiter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Entdecker},
                new ProfessionsIdentifier(){ name = ProfessionsName.Fernhaendler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Fischer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Fuhrmann},
                new ProfessionsIdentifier(){ name = ProfessionsName.Grenzjaeger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Großwildjaeger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hirte},
                new ProfessionsIdentifier(){ name = ProfessionsName.Jaeger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Karawanenfuehrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kundschafter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Prospektor},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schiffer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schmuggler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Seefahrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Straßenraeuber}
            };
            return reisendeProfs;
        }

        /// <summary>
        ///  Alle Gesellschaftlichen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetGesellschaft()
        {
            var gesellschaftProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Ausrufer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Barde},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bettler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Dieb},
                new ProfessionsIdentifier(){ name = ProfessionsName.Einbrecher},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gaukler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Haendler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Herold},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hofkuenstler},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hoefling},
                new ProfessionsIdentifier(){ name = ProfessionsName.KurtisaneGesellschafter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Privatlehrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schriftsteller},
                new ProfessionsIdentifier(){ name = ProfessionsName.Spitzel},
                new ProfessionsIdentifier(){ name = ProfessionsName.Streuner},
                new ProfessionsIdentifier(){ name = ProfessionsName.Taugenichts},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wirt},
            };

            return gesellschaftProfs;
        }

        /// <summary>
        ///  Alle handwerklichen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetHandwerk()
        {
            var handwerkProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Bader},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bauer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bergmann},
                new ProfessionsIdentifier(){ name = ProfessionsName.Domestik},
                new ProfessionsIdentifier(){ name = ProfessionsName.Edelhandwerker},
                new ProfessionsIdentifier(){ name = ProfessionsName.Gelehrter},
                new ProfessionsIdentifier(){ name = ProfessionsName.Handwerker},
                new ProfessionsIdentifier(){ name = ProfessionsName.Rattenfaenger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schreiber},
                new ProfessionsIdentifier(){ name = ProfessionsName.Tageloehner},
                new ProfessionsIdentifier(){ name = ProfessionsName.Tierbaendiger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wundarzt}
            };

            return handwerkProfs;
        }

        /// <summary>
        /// Alle magischen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetMagisch()
        {
            var magischProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.Alchimist},
                new ProfessionsIdentifier(){ name = ProfessionsName.MagiebegabterAlchimist},
                new ProfessionsIdentifier(){ name = ProfessionsName.Derwisch},
                new ProfessionsIdentifier(){ name = ProfessionsName.Druide},
                new ProfessionsIdentifier(){ name = ProfessionsName.DurroDun},
                new ProfessionsIdentifier(){ name = ProfessionsName.Bewahrer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Former},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kaempfer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Legendensaenger},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wildnislaeufer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Zauberweber},
                new ProfessionsIdentifier(){ name = ProfessionsName.Wanderer},
                new ProfessionsIdentifier(){ name = ProfessionsName.FerkinaBesessener},
                new ProfessionsIdentifier(){ name = ProfessionsName.Geode},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hexe},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kristallomant},
                new ProfessionsIdentifier(){ name = ProfessionsName.Magier},
                new ProfessionsIdentifier(){ name = ProfessionsName.Scharlatan},
                new ProfessionsIdentifier(){ name = ProfessionsName.Taenzer},
                new ProfessionsIdentifier(){ name = ProfessionsName.Schelm},
                new ProfessionsIdentifier(){ name = ProfessionsName.Zibilja}
            };
            return magischProfs;
        }

        /// <summary>
        /// Alle klerikalen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsIdentifier> GetKlerikal()
        {
            var klerikaleProfs = new List<ProfessionsIdentifier>()
            {
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPraios},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerRondra},
                new ProfessionsIdentifier(){ name = ProfessionsName.RondrageweihteAmazone},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesEfferd},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTravia},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronAlAnfanerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesBoronPuninerRitus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerHesinde},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesFirun},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerTsa},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesPhex},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerPeraine},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesIngerimm},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihteDerRahja},
                new ProfessionsIdentifier(){ name = ProfessionsName.PredigerVomBundDesWahrenGlaubens},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAves},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesKor},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesNandus},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDerIfirn},
                new ProfessionsIdentifier(){ name = ProfessionsName.HorasRitter},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesSwafnir},
                new ProfessionsIdentifier(){ name = ProfessionsName.GeweihterDesAngrosch},
                new ProfessionsIdentifier(){ name = ProfessionsName.PriesterDerHSzint},
                new ProfessionsIdentifier(){ name = ProfessionsName.PriesterDerZsahh},
                new ProfessionsIdentifier(){ name = ProfessionsName.PriesterVonRurUndGror},
                new ProfessionsIdentifier(){ name = ProfessionsName.StammeskriegerDerBeniDervez},
                new ProfessionsIdentifier(){ name = ProfessionsName.Hadjinim},
                new ProfessionsIdentifier(){ name = ProfessionsName.Medizinmann},
                new ProfessionsIdentifier(){ name = ProfessionsName.Kaskjua},
                new ProfessionsIdentifier(){ name = ProfessionsName.Nuranshar},
                new ProfessionsIdentifier(){ name = ProfessionsName.BrenochDun},
                new ProfessionsIdentifier(){ name = ProfessionsName.Skuldrun},
                new ProfessionsIdentifier(){ name = ProfessionsName.Shochzul},
                new ProfessionsIdentifier(){ name = ProfessionsName.TairachPriester},
                new ProfessionsIdentifier(){ name = ProfessionsName.GraveshPriester},
                new ProfessionsIdentifier(){ name = ProfessionsName.RikaiPriester},
                new ProfessionsIdentifier(){ name = ProfessionsName.GoblinSchamanin},
                new ProfessionsIdentifier(){ name = ProfessionsName.SchamaneDerAchaz},

            };
            return klerikaleProfs;

        }         
    }

    /// <summary>
    /// Struktur, die alle Professionen in Aventurien enthält:
    /// </summary>
    public struct professionenStruct
    {
        // Wir listen nun auf, welche Attribute eine Profession hat:

        /// <summary>
        /// Identifier der Profession
        /// </summary>
        public ProfessionsName profession;

        /// <summary>
        /// Eine Liste mit allen möglichen Subprofessionen. Gibt es keine
        /// Subprofessionen, wird die Subprofession "keine" gesetzt.
        /// Die Variante besimmt GP-Kosten, Talente, Modifikatoren,
        /// etc. Und muss beim Auswählen einer Profession immer mit angegeben werden.
        /// </summary>
        public List<subprofession> moeglicheSubprofessionen;


        /// <summary>
        /// Der Identifier dieser Kultur. Der Setter definiert die Attribute der Kultur
        /// </summary>        
        public ProfessionsName Profession
        {
            get
            {
                return profession;
            }

            set
            {
                try
                {

                    switch (value)
                    {

                        ///////////////////////////////////////
                        // Amazone
                        ///////////////////////////////////////
                        case ProfessionsName.Amazone:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createAmazoneSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Fähnrich
                        ///////////////////////////////////////
                        case ProfessionsName.Faehnrich:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussAlAnfa());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussAlbenhus());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussFestum());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussGareth());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussOberfels());
                            moeglicheSubprofessionen.Add(createFaehnrichSubFussHoningen());
                            moeglicheSubprofessionen.Add(createFaehnrichSubKavKeine());
                            moeglicheSubprofessionen.Add(createFaehnrichSubKavRagath());
                            moeglicheSubprofessionen.Add(createFaehnrichSubStabKeine());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeKeine());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeHarben());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeAlAnfa());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeFestum());
                            break;

                        default:
                            throw new System.ArgumentOutOfRangeException();
                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Ungültige Profession angegeben!");
                }
            }
        }



        private subprofession createFaehnrichSubSeeFestum()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubSeeAlAnfa()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubSeeHarben()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubSeeKeine()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubStabKeine()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubKavRagath()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubKavKeine()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussHoningen()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussOberfels()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussGareth()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussFestum()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussAlbenhus()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussAlAnfa()
        {
            throw new NotImplementedException();
        }

        private subprofession createFaehnrichSubFussKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>() 
            { 
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +3;
            subkeine.soInterval = new Range() { lower = 7, upper = 11 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = +10},
                // TOCHECK: In Dukaten!
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1500},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Gesucht},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust, wert = +3},
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +4},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +4},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +4},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +5},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geographie, wert = +2},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +3},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +6},
                new talentIdentifier(){ name = TalentName.Magiekunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
            };

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Formation},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            // Wahl:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlFecht = new wahlmoeglichkeiten() { };
            wahlFecht.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Fechtwaffen},
                 new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +5;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlHieb = new wahlmoeglichkeiten() { };
            wahlHieb.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Hiebwaffen},
                 new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlInfi = new wahlmoeglichkeiten() { };
            wahlInfi.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                 new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +3;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            return subkeine;
        }

        private subprofession createAmazoneSubKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.generierungskosten = 10;
            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen(){ };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>() 
            { 
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };
            subkeine.voraussetzungen.geschlechtstyp = GeschlechtNamen.weiblich;

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +3;
            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildung, auspraegung = AkademischeAusbilung.Krieger},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile, auspraegung = Vorurteile.Maenner},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Feenfreund},
                new VorteilsIdentifier(){ name = VorteileName.Koboldfreund},
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            // Talente:
            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +1},
                new talentIdentifier(){ name = TalentName.Lanzenreiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Speere, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +4},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +1},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +1},
            };


            // SF:
            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Klingensturm},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schnellziehen},
            };

            // Wahl:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlNachteil = new wahlmoeglichkeiten() { };
            wahlNachteil.nachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, wert = +12},
                new NachteilsIdentifier(){ name = NachteileName.Moralkodex, auspraegung = Moralcodices.Rondrakirche},
            };
            wahlNachteil.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlNachteil);

            var wahlKampf = new wahlmoeglichkeiten() { };
            wahlKampf.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Saebel},
                 new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlKampf.talentWerte = new int[1];
            wahlKampf.talentWerte[0] = +3;
            wahlKampf.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKampf);

            return subkeine;
        }

    }

    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer SF aufgelistet sein können:
    /// </summary>
    public struct professionsVorausssetzungen
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
        public List<sfIdentifier> andereSF;
        /// <summary>
        /// Beschreibt, welches Geschlecht ein Held/eine Helden haben muss, um die Profession
        /// ausüben zu können. "männlich", "weiblich", "beide"
        /// Ist z.B. wichtig für: Amazonen
        /// </summary>
        public GeschlechtNamen geschlechtstyp;
    };

    /// <summary>
    /// Eine Struktur mit allen Attributen, die eine Profession ausmachen!
    /// </summary>
    public struct subprofession
    {
        /// <summary>
        /// Name der Subprofession
        /// </summary>
        public SubProfessionsName name;

        /// <summary>
        /// Typ der Profession (z.B. "kämpferisch", "reisend", etc.
        /// </summary>
        public ProfessionsTyp professionenTyp;

        /// <summary>
        /// Generierungskosten in GP. Eine Profession kann nur bei der Generierung gewählt werden
        /// </summary>
        public int generierungskosten;

        /// <summary>
        /// Gibt an, ob es sich um eine zeitaufwändige Profession handelt oder nicht.
        /// </summary>
        public bool zeitaufwaendig;

        /// <summary>
        /// Struktur, die alle Voraussetzungen enthält, die für das Erlernen einer Profession erfüllt sein müssen (s.u.)
        /// </summary>
        public professionsVorausssetzungen voraussetzungen;

        /// <summary>
        /// Der Professionsmodifikator auf die LE
        /// </summary>
        public int leModifikator;
        /// <summary>
        /// Der Professionsmodifikator auf die Ausdauer
        /// </summary>
        public int auModifikator;
        /// <summary>
        /// Der Professionsmodifikator auf die Magieresistenz
        /// </summary>
        public int mrModifikator;

        /// <summary>
        /// Der Professionsmodifikator auf die Eigenschaften inklusive Name der Eigenschaft
        /// </summary>
        public List<GenericListenNameWertPaar<EigenschaftenName>> eigenschaftsModifikationen;

        /// <summary>
        /// Das Interval, in dem sich der Sozialstatus bewegen muss, damit man die Profession ausüben / erlernen kann.
        /// Der Held bekommt AUTOMATISCH den Minimalwert aus der Profession gutgeschrieben und KANN ihn nachträglich bis
        /// zum Maximum erhöhen. Dabei muss aber beachtet werden, dass Kulturen ein SO-Maximum aufweisen, das dennoch
        /// nicht überschritten werden darf! Ein Held, der durch die Rasse ein SO-Maximum von 3 hat, kann z.B. kein
        /// "Fähnrich" werden.
        /// </summary>
        public Range soInterval;

        /// <summary>
        /// Automatische Vorteile durch die Profession inklusive Wert.
        /// </summary>
        public List<VorteilsIdentifier> automatischeVorteile;
        /// <summary>
        /// Automatische Nachteile durch die Profession inklusive Wert.
        /// </summary>
        public List<NachteilsIdentifier> automatischeNachteile;
        /// <summary>
        /// Empfohlene Vorteile durch die Profession (nicht bindend).
        /// </summary>
        public List<VorteilsIdentifier> empfohleneVorteile;
        /// <summary>
        /// Empfohlene Nachteile durch die Profession (nicht bindend).
        /// </summary>
        public List<NachteilsIdentifier> empfohleneNachteile;
        /// <summary>
        /// Ungeeignete Vorteile für die Profession (sollte bindend sein).
        /// </summary>
        public List<VorteilsIdentifier> ungeeigneteVorteile;
        /// <summary>
        /// Ungeeignete Nachteile für die Profession (sollte bindend sein).
        /// </summary>
        public List<NachteilsIdentifier> ungeeigneteNachteile;

        /// <summary>
        /// Liste von Talenten und Modifikatoren, die man durch die Profession erhält.
        /// </summary>
        public List<talentIdentifier> talente;

        /// <summary>
        /// Liste von Sonderfertigkeiten, die man durch die Profession erhält.
        /// </summary>
        public List<sfIdentifier> sonderfertigkeiten;

        /// <summary>
        /// Liste von Sonderfertigkeiten, die man durch die Profession verbilligt kaufen kann:
        /// </summary>
        public List<sfIdentifier> verbilligteSF;

        /// <summary>
        /// Eine Liste, die alle Zauberfertigkeiten und Spezialisierungen enthält, die durch die Rasse
        /// gegeben werden.
        /// </summary>
        public List<ZauberIdentifier> zauberfertigkeiten;

        /// <summary>
        /// Eine Liste von verschiedenen Auswahlen für Vorteile, Talente, etc.
        /// </summary>
        public List<wahlmoeglichkeiten> wahlen;

        /// <summary>
        /// Sprachen, die mit der Profession verknüpft sind:
        /// (kann auch sein, dass sie erst zwischen mehreren gewählt werden muss!)
        /// </summary>
        public List<SprachenIdentifier> sprachen;

        /// <summary>
        /// Eine Liste aller Schriften, die man durch die Profession kennt:
        /// </summary>
        public List<SchriftenIdentifier> schriften;

    };

}