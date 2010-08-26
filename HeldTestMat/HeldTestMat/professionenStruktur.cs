using System.Collections.Generic;
using listenStruktur;
using Common;
using Listen;
using professionenStruktur;

namespace professionenStruktur
{
    //////////////////////////////////////
    //  Professionsstruktur. TODO: Ausgliedern!
    //////////////////////////////////////

    /// <summary>
    /// Versschiedenen Kategorien von Professionen inklusive aller zugehörigen Professionen.
    /// </summary>
    public class ProfessionsKategorien
    {
        /// <summary>
        /// Gibt ALLE Professionen zurück:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetAlle()
        {
            var alleProfs = new List<ProfessionsName>() { };
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
        public List<ProfessionsName> GetZwoelfgoetterkulte()
        {
            var zwoelfeProfs = new List<ProfessionsName>()
            {
                ProfessionsName.GeweihterDesPraios,
                ProfessionsName.GeweihterDerRondra,
                ProfessionsName.RondrageweihteAmazone,
                ProfessionsName.GeweihterDesEfferd,
                ProfessionsName.GeweihterDerTravia,
                ProfessionsName.GeweihterDesBoronAlAnfanerRitus,
                ProfessionsName.GeweihterDesBoronPuninerRitus,
                ProfessionsName.GeweihterDerHesinde,
                ProfessionsName.GeweihterDesFirun,
                ProfessionsName.GeweihterDerTsa,
                ProfessionsName.GeweihterDesPhex,
                ProfessionsName.GeweihterDerPeraine,
                ProfessionsName.GeweihterDesIngerimm,
                ProfessionsName.GeweihteDerRahja,
                ProfessionsName.PredigerVomBundDesWahrenGlaubens,
                ProfessionsName.GeweihterDesAves,
                ProfessionsName.GeweihterDesKor,
                ProfessionsName.GeweihterDesNandus,
                ProfessionsName.GeweihterDerIfirn,
                ProfessionsName.GeweihterDesSwafnir,
                ProfessionsName.GeweihterDesAngrosch,
            };
            return zwoelfeProfs;
        }

        /// <summary>
        ///  Alle Gesellschaftlichen Professionen
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetKriegerische()
        {
            var kriegerischeProfs = new List<ProfessionsName>()
            {
                ProfessionsName.Amazone,
                ProfessionsName.Faehnrich,
                ProfessionsName.FaehnrichDerKavallerie,
                ProfessionsName.Stabsfaehnrich,
                ProfessionsName.FaehnrichZurSee,
                ProfessionsName.Gladiator,
                ProfessionsName.Schaukaempfer,
                ProfessionsName.Gardist,
                ProfessionsName.Jahrmarktskaempfer,
                ProfessionsName.Krieger,
                ProfessionsName.Ritter,
                ProfessionsName.Schwertgeselle,
                ProfessionsName.Soldat,
                ProfessionsName.Soeldner,
                ProfessionsName.Stammeskrieger                
            };
            return kriegerischeProfs;
        }

        /// <summary>
        /// Alle Reisenden Professionen
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetReisende()
        {
            var reisendeProfs = new List<ProfessionsName>()
            {
                ProfessionsName.Botenreiter,
                ProfessionsName.Entdecker,
                ProfessionsName.Fernhaendler,
                ProfessionsName.Fischer,
                ProfessionsName.Fuhrmann,
                ProfessionsName.Grenzjaeger,
                ProfessionsName.Großwildjaeger,
                ProfessionsName.Hirte,
                ProfessionsName.Jaeger,
                ProfessionsName.Karawanenhueter,
                ProfessionsName.Kundschafter,
                ProfessionsName.Prospektor,
                ProfessionsName.Schiffer,
                ProfessionsName.Schmuggler,
                ProfessionsName.Seefahrer,
                ProfessionsName.Straßenraeuber
            };
            return reisendeProfs;
        }

        /// <summary>
        ///  Alle Gesellschaftlichen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetGesellschaft()
        {
            var gesellschaftProfs = new List<ProfessionsName>()
            {
                ProfessionsName.Ausrufer,
                ProfessionsName.Barde,
                ProfessionsName.Bettler,
                ProfessionsName.Dieb,
                ProfessionsName.Einbrecher,
                ProfessionsName.Gaukler,
                ProfessionsName.Haendler,
                ProfessionsName.Herold,
                ProfessionsName.Hofkuenstler,
                ProfessionsName.Hoefling,
                ProfessionsName.KurtisaneGesellschafter,
                ProfessionsName.Privatlehrer,
                ProfessionsName.Schriftsteller,
                ProfessionsName.Spitzel,
                ProfessionsName.Streuner,
                ProfessionsName.Taugenichts,
                ProfessionsName.Wirt,
            };

            return gesellschaftProfs;
        }

        /// <summary>
        ///  Alle handwerklichen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetHandwerk()
        {
            var handwerkProfs = new List<ProfessionsName>()
            {
                ProfessionsName.Bader,
                ProfessionsName.Bauer,
                ProfessionsName.Bergmann,
                ProfessionsName.Domestik,
                ProfessionsName.Edelhandwerker,
                ProfessionsName.Gelehrter,
                ProfessionsName.Handwerker,
                ProfessionsName.Rattenfaenger,
                ProfessionsName.Schreiber,
                ProfessionsName.Tageloehner,
                ProfessionsName.Tierbaendiger,
                ProfessionsName.Wundarzt
            };

            return handwerkProfs;
        }

        /// <summary>
        /// Alle magischen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetMagisch()
        {
            var magischProfs = new List<ProfessionsName>()
            {
                ProfessionsName.Alchimist,
                ProfessionsName.MagiebegabterAlchimist,
                ProfessionsName.Derwisch,
                ProfessionsName.Druide,
                ProfessionsName.DurroDun,
                ProfessionsName.Bewahrer,
                ProfessionsName.Former,
                ProfessionsName.Kaempfer,
                ProfessionsName.Legendensaenger,
                ProfessionsName.Wildnislaeufer,
                ProfessionsName.Zauberweber,
                ProfessionsName.Wanderer,
                ProfessionsName.FerkinaBesessener,
                ProfessionsName.Geode,
                ProfessionsName.Hexe,
                ProfessionsName.Kristallomant,
                ProfessionsName.Magier,
                ProfessionsName.Scharlatan,
                ProfessionsName.Taenzer,
                ProfessionsName.Schelm,
                ProfessionsName.Zibilja
            };
            return magischProfs;
        }

        /// <summary>
        /// Alle klerikalen Professionen:
        /// </summary>
        /// <returns></returns>
        public List<ProfessionsName> GetKlerikal()
        {
            var klerikaleProfs = new List<ProfessionsName>()
            {
                ProfessionsName.GeweihterDesPraios,
                ProfessionsName.GeweihterDerRondra,
                ProfessionsName.RondrageweihteAmazone,
                ProfessionsName.GeweihterDesEfferd,
                ProfessionsName.GeweihterDerTravia,
                ProfessionsName.GeweihterDesBoronAlAnfanerRitus,
                ProfessionsName.GeweihterDesBoronPuninerRitus,
                ProfessionsName.GeweihterDerHesinde,
                ProfessionsName.GeweihterDesFirun,
                ProfessionsName.GeweihterDerTsa,
                ProfessionsName.GeweihterDesPhex,
                ProfessionsName.GeweihterDerPeraine,
                ProfessionsName.GeweihterDesIngerimm,
                ProfessionsName.GeweihteDerRahja,
                ProfessionsName.PredigerVomBundDesWahrenGlaubens,
                ProfessionsName.GeweihterDesAves,
                ProfessionsName.GeweihterDesKor,
                ProfessionsName.GeweihterDesNandus,
                ProfessionsName.GeweihterDerIfirn,
                ProfessionsName.HorasRitter,
                ProfessionsName.GeweihterDesSwafnir,
                ProfessionsName.GeweihterDesAngrosch,
                ProfessionsName.PriesterDerHSzint,
                ProfessionsName.PriesterDerZsahh,
                ProfessionsName.PriesterVonRurUndGror,
                ProfessionsName.StammeskriegerDerBeniDervez,
                ProfessionsName.Hadjinim,
                ProfessionsName.Medizinmann,
                ProfessionsName.Kaskjua,
                ProfessionsName.Nuranshar,
                ProfessionsName.BrenochDun,
                ProfessionsName.Skuldrun,
                ProfessionsName.Shochzul,
                ProfessionsName.TairachPriester,
                ProfessionsName.GraveshPriester,
                ProfessionsName.RikaiPriester,
                ProfessionsName.GoblinSchamanin,
                ProfessionsName.SchamaneDerAchaz,

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