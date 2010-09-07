using System.Collections.Generic;
using listenStruktur;
using Common;
using Listen;
using professionenStruktur;
using System;
using System.Linq;
using System.Text;


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
                new ProfessionsIdentifier(){ name = ProfessionsName.FaehnrichDerKavallerie},
                new ProfessionsIdentifier(){ name = ProfessionsName.Stabsfaehnrich},
                new ProfessionsIdentifier(){ name = ProfessionsName.FaehnrichZurSee},
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
        /// Name der Profession
        /// </summary>
        public string name;

        /// <summary>
        /// Typ der Profession (z.B. "kämpferisch", "reisend", etc.
        /// </summary>
        public string professionenTyp;

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
        public List<NameWertPaar> eigenschaftsModifikationen;

        /// <summary>
        /// Das Interval, in dem sich der Sozialstatus bewegen muss, damit man die Profession ausüben / erlernen kann.
        /// Der Held bekommt AUTOMATISCH den Minimalwert aus der Profession gutgeschrieben und KANN ihn nachträglich bis
        /// zum Maximum erhöhen. Dabei muss aber beachtet werden, dass Kulturen ein SO-Maximum aufweisen, das dennoch
        /// nicht überschritten werden darf! Ein Held, der durch die Rasse ein SO-Maximum von 3 hat, kann z.B. kein
        /// "Fähnrich" werden.
        /// </summary>
        public Range soInterval;

        /// <summary>
        /// Eine Liste der für die Profession üblichen Kulturen. Nicht bindend, aber sollte eingehalten werden.
        /// </summary>
        public List<string> ueblicheKulturen;

        /// <summary>
        /// Eine Liste aller möglichen Varianten einer Profession. Die Variante besimmt GP-Kosten, Talente, Modifikatoren,
        /// etc. Und muss beim Auswählen einer Profession immer mit angegeben werden. Wenn es moegliche Varianten gibt,
        /// aber auch eine "Basisvariante", sollte die Basisvariante mit "keine" bezeichnet werden.
        /// </summary>
        public List<string> moeglicheVarianten;

        /// <summary>
        /// Die vom Helden tatsächlich gewählte Variante.
        /// </summary>
        public string gewaehlteVariante;

        /// <summary>
        /// Automatische Vorteile durch die Profession inklusive Wert.
        /// </summary>
        public List<NameWertPaar> automatischeVorteile;
        /// <summary>
        /// Automatische Nachteile durch die Profession inklusive Wert.
        /// </summary>
        public List<NameWertPaar> automatischeNachteile;
        /// <summary>
        /// Empfohlene Vorteile durch die Profession (nicht bindend).
        /// </summary>
        public List<string> empfohleneVorteile;
        /// <summary>
        /// Empfohlene Nachteile durch die Profession (nicht bindend).
        /// </summary>
        public List<string> empfohleneNachteile;
        /// <summary>
        /// Ungeeignete Vorteile für die Profession (sollte bindend sein).
        /// </summary>
        public List<string> ungeeigneteVorteile;
        /// <summary>
        /// Ungeeignete Nachteile für die Profession (sollte bindend sein).
        /// </summary>
        public List<string> ungeeigneteNachteile;

        /// <summary>
        /// Liste von Talenten und Modifikatoren, die man durch die Profession erhält.
        /// </summary>
        public List<NameWertPaar> talente;

        /// <summary>
        /// Liste von Sonderfertigkeiten, die man durch die Profession erhält.
        /// </summary>
        public List<string> sonderfertigkeiten;

        /// <summary>
        /// Liste von Sonderfertigkeiten, die man durch die Profession verbilligt kaufen kann:
        /// </summary>
        public List<string> verbilligteSF;

        /// <summary>
        /// Eine Liste, die die Ausrüstungsgegenstände enthält, die man durch die Profession bekommt.
        /// TODO!
        /// </summary>
        public List<NameWertPaar> ausruestung;

        /// <summary>
        /// Eine Liste, die den besonderen Besitz enthält, den ein Held durch die Profession NUR DANN
        /// bekommt, wenn er den Vorteil "besonderer Besitz" gewählt hat
        /// </summary>
        public List<NameWertPaar> besondererBesitz;

        /// <summary>
        /// Eine Liste, die alle Zauberfertigkeiten und Spezialisierungen enthält, die durch die Rasse
        /// gegeben werden.
        /// </summary>
        public List<nameSubnamePaar> zauberfertigkeiten;

        /// <summary>
        /// Eine Liste, die alle möglichen Ausbildungsorte / Akademien, etc. enthält.
        /// TODO: Ist das überhaupt nötig?
        /// </summary>
        public List<string> ausbildungsorte;


        /// <summary>
        /// Name der Profession
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
                        // Amazone
                        ///////////////////////////////////////
                        case "Amazone":
                            name = value;

                            generierungskosten = 10;
                            zeitaufwaendig = true;
                            voraussetzungen = new professionsVorausssetzungen()
                            {
                                geschlechtstyp = "weiblich",
                                eigenschaften = new List<NameWertPaar>()
                                {
                                    new NameWertPaar () {name = "MU", wert = 13},
                                    new NameWertPaar () {name = "GE", wert = 12},
                                    new NameWertPaar () {name = "KO", wert = 13},
                                    new NameWertPaar () {name = "KK", wert = 11},
                                },
                            };
                            leModifikator = 1;
                            auModifikator = 3;
                            soInterval = new Range(){ lower = 5, upper = 10};
                            automatischeVorteile = new List<NameWertPaar>()
                            {
                                new NameWertPaar () {name = "Akademische Ausbildung", wert = 0},
                                new NameWertPaar () {name = "Akademische Ausbildung", wert = 0},
                            };

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

    }

    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen einer SF aufgelistet sein können:
    /// </summary>
    public struct professionsVorausssetzungen
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
        public List<string> andereSF;
        /// <summary>
        /// Beschreibt, welches Geschlecht ein Held/eine Helden haben muss, um die Profession
        /// ausüben zu können. "männlich", "weiblich", "beide"
        /// Ist z.B. wichtig für: Amazonen
        /// </summary>
        public string geschlechtstyp;
    };

}