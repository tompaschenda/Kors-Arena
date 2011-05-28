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
    public class sonderregelKlasse
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
            kombo.beschreibung = "Einheit besteht automatisch jeden Sammeltest. Darf Tests auch bei weniger als halber Sollstärke ablegen. ";
            kombo.beschreibung += "Normale Bewegung ist erlaubt; Einheit zählt nicht als bewegt.";
            kombo.beschreibung += "Einheit wird durch Vorstürmen nicht vernichtet und kämpft normal weiter nach Regel \\emph{Kein Rückzug}.";
            return kombo;
        }
        private sonderRegelKombo createKampftaktiken()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kampftaktiken };
            kombo.beschreibung = "Falls Einheit nicht \\emph{Furchtlos} ist, darf sie auf Wunsch jeden Moraltest verpatzen.";
            return kombo;
        }
        private sonderRegelKombo createKampftrupps()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kampftrupps };
            kombo.beschreibung = "Trupps mit 10 Modellen können für den Rest des Spiels in zwei 5er Trupps aufgeteilt werden. ";
            kombo.beschreibung += "Aufteilung muss bei Spielbeginn erfolgen, es sei denn, Trupp steigt aus Landungskapsel";
            return kombo;
        }
        private sonderRegelKombo createOrbitalesBombardement()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.OrbitalesBombardement };
            kombo.beschreibung = "Kann einmal pro Spiel als Fernkampffeuerwaffe eingesetzt werden, wenn sich das Modell nicht bewegt hat in aktueller Phase. ";
            kombo.beschreibung += "Modell darf danach noch angreifen. Abweichungen immer in voller Höhe; kein BF-Abzug erlaubt.";
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
            kombo.beschreibung = "Charaktermodell und Einheit unterliegen der Regel \\emph{Furchtlos}.";
            return kombo;
        }
        private sonderRegelKombo createLiturgienDerSchlacht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LiturgienDerSchlacht };
            kombo.beschreibung = "In dem Spielerzug, wo das Modell angreift, darf es (und alle Modelle der Einheit) verpatzte Trefferwürfe wiederholen.";
            return kombo;
        }
        private sonderRegelKombo createHeroischeIntervention()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.HeroischeIntervention };
            kombo.beschreibung = "Kann angesagt werden, wenn Expugnatorgarde das Spiel als \\emph{Schocktruppen} erreicht (vor Abweichungswurf). ";
            kombo.beschreibung += "Trupp darf dann nicht schießen oder rennen, aber angreifen. Geht nicht, wenn unabhängiges Charaktermodell dabei ist.";
            return kombo;
        }
        private sonderRegelKombo createEhrwuerdig()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Ehrwuerdig };
            kombo.beschreibung = "Bei Streifschuss oder Volltreffer darf auf Wunsch der Wurf auf der Fahrzeugschadenstabelle wiederholt werden. ";
            kombo.beschreibung += " Das zweite Ergebnis zählt.";
            return kombo;
        }
        private sonderRegelKombo createLandungskapselAngriff()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LandungskapselAngriff };
            kombo.beschreibung = "Im ersten Spielzug muss aufgerundete Hälfte der Landungskapseln nach Schocktruppen eingesetzt werden. ";
            kombo.beschreibung += "Einheit erscheint automatisch im ersten Spielzug des Spielers; Einheiten dürfen sich bewegen und schießen, aber nicht angreifen";
            return kombo;
        }
        private sonderRegelKombo createInertialLeitsystem()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.InertialLeitsystem };
            kombo.beschreibung = "Wenn Modell in unpassierbares Gelände (oder auf anderes Modell) abweicht, wird Abweichungswurf um die ";
            kombo.beschreibung += "minimale Distanz verringert, die nötig ist, um das Hindernis zu umgehen";
            return kombo;
        }
        private sonderRegelKombo createStationaer()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Stationaer };
            kombo.beschreibung = "Fahrzeug ist \\emph{lahmgelegt}.";
            return kombo;
        }
        private sonderRegelKombo createSegenDesOmni()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.SegenDesOmnissiah };
            kombo.beschreibung = "Techmarine kann Fahrzeug bei Basekontakt versuchen zu reparieren, anstatt zu schießen. Wirf W6 + 1 für ";
            kombo.beschreibung += "jeden Servitor mit Servorarm und +1 für Servoharnisch. Bei 5 oder höher kann entweder ein ";
            kombo.beschreibung += "\\emph{Waffe zerstört} oder \\emph{lahmgelegt} repariert werden. Geht nicht, falls der Techmarine sich zurückzieht oder Schutz sucht.";
            return kombo;
        }
        private sonderRegelKombo createBefestigen()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Befestigen };
            kombo.beschreibung = "Jeder Techmarine kann vor Spielbeginn eine Ruine befestigen. Der Deckungswurf wird dann um +1 erhöht.";
            return kombo;
        }
        private sonderRegelKombo createLobotomie()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Lobotomie };
            kombo.beschreibung = "W6 für jeden Servitor zu Beginn eines befreundeten Spielzuges würfeln. Bei 4 oder höher: einheit funktioniert normal. ";
            kombo.beschreibung += "Sont: Einheit und angeschlossene Charaktermodelle dürfen sich nicht bewegen, schießen oder angreifen. Falls Einheit ";
            kombo.beschreibung += "bereits im Nahkampf ist, darf sie sich verteidigen";
            return kombo;
        }
        private sonderRegelKombo createReparieren()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Reparieren };
            kombo.beschreibung = "\\emph{Lahmgelegter} kann von der Crew repariert werden im nachfolgenden Spielzug bei 6 auf W6.";
            return kombo;
        }
        private sonderRegelKombo createMachtDesMaschinengeistes()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.MachtDesMaschinengeistes };
            kombo.beschreibung = "Fahrzeug darf eine Waffe mehr abfeuern, als normalerweise erlaubt. Wahlweise auch auf andere Einheit.";
            return kombo;
        }
        private sonderRegelKombo createSturmpanzer()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Sturmpanzer };
            kombo.beschreibung = "Modelle, die Fahrzeug verlassen, dürfen im selben Spielzug noch angreifen.";
            return kombo;
        }
        private sonderRegelKombo createTitanischeMacht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.TitanischeMacht };
            kombo.beschreibung = "Modell darf alle verpatzten Schadenswürfe in Nah- und Fernkampf wiederholen.";
            return kombo;
        }
        private sonderRegelKombo createKriegsgott()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Kriegsgott };
            kombo.beschreibung = "Alle Einheiten mit Sonderregel \\emph{Kampftaktiken} dürfen Moraltests, zu denen sie gezwungen werden, ";
            kombo.beschreibung += "wahlweise bestehen oder verpatzen, so lange die Einheit auf dem Spielfeld ist.";
            return kombo;
        }
        private sonderRegelKombo createUeberraschungsangriff()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Ueberraschungsangriff };
            kombo.beschreibung = "Würfelwurf zum Stehlen der Initiative zu Spielbeginn darf wiederholt werden.";
            return kombo;
        }
        private sonderRegelKombo createRitenDerSchlacht()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.RitenDerSchlacht };
            kombo.beschreibung = "Alle Einheiten dürfen Moralwert des Modells für Moral- und Niederhalten-Tests verwenden, so lange Einheit auf dem Spielfeld ist.";
            return kombo;
        }
        private sonderRegelKombo createKampfgestaehlteHelden()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.KampfgestaehlteHelden };
            kombo.beschreibung = "Ein taktischer Trupp kann eine der folgenden Sonderregeln erhalten: ";
            kombo.beschreibung += "\\emph{Gegenschlag}, \\emph{Infiltratoren}, \\emph{Scouts} oder \\emph{Panzerjäger}.";
            return kombo;
        }
        private sonderRegelKombo createMeisterpsioniker()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Meisterpsioniker };
            kombo.beschreibung = "Modell kennt alle Psi-Kräfte der Space Marine Scriptoren.";
            return kombo;
        }
        private sonderRegelKombo createGabeDerVorhersehung()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.GabeDerVorhersehung };
            kombo.beschreibung = "Alle Reserve-Würfe dürfen auf Wunsch wiederholt werden (auch erfolgreiche).";
            return kombo;
        }
        private sonderRegelKombo creatreAugeDerVergeltung()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.AugeDerVergeltung };
            kombo.beschreibung = "Verwundungen durch Schussattacken des Modells werden vom Angreifer zugeteilt anstatt vom Verteidiger.";
            return kombo;
        }
        private sonderRegelKombo createLeitendeHand()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.LeitendeHand };
            kombo.beschreibung = "Wenn Modell seine Schussattacke aufgibt, darf ein anderes Modell des Trupps BF des Modells nutzen. Muss vor Schuss angesagt werden!";
            return kombo;
        }
        private sonderRegelKombo createPanzerkommandant()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.Panzerkommandant };
            kombo.beschreibung = "Panzer darf BF von Modell verwenden und ignoriert \\emph{Crew durchgeschüttelt} und \\emph{Crew betäubt}. ";
            kombo.beschreibung += "Wird Fahrzeug zerstört, entkommt Modell bei 3 oder höher. Ist dann unabhängiges Charaktermodell.";
            return kombo;
        }
        private sonderRegelKombo createHaltetDieLinien()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.OrdenstaktikHaltet };
            kombo.beschreibung = "Alle Einheiten der Protektorgarde gelten als punktende Einheiten.";
            return kombo;
        }
        private sonderRegelKombo createInspirierendeGegenwart()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.InspirierendeGegenwart };
            kombo.beschreibung = "Solange Modell lebt, erhalten alle befreundeten Einheiten in 12 Zoll Umkreis +1 Attacke. ";
            kombo.beschreibung += "Gilt nicht für Modell selbst oder kumulativ mit Bonus durch Ordensbanner.";
            return kombo;
        }
        private sonderRegelKombo createBolterDrill()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.BolterDrill };
            kombo.beschreibung = "Jedes Modell der Einheit darf alle verpatzten Trefferwürfe mit Schwerem Bolter, Sturmbolter, Bolter oder Boltpistole wiederholen.";
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
            kombo.beschreibung = "Einheiten des Trupp sind Infiltratoren.";
            return kombo;
        }
        private sonderRegelKombo createMeisterDerJagd()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.MeisterDerJagd };
            kombo.beschreibung = "Einheit hat Sonderregeln \\emph{Zurückfallen} und \\emph{Rasender Angriff}.";
            return kombo;
        }
        private sonderRegelKombo createUnbeugsameGeister()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.UnbeugsameGeister };
            kombo.beschreibung = "Schutzwurf der Einheit ist ein Rettungswurf.";
            return kombo;
        }
        private sonderRegelKombo createWieAusDemNichts()
        {
            sonderRegelKombo kombo = new sonderRegelKombo() { name = Sonderregeln.WieAusDemNichts };
            kombo.beschreibung = "Einheit beginnt Spiel immer in Reserve und betritt als Schocktruppen. Abweichungswurf darf auf Wunsch wiederholt werden.";
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
