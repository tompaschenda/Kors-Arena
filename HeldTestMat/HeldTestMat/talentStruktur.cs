using System.Collections.Generic;
using Listen;
using Common;

namespace talentStruktur
{
    //////////////////////////////////////
    //  Talent-Struktur. TODO: Ausgliedern!
    //////////////////////////////////////

    /// <summary>
    /// Klasse, in der alle Talente enthalten sind und abgerufen werden können.
    /// </summary>
    public class talentFabrik
    {
        /// <summary>
        ///  Liefer ein gewünschtes Talent zurück:
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public talentStruct gibMirTalent(TalentName name)
        {

            var gewuenschtesTalent = new talentStruct();

            try
            {
                switch (name)
                {
                    case TalentName.Akrobatik:
                        gewuenschtesTalent = getAkrobatik();
                        break;
                    case TalentName.Athletik:
                        gewuenschtesTalent = getAthletik();
                        break;
                    case TalentName.Fliegen:
                        gewuenschtesTalent = getFliegen();
                        break;
                    case TalentName.Gaukeleien:
                        gewuenschtesTalent = getGaukeleien();
                        break;

                    default:
                        throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Console.WriteLine("Ungültiges Talent angegeben!");
            }

            return gewuenschtesTalent;
        }

        private talentStruct getGaukeleien()
        {
            var talent = new talentStruct();
            talent.name = TalentName.Gaukeleien;
            talent.istBasisTalent = false;
            talent.talenttyp = TalentKategorie.Koerperlich;
            talent.eigenschaften = new List<EigenschaftenName>()
            {
                EigenschaftenName.MU, EigenschaftenName.CH, EigenschaftenName.FF,
            };
            talent.voraussetzungen = new talentVorausssetzungen() { };
            talent.effektiveBEAbzug = 0;
            talent.effektiveBEMultiplikator = 2;
            talent.spezialisierungen = new List<TalentSpezialisierung>()
            {
                TalentSpezialisierung.Bauchreden, 
                TalentSpezialisierung.Feuerkunst,
                TalentSpezialisierung.Jonglieren, 
                TalentSpezialisierung.Possenreissen, 
                TalentSpezialisierung.Taschenspielereien, 
            };
            talent.ersatzweiseFertigkeiten = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Falschspiel, wert = +10},
                new talentIdentifier(){ name = TalentName.Taschendiebstahl, wert = +10},
            };

