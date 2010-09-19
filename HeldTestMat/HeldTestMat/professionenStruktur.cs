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
                            moeglicheSubprofessionen.Add(createFaehnrichSubStabWehrheim());
                            moeglicheSubprofessionen.Add(createFaehnrichSubStabVinsalt());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeKeine());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeHarben());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeAlAnfa());
                            moeglicheSubprofessionen.Add(createFaehnrichSubSeeFestum());
                            break;
                        ///////////////////////////////////////
                        // Gladiator
                        ///////////////////////////////////////
                        case ProfessionsName.Gladiator:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGladiatorFasar());
                            moeglicheSubprofessionen.Add(createGladiatorAlanfa());
                            break;
                        ///////////////////////////////////////
                        // Schaukämpfer
                        ///////////////////////////////////////
                        case ProfessionsName.Schaukaempfer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createSchauSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Gardist
                        ///////////////////////////////////////
                        case ProfessionsName.Gardist:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createGardistSubStadt());
                            moeglicheSubprofessionen.Add(createGardistSubDorf());
                            moeglicheSubprofessionen.Add(createGardistSubStrasse());
                            moeglicheSubprofessionen.Add(createGardistSubSchliesser());
                            moeglicheSubprofessionen.Add(createGardistSubAkademie());
                            moeglicheSubprofessionen.Add(createGardistSubSippe());
                            break;
                        ///////////////////////////////////////
                        // Jahrmarktskämpfer
                        ///////////////////////////////////////
                        case ProfessionsName.Jahrmarktskaempfer:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createJahrSubKeine());
                            break;
                        ///////////////////////////////////////
                        // Krieger
                        ///////////////////////////////////////
                        case ProfessionsName.Krieger:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createKriegerSubStandard());
                            moeglicheSubprofessionen.Add(createKriegerSubArivor());
                            moeglicheSubprofessionen.Add(createKriegerSubBaburin());
                            moeglicheSubprofessionen.Add(createKriegerSubBaliho());
                            moeglicheSubprofessionen.Add(createKriegerSubElenvina());
                            moeglicheSubprofessionen.Add(createKriegerSubEslamsgrund());
                            moeglicheSubprofessionen.Add(createKriegerSubGareth());
                            moeglicheSubprofessionen.Add(createKriegerSubHavena());
                            moeglicheSubprofessionen.Add(createKriegerSubHyl());
                            moeglicheSubprofessionen.Add(createKriegerSubMeng());
                            moeglicheSubprofessionen.Add(createKriegerSubNeer());
                            moeglicheSubprofessionen.Add(createKriegerSubPrem());
                            moeglicheSubprofessionen.Add(createKriegerSubPunin());
                            moeglicheSubprofessionen.Add(createKriegerSubRommi());
                            moeglicheSubprofessionen.Add(createKriegerSubThorwal());
                            moeglicheSubprofessionen.Add(createKriegerSubVinsalt());
                            moeglicheSubprofessionen.Add(createKriegerSubWinhall());
                            moeglicheSubprofessionen.Add(createKriegerSubXorlosch());
                            break;
                        ///////////////////////////////////////
                        // Ritter
                        ///////////////////////////////////////
                        case ProfessionsName.Ritter:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
                            moeglicheSubprofessionen.Add(createRitterSubkeine());
                            moeglicheSubprofessionen.Add(createRitterSubAlt());
                            moeglicheSubprofessionen.Add(createRitterSubKnappe());
                            moeglicheSubprofessionen.Add(createRitterSubKnappeTradi());
                            break;
                        ///////////////////////////////////////
                        // Schwertgeselle
                        ///////////////////////////////////////
                        case ProfessionsName.Schwertgeselle:
                            profession = value;
                            moeglicheSubprofessionen = new List<subprofession>();
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

        private subprofession createSchwertBasis()
        {
            throw new NotImplementedException();
        }

        private subprofession createRitterSubKnappeTradi()
        {
            var subkeine = createRitterSubkeine();

            subkeine.generierungskosten = 12;
            subkeine.name = SubProfessionsName.KnappeDesTraditionellenRitters;

            subkeine.zeitaufwaendig = false;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +6;
            wahlAndert.talentWerte[1] = +3;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = -2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},              
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createRitterSubKnappe()
        {
            var subkeine = createRitterSubkeine();

            subkeine.generierungskosten = 11;
            subkeine.name = SubProfessionsName.Knappe;

            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.zeitaufwaendig = false;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +6;
            wahlAndert.talentWerte[1] = +3;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +1;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = -2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},            
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createRitterSubAlt()
        {
            var subkeine =createRitterSubkeine();

            subkeine.generierungskosten = 21;
            subkeine.name = SubProfessionsName.RitterAltenSchlags;

            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +7;
            wahlAndert.talentWerte[1] = +4;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +1;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);


            var wahlStaat = new wahlmoeglichkeiten();
            wahlStaat.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Staatskunst},
                new talentIdentifier(){ name = TalentName.Tierkunde},
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
            };
            wahlStaat.talentWerte = new int[1];
            wahlStaat.talentWerte[0] = +3;
            wahlStaat.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlStaat);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Staatskunst, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Musizieren, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subkeine.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Befreiungsschlag });

            return subkeine;
        }
        private subprofession createRitterSubkeine()
        {
            var subkeine = new subprofession() { };

            subkeine.name = SubProfessionsName.keine;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.zeitaufwaendig = true;

            subkeine.generierungskosten = 21;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +2;
            subkeine.soInterval = new Range() { lower = 8, upper = 13 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ritterkodex, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SchutzDerSchwachen, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SchutzDesGlaubens, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Lehnsherr},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Schuztbefohlenen},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Ausrüstungsvorteil},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Vorurteile},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Einhaendig},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[2];
            wahlAndert.talentWerte[0] = +7;
            wahlAndert.talentWerte[1] = +4;
            wahlAndert.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAndert);

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Lanzenreiten, wert = +7},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +3},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +7},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +5},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +5},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +3},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
            };

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},                
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
            };

            return subkeine;
        }

        private subprofession createKriegerSubXorlosch()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieXorlosch;
            subkeine.generierungskosten = 18;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.kultur = new List<KulturName>()
            { 
                KulturName.Ambosszwerge, KulturName.Erzzwerge, KulturName.Huegelzwerge, 
                KulturName.Brillantzwerge, KulturName.Brobim,
            };

            subkeine.voraussetzungen.Rasse = new List<SpielerRassenName>()
            {
                SpielerRassenName.Zwerg
            };

            subkeine.leModifikator = subkeine.leModifikator + 1;

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() 
            { 
                name = NachteileName.Einbildungen 
            });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() 
            { 
                name = NachteileName.Vorurteile, auspraegung = Vorurteile.Echsen, wert = +6 
            });
            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() 
            { 
                name = NachteileName.Weltfremd, auspraegung = Weltfremd.MenschlicheAnsiedlungen, wert = +5 
            });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Reiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +4 });

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.Rogolan, wert = +4 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Kriegskunst, subAuspraegung = TalentSpezialisierung.KampfGegenDrachen},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Magiekunde, subAuspraegung = TalentSpezialisierung.Drachenmagie},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Tierkunde, subAuspraegung = TalentSpezialisierung.Drachen},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Hammerschlag},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Spiessgespann},
                new sfIdentifier(){ name = SFNamen.Sturmangriff},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[2];
            wahlInfi.talentWerte[0] = +5;
            wahlInfi.talentWerte[1] = +2;
            wahlInfi.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlInfi);

            var wahlKette = new wahlmoeglichkeiten();
            wahlKette.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
            };
            wahlKette.talentWerte = new int[1];
            wahlKette.talentWerte[0] = +3;
            wahlKette.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKette);

            return subkeine;
        }
        private subprofession createKriegerSubWinhall()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieWinhall;
            subkeine.generierungskosten = 24;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });

            return subkeine;
        }
        private subprofession createKriegerSubVinsalt()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieVinsalt;
            subkeine.generierungskosten = 21;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.leModifikator = +1;

            subkeine.soInterval = new Range() { lower = 9, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Fechtwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Meisterparade},
            };

            return subkeine;
        }
        private subprofession createKriegerSubThorwal()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieThorwal;
            subkeine.generierungskosten = 25;

            subkeine.soInterval = new Range() { lower = 5, upper = 11 };

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.kultur.Add(KulturName.Thorwal);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfspeere, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +2 });

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSchwerter = new wahlmoeglichkeiten();
            wahlSchwerter.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
            };
            wahlSchwerter.talentWerte = new int[2];
            wahlSchwerter.talentWerte[0] = +6;
            wahlSchwerter.talentWerte[1] = +3;
            wahlSchwerter.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlSchwerter);

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.HjaldingscheRunen, wert = +4 });

            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, modifikator = +2 });

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createKriegerSubRommi()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieRommilys;
            subkeine.generierungskosten = 19;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = -1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausfall},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LangesKettenhemd},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Meisterparade},
            };

            return subkeine;
        }
        private subprofession createKriegerSubPunin()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademiePunin;
            subkeine.generierungskosten = 21;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            return subkeine;
        }
        private subprofession createKriegerSubPrem()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademiePrem;
            subkeine.generierungskosten = 19;

            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfbeile, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +2 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = -1 });

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = +2 });
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.HjaldingscheRunen, wert = +4 });

            subkeine.sprachen = new List<SprachenIdentifier>() { };
            subkeine.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Garethi, modifikator = +3 });

            var wahlSchwert = new wahlmoeglichkeiten();
            wahlSchwert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSchwert.talentWerte = new int[1];
            wahlSchwert.talentWerte[0] = +4;
            wahlSchwert.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchwert);

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Aufmerksamkeit });

            return subkeine;
        }
        private subprofession createKriegerSubNeer()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieNeersand;
            subkeine.generierungskosten = 20;

            subkeine.voraussetzungen.vorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
            };
            subkeine.voraussetzungen.kultur.Add(KulturName.Bornland);

            subkeine.auModifikator = subkeine.auModifikator +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wurfmesser, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Skifahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kochen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schneidern, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            return subkeine;
        }
        private subprofession createKriegerSubMeng()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieMengbilla;
            subkeine.generierungskosten = 19;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Totenangst });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kettenwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Peitsche, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anatomie, wert = +1});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            return subkeine;
        }
        private subprofession createKriegerSubHyl()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieHylailos;
            subkeine.generierungskosten = 21;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };
            subkeine.voraussetzungen.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unansehnlich},
                new NachteilsIdentifier(){ name = NachteileName.WiderwaertigesAussehen},
            };

            subkeine.leModifikator = +1;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +3});
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Philosophie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = -2 });

            var wahlSchwert = new wahlmoeglichkeiten();
            wahlSchwert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlSchwert.talentWerte = new int[1];
            wahlSchwert.talentWerte[0] = +2;
            wahlSchwert.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchwert);

            var wahlSingen = new wahlmoeglichkeiten();
            wahlSingen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Singen},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlSingen.talentWerte = new int[1];
            wahlSingen.talentWerte[0] = +1;
            wahlSingen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSingen);

            var wahlBrett = new wahlmoeglichkeiten();
            wahlBrett.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen},
            };
            wahlBrett.talentWerte = new int[1];
            wahlBrett.talentWerte[0] = +2;
            wahlBrett.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBrett);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.KurzesKettenhemd},
            };

            return subkeine;
        }
        private subprofession createKriegerSubHavena()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieHavena;
            subkeine.generierungskosten = 24;

            subkeine.soInterval = new Range() { lower = 8, upper = 13 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            return subkeine;
        }
        private subprofession createKriegerSubGareth()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieGareth;
            subkeine.generierungskosten = 25;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Gewandtheit, wert = +13 });

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Bogen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +3 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},
            };

            return subkeine;
        }
        private subprofession createKriegerSubEslamsgrund()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieEslamsgrund;
            subkeine.generierungskosten = 24;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });

            return subkeine;
        }
        private subprofession createKriegerSubElenvina()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieElenvina;
            subkeine.generierungskosten = 24;

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +2 });

            subkeine.sonderfertigkeiten.Add(new sfIdentifier() {  name = SFNamen.Reiterkampf});
            subkeine.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });

            return subkeine;
        }
        private subprofession createKriegerSubBaliho()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieBaliho;
            subkeine.generierungskosten = 27;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Koerperkraft, wert = +13 });

            subkeine.soInterval = new Range() { lower = 8, upper = 12 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Hiebwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kettenwaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -1 });
            subkeine.talente.Remove(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            subkeine.empfohleneVorteile.Add(new VorteilsIdentifier() { name = VorteileName.BesondererBesitz });

            return subkeine;
        }
        private subprofession createKriegerSubBaburin()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieBaburin;
            subkeine.generierungskosten = 23;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +11 },
                new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Fingerfertigkeit, wert = +12 },
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.automatischeNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Schulden, wert = +1000 });

            subkeine.leModifikator = +1;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlLanze = new wahlmoeglichkeiten();
            wahlLanze.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Lanzenreiten},
                new talentIdentifier(){ name = TalentName.Peitsche},
            };
            wahlLanze.talentWerte = new int[1];
            wahlLanze.talentWerte[0] = +3;
            wahlLanze.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlLanze);

            var wahlPhilo = new wahlmoeglichkeiten();
            wahlPhilo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Philosophie},
            };
            wahlPhilo.talentWerte = new int[1];
            wahlPhilo.talentWerte[0] = +2;
            wahlPhilo.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlPhilo);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.verbilligteSonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtesKettenhemd},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            // Wahl der Sprache:
            var wahlSchrift = new wahlmoeglichkeiten();
            wahlSchrift.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen},
                new SchriftenIdentifier(){ name = SchriftName.Tulamidya},
            };
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            wahlSchrift.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.schriften = new List<SchriftenIdentifier>() { };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Saebel, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Speere, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = -2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.BerittenerSchuetze},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createKriegerSubArivor()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.AkademieArivor;
            subkeine.generierungskosten = 20;

            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +13 });

            subkeine.soInterval = new Range() { lower = 4, upper = 11 };

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });

            return subkeine;
        }
        private subprofession createKriegerSubStandard()
        {
            var subkeine = createKriegerBasis();

            subkeine.name = SubProfessionsName.StandardKriegerakademie;
            subkeine.generierungskosten = 18;

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlAndert = new wahlmoeglichkeiten();
            wahlAndert.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAndert.talentWerte = new int[1];
            wahlAndert.talentWerte[0] = +4;
            wahlAndert.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAndert);

            var wahlArm = new wahlmoeglichkeiten();
            wahlArm.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Wurfspeere},
            };
            wahlArm.talentWerte = new int[1];
            wahlArm.talentWerte[0] = +4;
            wahlArm.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlArm);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Speere},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +2;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwerter, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });

            return subkeine;
        }
        private subprofession createKriegerBasis()
        {
            var subkeine = new subprofession() { };

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;
            subkeine.zeitaufwaendig = true;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +2;
            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildungKrieger},
            };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet , wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit , wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.SchutzDerSchwachen , wert = +10},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Autoritaetsglaeubig},
                new NachteilsIdentifier(){ name = NachteileName.Gerechtigkeitswahn},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Finanzier},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Lehrer},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Dienstherr},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };
            var vortKat = new Vorteilskategorien();
            subkeine.ungeeigneteVorteile.AddRange( vortKat.getMagische());

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutdurst},
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
                new NachteilsIdentifier(){ name = NachteileName.Lichtempfindlich},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
                new NachteilsIdentifier(){ name = NachteileName.Stubenhocker},
                new NachteilsIdentifier(){ name = NachteileName.Totenangst},
                new NachteilsIdentifier(){ name = NachteileName.Unfrei},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
                new NachteilsIdentifier(){ name = NachteileName.Wahnvorstellungen},
                new NachteilsIdentifier(){ name = NachteileName.Einaeugig},
                new NachteilsIdentifier(){ name = NachteileName.Einarmig},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Einhaendig},
            };
            var nachteileKat = new Nachteilskategorien();
            subkeine.ungeeigneteNachteile.AddRange(nachteileKat.getMagische());

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +1},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Klettern, wert = +1},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +4},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +3},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            subkeine.schriften = new List<SchriftenIdentifier>() { };
            subkeine.schriften.Add(new SchriftenIdentifier() { name = SchriftName.KuslikerZeichen, wert = +4});

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }

        private subprofession createJahrSubKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.generierungskosten = 6;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +13},
            };

            subkeine.auModifikator = +2;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.SozialeAnpassungsfaehigkeit},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Aberglaube},
                new NachteilsIdentifier(){ name = NachteileName.Neugier},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Krankheitsanfaellig},
            };

            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +4},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +4},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +3},
                new talentIdentifier(){ name = TalentName.Schauspielerei, wert = +2},
                new talentIdentifier(){ name = TalentName.SichVerkleiden, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +1},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen2},
                new sfIdentifier(){ name = SFNamen.Ausweichen3},
                new sfIdentifier(){ name = SFNamen.Kampfgespuehr},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
            };

            return subkeine;
        }

        private subprofession createGardistSubSippe()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.AranischerSippenkrieger;
            subkeine.generierungskosten = 8;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
            };

            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 6, upper = 10 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen, auspraegung = Verpflichtungen.Sippe},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +1200},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Bogen},
                new talentIdentifier(){ name = TalentName.Lanzenreiten},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlFecht.talentWerte = new int[2];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.talentWerte[1] = +3;
            wahlFecht.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlFecht);

            var wahlTanz = new wahlmoeglichkeiten();
            wahlTanz.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Singen},
                new talentIdentifier(){ name = TalentName.Tanzen},
            };
            wahlTanz.talentWerte = new int[1];
            wahlTanz.talentWerte[0] = +2;
            wahlTanz.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlTanz);

            var wahlBet = new wahlmoeglichkeiten();
            wahlBet.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Betoeren},
                new talentIdentifier(){ name = TalentName.Gassenwissen},
                new talentIdentifier(){ name = TalentName.Lehren},
            };
            wahlBet.talentWerte = new int[1];
            wahlBet.talentWerte[0] = +2;
            wahlBet.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBet);

            var wahlSpiel = new wahlmoeglichkeiten();
            wahlSpiel.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BrettUndKartenspiel},
                new talentIdentifier(){ name = TalentName.Geographie},
                new talentIdentifier(){ name = TalentName.Geschichtswissen},
            };
            wahlSpiel.talentWerte = new int[1];
            wahlSpiel.talentWerte[0] = +3;
            wahlSpiel.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSpiel);

            var wahlPhilo = new wahlmoeglichkeiten();
            wahlPhilo.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Philosophie},
                new talentIdentifier(){ name = TalentName.Rechtskunde},
                new talentIdentifier(){ name = TalentName.Staatskunst},
            };
            wahlPhilo.talentWerte = new int[1];
            wahlPhilo.talentWerte[0] = +2;
            wahlPhilo.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlPhilo);

            var wahlAb = new wahlmoeglichkeiten();
            wahlAb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Abrichten},
                new talentIdentifier(){ name = TalentName.Handel},
                new talentIdentifier(){ name = TalentName.Hauswirtschaft},
                new talentIdentifier(){ name = TalentName.Musizieren},
            };
            wahlAb.talentWerte = new int[2];
            wahlAb.talentWerte[0] = +2;
            wahlAb.talentWerte[1] = +2;
            wahlAb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlAb);

            var wahlAcker = new wahlmoeglichkeiten();
            wahlAcker.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Ackerbau},
                new talentIdentifier(){ name = TalentName.Viehzucht},
                new talentIdentifier(){ name = TalentName.Winzer},
            };
            wahlAcker.talentWerte = new int[1];
            wahlAcker.talentWerte[0] = +1;
            wahlAcker.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAcker);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kettenhemd},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Ringelpanzer},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Gambeson},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +3},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +3},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +3},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +4},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.MalenUndZeichnen, wert = +2},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGardistSubAkademie()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Akademiegardist;
            subkeine.generierungskosten = 8;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };


            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 5, upper = 10 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet , wert = +6},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.HoheMagieresistenz},
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +5;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);


            var wahlStaebe = new wahlmoeglichkeiten();
            wahlStaebe.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlStaebe.talentWerte = new int[1];
            wahlStaebe.talentWerte[0] = +6;
            wahlStaebe.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlStaebe);


            // Ein beliebiges Wissenstalent +2:
            var wahlWissen = new wahlmoeglichkeiten();
            wahlWissen.talente = new List<talentIdentifier>(){};
            var talentKats = new Talentkategorien();
            wahlWissen.talente.AddRange(talentKats.getWissen());
            wahlWissen.talentWerte = new int[1];
            wahlWissen.talentWerte[0] = +2;
            wahlWissen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlWissen);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                // TODO: Im Prinzip ALLE Rüstungstypen möglich!
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.WattierterWaffenrock},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kettenhemd},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtePlatte},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +5},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +3},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +1},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +3},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +4},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Formation},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGardistSubSchliesser()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Schliesser;
            subkeine.generierungskosten = 3;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };


            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlKette = new wahlmoeglichkeiten();
            wahlKette.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Peitsche},
            };
            wahlKette.talentWerte = new int[1];
            wahlKette.talentWerte[0] = +4;
            wahlKette.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlKette);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Infanteriewaffen, wert = +3},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +3},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +5},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +3},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +1},
                new talentIdentifier(){ name = TalentName.Gassenwissen, wert = +1},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +5},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +2},
                new talentIdentifier(){ name = TalentName.SchloesserKnacken, wert = +2},
            };


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGardistSubStrasse()
        {
            var subStrasse = new subprofession() { };
            subStrasse.name = SubProfessionsName.Strassenwaechter;
            subStrasse.generierungskosten = 8;

            subStrasse.professionenTyp = ProfessionsTyp.Kaempferisch;

            subStrasse.voraussetzungen = new professionsVorausssetzungen() { };
            subStrasse.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };


            subStrasse.auModifikator = +1;
            subStrasse.soInterval = new Range() { lower = 5, upper = 8 };

            subStrasse.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subStrasse.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
                new NachteilsIdentifier(){ name = NachteileName.Einarmig},
                new NachteilsIdentifier(){ name = NachteileName.Einbeinig},
                new NachteilsIdentifier(){ name = NachteileName.Einaeugig},
                new NachteilsIdentifier(){ name = NachteileName.Lahm},
            };

            subStrasse.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subStrasse.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };



            subStrasse.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subStrasse.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subStrasse.wahlen.Add(wahlFecht);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subStrasse.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.WattierterWaffenrock},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederruestung},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subStrasse.wahlen.Add(wahlSO);

            subStrasse.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Infanteriewaffen, wert = +5},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +5},
                new talentIdentifier(){ name = TalentName.Ringen, wert = +3},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +2},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +2},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +2},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +2},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +2},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +2},
                new talentIdentifier(){ name = TalentName.Faehrtensuchen, wert = +2},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +3},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Schaetzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +1},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken, wert = +2},
            };


            subStrasse.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            subStrasse.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };
    
            return subStrasse;
        }
        private subprofession createGardistSubDorf()
        {

            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Dorfbuettel;
            subkeine.generierungskosten = 4;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };

            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 5, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            // Dorfbüttel:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +1 });


            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange(alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +2;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);


            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;
        }
        private subprofession createGardistSubStadt()
        {

            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Stadtgardist;
            subkeine.generierungskosten = 11;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +11},
            };


            subkeine.auModifikator = +1;
            subkeine.soInterval = new Range() { lower = 5, upper = 8 };         

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Verbindungen},
                new VorteilsIdentifier(){ name = VorteileName.Veteran},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Verpflichtungen},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Adlig},
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.AdligesErbe},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Unstet},
            };

            // Stadtgardist:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +3 });


            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlBogen = new wahlmoeglichkeiten();
            wahlBogen.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust},
                new talentIdentifier(){ name = TalentName.Bogen},
            };
            wahlBogen.talentWerte = new int[1];
            wahlBogen.talentWerte[0] = +3;
            wahlBogen.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBogen);

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +4;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlInfi = new wahlmoeglichkeiten();
            wahlInfi.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Infanteriewaffen},
                new talentIdentifier(){ name = TalentName.Staebe},
            };
            wahlInfi.talentWerte = new int[1];
            wahlInfi.talentWerte[0] = +5;
            wahlInfi.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlInfi);

            var wahlReiten = new wahlmoeglichkeiten();
            wahlReiten.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Reiten},
                new talentIdentifier(){ name = TalentName.Schwimmen},
            };
            wahlReiten.talentWerte = new int[1];
            wahlReiten.talentWerte[0] = +2;
            wahlReiten.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlReiten);

            var wahlBoote = new wahlmoeglichkeiten();
            wahlBoote.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.BooteFahren},
                new talentIdentifier(){ name = TalentName.FahrzeugLenken},
            };
            wahlBoote.talentWerte = new int[1];
            wahlBoote.talentWerte[0] = +2;
            wahlBoote.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlBoote);

            var wahlSchrift = new wahlmoeglichkeiten();
            var alleSchriften = new SchriftenKategorien();
            wahlSchrift.schriften = new List<SchriftenIdentifier>() { };
            wahlSchrift.schriften.AddRange( alleSchriften.GetSchriften());
            wahlSchrift.anzahlZuWaehlen = 1;
            wahlSchrift.talentWerte = new int[1];
            wahlSchrift.talentWerte[0] = 4;
            subkeine.wahlen.Add(wahlSchrift);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.WattierterWaffenrock},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Lederwams},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ortskenntnis},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Formation},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }

        private subprofession createSchauSubKeine()
        {
            var subkeine = createGladiatorBase();
            subkeine.generierungskosten = +12;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +13},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };
            subkeine.name = SubProfessionsName.keine;

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };
            subkeine.ungeeigneteNachteile.Add(new NachteilsIdentifier() { name = NachteileName.Blutrausch });


            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var talentkat = new Talentkategorien();

            var wahlKampf = new wahlmoeglichkeiten();
            wahlKampf.talente = new List<talentIdentifier>(){};
            wahlKampf.talente.AddRange(talentkat.getBewaffneterNahkampf());
            wahlKampf.talentWerte = new int[3];
            wahlKampf.talentWerte[0] = +3;
            wahlKampf.talentWerte[1] = +3;
            wahlKampf.talentWerte[2] = +3;
            wahlKampf.anzahlZuWaehlen = 3;
            subkeine.wahlen.Add(wahlKampf);

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);


            // Schaukämpfer:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gaukeleien, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = -1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schauspielerei, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SichVerkleiden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                  new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                  new sfIdentifier(){ name = SFNamen.Finte},
                  new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                  new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                  new sfIdentifier(){ name = SFNamen.Betaeubungsschlag},
            };

            return subkeine;
        }
        private subprofession createGladiatorAlanfa()
        {
            var subkeine = createGladiatorBase();
            subkeine.generierungskosten = +14;
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Charisma, wert = +11 });
            subkeine.auModifikator = subkeine.auModifikator + 1;
            subkeine.name = SubProfessionsName.AlAnfa;

            subkeine.soInterval = new Range() { lower = 3, upper = 8 };

            // ALANFA GLADI
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Gassenwissen, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });


            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlDolch = new wahlmoeglichkeiten();
            wahlDolch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlDolch.talentWerte = new int[2];
            wahlDolch.talentWerte[0] = +5;
            wahlDolch.talentWerte[1] = +5;
            wahlDolch.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlDolch);

            var wahlAkro = new wahlmoeglichkeiten();
            wahlAkro.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik},
                new talentIdentifier(){ name = TalentName.Reiten},
            };
            wahlAkro.talentWerte = new int[1];
            wahlAkro.talentWerte[0] = +3;
            wahlAkro.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAkro);

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
            subkeine.wahlen.Add(wahlSprache);


            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
                new sfIdentifier(){ name = SFNamen.Hruruzat},
                new sfIdentifier(){ name = SFNamen.Bornlaendisch},
                new sfIdentifier(){ name = SFNamen.Mercenario},
                new sfIdentifier(){ name = SFNamen.UnauerSchule},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);


            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            return subkeine;
        }
        private subprofession createGladiatorFasar()
        {
            var subkeine = createGladiatorBase();
            subkeine.name = SubProfessionsName.Fasar;

            subkeine.generierungskosten = +3;
            subkeine.voraussetzungen.eigenschaften.Add(new GenericListenNameWertPaar<EigenschaftenName>() { name = EigenschaftenName.Mut, wert = +13 });

            // Fasaraer Gladi:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Akrobatik, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });

            // So:
            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Ausweichen1},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.Kampfreflexe},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Niederwerfen},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
            };

            var wahlSO = new wahlmoeglichkeiten();
            wahlSO.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Gladiatorenstil},
                new sfIdentifier(){ name = SFNamen.Hammerfaust},
            };
            wahlSO.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSO);

            return subkeine;
        }
        private subprofession createGladiatorBase()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Koerperkraft, wert = +12},
            };

            subkeine.leModifikator = +1;
            subkeine.auModifikator = +2;

            subkeine.soInterval = new Range() { lower = 1, upper = 7 };

            subkeine.automatischeVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.ZaeherHund},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.GutAussehend},
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
                new NachteilsIdentifier(){ name = NachteileName.Eitelkeit},
                new NachteilsIdentifier(){ name = NachteileName.Schulden},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Fettleibig},
                new NachteilsIdentifier(){ name = NachteileName.Glasknochen},
                new NachteilsIdentifier(){ name = NachteileName.SchlechteRegeneration},
            };

            // Gladiator Basis
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +1 });

            // Wahlen:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlDolch = new wahlmoeglichkeiten();
            wahlDolch.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Dolche},
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Kettenwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
                new talentIdentifier(){ name = TalentName.Schwerter},
                new talentIdentifier(){ name = TalentName.Speere},
                new talentIdentifier(){ name = TalentName.Zweihandflegel},
                new talentIdentifier(){ name = TalentName.ZweihandHiebwaffen},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlDolch.talentWerte = new int[2];
            wahlDolch.talentWerte[0] = +4;
            wahlDolch.talentWerte[1] = +3;
            wahlDolch.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlDolch);

            return subkeine; 	    
        }

        private subprofession createFaehnrichSubSeeFestum()
        {
            var subFestum = createFaehnrichSubSeeAlAnfa();
            subFestum.name = SubProfessionsName.SeeFestum;

            return subFestum;
        }
        private subprofession createFaehnrichSubSeeAlAnfa()
        {
            var subAnfa = createFaehnrichSubSeeKeine();
            subAnfa.name = SubProfessionsName.SeeAlAnfa;

            subAnfa.generierungskosten = 23;

            // AL ANFA
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Schaetzen, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Handel, wert = +3 });

            return subAnfa;
        }
        private subprofession createFaehnrichSubSeeHarben()
        {
            var subHarben = createFaehnrichSubSeeKeine();
            subHarben.name = SubProfessionsName.SeeHarben;

            subHarben.generierungskosten = 23;

            // Harben:
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +1 });
            subHarben.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +1 });

            subHarben.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Wuchtschlag},
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Kriegskunst, subAuspraegung = TalentSpezialisierung.Seegefechte},
            };

            return subHarben;
        }
        private subprofession createFaehnrichSubSeeKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;
            subkeine.generierungskosten = 21;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.voraussetzungen.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Meeresangst},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +2000},
            };

            subkeine.empfohleneVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.AdligeAbstammung},
                new VorteilsIdentifier(){ name = VorteileName.Balance},
                new VorteilsIdentifier(){ name = VorteileName.InnererKompass},
            };

            subkeine.empfohleneNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Arroganz},
                new NachteilsIdentifier(){ name = NachteileName.Raumangst},
            };

            subkeine.ungeeigneteVorteile = new List<VorteilsIdentifier>()
            {
                new VorteilsIdentifier(){ name = VorteileName.Kampfrausch},
            };

            subkeine.ungeeigneteNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Blutrausch},
            };

            // See:
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Klettern, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Zechen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wettervorhersage, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Wildnisleben, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geographie, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sternkunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.BooteFahren, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Seefahrt, wert = +6 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlFecht = new wahlmoeglichkeiten();
            wahlFecht.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecht.talentWerte = new int[1];
            wahlFecht.talentWerte[0] = +5;
            wahlFecht.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecht);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
                new sfIdentifier(){ name = SFNamen.Standfest},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Kriegskunst, subAuspraegung = TalentSpezialisierung.Seegefechte},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Finte},
                new sfIdentifier(){ name = SFNamen.KampfImWasser},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Seefahrt, subAuspraegung = TalentSpezialisierung.Steuermann},
            };

            return subkeine;
        }

        private subprofession createFaehnrichSubStabVinsalt()
        {
            var subkeine = createFaehnrichSubStabWehrheim();

            subkeine.name = SubProfessionsName.Vinsalt;

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.DefensiverKampfstil},
                new sfIdentifier(){ name = SFNamen.Formation},
                new sfIdentifier(){ name = SFNamen.Geschuetzmeister},
                new sfIdentifier(){ name = SFNamen.Meisterparade},
                new sfIdentifier(){ name = SFNamen.Parierwaffen1},
            };

            return subkeine;
        }
        private subprofession createFaehnrichSubStabWehrheim()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.Wehrheim;
            subkeine.zeitaufwaendig = true;
            subkeine.generierungskosten = 15;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen(){};
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>()
            {
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Klugheit, wert = +11},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +11},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 7, upper = 12 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = +10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = +10},
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
                new NachteilsIdentifier(){ name = NachteileName.Rachsucht},
            };

            // Stabsfähnrich:
            subkeine.talente = new List<talentIdentifier>() { };
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lanzenreiten, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Raufen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Athletik, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung, wert = +6 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Lehren, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = +5 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberreden, wert = +3 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Geschichtswissen, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kriegskunst, wert = +7 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Magiekunde, wert = +1 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = +4 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.Kartographie, wert = +2 });
            subkeine.talente.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen, wert = +4 });

            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlHaender = new wahlmoeglichkeiten();
            wahlHaender.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlHaender.talentWerte = new int[1];
            wahlHaender.talentWerte[0] = +2;
            wahlHaender.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHaender);

            var wahlFecgt = new wahlmoeglichkeiten();
            wahlFecgt.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Fechtwaffen},
                new talentIdentifier(){ name = TalentName.Schwerter},
            };
            wahlFecgt.talentWerte = new int[1];
            wahlFecgt.talentWerte[0] = +5;
            wahlFecgt.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlFecgt);

            var wahlHieb = new wahlmoeglichkeiten();
            wahlHieb.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Hiebwaffen},
                new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[1];
            wahlHieb.talentWerte[0] = +3;
            wahlHieb.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlHieb);

            subkeine.sprachen = new List<SprachenIdentifier>()
            {
                new SprachenIdentifier(){ name = SprachenName.Bosparano, modifikator = +4},
            };

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };


            var wahlAnder = new wahlmoeglichkeiten();
            wahlAnder.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kettenhemd},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
            };
            wahlAnder.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlAnder);

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Linkhand},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung2},
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Schildkampf1},
            };

            return subkeine;            
        }

        private subprofession createFaehnrichSubKavRagath()
        {
            var subRagath = createFaehnrichSubKavKeine();

            subRagath.generierungskosten = 16;
            subRagath.name = SubProfessionsName.KavallerieRagath;

            subRagath.talente.Add(new talentIdentifier() {  name = TalentName.FesselnUndEntfesseln, wert = +2});
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde, wert = +1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Rechtskunde, wert = -1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden, wert = +1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Staatskunst, wert = -1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Tierkunde, wert = +1 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.Abrichten, wert = +5 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subRagath.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });

            subRagath.sonderfertigkeiten.Add(new sfIdentifier() 
            { name = SFNamen.Talentspezialisierung, auspraegung = TalentName.Abrichten, 
                subAuspraegung = TalentSpezialisierung.Zureiter
            });

            subRagath.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subRagath.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            return subRagath;
        }
        private subprofession createFaehnrichSubKavKeine()
        {
            var subkeine = new subprofession() { };
            subkeine.name = SubProfessionsName.keine;
            subkeine.zeitaufwaendig = true;
            subkeine.generierungskosten = 11;

            subkeine.professionenTyp = ProfessionsTyp.Kaempferisch;

            subkeine.voraussetzungen = new professionsVorausssetzungen() { };
            subkeine.voraussetzungen.eigenschaften = new List<GenericListenNameWertPaar<EigenschaftenName>>() 
            { 
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Mut, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Charisma, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Gewandtheit, wert = +12},
                new GenericListenNameWertPaar<EigenschaftenName>(){ name = EigenschaftenName.Konstitution, wert = +12},
            };

            subkeine.auModifikator = +3;
            subkeine.leModifikator = +1;
            subkeine.soInterval = new Range() { lower = 7, upper = 13 };

            subkeine.automatischeNachteile = new List<NachteilsIdentifier>()
            {
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Gehorsam, wert = 10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Loyalitaet, wert = 10},
                new NachteilsIdentifier(){ name = NachteileName.Prinzipientreue, auspraegung = Prinzipien.Ehrenhaftigkeit, wert = 10},
                new NachteilsIdentifier(){ name = NachteileName.Schulden, wert = +2000},
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
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
                new NachteilsIdentifier(){ name = NachteileName.Lichtscheu},
                new NachteilsIdentifier(){ name = NachteileName.Randgruppe},
            };
            
            subkeine.talente = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Armbrust, wert = +2},
                new talentIdentifier(){ name = TalentName.Dolche, wert = +2},
                new talentIdentifier(){ name = TalentName.Lanzenreiten, wert = +5},
                new talentIdentifier(){ name = TalentName.Raufen, wert = +2},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +3},
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Reiten, wert = +7},
                new talentIdentifier(){ name = TalentName.Selbstbeherrschung, wert = +4},
                new talentIdentifier(){ name = TalentName.Sinnesschaerfe, wert = +3},
                new talentIdentifier(){ name = TalentName.Tanzen, wert = +3},
                new talentIdentifier(){ name = TalentName.Zechen, wert = +1},
                new talentIdentifier(){ name = TalentName.Etikette, wert = +5},
                new talentIdentifier(){ name = TalentName.Lehren, wert = +4},
                new talentIdentifier(){ name = TalentName.Menschenkenntnis, wert = +4},
                new talentIdentifier(){ name = TalentName.Ueberreden, wert = +3},
                new talentIdentifier(){ name = TalentName.Ueberzeugen, wert = +3},
                new talentIdentifier(){ name = TalentName.FesselnUndEntfesseln, wert = +1},
                new talentIdentifier(){ name = TalentName.Orientierung, wert = +2},
                new talentIdentifier(){ name = TalentName.Wildnisleben, wert = +1},
                new talentIdentifier(){ name = TalentName.Geschichtswissen, wert = +2},
                new talentIdentifier(){ name = TalentName.GoetterUndKulte, wert = +2},
                new talentIdentifier(){ name = TalentName.Heraldik, wert = +4},
                new talentIdentifier(){ name = TalentName.Kriegskunst, wert = +6},
                new talentIdentifier(){ name = TalentName.Magiekunde, wert = +1},
                new talentIdentifier(){ name = TalentName.Rechnen, wert = +2},
                new talentIdentifier(){ name = TalentName.Rechtskunde, wert = +3},
                new talentIdentifier(){ name = TalentName.SagenUndLegenden, wert = +1},
                new talentIdentifier(){ name = TalentName.Staatskunst, wert = +2},
                new talentIdentifier(){ name = TalentName.Tierkunde, wert = +3},
                new talentIdentifier(){ name = TalentName.Abrichten, wert = +2},
                new talentIdentifier(){ name = TalentName.HeilkundeWunden, wert = +2},
                new talentIdentifier(){ name = TalentName.Lederarbeiten, wert = +2},
            };

            subkeine.schriften = new List<SchriftenIdentifier>()
            {
                new SchriftenIdentifier(){ name = SchriftName.KuslikerZeichen, wert = +4},
            };

            // Wahl:
            subkeine.wahlen = new List<wahlmoeglichkeiten>() { };

            var wahlHieb = new wahlmoeglichkeiten() { };
            wahlHieb.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Hiebwaffen},
                 new talentIdentifier(){ name = TalentName.Saebel},
            };
            wahlHieb.talentWerte = new int[2];
            wahlHieb.talentWerte[0] = +5;
            wahlHieb.talentWerte[1] = +3;
            wahlHieb.anzahlZuWaehlen = 2;
            subkeine.wahlen.Add(wahlHieb);

            var wahlSF = new wahlmoeglichkeiten() { };
            wahlSF.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.Kuerass},
                new sfIdentifier(){ name = SFNamen.Ruestungsgewoehnung1, auspraegung = RuestungsName.LeichtePlatte},
            };
            wahlSF.anzahlZuWaehlen = 1;
            subkeine.wahlen.Add(wahlSF);

            subkeine.sonderfertigkeiten = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Reiterkampf},
                new sfIdentifier(){ name = SFNamen.Turnierreiterei},
            };

            subkeine.verbilligteSF = new List<sfIdentifier>()
            {
                new sfIdentifier(){ name = SFNamen.Aufmerksamkeit},
                new sfIdentifier(){ name = SFNamen.Kriegsreiterei},
            };

            return subkeine;
        }

        private subprofession createFaehnrichSubFussHoningen()
        {
            var subHoningen = createFaehnrichSubFussKeine();
            subHoningen.generierungskosten = 13;
            subHoningen.name = SubProfessionsName.FusskaempferOberfels;

            subHoningen.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subHoningen.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subHoningen.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Linkhand });
            subHoningen.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subHoningen.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subHoningen.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });

            return subHoningen;
        }
        private subprofession createFaehnrichSubFussOberfels()
        {
            var subOber = createFaehnrichSubFussGareth();

            // Hier unterscheidet sich lediglich der Name...
            subOber.name = SubProfessionsName.FusskaempferOberfels;

            return subOber;
        }
        private subprofession createFaehnrichSubFussGareth()
        {
            var subGareth = createFaehnrichSubFussKeine();
            subGareth.generierungskosten = 20;
            subGareth.name = SubProfessionsName.FusskaempferGareth;

            var wahlAnderthalb = new wahlmoeglichkeiten() { };
            wahlAnderthalb.talente = new List<talentIdentifier>()
            {
                 new talentIdentifier(){ name = TalentName.Anderthalbhaender},
                 new talentIdentifier(){ name = TalentName.ZweihandSchwerterUndSaebel},
            };
            wahlAnderthalb.talentWerte = new int[1];
            wahlAnderthalb.talentWerte[0] = +3;
            wahlAnderthalb.anzahlZuWaehlen = 1;
            subGareth.wahlen.Add(wahlAnderthalb);

            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Armbrust, wert = +3 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Tanzen, wert = +3 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Etikette, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel, wert = +2 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = +1 });
            subGareth.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +1 });

            subGareth.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Linkhand });
            subGareth.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Schildkampf1 });
            subGareth.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Linkhand });
            subGareth.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subGareth.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Kampfreflexe });
            subGareth.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subGareth.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schnellziehen });

            return subGareth;
        }
        private subprofession createFaehnrichSubFussFestum()
        {
            var subFestum = createFaehnrichSubFussKeine();
            subFestum.generierungskosten = 12;
            subFestum.name = SubProfessionsName.FusskaempferFestum;

            subFestum.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +1 });
            subFestum.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });

            subFestum.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Alaani, modifikator = +4 });
            subFestum.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Nujuka, modifikator = +4 });

            subFestum.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subFestum.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            return subFestum;
        }
        private subprofession createFaehnrichSubFussAlbenhus()
        {
            var subAlben = createFaehnrichSubFussKeine();
            subAlben.generierungskosten = 23;
            subAlben.name = SubProfessionsName.FusskaempferAlbenhus;

            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen, wert = +4 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen, wert = +3 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis, wert = -1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Ueberzeugen, wert = -2 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Orientierung, wert = +1 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Mechanik, wert = +3 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Rechnen, wert = +2 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken, wert = +2 });
            subAlben.talente.Add(new talentIdentifier() { name = TalentName.Lederarbeiten, wert = +2 });

            subAlben.sprachen.Add(new SprachenIdentifier() { name = SprachenName.Rogolan, modifikator = +4 });
            subAlben.schriften.Add(new SchriftenIdentifier(){ name = SchriftName.Rogolan, wert = +4});

            subAlben.sonderfertigkeiten.Add(new sfIdentifier(){ name = SFNamen.Linkhand});
            subAlben.sonderfertigkeiten.Add(new sfIdentifier(){ name = SFNamen.Schildkampf1});
            subAlben.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Linkhand });
            subAlben.verbilligteSF.Remove(new sfIdentifier() { name = SFNamen.Schildkampf1 });

            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ausweichen1 });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Geschuetzmeister });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Niederwerfen });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Schildkampf2 });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Sturmangriff });
            subAlben.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            return subAlben;
        }
        private subprofession createFaehnrichSubFussAlAnfa()
        {
            var subAnfa = createFaehnrichSubFussKeine();
            subAnfa.generierungskosten = 18;
            subAnfa.name = SubProfessionsName.FusskaempferAlAnfa;

            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Dolche, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Kettenwaffen, wert = +3 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Ringen, wert = -1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel, wert = +3 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Reiten, wert = -1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Schwimmen, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe, wert = +1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln, wert = +1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte, wert = +2 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.Heraldik, wert = -1 });
            subAnfa.talente.Add(new talentIdentifier() { name = TalentName.HeilkundeGift, wert = +2 });

            subAnfa.sonderfertigkeiten.Add(new sfIdentifier() { name = SFNamen.Wuchtschlag });

            subAnfa.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.Ruestungsgewoehnung2 });
            subAnfa.verbilligteSF.Add(new sfIdentifier() { name = SFNamen.KampfImWasser });

            return subAnfa;
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
                new NachteilsIdentifier(){ name = NachteileName.Gesucht1},
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
                new VorteilsIdentifier(){ name = VorteileName.AkademischeAusbildungKrieger},
                new VorteilsIdentifier(){ name = VorteileName.Ausdauernd},
                new VorteilsIdentifier(){ name = VorteileName.Beidhaendig},
                new VorteilsIdentifier(){ name = VorteileName.Eisern},
                new VorteilsIdentifier(){ name = VorteileName.Gefahreninstinkt},
                new VorteilsIdentifier(){ name = VorteileName.HoheLebenskraft},
                new VorteilsIdentifier(){ name = VorteileName.SchnelleHeilung1},
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

        /// <summary>
        /// Nachteile, die man als Voraussetzung NICHT haben darf!
        /// </summary>
        public List<NachteilsIdentifier> ungeeigneteNachteile;

        /// <summary>
        /// Enthält alle benötigten Vorteile für diese Profession:
        /// </summary>
        public List<VorteilsIdentifier> vorteile;

        /// <summary>
        /// Enthält eine der benötigten Kulturen für diese Profession. Es genügt, EINE dieser Kulturen zu
        /// besitzen (man kann ja sowieso nur eine Kultur haben)
        /// </summary>
        public List<KulturName> kultur;

        /// <summary>
        /// Enthält eine der benögiten Rassen für diese Profession. Es genügt, EINE dieser Rassen zu besitzen
        /// (man kann ja sowieso nur eine Rasse haben)
        /// </summary>
        public List<SpielerRassenName> Rasse;

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