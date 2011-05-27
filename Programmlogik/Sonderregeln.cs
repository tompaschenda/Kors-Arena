using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Listen;

namespace WarhammerGUI
{
    /// <summary>
    /// In dieser Klasse werden alle Sonderregeln in schriftlicher
    /// Form (Strings) abgelegt, so dass sie für die Übersicht mit ausgegeben 
    /// werden können.
    /// </summary>
    class sonderregelKlasse
    {
        // Einzige Instanz unseres Singletons:
        private static sonderregelKlasse m_Instance;

        // Instanziierung, da Singleton:
        public static sonderregelKlasse getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new sonderregelKlasse();
            }
            return m_Instance;
        }

        // Privater Konstruktor:
        private sonderregelKlasse()
        {
            createAllRules();
        }

        // Die interne Regelliste:
        private List<sonderRegelKombo> regelListe;

        /// <summary>
        /// Gibt den Beschreibungsstring zurück, der zu einer ausgewählten Regel gehört!
        /// </summary>
        /// <param name="regelName"></param>
        /// <returns></returns>
        public string gibMirFolgendeSonderregel(Sonderregeln regelName)
        {
            for (int i = 0; i < regelListe.Count; ++i)
            {
                if (regelName.ToString() == regelListe[i].name.ToString())
                    return regelListe[i].beschreibung;
            }

            // Wenn wir nichts finden, werfen wir eine Exception:
            throw new ArgumentOutOfRangeException("Konnte die angegebene Sonderregel nicht finden!");
        }

        private void createAllRules()
        {
            this.regelListe = new List<sonderRegelKombo>() { };
            regelListe.Add(createGegenschlag());
            regelListe.Add(createEwigerKrieger());
            regelListe.Add(createFurchtlos());
            regelListe.Add(createVerletzungenIgnorieren());
            regelListe.Add(createSprinten());
            regelListe.Add(createRasenderAngriff());
            regelListe.Add(createZurueckfallen());
            regelListe.Add(createInfiltratoren());
            regelListe.Add(createDurchDeckungBewegen());
            regelListe.Add(createNachtsicht());
            regelListe.Add(createScharfeSinne());
            regelListe.Add(createErzfeind());
            regelListe.Add(createBlutruenstig());
            regelListe.Add(createWaffenexperte());
            regelListe.Add(createScouts());
            regelListe.Add(createGelaendeErfahrung());
            regelListe.Add(createLangsamUndEntschlossen());
            regelListe.Add(createDeckungNutzen());
            regelListe.Add(createUnnachgiebig());
            regelListe.Add(createSchwaerme());
            regelListe.Add(createPanzerjaeger());
            regelListe.Add(createTubroBooster());
            regelListe.Add(createVerwundbar());
            regelListe.Add(createSchocktruppen());
            regelListe.Add(createPsioniker());
            regelListe.Add(createUnabhaengigesCharaktermodell());

            // Space Marines:
            regelListe.Add(createDieKeineFurchtKennen());
            regelListe.Add(createKampftaktiken());
            regelListe.Add(createKampftrupps());
            regelListe.Add(createOrbitalesBombardement());
            regelListe.Add(createKriegerstolz());
            regelListe.Add(createEhreDesOrdens());
            regelListe.Add(createLiturgienDerSchlacht());
            regelListe.Add(createHeroischeIntervention());
            regelListe.Add(createEhrwuerdig());
            regelListe.Add(createLandungskapselAngriff());
            regelListe.Add(createInertialLeitsystem());
            regelListe.Add(createStationaer());
            regelListe.Add(createSegenDesOmni());
            regelListe.Add(createBefestigen());
            regelListe.Add(createLobotomie());
            regelListe.Add(createReparieren());
            regelListe.Add(createMachtDesMaschinengeistes());
            regelListe.Add(createSturmpanzer());
            regelListe.Add(createTitanischeMacht());
            regelListe.Add(createKriegsgott());
            regelListe.Add(createUeberraschungsangriff());
            regelListe.Add(createRitenDerSchlacht());
            regelListe.Add(createKampfgestaehlteHelden());
            regelListe.Add(createMeisterpsioniker());
            regelListe.Add(createGabeDerVorhersehung());
            regelListe.Add(creatreAugeDerVergeltung());
            regelListe.Add(createLeitendeHand());
            regelListe.Add(createPanzerkommandant());
            regelListe.Add(createHaltetDieLinien());
            regelListe.Add(createInspirierendeGegenwart());
            regelListe.Add(createBolterDrill());
            regelListe.Add(createOrdenstaktik());
            regelListe.Add(createSehenAberNichtGesehen());
            regelListe.Add(createMeisterDerJagd());
            regelListe.Add(createUnbeugsameGeister());
            regelListe.Add(createWieAusDemNichts());
            regelListe.Add(createLahmgelegt());
            regelListe.Add(createGeschenkDerVorsehung());
        }


        // An dieser Stelle folgen die Sonderregeln der Space Marines:
        private sonderRegelKombo createDieKeineFurchtKennen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.DieKeineFurchtKennen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createKampftaktiken()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kampftaktiken };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createKampftrupps()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kampftrupps };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createOrbitalesBombardement()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.OrbitalesBombardement };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createKriegerstolz()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kriegerstolz };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createEhreDesOrdens()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.DieEhreDesOrdens };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createLiturgienDerSchlacht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LiturgienDerSchlacht };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createHeroischeIntervention()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.HeroischeIntervention };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createEhrwuerdig()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Ehrwuerdig };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createLandungskapselAngriff()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LandungskapselAngriff };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createInertialLeitsystem()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.InertialLeitsystem };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createStationaer()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Stationaer };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createSegenDesOmni()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.SegenDesOmnissiah };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createBefestigen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Befestigen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createLobotomie()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Lobotomie };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createReparieren()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Reparieren };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createMachtDesMaschinengeistes()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.MachtDesMaschinengeistes };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createSturmpanzer()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Sturmpanzer };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createTitanischeMacht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.TitanischeMacht };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createKriegsgott()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kriegsgott };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createUeberraschungsangriff()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Ueberraschungsangriff };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createRitenDerSchlacht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.RitenDerSchlacht };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createKampfgestaehlteHelden()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.KampfgestaehlteHelden };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createMeisterpsioniker()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Meisterpsioniker };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createGabeDerVorhersehung()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.GabeDerVorhersehung };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo creatreAugeDerVergeltung()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.AugeDerVergeltung };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createLeitendeHand()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LeitendeHand };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createPanzerkommandant()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Panzerkommandant };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createHaltetDieLinien()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.OrdenstaktikHaltet };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createInspirierendeGegenwart()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.InspirierendeGegenwart };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createBolterDrill()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.BolterDrill };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createOrdenstaktik()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Ordenstaktik };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createSehenAberNichtGesehen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.SehenAberNichtGesehen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createMeisterDerJagd()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.MeisterDerJagd };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createUnbeugsameGeister()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.UnbeugsameGeister };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createWieAusDemNichts()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.WieAusDemNichts };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createLahmgelegt()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Lahmgelegt };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createGeschenkDerVorsehung()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.GeschenkDerVorsehung };
            kombo.beschreibung = "";
            return kombo;
        }

        // Allgemeine Sonderregeln:
        private sonderRegelKombo createGegenschlag()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Gegenschlag };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createEwigerKrieger()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.EwigerKrieger };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createFurchtlos()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Furchtlos };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createVerletzungenIgnorieren()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.VerletzungenIgnorieren };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createSprinten()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Sprinten };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createRasenderAngriff()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.RasenderAngriff };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createZurueckfallen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Zurueckfallen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createInfiltratoren()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Infiltratoren };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createDurchDeckungBewegen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.DurchDeckungBewegen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createNachtsicht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Nachtsicht };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createScharfeSinne()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.ScharfeSinne };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createErzfeind()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Erzfeind };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createBlutruenstig()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Blutruenstig };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createWaffenexperte()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Waffenexperten };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createScouts()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Scouts };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createGelaendeErfahrung()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.GelaendeErfahrung };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createLangsamUndEntschlossen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LangsamUndEntschlossen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createDeckungNutzen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.DeckungNutzen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createUnnachgiebig()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Unnachgiebig };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createSchwaerme()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Schwaerme };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createPanzerjaeger()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Panzerjaeger };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createTubroBooster()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.TurboBooser };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createVerwundbar()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.VerwundbarExplosivFlamme };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createSchocktruppen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Schocktruppen };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createPsioniker()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Psioniker };
            kombo.beschreibung = "";
            return kombo;
        }
        private sonderRegelKombo createUnabhaengigesCharaktermodell()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.UnabhaengigesCharakterModell };
            kombo.beschreibung = "";
            return kombo;
        }


        public struct sonderRegelKombo
        {
            /// <summary>
            /// Name der Sonderregel
            /// </summary>
            public Sonderregeln name;

            /// <summary>
            /// Beschreibbungsstring der Regel
            /// </summary>
            public string beschreibung;
        }
    }
}