            return talent;
        }
        private talentStruct getFliegen()
        {
            var talent = new talentStruct();
            talent.name = TalentName.Fliegen;
            talent.istBasisTalent = false;
            talent.talenttyp = TalentKategorie.Koerperlich;
            talent.eigenschaften = new List<EigenschaftenName>()
            {
                EigenschaftenName.MU, EigenschaftenName.IN, EigenschaftenName.GE,
            };
            talent.voraussetzungen = new talentVorausssetzungen() { };
            talent.effektiveBEAbzug = 0;
            talent.effektiveBEMultiplikator = 1;
            talent.spezialisierungen = new List<TalentSpezialisierung>()
            {
                TalentSpezialisierung.Hexenbesen, 
                TalentSpezialisierung.FliegenderTeppich,
                TalentSpezialisierung.JeNachFluggeraet, 
            };
            talent.ersatzweiseFertigkeiten = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +10},
            };

            return talent;
        }
        private talentStruct getAthletik()
        {
            var talent = new talentStruct();
            talent.name = TalentName.Athletik;
            talent.istBasisTalent = true;
            talent.talenttyp = TalentKategorie.Koerperlich;
            talent.eigenschaften = new List<EigenschaftenName>()
            {
                EigenschaftenName.GE, EigenschaftenName.KO, EigenschaftenName.KK,
            };
            talent.voraussetzungen = new talentVorausssetzungen() { };
            talent.effektiveBEAbzug = 0;
            talent.effektiveBEMultiplikator = 2;
            talent.spezialisierungen = new List<TalentSpezialisierung>()
            {
                TalentSpezialisierung.Hochsprung, 
                TalentSpezialisierung.Kraftakte,
                TalentSpezialisierung.Langlauf, 
                TalentSpezialisierung.Sprint, 
                TalentSpezialisierung.Weitsprung,
            };
            talent.ersatzweiseFertigkeiten = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Akrobatik, wert = +10},
            };

            return talent;
        }
        private talentStruct getAkrobatik()
        {
            var talent = new talentStruct();
            talent.name = TalentName.Akrobatik;
            talent.istBasisTalent = false;
            talent.talenttyp = TalentKategorie.Koerperlich;
            talent.eigenschaften = new List<EigenschaftenName>()
            {
                EigenschaftenName.MU, EigenschaftenName.GE, EigenschaftenName.KK,
            };
            talent.voraussetzungen = new talentVorausssetzungen(){};
            talent.voraussetzungen.talente.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung, wert = +4 });
            talent.effektiveBEAbzug = 0;
            talent.effektiveBEMultiplikator = 2;
            talent.spezialisierungen = new List<TalentSpezialisierung>()
            {
                TalentSpezialisierung.Balancieren, 
                TalentSpezialisierung.Bodenakrobatik,
                TalentSpezialisierung.Schwingen, 
                TalentSpezialisierung.Spruenge, 
                TalentSpezialisierung.Winden,
            };
            talent.ersatzweiseFertigkeiten = new List<talentIdentifier>()
            {
                new talentIdentifier(){ name = TalentName.Koerperbeherrschung, wert = +5},
                new talentIdentifier(){ name = TalentName.Athletik, wert = +10},
            };

            return talent;
        }
    }


    /// <summary>
    /// Struktur, die alle Talente in Aventurien enthält:
    /// </summary>
    public struct talentStruct
    {
        // Wir listen nun auf, welche Attribute eine Talent hat:

        /// <summary>
        /// Name der Talente
        /// </summary>
        public TalentName name;

        /// <summary>
        /// Handelt es sich um ein Basistalent? Wenn ja, ist es immer aktiviert!
        /// </summary>
        public bool istBasisTalent;

        /// <summary>
        /// Von welchem Typ ist das Talent? (Nahkampf, Fernkampf, Körperlich, etc.)
        /// </summary>
        public TalentKategorie talenttyp;

        /// <summary>
        /// Eine Liste, die jeweils Namen der jeweiligen Eigenschaften für die Talentprobe enthält.
        /// Im Fall von Kampftalenten sind AT/PA, bzw. FK-Basis und Ausweichen zu wählen.
        /// </summary>
        public List<EigenschaftenName> eigenschaften;

        /// <summary>
        /// Eine Struktur, die alle nötigen Voraussetzungen enthält, die man für ein Talent erfüllt haben muss.
        /// Man kann ein Talent zwar aktiviert haben und besitzen (z.B. durch eine Rasse oder Kultur), es aber
        /// dennoch nicht nutzen, wenn die Voraussetzungen nicht erfüllt sind!
        /// </summary>
        public talentVorausssetzungen voraussetzungen;

        /// <summary>
        /// Effektive Behinderung, die bei Nutzung des Talents zum Tragen kommt. Der Wert wird IMMER
        /// von der Behinderung des Helden abgezogen. "0" entspricht daher eBE = BE. Beim Abzug muss man
        /// aufpassen, da der Held durch die eBE trotzdem natürlich niemals einen Bonus bekommen kann!
        /// </summary>
        public int effektiveBEAbzug;

        /// <summary>
        /// Ein Multiplikator, mit dem die normale BE multipliziert wird, um die eBE zu erhalten.
        /// </summary>
        public int effektiveBEMultiplikator;

        /// <summary>
        /// Eine Liste, die alle möglichen Spezialisierungen eines Talents enthält:
        /// </summary>
        public List<TalentSpezialisierung> spezialisierungen;

        /// <summary>
        /// Eine Liste, die alle Fertigkeiten (genauer: "Talente") enthält, die anstelle dieses Talents
        /// genutzt werden können (z.B., falls der Held dieses Talent nicht aktiviert hat). Außerdem ist 
        /// jeweils auch der Aufschlagsmodifikator mit enthalten (positiv), der als Erschwernis hinzukommt.
        /// </summary>
        public List<talentIdentifier> ersatzweiseFertigkeiten;
    }

    /// <summary>
    /// Eine Struktur, in der die Voraussetzungen eines Talents aufgelistet sein können:
    /// </summary>
    public struct talentVorausssetzungen
    {
        /// <summary>
        /// Welche Talente brauche ich und auf welchem Wert müssen sie sein?
        /// </summary>
        public List<talentIdentifier> talente;
    };

    /// <summary>
    /// Ermöglicht die eindeutige Identifizierung eines Talents.
    /// </summary>
    public struct talentIdentifier
    {
        /// <summary>
        /// Name des Talents
        /// </summary>
        public TalentName name;

        /// <summary>
        /// Wert des Talents (kann auch negativ sein!)
        /// </summary>
        public int wert;

        /// <summary>
        /// Handelt es sich um ein Leittalent (Elfen) oder nicht?
        /// Default: False!
        /// </summary>
        public bool leittalent;

        /// <summary>
        /// Welche Ausprägung soll das Talent haben?
        /// </summary>
        public object auspraegung;

    };

    /// <summary>
    /// Bieter Zugriff auf alle Talentkategorien
    /// </summary>
    public class Talentkategorien
    {
        /// <summary>
        /// Gibt ALLE Talente zurück:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> GetAlle()
        {
            var alleTalente = new List<talentIdentifier>() { };
            alleTalente.AddRange(getKampftalente());
            alleTalente.AddRange(getKoerperlich());
            alleTalente.AddRange(getGesellschaftlich());
            alleTalente.AddRange(getNatur());
            alleTalente.AddRange(getWissen());
            alleTalente.AddRange(getHandwerk());
            alleTalente.AddRange(getBeruf());
            alleTalente.AddRange(getGabe());
            alleTalente.AddRange(getMeta());
            alleTalente.AddRange(getZauber());
            alleTalente.AddRange(getSpracheUndSchrift());

            return alleTalente;
        }

        /// <summary>
        /// Talente aus dem Bereich Sprachen und Schriften (eigentlich Wissenstalente, aber
        /// speziell, da für jede Sprache anders!)
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getSpracheUndSchrift()
        {
            var sprachenSchriften = new List<talentIdentifier>() { };
            sprachenSchriften.Add(new talentIdentifier() { name = TalentName.LesenUndSchreiben });
            sprachenSchriften.Add(new talentIdentifier() { name = TalentName.SprachenKennen });
            return sprachenSchriften;
        }

        /// <summary>
        /// Sammelt alle Zaubertalente (?)
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getZauber()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sammelt alle Metatalente
        /// </summary>
        /// <returns></returns>
        private List<talentIdentifier> getMeta()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sammelt alle Gaben
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getGabe()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sammelt alle Berufstalente
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getBeruf()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Eine Sammlung aller Handwerkstalente:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getHandwerk()
        {
            var handwerk = new List<talentIdentifier>() { };
            handwerk.Add(new talentIdentifier() { name = TalentName.Abrichten });
            handwerk.Add(new talentIdentifier() { name = TalentName.Ackerbau });
            handwerk.Add(new talentIdentifier() { name = TalentName.Alchimie });
            handwerk.Add(new talentIdentifier() { name = TalentName.Bergbau });
            handwerk.Add(new talentIdentifier() { name = TalentName.Bogenbau });
            handwerk.Add(new talentIdentifier() { name = TalentName.BooteFahren });
            handwerk.Add(new talentIdentifier() { name = TalentName.Brauer });
            handwerk.Add(new talentIdentifier() { name = TalentName.Drucker });
            handwerk.Add(new talentIdentifier() { name = TalentName.FahrzeugLenken });
            handwerk.Add(new talentIdentifier() { name = TalentName.Falschspiel });
            handwerk.Add(new talentIdentifier() { name = TalentName.Feinmechanik });
            handwerk.Add(new talentIdentifier() { name = TalentName.Feuersteinbearbeitung });
            handwerk.Add(new talentIdentifier() { name = TalentName.Fleischer });
            handwerk.Add(new talentIdentifier() { name = TalentName.GerberUndKuerschner });
            handwerk.Add(new talentIdentifier() { name = TalentName.Glaskunst });
            handwerk.Add(new talentIdentifier() { name = TalentName.Grobschmied });
            handwerk.Add(new talentIdentifier() { name = TalentName.Handel });
            handwerk.Add(new talentIdentifier() { name = TalentName.Hauswirtschaft });
            handwerk.Add(new talentIdentifier() { name = TalentName.HeilkundeGift });
            handwerk.Add(new talentIdentifier() { name = TalentName.HeilkundeKrankheiten });
            handwerk.Add(new talentIdentifier() { name = TalentName.HeilkundeSeele });
            handwerk.Add(new talentIdentifier() { name = TalentName.HeilkundeWunden });
            handwerk.Add(new talentIdentifier() { name = TalentName.Holzbearbeitung });
            handwerk.Add(new talentIdentifier() { name = TalentName.Instrumentenbauer });
            handwerk.Add(new talentIdentifier() { name = TalentName.Kartographie });
            handwerk.Add(new talentIdentifier() { name = TalentName.Kochen });
            handwerk.Add(new talentIdentifier() { name = TalentName.Kristallzucht });
            handwerk.Add(new talentIdentifier() { name = TalentName.Lederarbeiten });
            handwerk.Add(new talentIdentifier() { name = TalentName.MalenUndZeichnen });
            handwerk.Add(new talentIdentifier() { name = TalentName.Maurer });
            handwerk.Add(new talentIdentifier() { name = TalentName.Metallguss });
            handwerk.Add(new talentIdentifier() { name = TalentName.Musizieren });
            handwerk.Add(new talentIdentifier() { name = TalentName.SchloesserKnacken });
            handwerk.Add(new talentIdentifier() { name = TalentName.SchnapsBrennen });
            handwerk.Add(new talentIdentifier() { name = TalentName.Schneidern });
            handwerk.Add(new talentIdentifier() { name = TalentName.Seefahrt });
            handwerk.Add(new talentIdentifier() { name = TalentName.Seiler });
            handwerk.Add(new talentIdentifier() { name = TalentName.Steinmetz });
            handwerk.Add(new talentIdentifier() { name = TalentName.SteinschneiderUndJuwelier });
            handwerk.Add(new talentIdentifier() { name = TalentName.Stellmacher });
            handwerk.Add(new talentIdentifier() { name = TalentName.StoffeFaerben });
            handwerk.Add(new talentIdentifier() { name = TalentName.Taetowieren });
            handwerk.Add(new talentIdentifier() { name = TalentName.Toepfern });
            handwerk.Add(new talentIdentifier() { name = TalentName.Viehzucht });
            handwerk.Add(new talentIdentifier() { name = TalentName.Webkunst });
            handwerk.Add(new talentIdentifier() { name = TalentName.Winzer });
            handwerk.Add(new talentIdentifier() { name = TalentName.Zimmermann });
            return handwerk;

        }

        /// <summary>
        /// Eine Sammlung aller Wissenstalente:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getWissen()
        {
            var wissen = new List<talentIdentifier>() { };
            wissen.Add(new talentIdentifier() { name = TalentName.Anatomie });
            wissen.Add(new talentIdentifier() { name = TalentName.Baukunst });
            wissen.Add(new talentIdentifier() { name = TalentName.BrettUndKartenspiel });
            wissen.Add(new talentIdentifier() { name = TalentName.Geographie });
            wissen.Add(new talentIdentifier() { name = TalentName.Geschichtswissen });
            wissen.Add(new talentIdentifier() { name = TalentName.Gesteinskunde });
            wissen.Add(new talentIdentifier() { name = TalentName.GoetterUndKulte });
            wissen.Add(new talentIdentifier() { name = TalentName.Heraldik });
            wissen.Add(new talentIdentifier() { name = TalentName.Huettenkunde });
            wissen.Add(new talentIdentifier() { name = TalentName.Kriegskunst });
            wissen.Add(new talentIdentifier() { name = TalentName.Kryptographie });
            wissen.Add(new talentIdentifier() { name = TalentName.Magiekunde });
            wissen.Add(new talentIdentifier() { name = TalentName.Mechanik });
            wissen.Add(new talentIdentifier() { name = TalentName.Pflanzenkunde });
            wissen.Add(new talentIdentifier() { name = TalentName.Philosophie });
            wissen.Add(new talentIdentifier() { name = TalentName.Rechnen });
            wissen.Add(new talentIdentifier() { name = TalentName.Rechtskunde });
            wissen.Add(new talentIdentifier() { name = TalentName.SagenUndLegenden });
            wissen.Add(new talentIdentifier() { name = TalentName.Schaetzen });
            wissen.Add(new talentIdentifier() { name = TalentName.Sprachenkunde });
            wissen.Add(new talentIdentifier() { name = TalentName.Staatskunst });
            wissen.Add(new talentIdentifier() { name = TalentName.Sternkunde });
            wissen.Add(new talentIdentifier() { name = TalentName.Tierkunde });
            return wissen;
        }

        /// <summary>
        /// Eine Sammlung aller Naturtalente:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getNatur()
        {
            var natur = new List<talentIdentifier>() { };
            natur.Add(new talentIdentifier() { name = TalentName.Faehrtensuchen });
            natur.Add(new talentIdentifier() { name = TalentName.Fallenstellen });
            natur.Add(new talentIdentifier() { name = TalentName.FesselnUndEntfesseln });
            natur.Add(new talentIdentifier() { name = TalentName.FischenUndAngeln });
            natur.Add(new talentIdentifier() { name = TalentName.Orientierung });
            natur.Add(new talentIdentifier() { name = TalentName.Wettervorhersage });
            natur.Add(new talentIdentifier() { name = TalentName.Wildnisleben });
            return natur;
        }

        /// <summary>
        /// Eine Sammlung aller gesellschaftlichen Talente:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getGesellschaftlich()
        {
            var gesellschaftlich = new List<talentIdentifier>() { };
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Betoeren });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Etikette });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Gassenwissen });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Lehren });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Menschenkenntnis });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Schauspielerei });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.SchriftlicherAusdruck });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.SichVerkleiden });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Ueberreden });
            gesellschaftlich.Add(new talentIdentifier() { name = TalentName.Ueberzeugen });
            return gesellschaftlich;
        }

        /// <summary>
        /// Eine Sammlung aller körperlichen Talente:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getKoerperlich()
        {
            var koerperlich = new List<talentIdentifier>() { };
            koerperlich.Add(new talentIdentifier() { name = TalentName.Akrobatik });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Athletik });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Fliegen });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Gaukeleien });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Klettern });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Koerperbeherrschung });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Reiten });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Schleichen });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Schwimmen });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Selbstbeherrschung });
            koerperlich.Add(new talentIdentifier() { name = TalentName.SichVerstecken });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Singen });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Sinnesschaerfe });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Skifahren });
            koerperlich.Add(new talentIdentifier() { name = TalentName.StimmenImitieren });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Tanzen });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Taschendiebstahl });
            koerperlich.Add(new talentIdentifier() { name = TalentName.Zechen });
            return koerperlich;
        }

        /// <summary>
        /// Gruppiert alle Kampftalente zusammen!
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getKampftalente()
        {
            var kampfTalente = new List<talentIdentifier>() { };
            kampfTalente.AddRange(getNahkampfUnbewaffnet());
            kampfTalente.AddRange(getBewaffneterNahkampf());
            kampfTalente.AddRange(getFernkampf());
            kampfTalente.AddRange(getKampfSonst());
            return kampfTalente;
        }

        /// <summary>
        /// Sonstige Kampffertigkeiten:
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getKampfSonst()
        {
            var kampfsonst = new List<talentIdentifier>() { };
            kampfsonst.Add(new talentIdentifier() { name = TalentName.Lanzenreiten });
            kampfsonst.Add(new talentIdentifier() { name = TalentName.Peitsche });
            return kampfsonst;
        }

        /// <summary>
        /// Eine Sammlung aller unbewaffneten Nahkampftalente
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getNahkampfUnbewaffnet()
        {
            var nahkampf = new List<talentIdentifier>() { };
            nahkampf.Add(new talentIdentifier() { name = TalentName.Raufen });
            nahkampf.Add(new talentIdentifier() { name = TalentName.Ringen });
            return nahkampf;
        }

        /// <summary>
        /// Eine Sammlung aller bewaffneten Nahkampftalente
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getBewaffneterNahkampf()
        {
            var bewaffneterNahkampf = new List<talentIdentifier>() { };
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Anderthalbhaender });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Dolche });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Fechtwaffen });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Hiebwaffen });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Infanteriewaffen });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Kettenstaebe });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Kettenwaffen });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Saebel });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Schwerter });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Speere });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Staebe });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.Zweihandflegel });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.ZweihandHiebwaffen });
            bewaffneterNahkampf.Add(new talentIdentifier() { name = TalentName.ZweihandSchwerterUndSaebel });
            return bewaffneterNahkampf;
        }


        /// <summary>
        /// Eine Sammlung aller Fernkampf-Waffentalente
        /// </summary>
        /// <returns></returns>
        public List<talentIdentifier> getFernkampf()
        {
            var fernkampf = new List<talentIdentifier>() { };
            fernkampf.Add(new talentIdentifier() { name = TalentName.Armbrust });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Belagerungswaffen });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Blasrohr });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Bogen });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Diskus });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Schleuder });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Wurfbeile });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Wurfmesser });
            fernkampf.Add(new talentIdentifier() { name = TalentName.Wurfspeere });
            return fernkampf;
        }


    }


}