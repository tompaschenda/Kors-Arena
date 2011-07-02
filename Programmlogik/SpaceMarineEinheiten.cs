using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;
using System.IO;

namespace WarhammerGUI
{

    /// <summary>
    /// Klasse, die alle Einheiten der Space Marines hält!
    /// </summary>
    public class SpaceMarineEinheitenListe
    {
        /// <summary>
        /// Gibt ALLE Einheiten der Space Marines zurück!
        /// </summary>
        /// <returns></returns>
        public List<Einheit> gibMirAlleSpaceMarineEinheiten()
        {
            var listeAllerSpaceMarineEinheiten = new List<Einheit>(){};

            var tTrupp = new taktischerTrupp() { };
            tTrupp.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tTrupp);

            var termies = new terminatortrupp() { };
            termies.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(termies);

            var termiesturm = new terminatorSturmTrupp() { };
            termiesturm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(termiesturm);

            var rhino = new rhino() { };
            rhino.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(rhino);

            var razorback = new razorback() { };
            razorback.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(razorback);

            var landungskapsel = new landungskapsel() { };
            landungskapsel.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(landungskapsel);

            var whirl = new whirlwind() { };
            whirl.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(whirl);

            var landRaider = new landRaider() { };
            landRaider.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(landRaider);

            var crusader = new landRaiderCrusader() { };
            crusader.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(crusader);

            var redeemer = new landRaiderRedeemer() { };
            redeemer.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(redeemer);

            var vindi = new vindicator() { };
            vindi.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(vindi);

            var chronus = new sargeChronus() { };
            chronus.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(chronus);

            var tellion = new sargeTellion() { };
            tellion.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tellion);

            var sicarius = new capSicarius() { };
            sicarius.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(sicarius);

            var tigurius = new varroTigurius() { };
            tigurius.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tigurius);

            var cass = new cassius() { };
            cass.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(cass);

            var pedro = new kantor() { };
            pedro.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(pedro);

            var lys = new lysander() { };
            lys.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(lys);

            var sh = new shrike() { };
            sh.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(sh);

            var vuk = new vukan() { };
            vuk.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(vuk);

            var kh = new khan() { };
            kh.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(kh);

            var salve = new salvenkanone() { };
            salve.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(salve);

            var deva = new devastortrupp() { };
            deva.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(deva);

            var storm = new landSpeederStorm() { };
            storm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(storm);

            var scoutSchwad = new scoutbikerschwadron() { };
            scoutSchwad.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(scoutSchwad);

            var sturm = new sturmTrupp() { };
            sturm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(sturm);

            var kRhino = new kostenloserRhino() { };
            kRhino.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(kRhino);

            var kLand = new kostenloseLandungskapsel() { };
            kLand.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(kLand);

            var expu = new expugnatorGarde() { };
            expu.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(expu);

            var ehrw = new ehrwCybot() { };
            ehrw.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(ehrw);

            var cyv = new cybot() { };
            cyv.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(cyv);

            var iron = new ironclad() { };
            iron.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(iron);

            var scouts = new scoutTrupp() { };
            scouts.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(scouts);

            var cap = new spaceMarineCaptain() { };
            cap.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(cap);

            var ordnesmeist = new spaceMarineOrdensmeister() { };
            ordnesmeist.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(ordnesmeist);

            var protekt = new protektorGarde() { };
            protekt.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(protekt);

            var preda = new predator() { };
            preda.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(preda);

            var lsped = new landSpeederSchwadron() { };
            lsped.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(lsped);

            var tr = new trikeSchwadron() { };
            tr.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tr);

            var bikeS = new bikeSchwadron() { };
            bikeS.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(bikeS);

            var leg = new legionOfTheDamned() { };
            leg.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(leg);

            var techm = new techmarine() { };
            techm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(techm);

            var scrp = new scriptorDerSpaceMariens() { };
            scrp.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(scrp);

            var priest = new ordenspriesterDerSpaceMarines() { };
            priest.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(priest);


            listeAllerSpaceMarineEinheiten.Sort();

            return listeAllerSpaceMarineEinheiten;
        }
    }

    public static class spaceMarineHelperClass
    {
        // Erzeugt die Subeinheit "Space Marine"
        public static subEinheit createSpaceMarine()
        {
            var spaceMarine = new subEinheit() { };
            spaceMarine.name = alleSubeinheitenNamen.SpaceMarine;

            // Jeder Space Marine hat eine Servorüstung (keine Extra-Kosten):
            spaceMarine.ruestung = alleRuestungen.ServoRuestung;

            // Jeder Space Marine hat Fragment- und Sprenggranaten (keine Extra-Kosten):
            spaceMarine.ausruestung = new List<alleAusruestung>();
            spaceMarine.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarine.ausruestung.Add(alleAusruestung.Sprenggranaten);

            // Das Gleiche gilt für die Boltpistole!
            spaceMarine.waffen = new List<waffe>() { };
            spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

            // Fehlen noch die eigentlichen Were für den  Marine:
            spaceMarine.kg = 4;
            spaceMarine.bf = 4;
            spaceMarine.st = 4;
            spaceMarine.wid = 4;
            spaceMarine.lp = 1;
            spaceMarine.ini = 4;
            spaceMarine.at = 1;
            spaceMarine.mw = 8;
            spaceMarine.rw = 3;
            spaceMarine.ret = 0;

            spaceMarine.einheitentyp = Einheitstyp.Infanterie;

            return spaceMarine;
        }

        public static subEinheit createSpaceMarineSergeant()
        {
            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = new subEinheit() { };
            spaceMarineSergeant.name = alleSubeinheitenNamen.SergeantDerSpaceMarines;

            spaceMarineSergeant.ausruestung = new List<alleAusruestung>() { };
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprenggranaten);
            spaceMarineSergeant.ruestung = alleRuestungen.ServoRuestung;

            spaceMarineSergeant.waffen = new List<waffe>() { };
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

            // Fehlen noch die eigentlichen Were für den  Marine:
            spaceMarineSergeant.kg = 4;
            spaceMarineSergeant.bf = 4;
            spaceMarineSergeant.st = 4;
            spaceMarineSergeant.wid = 4;
            spaceMarineSergeant.lp = 1;
            spaceMarineSergeant.ini = 4;
            spaceMarineSergeant.at = 2;
            spaceMarineSergeant.mw = 9;
            spaceMarineSergeant.rw = 3;
            spaceMarineSergeant.ret = 0;
            spaceMarineSergeant.einheitentyp = Einheitstyp.Infanterie;

            return spaceMarineSergeant;
        }

        public static subEinheit createScout()
        {
            var scout = createSpaceMarine();
            scout.kg = 3;
            scout.bf = 3;
            scout.ruestung = alleRuestungen.Scoutruestung;
            return scout;
        }

        public static subEinheit createTerminator()
        {
            var terminator = new subEinheit() { };
            terminator.name = alleSubeinheitenNamen.SpaceMarineTerminator;

            terminator.ruestung = alleRuestungen.TerminatorRuestung;

            terminator.ausruestung = new List<alleAusruestung>();

            terminator.waffen = new List<waffe>() { };

            // Fehlen noch die eigentlichen Were für den Terminator:
            terminator.kg = 4;
            terminator.bf = 4;
            terminator.st = 4;
            terminator.wid = 4;
            terminator.ini = 4;
            terminator.lp = 1;
            terminator.at = 2;
            terminator.mw = 9;
            terminator.rw = 2;
            terminator.ret = 5;

            terminator.einheitentyp = Einheitstyp.Infanterie;

            return terminator;
        }

        public static subEinheit createTermiantorSergeant()
        {
            var sarge = createTerminator();
            sarge.name = alleSubeinheitenNamen.Terminatorsergeant;
            return sarge;
        }

        public static subEinheit createVeteran()
        {
            var veteran = createSpaceMarine();
            veteran.name = alleSubeinheitenNamen.VeteranDerSpaceMariens;
            veteran.at = 2;
            veteran.mw = 9;

            veteran.ausruestung.Add(alleAusruestung.Spezialmunition);

            return veteran;
        }

        public static subEinheit createLegionaerSarge()
        {
            var sarge = createSpaceMarineSergeant();
            sarge.kg = 5;
            sarge.mw = 10;
            sarge.name = alleSubeinheitenNamen.LegionSergeant;
            return sarge;
        }

        public static subEinheit createLegionaerLegionaer()
        {
            var leg = createLegionaerSarge();
            leg.name = alleSubeinheitenNamen.LegionLegionaer;
            leg.kg = 4;
            return leg;
        }
    }

    /// <summary>
    /// Taktischer Trupp der Space Marines!
    /// </summary>
    public class taktischerTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.TaktischerTrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 90;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Standard);
           
            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProSpaceMarine = 16;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Space Marines erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if(!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpaceMarinesGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };
   

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarinesGesamt; ++i )
            {
                // Okay, legen wir die Space Marines an:
                var spaceMarine = spaceMarineHelperClass.createSpaceMarine();                

                // Von 1 bis 8 nur Standard und keine weiteren Kosten!
                if(i == 7)
                {
                    // Bolter 'raus:
                    spaceMarine.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else if (i == 8)
                {
                    // Bolter 'raus:
                    spaceMarine.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 10 });

                    Auswahl1AusN auswahlWaffe2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe2.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe2.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
 
                subEinheiten.Add(spaceMarine);                
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = spaceMarineHelperClass.createSpaceMarineSergeant();

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            spaceMarineSergeant.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            spaceMarineSergeant.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.TeleportPeilsender, kosten = 15 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                spaceMarineSergeant.ausruestung.Add( (alleAusruestung) pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            if(anzahlSpaceMarinesGesamt==9)
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0: 
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class terminatortrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Terminatortrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProTerminator = 40;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Terminatoren erhalten", gesamtArmeePunkteKosten, punkteKostenProTerminator) { };

            // Okay, wie viele Terminatoren sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheTerminatoren = auswahlAnzahl.anzahlGewaehlt;
            int anzahlTerminatorenGesamt = 4 + zusaetlicheTerminatoren;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheTerminatoren * punkteKostenProTerminator;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlTerminatorenGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var terminator = spaceMarineHelperClass.createTerminator();               

                var terminatorNahkampfWaffen = new List<pulldownAuswahl>() { };
                terminatorNahkampfWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = +0 });
                terminatorNahkampfWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = +5 });

                Auswahl1AusN wahlTerminatorNahkampf = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", terminatorNahkampfWaffen);
                if (!wahlTerminatorNahkampf.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var gewaehlterIndex = wahlTerminatorNahkampf.gewaehlterIndexAusN;
                terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(terminatorNahkampfWaffen[gewaehlterIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + terminatorNahkampfWaffen[gewaehlterIndex].kosten * 1;

                if (i != 3 && i != 8)
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));
                else
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CycloneRaketenwerfer, kosten = +30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +30 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Termiantor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
               
                subEinheiten.Add(terminator);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var terminatorSergeant = spaceMarineHelperClass.createTermiantorSergeant();           

            // Der Sarge hat immer den Sturmbolter und ein E-Schwert!
            terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));
            terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));

            subEinheiten.Add(terminatorSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.LandRaider, kosten = 250 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.LandRaiderCrusader, kosten = 250 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.LandRaiderRedeemer, kosten = 240 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandRaider.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandRaiderCrusader.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandRaiderRedeemer.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class terminatorSturmTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Terminatorsturmtrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProTerminator = 40;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Terminatoren erhalten", gesamtArmeePunkteKosten, punkteKostenProTerminator) { };

            // Okay, wie viele Terminatoren sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheTerminatoren = auswahlAnzahl.anzahlGewaehlt;
            int anzahlTerminatorenGesamt = 4 + zusaetlicheTerminatoren;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheTerminatoren * punkteKostenProTerminator;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlTerminatorenGesamt; ++i)
            {
                var terminator = spaceMarineHelperClass.createTerminator();                

                var terminatorNahkampfWaffen = new List<pulldownAuswahl>() { };
                terminatorNahkampfWaffen.Add(new pulldownAuswahl() { auswahl = "Ein Paar Energieklauen", kosten = +0 });
                terminatorNahkampfWaffen.Add(new pulldownAuswahl() { auswahl = "Energiehammer und Sturmschild", kosten = +0 });

                Auswahl1AusN wahlTerminatorNahkampf = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", terminatorNahkampfWaffen);
                if (!wahlTerminatorNahkampf.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var gewaehlterIndex = wahlTerminatorNahkampf.gewaehlterIndexAusN;
                if (gewaehlterIndex == 0)
                {
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                }
                else
                {
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                    terminator.ausruestung.Add(alleAusruestung.Sturmschild);
                }
                einheitKostenGesamt = einheitKostenGesamt + terminatorNahkampfWaffen[gewaehlterIndex].kosten * 1;
 
                subEinheiten.Add(terminator);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var terminatorSergeant = spaceMarineHelperClass.createTermiantorSergeant();
            
            var sargeNah = new List<pulldownAuswahl>() { };
            sargeNah.Add(new pulldownAuswahl() { auswahl = "Ein Paar Energieklauen", kosten = +0 });
            sargeNah.Add(new pulldownAuswahl() { auswahl = "Energiehammer und Sturmschild", kosten = +0 });

            Auswahl1AusN wahlSargeNah = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", sargeNah);
            if (!wahlSargeNah.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var aktIndex = wahlSargeNah.gewaehlterIndexAusN;
            if (aktIndex == 0)
            {
                terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
            }
            else
            {
                terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                terminatorSergeant.ausruestung.Add(alleAusruestung.Sturmschild);
            }
            einheitKostenGesamt = einheitKostenGesamt + sargeNah[aktIndex].kosten * 1;          

            subEinheiten.Add(terminatorSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.LandRaider, kosten = 250 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.LandRaiderCrusader, kosten = 250 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.LandRaiderRedeemer, kosten = 240 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandRaider.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandRaiderCrusader.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandRaiderRedeemer.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class rhino : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Rhino;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 35;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Reparieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();            
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myRhino = new subEinheit() { };
            myRhino.name = alleSubeinheitenNamen.Rhino;
            myRhino.ausruestung = new List<alleAusruestung>() { };
            myRhino.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myRhino.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            myRhino.waffen = new List<waffe>() { };
            myRhino.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));

     
            var rhinoAusruestung = new List<pulldownAuswahl>() { };
            rhinoAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            rhinoAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            rhinoAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlRhinoAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", rhinoAusruestung);
            if (!wahlRhinoAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlRhinoAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myRhino.ausruestung.Add( (alleAusruestung) rhinoAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + rhinoAusruestung[i].kosten * 1;
            }



            var rhinoWaffen = new List<pulldownAuswahl>() { };
            rhinoWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            AuswahlMAusN wahlRhinoWaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", rhinoWaffen);
            if (!wahlRhinoWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlRhinoWaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myRhino.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(rhinoWaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + rhinoWaffen[i].kosten * 1;
            }


            myRhino.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myRhino.bf = 4;
            myRhino.front = 11;
            myRhino.seit = 11;
            myRhino.heck = 10;
            myRhino.transportkapazitaet = 10;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myRhino);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class kostenloserRhino : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.RhinoKostenlos;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 0;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Reparieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myRhino = new subEinheit() { };
            myRhino.name = alleSubeinheitenNamen.Rhino;
            myRhino.ausruestung = new List<alleAusruestung>() { };
            myRhino.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myRhino.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            myRhino.waffen = new List<waffe>() { };
            myRhino.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));


            var rhinoAusruestung = new List<pulldownAuswahl>() { };
            rhinoAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            rhinoAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            rhinoAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlRhinoAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", rhinoAusruestung);
            if (!wahlRhinoAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlRhinoAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myRhino.ausruestung.Add((alleAusruestung)rhinoAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + rhinoAusruestung[i].kosten * 1;
            }



            var rhinoWaffen = new List<pulldownAuswahl>() { };
            rhinoWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            AuswahlMAusN wahlRhinoWaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", rhinoWaffen);
            if (!wahlRhinoWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlRhinoWaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myRhino.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(rhinoWaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + rhinoWaffen[i].kosten * 1;
            }


            myRhino.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myRhino.bf = 4;
            myRhino.front = 11;
            myRhino.seit = 11;
            myRhino.heck = 10;
            myRhino.transportkapazitaet = 10;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myRhino);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class razorback : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Razorback;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 40;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myRazorback = new subEinheit() { };
            myRazorback.name = alleSubeinheitenNamen.Razorback;
            myRazorback.ausruestung = new List<alleAusruestung>() { };
            myRazorback.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myRazorback.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            myRazorback.waffen = new List<waffe>() { };


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var razorbackHauptWaffen = new List<pulldownAuswahl>() { };
            razorbackHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererBolter, kosten = +0 });
            razorbackHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererFlammenwerfer, kosten = +25 });
            razorbackHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Syncsturmkanone, kosten = +35 });
            razorbackHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = +35 });
            razorbackHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.LaserkanoneUndSynchroPlasma, kosten = +35 });

            Auswahl1AusN wahlRazorGrundWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", razorbackHauptWaffen);
            if (!wahlRazorGrundWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var gewaehlterIndex = wahlRazorGrundWaffen.gewaehlterIndexAusN;

            if (gewaehlterIndex != 4)
            {
                myRazorback.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(razorbackHauptWaffen[gewaehlterIndex].auswahl));
            }
            else
            {
                myRazorback.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Laserkanone));
                myRazorback.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncPlasmawerfer));
            }
            einheitKostenGesamt = einheitKostenGesamt + razorbackHauptWaffen[gewaehlterIndex].kosten * 1;


            var razorAusruestung = new List<pulldownAuswahl>() { };
            razorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            razorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            razorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlRazorAustruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", razorAusruestung);
            if (!wahlRazorAustruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlRazorAustruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myRazorback.ausruestung.Add((alleAusruestung)razorAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + razorAusruestung[i].kosten * 1;
            }



            var razorbackWaffen = new List<pulldownAuswahl>() { };
            razorbackWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            AuswahlMAusN wahlRazorbackWaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen zusätzlich gewählt werden:", razorbackWaffen);
            if (!wahlRazorbackWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlRazorbackWaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myRazorback.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(razorbackWaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + razorbackWaffen[i].kosten * 1;
            }


            myRazorback.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myRazorback.bf = 4;
            myRazorback.front = 11;
            myRazorback.seit = 11;
            myRazorback.heck = 10;
            myRazorback.transportkapazitaet = 6;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myRazorback);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landungskapsel : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Landungskapsel;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 35;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugOffen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.InertialLeitsystem);
            sonderregeln.Add(Sonderregeln.Lahmgelegt);
            sonderregeln.Add(Sonderregeln.LandungskapselAngriff);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myLandungsKapsel = new subEinheit() { };
            myLandungsKapsel.name = alleSubeinheitenNamen.Landungskapsel;
            myLandungsKapsel.ausruestung = new List<alleAusruestung>() { };
            myLandungsKapsel.waffen = new List<waffe>() { };


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var landungsKapselHauptwaffen = new List<pulldownAuswahl>() { };
            landungsKapselHauptwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +0 });
            landungsKapselHauptwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.DeathwindSystem, kosten = +20 });

            Auswahl1AusN wahlRazorGrundWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", landungsKapselHauptwaffen);
            if (!wahlRazorGrundWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var gewaehlterIndex = wahlRazorGrundWaffen.gewaehlterIndexAusN;
            myLandungsKapsel.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(landungsKapselHauptwaffen[gewaehlterIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + landungsKapselHauptwaffen[gewaehlterIndex].kosten * 1;


            var kapselAusruestung = new List<pulldownAuswahl>() { };
            kapselAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Peilsender, kosten = +10 });

            AuswahlMAusN wahlKapselAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", kapselAusruestung);
            if (!wahlKapselAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlKapselAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandungsKapsel.ausruestung.Add((alleAusruestung)kapselAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + kapselAusruestung[i].kosten * 1;
            }

            myLandungsKapsel.einheitentyp = Einheitstyp.FahrzeugOffen;

            // Setzen der Panzerungswerte:
            myLandungsKapsel.bf = 4;
            myLandungsKapsel.front = 12;
            myLandungsKapsel.seit = 12;
            myLandungsKapsel.heck = 12;
            myLandungsKapsel.transportkapazitaet = 12;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myLandungsKapsel);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class kostenloseLandungskapsel : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandungskapselKostenlos;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 0;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugOffen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.InertialLeitsystem);
            sonderregeln.Add(Sonderregeln.Lahmgelegt);
            sonderregeln.Add(Sonderregeln.LandungskapselAngriff);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myLandungsKapsel = new subEinheit() { };
            myLandungsKapsel.name = alleSubeinheitenNamen.Landungskapsel;
            myLandungsKapsel.ausruestung = new List<alleAusruestung>() { };
            myLandungsKapsel.waffen = new List<waffe>() { };


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var landungsKapselHauptwaffen = new List<pulldownAuswahl>() { };
            landungsKapselHauptwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +0 });
            landungsKapselHauptwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.DeathwindSystem, kosten = +20 });

            Auswahl1AusN wahlRazorGrundWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", landungsKapselHauptwaffen);
            if (!wahlRazorGrundWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var gewaehlterIndex = wahlRazorGrundWaffen.gewaehlterIndexAusN;
            myLandungsKapsel.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(landungsKapselHauptwaffen[gewaehlterIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + landungsKapselHauptwaffen[gewaehlterIndex].kosten * 1;


            var kapselAusruestung = new List<pulldownAuswahl>() { };
            kapselAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Peilsender, kosten = +10 });

            AuswahlMAusN wahlKapselAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", kapselAusruestung);
            if (!wahlKapselAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlKapselAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandungsKapsel.ausruestung.Add((alleAusruestung)kapselAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + kapselAusruestung[i].kosten * 1;
            }

            myLandungsKapsel.einheitentyp = Einheitstyp.FahrzeugOffen;

            // Setzen der Panzerungswerte:
            myLandungsKapsel.bf = 4;
            myLandungsKapsel.front = 12;
            myLandungsKapsel.seit = 12;
            myLandungsKapsel.heck = 12;
            myLandungsKapsel.transportkapazitaet = 12;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myLandungsKapsel);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landRaiderCrusader : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandRaiderCrusader;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 250;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.MachtDesMaschinengeistes);
            sonderregeln.Add(Sonderregeln.Sturmpanzer);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCrusader = new subEinheit() { };
            myCrusader.name = alleSubeinheitenNamen.LandRaiderCrusader;
            myCrusader.ausruestung = new List<alleAusruestung>() { };
            myCrusader.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myCrusader.ausruestung.Add(alleAusruestung.Splittergranatwerfer);
            myCrusader.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myCrusader.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myCrusader.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Syncsturmkanone));
            myCrusader.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.HurricaneBolter));
            myCrusader.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.HurricaneBolter));


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var crusaderZusatzWaffen = new List<pulldownAuswahl>() { };
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

            AuswahlMAusN wahlCrusaderZusatzwaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", crusaderZusatzWaffen);
            if (!wahlCrusaderZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlCrusaderZusatzwaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCrusader.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(crusaderZusatzWaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + crusaderZusatzWaffen[i].kosten * 1;
            }


            var crusaderAusruestung = new List<pulldownAuswahl>() { };
            crusaderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            crusaderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlCrusaderAusruesutng = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", crusaderAusruestung);
            if (!wahlCrusaderAusruesutng.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlCrusaderAusruesutng.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCrusader.ausruestung.Add((alleAusruestung)crusaderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + crusaderAusruestung[i].kosten * 1;
            }

            myCrusader.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myCrusader.bf = 4;
            myCrusader.front = 14;
            myCrusader.seit = 14;
            myCrusader.heck = 14;
            myCrusader.transportkapazitaet = 16;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCrusader);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landRaider : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandRaider;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 250;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.MachtDesMaschinengeistes);
            sonderregeln.Add(Sonderregeln.Sturmpanzer);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myLandRaider = new subEinheit() { };
            myLandRaider.name = alleSubeinheitenNamen.LandRaider;
            myLandRaider.ausruestung = new List<alleAusruestung>() { };
            myLandRaider.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myLandRaider.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myLandRaider.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncSchwererBolter));
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncLaserKanone));
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncLaserKanone));



            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var landRaiderZusatzwaffen = new List<pulldownAuswahl>() { };
            landRaiderZusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            landRaiderZusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

            AuswahlMAusN wahlLandRaiderZusatzwaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", landRaiderZusatzwaffen);
            if (!wahlLandRaiderZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderZusatzwaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(landRaiderZusatzwaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + landRaiderZusatzwaffen[i].kosten * 1;
            }


            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandRaider.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            myLandRaider.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myLandRaider.bf = 4;
            myLandRaider.front = 14;
            myLandRaider.seit = 14;
            myLandRaider.heck = 14;
            myLandRaider.transportkapazitaet = 12;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myLandRaider);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landRaiderRedeemer : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandRaiderRedeemer;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 240;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.MachtDesMaschinengeistes);
            sonderregeln.Add(Sonderregeln.Sturmpanzer);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myLandRaider = new subEinheit() { };
            myLandRaider.name = alleSubeinheitenNamen.LandRaiderRedeemer;
            myLandRaider.ausruestung = new List<alleAusruestung>() { };
            myLandRaider.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myLandRaider.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myLandRaider.ausruestung.Add(alleAusruestung.Splittergranatwerfer);
            myLandRaider.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Syncsturmkanone));
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Flammensturmkanone));
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Flammensturmkanone));



            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var landRaiderZusatzwaffen = new List<pulldownAuswahl>() { };
            landRaiderZusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            landRaiderZusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

            AuswahlMAusN wahlLandRaiderZusatzwaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", landRaiderZusatzwaffen);
            if (!wahlLandRaiderZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderZusatzwaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(landRaiderZusatzwaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + landRaiderZusatzwaffen[i].kosten * 1;
            }


            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandRaider.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            myLandRaider.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myLandRaider.bf = 4;
            myLandRaider.front = 14;
            myLandRaider.seit = 14;
            myLandRaider.heck = 14;
            myLandRaider.transportkapazitaet = 12;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myLandRaider);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class whirlwind : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Whirlwind;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 85;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myWhirlwind = new subEinheit() { };
            myWhirlwind.name = alleSubeinheitenNamen.Whirlwind;
            myWhirlwind.ausruestung = new List<alleAusruestung>() { };
            myWhirlwind.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myWhirlwind.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myWhirlwind.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myWhirlwind.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.WhirlwindMehrfachRaketenWerfer));


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var zusatzwaffen = new List<pulldownAuswahl>() { };
            zusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });

            AuswahlMAusN wahlZusatzwaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", zusatzwaffen);
            if (!wahlZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlZusatzwaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myWhirlwind.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(zusatzwaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + zusatzwaffen[i].kosten * 1;
            }


            var listeAusruestung = new List<pulldownAuswahl>() { };
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", listeAusruestung);
            if (!wahlAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myWhirlwind.ausruestung.Add((alleAusruestung)listeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + listeAusruestung[i].kosten * 1;
            }

            myWhirlwind.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myWhirlwind.bf = 4;
            myWhirlwind.front = 11;
            myWhirlwind.seit = 11;
            myWhirlwind.heck = 10;
            myWhirlwind.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myWhirlwind);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class vindicator : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Vindicator;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 115;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myVindi = new subEinheit() { };
            myVindi.name = alleSubeinheitenNamen.Vindicator;
            myVindi.ausruestung = new List<alleAusruestung>() { };
            myVindi.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myVindi.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myVindi.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myVindi.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.DemolisherGeschuetz));
            myVindi.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var zusatzwaffen = new List<pulldownAuswahl>() { };
            zusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });

            AuswahlMAusN wahlZusatzwaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", zusatzwaffen);
            if (!wahlZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlZusatzwaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myVindi.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(zusatzwaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + zusatzwaffen[i].kosten * 1;
            }


            var listeAusruestung = new List<pulldownAuswahl>() { };
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Belagerungsschild, kosten = +10 });
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", listeAusruestung);
            if (!wahlAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myVindi.ausruestung.Add((alleAusruestung)listeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + listeAusruestung[i].kosten * 1;
            }

            myVindi.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myVindi.bf = 4;
            myVindi.front = 13;
            myVindi.seit = 11;
            myVindi.heck = 10;
            myVindi.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myVindi);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class sargeChronus : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.SergeantChronus;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 70;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Panzerkommandant);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.keine);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

          
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var sarge = new subEinheit() { };
            sarge.name = alleSubeinheitenNamen.SergeantChronus;
            sarge.ruestung = alleRuestungen.ServoRuestung;
            sarge.ausruestung = new List<alleAusruestung>() { };
            sarge.ausruestung.Add(alleAusruestung.Servoarm);
            sarge.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            sarge.ausruestung.Add(alleAusruestung.Sprenggranaten);
            sarge.waffen = new List<waffe>() { };
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

            sarge.kg = 4;
            sarge.bf = 5;
            sarge.st = 4;
            sarge.wid = 4;
            sarge.ini = 4;
            sarge.lp = 1;
            sarge.at = 2;
            sarge.mw = 9;
            sarge.rw = 3;
            sarge.ret = 0;

            sarge.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(sarge);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class sargeTellion : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.SergeantTellion;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Infiltratoren);
            sonderregeln.Add(Sonderregeln.DurchDeckungBewegen);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.keine);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var sarge = new subEinheit() { };
            sarge.name = alleSubeinheitenNamen.SergeantTelion;
            sarge.ruestung = alleRuestungen.Scoutruestung;
            sarge.ausruestung = new List<alleAusruestung>() { };
            sarge.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            sarge.ausruestung.Add(alleAusruestung.Sprenggranaten);
            sarge.waffen = new List<waffe>() { };
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.StalkerSchemaBolter));

            sarge.kg = 5;
            sarge.bf = 6;
            sarge.st = 4;
            sarge.wid = 4;
            sarge.ini = 4;
            sarge.lp = 1;
            sarge.at = 2;
            sarge.mw = 9;
            sarge.rw = 4;
            sarge.ret = 0;

            sarge.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(sarge);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class capSicarius : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainCatoSicarius;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.RitenDerSchlacht);
            sonderregeln.Add(Sonderregeln.Ueberraschungsangriff);
            sonderregeln.Add(Sonderregeln.KampfgestaehlteHelden);
            sonderregeln.Add(Sonderregeln.VerletzungenIgnorieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cap = new subEinheit() { };
            cap.name = alleSubeinheitenNamen.CaptainCatoSicarius;
            cap.ruestung = alleRuestungen.MeisterhafteRuestung;
            cap.ausruestung = new List<alleAusruestung>() { };
            cap.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cap.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cap.ausruestung.Add(alleAusruestung.StaehlernerStern);
            cap.waffen = new List<waffe>() { };
            cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.TalassarianischeSturmklinge));
            cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Plasmapistole));

            cap.kg = 6;
            cap.bf = 5;
            cap.st = 4;
            cap.wid = 4;
            cap.ini = 5;
            cap.lp = 3;
            cap.at = 3;
            cap.mw = 10;
            cap.rw = 2;
            cap.ret = 4;

            cap.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cap);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class varroTigurius : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.VarroTigurius;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 230;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.Meisterpsioniker);
            sonderregeln.Add(Sonderregeln.GabeDerVorhersehung);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var tigurius = new subEinheit() { };
            tigurius.name = alleSubeinheitenNamen.VarroTigurius;
            tigurius.ruestung = alleRuestungen.ServoRuestung;
            tigurius.ausruestung = new List<alleAusruestung>() { };
            tigurius.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            tigurius.ausruestung.Add(alleAusruestung.Sprenggranaten);
            tigurius.ausruestung.Add(alleAusruestung.Hoellenfeuermatrix);
            tigurius.waffen = new List<waffe>() { };
            tigurius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.StabDesTigurius));
            tigurius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

            tigurius.psikraefte = new List<Psikraefte>() { };
            tigurius.psikraefte.Add(Psikraefte.Schmetterschlag);
            tigurius.psikraefte.Add(Psikraefte.Psischild);
            tigurius.psikraefte.Add(Psikraefte.AvatarDerSuehne);
            tigurius.psikraefte.Add(Psikraefte.MachtDerAlten);
            tigurius.psikraefte.Add(Psikraefte.Nullzone);
            tigurius.psikraefte.Add(Psikraefte.TorZurUnendlichkeit);
            tigurius.psikraefte.Add(Psikraefte.VortexDerVerdammnis);
            tigurius.psikraefte.Add(Psikraefte.Beschleunigung);
            tigurius.psikraefte.Add(Psikraefte.Maschinenfluch);

            tigurius.kg = 5;
            tigurius.bf = 4;
            tigurius.st = 4;
            tigurius.wid = 4;
            tigurius.ini = 4;
            tigurius.lp = 2;
            tigurius.at = 2;
            tigurius.mw = 10;
            tigurius.rw = 3;
            tigurius.ret = 0;

            tigurius.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(tigurius);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class cassius : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.OrtanCassius;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieEhreDesOrdens);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.LiturgienDerSchlacht);
            sonderregeln.Add(Sonderregeln.VerletzungenIgnorieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cassius = new subEinheit() { };
            cassius.name = alleSubeinheitenNamen.OrtanCassius;
            cassius.ruestung = alleRuestungen.ServoRuestung;
            cassius.ausruestung = new List<alleAusruestung>() { };
            cassius.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cassius.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cassius.ausruestung.Add(alleAusruestung.Rosarius);
            cassius.waffen = new List<waffe>() { };
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Crozius));
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Infernus));

            cassius.kg = 5;
            cassius.bf = 4;
            cassius.st = 4;
            cassius.wid = 6;
            cassius.ini = 4;
            cassius.lp = 2;
            cassius.at = 2;
            cassius.mw = 10;
            cassius.rw = 3;
            cassius.ret = 4;

            cassius.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cassius);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class kantor : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.PedroKantor;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 175;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.OrbitalesBombardement);
            sonderregeln.Add(Sonderregeln.InspirierendeGegenwart);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cassius = new subEinheit() { };
            cassius.name = alleSubeinheitenNamen.PedroKantor;
            cassius.ruestung = alleRuestungen.ServoRuestung;
            cassius.ausruestung = new List<alleAusruestung>() { };
            cassius.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cassius.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cassius.ausruestung.Add(alleAusruestung.StaehlernerStern);
            cassius.waffen = new List<waffe>() { };
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.DornsPfeil));

            cassius.kg = 6;
            cassius.bf = 5;
            cassius.st = 4;
            cassius.wid = 4;
            cassius.ini = 5;
            cassius.lp = 3;
            cassius.at = 3;
            cassius.mw = 10;
            cassius.rw = 3;
            cassius.ret = 4;

            cassius.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cassius);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class lysander : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainLysander;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.BolterDrill);
            sonderregeln.Add(Sonderregeln.EwigerKrieger);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);
            sonderregeln.Add(Sonderregeln.Befestigen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var lys = new subEinheit() { };
            lys.name = alleSubeinheitenNamen.CaptainLysander;
            lys.ruestung = alleRuestungen.TerminatorRuestung;
            lys.ausruestung = new List<alleAusruestung>() { };
            lys.waffen = new List<waffe>() { };
            lys.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.DornsFaust));

            lys.kg = 6;
            lys.bf = 5;
            lys.st = 4;
            lys.wid = 4;
            lys.ini = 5;
            lys.lp = 4;
            lys.at = 3;
            lys.mw = 10;
            lys.rw = 2;
            lys.ret = 5;

            lys.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(lys);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class shrike : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainShrike;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 195;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Sprungtruppen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.SehenAberNichtGesehen);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var shrike = new subEinheit() { };
            shrike.name = alleSubeinheitenNamen.CaptainShrike;
            shrike.ruestung = alleRuestungen.ServoRuestung;
            shrike.ausruestung = new List<alleAusruestung>() { };
            shrike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            shrike.ausruestung.Add(alleAusruestung.Sprenggranaten);
            shrike.ausruestung.Add(alleAusruestung.Sprungmodul);
            shrike.ausruestung.Add(alleAusruestung.StaehlernerStern);
            shrike.waffen = new List<waffe>() { };
            shrike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            shrike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Rabenklauen));

            shrike.kg = 6;
            shrike.bf = 5;
            shrike.st = 4;
            shrike.wid = 4;
            shrike.ini = 5;
            shrike.lp = 3;
            shrike.at = 3;
            shrike.mw = 10;
            shrike.rw = 3;
            shrike.ret = 4;

            shrike.einheitentyp = Einheitstyp.Sprungtruppen;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(shrike);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class vukan : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.VulkanHestan;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 190;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var vulkan = new subEinheit() { };
            vulkan.name = alleSubeinheitenNamen.VulkanHestan;
            vulkan.ruestung = alleRuestungen.MeisterhafteRuestung;

            vulkan.ausruestung = new List<alleAusruestung>() { };
            vulkan.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            vulkan.ausruestung.Add(alleAusruestung.Sprenggranaten);
            vulkan.ausruestung.Add(alleAusruestung.KesaresMantel);
            vulkan.ausruestung.Add(alleAusruestung.Digitalwaffen);

            vulkan.waffen = new List<waffe>() { };
            vulkan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            vulkan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SpeerDesVulkan));
            vulkan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Schmiedefeuerhandschuh));

            vulkan.kg = 6;
            vulkan.bf = 5;
            vulkan.st = 4;
            vulkan.wid = 4;
            vulkan.lp = 3;
            vulkan.ini = 5;
            vulkan.at = 3;
            vulkan.mw = 10;
            vulkan.rw = 2;
            vulkan.ret = 0;

            vulkan.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(vulkan);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class khan : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.KorsarroKhan;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 160;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.MeisterDerJagd);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var khan = new subEinheit() { };
            khan.name = alleSubeinheitenNamen.KorsarroKhan;
            khan.ruestung = alleRuestungen.ServoRuestung;

            khan.ausruestung = new List<alleAusruestung>() { };
            khan.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            khan.ausruestung.Add(alleAusruestung.Sprenggranaten);
            khan.ausruestung.Add(alleAusruestung.StaehlernerStern);


            var listeSubeinheit = new List<pulldownAuswahl>(){};
            listeSubeinheit.Add(new pulldownAuswahl(){auswahl = alleSubeinheitenNamen.SpaceMarineBike, kosten = +45});
            AuswahlMAusN wahlAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", listeSubeinheit);
            if (!wahlAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            // Ggfs. müssen wir noch ein Bike dazu nehmen!
            var wahlVektor = wahlAusruestung.wahlIndexVektor;
            if (wahlVektor.Count != 0)
            {
                khan.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                khan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                einheitKostenGesamt = einheitKostenGesamt + listeSubeinheit[0].kosten;

                khan.wid = 5;
                khan.einheitentyp = Einheitstyp.Bike;
            }
            else
            {
                khan.einheitentyp = Einheitstyp.Infanterie;
                khan.wid = 4;
            }

            khan.waffen = new List<waffe>() { };
            khan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            khan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Mondfang));

            khan.kg = 6;
            khan.bf = 5;
            khan.st = 4;
            khan.lp = 3;
            khan.ini = 5;
            khan.at = 3;
            khan.mw = 10;
            khan.rw = 3;
            khan.ret = 4;

           
            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(khan);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class salvenkanone : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Salvenkanone;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Artillerie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.SegenDesOmnissiah);
            sonderregeln.Add(Sonderregeln.Befestigen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            var techmarine = new subEinheit() { };
            techmarine.name = alleSubeinheitenNamen.Techmarine;
            techmarine.ruestung = alleRuestungen.MeisterhafteRuestung;
            techmarine.ausruestung = new List<alleAusruestung>();
            techmarine.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            techmarine.ausruestung.Add(alleAusruestung.Sprenggranaten);
            techmarine.ausruestung.Add(alleAusruestung.Servoharnisch);
            techmarine.waffen = new List<waffe>() { };
            techmarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

            techmarine.kg = 4;
            techmarine.bf = 4;
            techmarine.st = 4;
            techmarine.wid = 4;            
            techmarine.lp = 1;
            techmarine.ini = 4;
            techmarine.at = 1;
            techmarine.mw = 8;
            techmarine.rw = 2;
            techmarine.ret = 0;
            techmarine.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten.Add(techmarine);

            // Jetzt die eigentliche Salvenkanone: Für sie setzen wir die Werte gleich null.
            var savle = new subEinheit() { };
            savle.name = alleSubeinheitenNamen.Salvenkanone;
            savle.ruestung = alleRuestungen.keine;
            savle.ausruestung = new List<alleAusruestung>();
            savle.waffen = new List<waffe>() { };

            savle.kg = 0;
            savle.bf = 0;
            savle.st = 0;
            savle.wid = 0;
            savle.lp = 0;
            savle.ini = 0;
            savle.at = 0;
            savle.mw = 0;
            savle.rw = 0;
            savle.ret = 0;
            savle.einheitentyp = Einheitstyp.Artillerie;
            subEinheiten.Add(savle);



            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class devastortrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Devastortrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 90;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProSpaceMarine = 16;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Space Marines erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpaceMarinesGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarinesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var spaceMarine = spaceMarineHelperClass.createSpaceMarine();
                
                // Das Gleiche gilt für die Boltpistole!
                spaceMarine.waffen = new List<waffe>() { };
                spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                // Die Marines 1 bis 4 dürfen Extra-Waffen erhalten!
                if (i < 4)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 25 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 35 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                }             

                subEinheiten.Add(spaceMarine);
            }

            ///
            // SARGE:
            ///
            var spaceMarineSergeant = spaceMarineHelperClass.createSpaceMarineSergeant();
           
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Signum);
            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });

            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                spaceMarineSergeant.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            if (anzahlSpaceMarinesGesamt == 9)
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landSpeederStorm : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandspeederStorm;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugSAO;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Schocktruppen);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var storm = new subEinheit() { };
            storm.name = alleSubeinheitenNamen.LandspeederStorm;
            storm.ausruestung = new List<alleAusruestung>() { };
            storm.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            storm.ausruestung.Add(alleAusruestung.Stoersender);

            // Die folgende Bewaffnung gibt es immer:
            storm.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.CerberusWerfer));


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var crusaderZusatzWaffen = new List<pulldownAuswahl>() { };
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +10 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +15 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +35 });

            Auswahl1AusN wahlCrusaderZusatzwaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", crusaderZusatzWaffen);
            if (!wahlCrusaderZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlCrusaderZusatzwaffen.gewaehlterIndexAusN;
            storm.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(crusaderZusatzWaffen[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + crusaderZusatzWaffen[myIndex].kosten * 1;


            storm.einheitentyp = Einheitstyp.FahrzeugSAO;

            // Setzen der Panzerungswerte:
            storm.bf = 3;
            storm.front = 10;
            storm.seit = 10;
            storm.heck = 10;
            storm.transportkapazitaet = 5;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(storm);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class scoutbikerschwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Scoutbikeschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 70;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Bike;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Infiltratoren);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProSpaceMarine = 20;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 3, 10, "Trupp darf bis zu sieben zusätzliche Scouts erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheScouts = auswahlAnzahl.anzahlGewaehlt;
            int anzahlScoutsGesamt = 3 + zusaetlicheScouts;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheScouts * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Soll es Splitterminen geben?
            var scoutExtras = new List<pulldownAuswahl>() { };
            scoutExtras.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Splitterminen, kosten = 10 });
            AuswahlMAusN wahlExtraAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die Scouts dürfen folgende Optionen wählen:", scoutExtras);
            if (!wahlExtraAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlExtraAusruestung.wahlIndexVektor;
            bool hatSplitterminen = false;
            foreach (int i in wahlVektor)
            {
                hatSplitterminen = true;
                einheitKostenGesamt = einheitKostenGesamt + scoutExtras[i].kosten * 1;
            }

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlScoutsGesamt; ++i)
            {
                var scoutBike = new subEinheit() { };
                scoutBike.name = alleSubeinheitenNamen.ScoutAufBike;
                scoutBike.ruestung = alleRuestungen.keine;
                scoutBike.ausruestung = new List<alleAusruestung>() { };
                if (hatSplitterminen)
                    scoutBike.ausruestung.Add(alleAusruestung.Splitterminen);

                scoutBike.waffen = new List<waffe>() { };

                if (i < 3)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncBolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AstartesGranatwerfer, kosten = 10 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    scoutBike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    scoutBike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                }

                // Fehlen noch die eigentlichen Were für den  Marine:
                scoutBike.kg = 3;
                scoutBike.bf = 3;
                scoutBike.st = 4;
                scoutBike.wid = 5;
                scoutBike.lp = 1;
                scoutBike.ini = 4;
                scoutBike.at = 1;
                scoutBike.mw = 8;
                scoutBike.rw = 4;
                scoutBike.ret = 0;

                scoutBike.einheitentyp = Einheitstyp.Bike;
 
                subEinheiten.Add(scoutBike);
            }

            ///
            // SARGE:
            ///

            var scoutSarge = new subEinheit() { };
            scoutSarge.name = alleSubeinheitenNamen.ScoutsergeantAufBike;

            scoutSarge.ausruestung = new List<alleAusruestung>() { };
            scoutSarge.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            scoutSarge.ausruestung.Add(alleAusruestung.Sprenggranaten);
            if (hatSplitterminen)
                scoutSarge.ausruestung.Add(alleAusruestung.Splitterminen);

            scoutSarge.ruestung = alleRuestungen.Scoutruestung;
            scoutSarge.waffen = new List<waffe>() { };
            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scout Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var sargeExtras = new List<pulldownAuswahl>() { };
            sargeExtras.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            sargeExtras.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Peilsender, kosten = 25 });

            AuswahlMAusN wahlSargeAus = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scout Sergeant darf folgende Optionen wählen:", sargeExtras);
            if (!wahlSargeAus.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlSargeAus.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                scoutSarge.ausruestung.Add((alleAusruestung)sargeExtras[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + sargeExtras[i].kosten * 1;
            }


            // Fehlen noch die eigentlichen Were für den  Marine:
            scoutSarge.kg = 4;
            scoutSarge.bf = 4;
            scoutSarge.st = 4;
            scoutSarge.wid = 5;
            scoutSarge.lp = 1;
            scoutSarge.ini = 4;
            scoutSarge.at = 2;
            scoutSarge.mw = 9;
            scoutSarge.rw = 4;
            scoutSarge.ret = 0;
            scoutSarge.einheitentyp = Einheitstyp.Bike;

            subEinheiten.Add(scoutSarge);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class sturmTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Sturmtrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Sprungtruppen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProSpaceMarine = 18;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Space Marines erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpaceMarinesGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;



            // Wir dürfen auf die Sprungmodule verzichten und stattdessen einen KOSTENLOSEN Rhino oder
            // eine KOSTENLOSE Landungskapsel bekommen. Spezialfall!
            var verzichtAuswahl = new List<pulldownAuswahl>() { };
            verzichtAuswahl.Add(new pulldownAuswahl() { auswahl = "Sprungmodule behalten", kosten = 0 });
            verzichtAuswahl.Add(new pulldownAuswahl() { auswahl = "Keine Module, aber kostenloses Transportfahrzeug", kosten = 0 });

            Auswahl1AusN auswahlModule = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", verzichtAuswahl);
            if (!auswahlModule.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            bool hatSprungmodule = true;
            var gewaehlterIndex = auswahlModule.gewaehlterIndexAusN;
            if (gewaehlterIndex == 0)
                hatSprungmodule = true;
            else
                hatSprungmodule = false;


            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarinesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var spaceMarine = spaceMarineHelperClass.createSpaceMarine();
                
                // Jeder Space Marine hat Fragment- und Sprenggranaten (keine Extra-Kosten):
                if(hatSprungmodule)
                    spaceMarine.ausruestung.Add(alleAusruestung.Sprungmodul);

                // Das Gleiche gilt für die Boltpistole!
                spaceMarine.waffen = new List<waffe>() { };


                // Space Marine 5 und 10 dürfen folgende Option haben!
                if (i == 3 || i == 8)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                }

                if(hatSprungmodule)
                    spaceMarine.einheitentyp = Einheitstyp.Sprungtruppen;
                else
                    spaceMarine.einheitentyp = Einheitstyp.Infanterie;

 
                subEinheiten.Add(spaceMarine);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = spaceMarineHelperClass.createSpaceMarineSergeant();
            
            if(hatSprungmodule)
                spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprungmodul);

            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Kettenschwert", kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Plasmapistole und Kettenschwert", kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieschwert", kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieklaue", kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiefaust", kosten = 25 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiehammer", kosten = 30 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energieschwerter", kosten = 30 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energieklauen", kosten = 30 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energiefäuste", kosten = 50 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energiehämmer", kosten = 60 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            switch (wahlIndex)
            {
                case 0:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                    break;
                case 1:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Plasmapistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                    break;
                case 2:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    break;
                case 3:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    break;
                case 4:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                    break;
                case 5:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));                    
                    break;
                case 6:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    break;
                case 7:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    break;
                case 8:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                    break;
                case 9:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                    break;
                default:
                    throw new ArgumentException("Wieder mal nicht aufgepasst! Sturmtrupp Sarge! ;-)");
            }          
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Parierschield, kosten = 5 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            bool hatParierschild = false;
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                if (i == 1)
                    hatParierschild = true;
                spaceMarineSergeant.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            if(hatParierschild)
                spaceMarineSergeant.ret = 5;


            if (hatSprungmodule)
                spaceMarineSergeant.einheitentyp = Einheitstyp.Sprungtruppen;
            else
                spaceMarineSergeant.einheitentyp = Einheitstyp.Infanterie;

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            // Das geht aber nur, wenn wir uns GEGEN Sprungmodule entschieden haben!
            if (!hatSprungmodule)
            {
                var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 0 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 0 });

                Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
                if (!auswahlScreen.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                wahlIndex = auswahlScreen.gewaehlterIndexAusN;

                // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
                switch (wahlIndex)
                {
                    case 0:
                        break;
                    case 1:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.RhinoKostenlos.ToString());
                        break;
                    case 2:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandungskapselKostenlos.ToString());
                        break;
                }
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class expugnatorGarde : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Expugnatorgarde;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.HeroischeIntervention);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProVeteran = 20;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Veteranen erhalten", gesamtArmeePunkteKosten, punkteKostenProVeteran) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlVeteranenGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProVeteran;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Wollen wir Sprungmodule haben?
            var auswahlKonstrukt = new List<pulldownAuswahl>() { };
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "keine Sprungmodule", kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = (anzahlVeteranenGesamt+1)*10 });
            Auswahl1AusN auswahlSprung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Alle Modelle dürfen Sprungmodule erhalten:", auswahlKonstrukt);
            if (!auswahlSprung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSprung.gewaehlterIndexAusN;
            bool hatSprungmodule = false;
            if (wahlIndex == 1)
            {
                hatSprungmodule = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
            }


            // Dürfen's auch ein paar Melterbomben sein?
            auswahlKonstrukt = new List<pulldownAuswahl>() { };
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "keine Melterbomben", kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            Auswahl1AusN auswahlMelter = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Alle Modelle dürfen Metlerbomben erhalten:", auswahlKonstrukt);
            if (!auswahlSprung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlMelter.gewaehlterIndexAusN;
            bool hatMelterbomben = false;
            if (wahlIndex == 1)
            {
                hatMelterbomben = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
            }




            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlVeteranenGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var veteran = spaceMarineHelperClass.createVeteran();
                veteran.name = alleSubeinheitenNamen.VeteranDerSpaceMariens;

                if (hatSprungmodule)
                    veteran.ausruestung.Add(alleAusruestung.Sprungmodul);
                if (hatMelterbomben)
                    veteran.ausruestung.Add(alleAusruestung.Melterbomben);

                // Das Gleiche gilt für die Boltpistole!
                veteran.waffen = new List<waffe>() { };

                // Jeder Veteran darf wählen zwischen folgenden Waffen (der Sarge auch!)
                auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Kettenschwert", kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Sturmschild und Kettenschwert", kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Plasmapistole und Kettenschwert", kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieschwert", kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieklaue", kosten = 15});
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiefaust", kosten = 25 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiehammer", kosten = 30 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energieschwerter", kosten = 30 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energieklauen", kosten = 30 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energiefäuste", kosten = 50 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energiehämmer", kosten = 60 });

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                switch (wahlIndex)
                {
                    case 0:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                        break;
                    case 1:
                        veteran.ausruestung.Add(alleAusruestung.Sturmschild);
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                        break;
                    case 2:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Plasmapistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                        break;
                    case 3:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                        break;
                    case 4:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                        break;
                    case 5:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                        break;
                    case 6:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                        break;
                    case 7:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                        break;
                    case 8:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                        break;
                    case 9:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                        break;
                    case 10:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                        break;
                }           

                subEinheiten.Add(veteran);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = spaceMarineHelperClass.createSpaceMarineSergeant();
            
            if (hatSprungmodule)
                spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprungmodul);
            if (hatMelterbomben)
                spaceMarineSergeant.ausruestung.Add(alleAusruestung.Melterbomben);

            spaceMarineSergeant.waffen = new List<waffe>() { };

            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 10 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => nur dann, wenn keine Sprungmodule gewählt wurden!
            if (!hatSprungmodule)
            {
                var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

                Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
                if (!auswahlScreen.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                wahlIndex = auswahlScreen.gewaehlterIndexAusN;

                // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
                switch (wahlIndex)
                {
                    case 0:
                        break;
                    case 1:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                        break;
                    case 2:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                        break;
                    case 3:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                        break;
                }
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class ehrwCybot : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.EhrwuerdigerCybot;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 165;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugLaeufer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Ehrwuerdig);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCybot = new subEinheit() { };
            myCybot.name = alleSubeinheitenNamen.EhrwuerdigerCybot;
            myCybot.ausruestung = new List<alleAusruestung>() { };
            myCybot.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myCybot.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myCybot.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Wahl des Sturmbolters:
            var wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0});
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });

            Auswahl1AusN wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;



            // Wahl des Multimelters:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererFlammenwerfer, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererBolter, kosten = 5 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = 30 });

            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl der Nahkampfwaffe:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CybotNahkampfWaffe, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 10 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;


            // Wahl der Extra-Ausrüstung:
            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCybot.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            myCybot.einheitentyp = Einheitstyp.FahrzeugLaeufer;

            // Setzen der Panzerungswerte:
            myCybot.kg = 5;
            myCybot.bf = 5;
            myCybot.st = 6;
            myCybot.front = 12;
            myCybot.seit = 12;
            myCybot.heck = 10;
            myCybot.ini = 4;
            myCybot.at = 2;
            myCybot.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCybot);



            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = "kein Transportfahrzeug", kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }



            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class cybot : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Cybot;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 105;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugLaeufer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCybot = new subEinheit() { };
            myCybot.name = alleSubeinheitenNamen.Cybot;
            myCybot.ausruestung = new List<alleAusruestung>() { };
            myCybot.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myCybot.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myCybot.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Wahl des Sturmbolters:
            var wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });

            Auswahl1AusN wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;



            // Wahl des Multimelters:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererFlammenwerfer, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererBolter, kosten = 5 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = 30 });

            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl der Nahkampfwaffe:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CybotNahkampfWaffe, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 10 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;


            // Wahl der Extra-Ausrüstung:
            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCybot.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            myCybot.einheitentyp = Einheitstyp.FahrzeugLaeufer;

            // Setzen der Panzerungswerte:
            myCybot.kg = 4;
            myCybot.bf = 4;
            myCybot.st = 6;
            myCybot.front = 12;
            myCybot.seit = 12;
            myCybot.heck = 10;
            myCybot.ini = 4;
            myCybot.at = 2;
            myCybot.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCybot);



            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = "kein Transportfahrzeug", kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }



            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class ironclad : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.IroncladCybot;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 135;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugLaeufer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DurchDeckungBewegen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCybot = new subEinheit() { };
            myCybot.name = alleSubeinheitenNamen.IroncladCybot;
            myCybot.ausruestung = new List<alleAusruestung>() { };
            myCybot.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myCybot.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myCybot.ausruestung.Add(alleAusruestung.Suchscheinwerfer);
            myCybot.ausruestung.Add(alleAusruestung.ZusaetzlichePanzerung);


            // Frage: Will ich ein Hurricano statt Cybotnahkampfwaffe und Sturmbolter?
            var wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = "Cybotnahkampfwaffe und Sturmbolter", kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.HurricaneBolter, kosten = 0 });

            Auswahl1AusN wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;
            if (myIndex == 1)
            {
                myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.HurricaneBolter));
            }
            else
            {
                // Jetzt darf ich mir noch überlegen, den Sturmbolter zu ersetzen. Die Nahkampfwaffe gibt es immer!
                myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.CybotNahkampfWaffe));

                wahlBolter = new List<pulldownAuswahl>() { };
                wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });

                wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
                if (!wahlBolterWaffen.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
                myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;
            }         

            // Wahl des Multimelters:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 5 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;



            // Wahl der Nahkampfwaffe:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SeismischerHammer, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = 0 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;


            // Wahl der Extra-Ausrüstung:
            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCybot.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            myCybot.einheitentyp = Einheitstyp.FahrzeugLaeufer;

            // Setzen der Panzerungswerte:
            myCybot.kg = 4;
            myCybot.bf = 4;
            myCybot.st = 6;
            myCybot.front = 13;
            myCybot.seit = 13;
            myCybot.heck = 10;
            myCybot.ini = 4;
            myCybot.at = 2;
            myCybot.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCybot);

            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = "kein Transportfahrzeug", kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }



            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class scoutTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Scouttrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 75;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Infiltratoren);
            sonderregeln.Add(Sonderregeln.DurchDeckungBewegen);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Standard);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProSpaceMarine = 13;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Scouts erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlScoutsGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Auswahl vorbereiten:
            var wahlIndex = new int();


            // Tranmäntel?
            var auswahlTarn = new List<pulldownAuswahl>() { };
            auswahlTarn.Add(new pulldownAuswahl() { auswahl = "keine Tarnmäntel", kosten = 0 });
            auswahlTarn.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Tarnmantel, kosten = 3*(anzahlScoutsGesamt+1) });

            Auswahl1AusN ausWahlTarnMantel = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Alle Scouts dürfen Tarnmäntel erhalten:", auswahlTarn);
            if (!ausWahlTarnMantel.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = ausWahlTarnMantel.gewaehlterIndexAusN;
            bool habenTarnmaentel = false;
            if (wahlIndex == 1)
                habenTarnmaentel = true;

            // Auswahl nutzen und Kosten aktualisieren:
            einheitKostenGesamt = einheitKostenGesamt + auswahlTarn[wahlIndex].kosten * 1;



            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlScoutsGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var scout = spaceMarineHelperClass.createScout();

                if (habenTarnmaentel)
                    scout.ausruestung.Add(alleAusruestung.Tarnmantel);

                scout.waffen = new List<waffe>() { };

                // Der erste Scout darf eine Extra-Auswahl treffen:
                if (i == 0)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Schwerer Bolter mit Höllenfeuergeschoss", kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 10 });

                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Schrotflinte, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Scharfschützengewehr, kosten = 0 });


                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Scout darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                    switch (wahlIndex)
                    {
                        case 0:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                            break;
                        case 1:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SchwererBolter));
                            scout.ausruestung.Add(alleAusruestung.Hoellenfeuergeschosse);
                            break;
                        case 2:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Raketenwerfer));
                            break;
                        case 3:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Schrotflinte));
                            break;
                        case 4:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kampfmesser));
                            break;
                        case 5:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Scharfschützengewehr));
                            break;
                    }


                    // Auswahl nutzen und Kosten aktualisieren:
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Schrotflinte, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Scharfschützengewehr, kosten = 0 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }                            
 
                subEinheiten.Add(scout);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var scoutSarge = spaceMarineHelperClass.createSpaceMarineSergeant();

            if (habenTarnmaentel)
                scoutSarge.ausruestung.Add(alleAusruestung.Tarnmantel);

            scoutSarge.ruestung = alleRuestungen.Scoutruestung;
            scoutSarge.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Schrotflinte, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Scharfschützengewehr, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });            
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.TeleportPeilsender, kosten = 15 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                scoutSarge.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(scoutSarge);         

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class spaceMarineCaptain : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainDerSpaceMarines;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;


            var cap = new subEinheit() { };
            cap.name = alleSubeinheitenNamen.CaptainDerSpaceMarines;

            cap.ausruestung = new List<alleAusruestung>() { };
            cap.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cap.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cap.ausruestung.Add(alleAusruestung.StaehlernerStern);

            bool hasSturmschild = false;
            bool hasMeisterhafteRuestung = false;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.MeisterhafteRuestung, kosten = 15 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.TerminatorRuestung, kosten = 40});

            cap.einheitentyp = Einheitstyp.Infanterie;

            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            var wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            if (wahlIndex == 0 || wahlIndex == 1)
            {
                // SERVO
                if (wahlIndex == 0)
                    cap.ruestung = alleRuestungen.ServoRuestung;
                else
                {
                    cap.ruestung = alleRuestungen.MeisterhafteRuestung;
                    hasMeisterhafteRuestung = true;
                }

                // Dann darf ich jetzt auch noch Sprungmodul oder Bike erhalten!
                var auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = "keine Auswahl", kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 35 });

                Auswahl1AusN auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                var intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                        break;
                    case 1:
                        cap.ausruestung.Add(alleAusruestung.Sprungmodul);
                        break;
                    case 2:
                        cap.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                        cap.einheitentyp = Einheitstyp.Bike;
                        break;
                }

                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Normale Waffen ersetzen:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });

                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 15 });

                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                        break;
                    case 12:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                }
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Und jetzt denselben Spaß noch einmal für die andere Hand:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });               
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });


                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen für die Offhand wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


            }
            else
            {
                // TERMIE
                cap.ruestung = alleRuestungen.TerminatorRuestung;
                hasMeisterhafteRuestung = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerRuestung[wahlIndex].kosten * 1;

                // Auswahl: Ich darf den Sturmbolter ersetzen!

                var auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 10 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 20 });

                Auswahl1AusN auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlSturmbolterListe[neuerIndex].kosten * 1;

                // Und das E-Schwert!
                auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 10 });               
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 10 });

                auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                switch (neuerIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                        break;
                    case 5:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Space Marine Cap OOR!");
                }

            }

            // Restliche Auswahlen:
            var pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Hoellenfeuermunition, kosten = 10 });

            AuswahlMAusN wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Optionen wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.ausruestung.Add((alleAusruestung)pulldownCapAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }


            pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AuxilarisGranatwerfer, kosten = 15 });
            wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Waffen zusätzlich wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(pulldownCapAusruestung[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }

            cap.kg = 6;
            cap.bf = 5;
            cap.st = 4;
            cap.wid = 4;
            cap.ini = 5;
            cap.lp = 3;
            cap.at = 3;
            cap.mw = 10;
            if (!hasMeisterhafteRuestung)
                cap.rw = 3;
            else
                cap.rw = 2;
            cap.ret = 4;
            if (hasSturmschild)
                cap.ret = 3;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cap);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class spaceMarineOrdensmeister : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.OrdensmeisterDerSpaceMarines;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.OrbitalesBombardement);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;


            var cap = new subEinheit() { };
            cap.name = alleSubeinheitenNamen.CaptainDerSpaceMarines;

            cap.ausruestung = new List<alleAusruestung>() { };
            cap.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cap.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cap.ausruestung.Add(alleAusruestung.StaehlernerStern);

            cap.einheitentyp = Einheitstyp.Infanterie;


            bool hasSturmschild = false;
            bool hasMeisterhafteRuestung = false;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.MeisterhafteRuestung, kosten = 15 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.TerminatorRuestung, kosten = 40 });

            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            var wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            if (wahlIndex == 0 || wahlIndex == 1)
            {
                // SERVO
                if (wahlIndex == 0)
                    cap.ruestung = alleRuestungen.ServoRuestung;
                else
                {
                    cap.ruestung = alleRuestungen.MeisterhafteRuestung;
                    hasMeisterhafteRuestung = true;
                }

                // Dann darf ich jetzt auch noch Sprungmodul oder Bike erhalten!
                var auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = "keine Auswahl", kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 35 });

                Auswahl1AusN auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                var intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                        break;
                    case 1:
                        cap.ausruestung.Add(alleAusruestung.Sprungmodul);
                        break;
                    case 2:
                        cap.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                        cap.einheitentyp = Einheitstyp.Bike;
                        break;
                }

                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Normale Waffen ersetzen:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });

                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 15 });

                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                        break;
                    case 12:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                }
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Und jetzt denselben Spaß noch einmal für die andere Hand:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });


                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen für die Offhand wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


            }
            else
            {
                // TERMIE
                cap.ruestung = alleRuestungen.TerminatorRuestung;
                hasMeisterhafteRuestung = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerRuestung[wahlIndex].kosten * 1;

                // Auswahl: Ich darf den Sturmbolter ersetzen!

                var auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 10 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 20 });

                Auswahl1AusN auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlSturmbolterListe[neuerIndex].kosten * 1;

                // Und das E-Schwert!
                auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 10 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 10 });

                auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                switch (neuerIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                        break;
                    case 5:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Space Marine Cap OOR!");
                }

            }

            // Restliche Auswahlen:
            var pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Hoellenfeuermunition, kosten = 10 });

            AuswahlMAusN wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Optionen wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.ausruestung.Add((alleAusruestung)pulldownCapAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }


            pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AuxilarisGranatwerfer, kosten = 15 });
            wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Waffen zusätzlich wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(pulldownCapAusruestung[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }

            cap.kg = 6;
            cap.bf = 5;
            cap.st = 4;
            cap.wid = 4;
            cap.ini = 5;
            cap.lp = 3;
            cap.at = 3;
            cap.mw = 10;
            if (!hasMeisterhafteRuestung)
                cap.rw = 3;
            else
                cap.rw = 2;
            cap.ret = 4;
            if (hasSturmschild)
                cap.ret = 3;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cap);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class protektorGarde : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Protektorgarde;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Kampftrupps);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProVeteran = 25;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Veteranen erhalten", gesamtArmeePunkteKosten, punkteKostenProVeteran) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetzlicheVeteranen = auswahlAnzahl.anzahlGewaehlt;
            int anzahlVeteranenGesamt = 4 + zusaetzlicheVeteranen;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetzlicheVeteranen * punkteKostenProVeteran;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlVeteranenGesamt; ++i)
            {
                var veteran = spaceMarineHelperClass.createVeteran();              

                veteran.waffen = new List<waffe>() { };
                veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));               

                // Bolter darf immer ersetzt werden! Für die ersten beiden Modelle sogar durch noch mehr Extras!
                if (i < 2)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });

                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 15 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Veteran darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    // Jetzt nur die Variante ohne Extras:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Veteran darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }                          

                subEinheiten.Add(veteran);     
            }

            // Sarge:
            var sarge = spaceMarineHelperClass.createSpaceMarineSergeant();            
            sarge.ausruestung.Add(alleAusruestung.Spezialmunition);

            sarge.waffen = new List<waffe>() { };

            // Zunächst einmal darf der Bolter ersetzt werden:
            var auswSarge1 = new List<pulldownAuswahl>() { };
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });

            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlWaffeS1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant darf eine der folgenden Waffen wählen:", auswSarge1);
            if (!auswahlWaffeS1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlWaffeS1.gewaehlterIndexAusN;
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswSarge1[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswSarge1[wahlIndex].kosten * 1;

            // Desgleichen für die zweite Hand:
            auswSarge1 = new List<pulldownAuswahl>() { };
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlWaffeS2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant darf eine der folgenden Waffen wählen:", auswSarge1);
            if (!auswahlWaffeS1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlWaffeS2.gewaehlterIndexAusN;
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswSarge1[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswSarge1[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });

            // Ausrüstung:
            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                sarge.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(sarge);
                        
            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0: 
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class predator : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Predator;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 60;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myPredator = new subEinheit() { };
            myPredator.name = alleSubeinheitenNamen.Predator;
            myPredator.ausruestung = new List<alleAusruestung>() { };
            myPredator.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myPredator.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            myPredator.waffen = new List<waffe>() { };
            myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Maschinenkanone));


            // Ich darf die Maschinenkanone auch ersetzen durch eine andere Auswahl!
            var predatorHauptWaffen = new List<pulldownAuswahl>() { };
            predatorHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Maschinenkanone, kosten = 0 });
            predatorHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = 45 });

            Auswahl1AusN wahlPredatorHauptwaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", predatorHauptWaffen);
            if (!wahlPredatorHauptwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = wahlPredatorHauptwaffen.gewaehlterIndexAusN;
            myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(predatorHauptWaffen[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + predatorHauptWaffen[wahlIndex].kosten * 1;

            var predatorNebenWaffen = new List<pulldownAuswahl>() { };
            predatorNebenWaffen.Add(new pulldownAuswahl() { auswahl = "Zwei Seitenkuppeln mit schwerem Bolter", kosten = +25 });
            predatorNebenWaffen.Add(new pulldownAuswahl() { auswahl = "Zwei Seitenkuppeln mit Laserkanonen", kosten = +60 });
            Auswahl1AusN wahlPredatorNabenwaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", predatorNebenWaffen);
            if (!wahlPredatorNabenwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlPredatorNabenwaffen.gewaehlterIndexAusN;
            if (wahlIndex == 0)
            {
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SchwererBolter));
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SchwererBolter));
            }
            else
            {
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Laserkanone));
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Laserkanone));
            }
            einheitKostenGesamt = einheitKostenGesamt + predatorNebenWaffen[wahlIndex].kosten * 1;



            var predatorAusruestung = new List<pulldownAuswahl>() { };
            predatorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            predatorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            predatorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlPredatorAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", predatorAusruestung);
            if (!wahlPredatorAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlPredatorAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myPredator.ausruestung.Add((alleAusruestung)predatorAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + predatorAusruestung[i].kosten * 1;
            }



            var predatorWaffen = new List<pulldownAuswahl>() { };
            predatorWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });

            AuswahlMAusN wahlPredatorWaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", predatorWaffen);
            if (!wahlPredatorWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlPredatorWaffen.wahlIndexVektor;

            foreach (int i in wahlVektor)
            {
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(predatorWaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + predatorWaffen[i].kosten * 1;
            }


            myPredator.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myPredator.bf = 4;
            myPredator.front = 13;
            myPredator.seit = 11;
            myPredator.heck = 10;
            myPredator.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myPredator);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landSpeederSchwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Landspeederschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugSchnellAntigrav;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Schocktruppen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            subEinheiten = new List<subEinheit>() { };

            // Wie viele Speeder wollen wir haben?
            int punkteKostenProSpeeder = 50;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 1, 3, "Trupp darf bis zu zwei zusätzliche Speeder erhalten", gesamtArmeePunkteKosten, punkteKostenProSpeeder) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpeeder = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpeederGesamt = 1 + zusaetlicheSpeeder;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpeeder * punkteKostenProSpeeder;

            for (int k = 0; k < anzahlSpeederGesamt; ++k)
            {
                // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
                var speeder = new subEinheit() { };
                speeder.name = alleSubeinheitenNamen.Landspeeder;
                speeder.ausruestung = new List<alleAusruestung>() { };
                speeder.waffen = new List<waffe>() { };


                // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                var speederWaffen1 = new List<pulldownAuswahl>() { };
                speederWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
                speederWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +0 });
                speederWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

                Auswahl1AusN wahlSpeederWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", speederWaffen1);
                if (!wahlSpeederWaffen1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var myIndex = wahlSpeederWaffen1.gewaehlterIndexAusN;
                speeder.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(speederWaffen1[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + speederWaffen1[myIndex].kosten * 1;

                // Und zusätzlich zwischen diesen:
                var speederWaffen2 = new List<pulldownAuswahl>() { };
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = "keine Zusatzwaffen", kosten = +0 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.TyphoonRaketenwerfer, kosten = +40 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +10 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +10 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +20 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +40 });

                Auswahl1AusN wahlSpeederWaffen2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", speederWaffen2);
                if (!wahlSpeederWaffen2.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                myIndex = wahlSpeederWaffen2.gewaehlterIndexAusN;
                if (myIndex != 0)
                    speeder.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(speederWaffen2[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + speederWaffen2[myIndex].kosten * 1;

                speeder.einheitentyp = Einheitstyp.FahrzeugSchnellAntigrav;

                // Setzen der Panzerungswerte:
                speeder.bf = 4;
                speeder.front = 10;
                speeder.seit = 10;
                speeder.heck = 10;
                speeder.transportkapazitaet = 0;
                subEinheiten.Add(speeder);
            }


            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class trikeSchwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Trikeschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 40;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Bike;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            subEinheiten = new List<subEinheit>() { };

            // Wie viele Speeder wollen wir haben?
            int punkteKostenProTrike = 40;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 1, 3, "Trupp darf bis zu zwei zusätzliche Trikes erhalten", gesamtArmeePunkteKosten, punkteKostenProTrike) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheTrikes = auswahlAnzahl.anzahlGewaehlt;
            int anzahlTrikesGesamt = 1 + zusaetlicheTrikes;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheTrikes * punkteKostenProTrike;

            for (int k = 0; k < anzahlTrikesGesamt; ++k)
            {
                // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
                var trike = new subEinheit() { };
                trike.name = alleSubeinheitenNamen.Trike;
                trike.ausruestung = new List<alleAusruestung>() { };
                trike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                trike.ausruestung.Add(alleAusruestung.Sprenggranaten);
                trike.ausruestung.Add(alleAusruestung.SpaceMarineBike);

                trike.waffen = new List<waffe>() { };
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                trike.ruestung = alleRuestungen.ServoRuestung;

                // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                var trikeWaffen1 = new List<pulldownAuswahl>() { };
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

                Auswahl1AusN wahlTrikeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", trikeWaffen1);
                if (!wahlTrikeWaffen1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var myIndex = wahlTrikeWaffen1.gewaehlterIndexAusN;
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(trikeWaffen1[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + trikeWaffen1[myIndex].kosten * 1;

                trike.einheitentyp = Einheitstyp.Bike;

                // Setzen der Panzerungswerte:
                trike.kg = 4;
                trike.bf = 4;
                trike.st = 4;
                trike.wid = 5;
                trike.lp = 2;
                trike.ini = 4;
                trike.at = 2;
                trike.mw = 8;
                trike.rw = 3;

                subEinheiten.Add(trike);
            }


            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class bikeSchwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Bikerschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 90;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Bike;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Kampftrupps);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            subEinheiten = new List<subEinheit>() { };

            // Wie viele Speeder wollen wir haben?
            int punkteKostenProBike = 40;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 3, 8, "Trupp darf bis zu fünf zusätzliche Bikes erhalten", gesamtArmeePunkteKosten, punkteKostenProBike) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheBikes = auswahlAnzahl.anzahlGewaehlt;
            int anzahlBikesGesamt = 1 + zusaetlicheBikes;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheBikes * punkteKostenProBike;

            for (int k = 0; k < anzahlBikesGesamt; ++k)
            {
                // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
                var bike = new subEinheit() { };
                bike.name = alleSubeinheitenNamen.SpaceMarineAufBike;
                bike.ausruestung = new List<alleAusruestung>() { };
                bike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                bike.ausruestung.Add(alleAusruestung.Sprenggranaten);
                bike.ausruestung.Add(alleAusruestung.SpaceMarineBike);

                bike.waffen = new List<waffe>() { };
                bike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));                

                bike.ruestung = alleRuestungen.ServoRuestung;

                if (k < 2)
                {
                    // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                    var bikeWaffen1 = new List<pulldownAuswahl>() { };
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = +0 });
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = +5 });
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = +10 });
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = +15 });

                    Auswahl1AusN wahlBikeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", bikeWaffen1);
                    if (!wahlBikeWaffen1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }
                    var myIndex = wahlBikeWaffen1.gewaehlterIndexAusN;
                    bike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(bikeWaffen1[myIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + bikeWaffen1[myIndex].kosten * 1;
                }
                else
                {
                    bike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                }


                bike.einheitentyp = Einheitstyp.Bike;

                // Setzen der Panzerungswerte:
                bike.kg = 4;
                bike.bf = 4;
                bike.st = 4;
                bike.wid = 5;
                bike.lp = 1;
                bike.ini = 4;
                bike.at = 1;
                bike.mw = 8;
                bike.rw = 3;

                subEinheiten.Add(bike);
            }

            // Sarge:
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var sarge = new subEinheit() { };
            sarge.name = alleSubeinheitenNamen.SergeantDerSpaceMarinesAufBike;
            sarge.ausruestung = new List<alleAusruestung>() { };
            sarge.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            sarge.ausruestung.Add(alleAusruestung.Sprenggranaten);
            sarge.ausruestung.Add(alleAusruestung.SpaceMarineBike);

            sarge.waffen = new List<waffe>() { };
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));

            sarge.ruestung = alleRuestungen.ServoRuestung;

            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var sargeWaffen1 = new List<pulldownAuswahl>() { };
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = +0 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = +15 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = +10 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = +10 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = +10 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = +15 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = +25 });

            Auswahl1AusN wahlSargeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss für den Sergeant gewählt werden:", sargeWaffen1);
            if (!wahlSargeWaffen1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex2 = wahlSargeWaffen1.gewaehlterIndexAusN;
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(sargeWaffen1[myIndex2].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + sargeWaffen1[myIndex2].kosten * 1;           

            // Es dürfen noch Melterbomben gewählt werden!
            var listeAusruestung = new List<pulldownAuswahl>() { };
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = +5 });

            AuswahlMAusN wahlAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen für den Sergeant gewählt werden:", listeAusruestung);
            if (!wahlAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                sarge.ausruestung.Add((alleAusruestung)listeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + listeAusruestung[i].kosten * 1;
            }

            sarge.einheitentyp = Einheitstyp.Bike;

            // Setzen der Panzerungswerte:
            sarge.kg = 4;
            sarge.bf = 4;
            sarge.st = 4;
            sarge.wid = 5;
            sarge.lp = 2;
            sarge.ini = 4;
            sarge.at = 2;
            sarge.mw = 9;
            sarge.rw = 3;

            subEinheiten.Add(sarge);

            // Jetzt muss ich noch auswählen, ob ich ein Trike zusätzlich will!
            var wahlTrikeRein = new List<pulldownAuswahl>() { };
            wahlTrikeRein.Add(new pulldownAuswahl() { auswahl = "kein Trike", kosten = +0 });
            wahlTrikeRein.Add(new pulldownAuswahl() { auswahl = alleSubeinheitenNamen.Trike, kosten = +40 });
            Auswahl1AusN wahlTrikeReinS = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Soll ein Trike hinzugefügt werden?", wahlTrikeRein);
            if (!wahlTrikeReinS.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex2 = wahlTrikeReinS.gewaehlterIndexAusN;

            if (myIndex2 != 0)
            {
                // Also noch ein Trike rein!
                var trike = new subEinheit() { };
                trike.name = alleSubeinheitenNamen.Trike;
                trike.ausruestung = new List<alleAusruestung>() { };
                trike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                trike.ausruestung.Add(alleAusruestung.Sprenggranaten);
                trike.ausruestung.Add(alleAusruestung.SpaceMarineBike);

                trike.waffen = new List<waffe>() { };
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                trike.ruestung = alleRuestungen.ServoRuestung;

                // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                var trikeWaffen1 = new List<pulldownAuswahl>() { };
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

                Auswahl1AusN wahlTrikeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss für das Trike gewählt werden:", trikeWaffen1);
                if (!wahlTrikeWaffen1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var myIndex = wahlTrikeWaffen1.gewaehlterIndexAusN;
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(trikeWaffen1[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + trikeWaffen1[myIndex].kosten * 1;

                trike.einheitentyp = Einheitstyp.Bike;

                // Setzen der Panzerungswerte:
                trike.kg = 4;
                trike.bf = 4;
                trike.st = 4;
                trike.wid = 5;
                trike.lp = 2;
                trike.ini = 4;
                trike.at = 2;
                trike.mw = 8;
                trike.rw = 3;

                subEinheiten.Add(trike);
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class legionOfTheDamned : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LegionOfTheDamned;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 155;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Furchtlos);
            sonderregeln.Add(Sonderregeln.UnbeugsameGeister);
            sonderregeln.Add(Sonderregeln.WieAusDemNichts);
            sonderregeln.Add(Sonderregeln.LangsamUndEntschlossen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProLegionaer = 30;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Legionäre erhalten", gesamtArmeePunkteKosten, punkteKostenProLegionaer) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheLegionaere = auswahlAnzahl.anzahlGewaehlt;
            int anzahlLegionaereGesamt = 4 + zusaetlicheLegionaere;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheLegionaere * punkteKostenProLegionaer;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlLegionaereGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var legionaer = spaceMarineHelperClass.createLegionaerLegionaer();

                if (i == 0)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    legionaer.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = +20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = +20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = +20 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Legionär darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    legionaer.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else if (i == 1)
                {
                    legionaer.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 30 });

                    Auswahl1AusN auswahlWaffe2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Legionär darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe2.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe2.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    legionaer.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }

                subEinheiten.Add(legionaer);
            }

            ///
            // SARGE:
            ///
            var legionSarge = spaceMarineHelperClass.createLegionaerSarge();
            
            legionSarge.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant der Legion muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            legionSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant der Legion muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            legionSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            subEinheiten.Add(legionSarge);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class techmarine : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Techmarine;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.SegenDesOmnissiah);
            sonderregeln.Add(Sonderregeln.Befestigen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);

            int punkteKostenProServitor = 15;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 0, 5, "Trupp darf bis zu fünf Servitoren erhalten", gesamtArmeePunkteKosten, punkteKostenProServitor) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheServitoren = auswahlAnzahl.anzahlGewaehlt;
            int anzahlServitorenGesamt = zusaetlicheServitoren;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheServitoren * punkteKostenProServitor;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlServitorenGesamt; ++i)
            {
                var servitor = new subEinheit() { };
                servitor.name = alleSubeinheitenNamen.Servitor;

                servitor.ruestung = alleRuestungen.Scoutruestung;

                servitor.ausruestung = new List<alleAusruestung>();

                servitor.waffen = new List<waffe>() { };

                if (i == 0)
                    this.sonderregeln.Add(Sonderregeln.Lobotomie);

                if (i < 2)
                {
                    // Servoarm darf ersetzt werden!
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Servoarm, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = +30 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Servitor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    servitor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    servitor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Servoarm));
                }

                servitor.kg = 3;
                servitor.bf = 3;
                servitor.st = 3;
                servitor.wid = 3;
                servitor.lp = 1;
                servitor.ini = 3;
                servitor.at = 8;
                servitor.mw = 10;
                servitor.rw = 4;
                servitor.ret = 0;

                servitor.einheitentyp = Einheitstyp.Infanterie;

                subEinheiten.Add(servitor);
            }

            ///
            // Techmarine:
            ///
            var techmar = new subEinheit() { };
            techmar.name = alleSubeinheitenNamen.Techmarine;

            techmar.ausruestung = new List<alleAusruestung>() { };
            techmar.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            techmar.ausruestung.Add(alleAusruestung.Sprenggranaten);
            techmar.ruestung = alleRuestungen.MeisterhafteRuestung;
            techmar.waffen = new List<waffe>() { };

            // Servoarm aufwerten?
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Servoarm, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Servoharnisch, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            if (wahlIndex == 0)
            {
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl)); 
            }
            else
            {
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Servoarm));
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Servoarm));
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncPlasmapistole));
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Flammenwerfer));
            }            
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Weitere Waffen:
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;


            var auswahlSargePulldown3 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown3.Add(new pulldownAuswahl() { auswahl = "keine Auswahl", kosten = 0 });
            auswahlSargePulldown3.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown3.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });
            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine darf eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown3);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            if (wahlIndex > 0)
            {
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown3[wahlIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown3[wahlIndex].kosten * 1;
            }

            techmar.einheitentyp = Einheitstyp.Infanterie;
            techmar.wid = 4;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 35 });

            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                techmar.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                techmar.einheitentyp = Einheitstyp.Bike;
                techmar.wid = 5;
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            techmar.kg = 4;
            techmar.bf = 4;
            techmar.st = 4;
            techmar.wid = 4;
            techmar.lp = 1;
            techmar.ini = 4;
            techmar.at = 1;
            techmar.mw = 8;
            techmar.rw = 2;
            techmar.ret = 0;

            subEinheiten.Add(techmar);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class scriptorDerSpaceMariens : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Scriptor;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.Psioniker);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var scriptor = new subEinheit() { };
            scriptor.name = alleSubeinheitenNamen.ScriptorSpaceMarines;

            scriptor.einheitentyp = Einheitstyp.Infanterie;

            scriptor.ausruestung = new List<alleAusruestung>() { };
            scriptor.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            scriptor.ausruestung.Add(alleAusruestung.Sprenggranaten);
            scriptor.ausruestung.Add(alleAusruestung.Psimatrix);
            scriptor.waffen = new List<waffe>() { };
            scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Psiwaffe));

            scriptor.einheitentyp = Einheitstyp.Infanterie;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.TerminatorRuestung, kosten = 25 });           
            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            bool hasTermieRuestung = (wahlIndex==1);
            if (!hasTermieRuestung)
                scriptor.ruestung = alleRuestungen.ServoRuestung;
            else
            {
                scriptor.ruestung = alleRuestungen.TerminatorRuestung;
                einheitKostenGesamt = einheitKostenGesamt + 40;
            }


            // Wahl der Psikräfte:
            var wahlPsi = new List<pulldownAuswahl>() { };
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Schmetterschlag, kosten = 0});
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Psischild, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Maschinenfluch, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Beschleunigung, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Nullzone, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.AvatarDerSuehne, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.MachtDerAlten, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.TorZurUnendlichkeit, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.VortexDerVerdammnis, kosten = 0 });
            Auswahl1AusN wahlPsi1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine der folgenden Psikräfte wählen:", wahlPsi);
            if (!wahlPsi1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlPsi1.gewaehlterIndexAusN;

            scriptor.psikraefte.Add((Psikraefte)wahlPsi[wahlIndex].auswahl);

            // Für die zweite Wahl muss genau diese entfernt werden!
            wahlPsi.RemoveAt(wahlIndex);
            wahlPsi1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine weitere der folgenden Psikräfte wählen:", wahlPsi);
            if (!wahlPsi1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlPsi1.gewaehlterIndexAusN;

            scriptor.psikraefte.Add((Psikraefte)wahlPsi[wahlIndex].auswahl);

            // Soll es ein Epistolarius sein?
            var wahlEpist = new List<pulldownAuswahl> { };
            wahlEpist.Add(new pulldownAuswahl() { auswahl = "keine Aufwertung", kosten = 0 });
            wahlEpist.Add(new pulldownAuswahl() { auswahl = "Aufwertung zum Epistolarius", kosten = 50 });
            Auswahl1AusN wahlEpi = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine der folgenden Auswahlen treffen:", wahlEpist);
            if (!wahlEpi.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlEpi.gewaehlterIndexAusN;
            if (wahlIndex > 0)
            {
                einheitKostenGesamt = einheitKostenGesamt + 50;
                sonderregeln.Add(Sonderregeln.Epistolarius);
            }


            scriptor.wid = 4;
            // Fall1: Kein Termi!
            if (!hasTermieRuestung)
            {
                // Wahl Waffe:
                var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });              

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                scriptor.rw = 3;
                scriptor.ret = 0;

                // Wahl für Sprungmodul oder Bike!
                var auswahlSprung = new List<pulldownAuswahl>() { };
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = "kein Upgrade", kosten = 0 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = +25 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = +35 });
                Auswahl1AusN auswahlSprung1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor darf eine der folgenden Auswahlen treffen:", auswahlSprung);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                if(wahlIndex ==1)
                {
                    // Sprungmodul!
                    scriptor.ausruestung.Add(alleAusruestung.Sprungmodul);
                    einheitKostenGesamt = einheitKostenGesamt + 25;
                    this.einheitentyp = Einheitstyp.Sprungtruppen;
                    scriptor.einheitentyp = Einheitstyp.Sprungtruppen;
                }
                if (wahlIndex == 2)
                {
                    // Bike!
                    scriptor.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                    this.einheitentyp = Einheitstyp.Bike;
                    scriptor.einheitentyp = Einheitstyp.Bike;
                    scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                    scriptor.wid = 5;
                }

            }
            else
            {
                // Doch Termie! Wähe die Waffe!
                var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Sturmschild", kosten = 15 });

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                if (wahlIndex != 5)
                {
                    scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));                    
                }
                else
                {
                    scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    scriptor.ausruestung.Add(alleAusruestung.Sturmschild);              
                }
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                scriptor.rw = 2;
                scriptor.ret = 5;
            }


            scriptor.kg = 5;
            scriptor.bf = 4;
            scriptor.st = 4;           
            scriptor.ini = 4;
            scriptor.lp = 2;
            scriptor.at = 2;
            scriptor.mw = 10;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(scriptor);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class ordenspriesterDerSpaceMarines : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.OrdenspriesterDerSpaceMarines;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.LiturgienDerSchlacht);
            sonderregeln.Add(Sonderregeln.DieEhreDesOrdens);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            base.createUnitInteraktion(100);


            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var ordenspriester = new subEinheit() { };
            ordenspriester.name = alleSubeinheitenNamen.OrdenspriesterDerSpaceMarines;

            ordenspriester.einheitentyp = Einheitstyp.Infanterie;

            ordenspriester.ausruestung = new List<alleAusruestung>() { };
            ordenspriester.ausruestung.Add(alleAusruestung.Rosarius);

            ordenspriester.waffen = new List<waffe>() { };
            ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Crozius));

            ordenspriester.einheitentyp = Einheitstyp.Infanterie;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Sturmbolter", kosten = 30 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Kombi-Flammenwerfer", kosten = 35 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Kombi-Melter", kosten = 35 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Kombi-Plasmawerfer", kosten = 35 });
            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            bool hasTermieRuestung = (wahlIndex > 0);
            if (!hasTermieRuestung)
            {
                ordenspriester.ruestung = alleRuestungen.ServoRuestung;
                ordenspriester.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                ordenspriester.ausruestung.Add(alleAusruestung.Sprenggranaten);
            }
            else
            {
                ordenspriester.ruestung = alleRuestungen.TerminatorRuestung;
                ordenspriester.rw = 2;
                ordenspriester.ret = 5;

                if (wahlIndex == 1)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));
                    einheitKostenGesamt = einheitKostenGesamt + 30;
                }
                if (wahlIndex == 2)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.KombiFlammenwerfer));
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                }
                if (wahlIndex == 3)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.KombiMelter));
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                }
                if (wahlIndex == 4)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.KombiPlasmawerfer));
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                }
            }


            ordenspriester.wid = 4;
            // Fall1: Kein Termi!
            if (!hasTermieRuestung)
            {
                ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                // Wahl Waffe:
                var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                ordenspriester.rw = 3;
                ordenspriester.ret = 0;

                // Wahl für Sprungmodul oder Bike!
                var auswahlSprung = new List<pulldownAuswahl>() { };
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = "kein Upgrade", kosten = 0 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = +15 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = +35 });
                Auswahl1AusN auswahlSprung1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester darf eine der folgenden Auswahlen treffen:", auswahlSprung);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                if (wahlIndex == 1)
                {
                    // Sprungmodul!
                    ordenspriester.ausruestung.Add(alleAusruestung.Sprungmodul);
                    einheitKostenGesamt = einheitKostenGesamt + 25;
                    this.einheitentyp = Einheitstyp.Sprungtruppen;
                    ordenspriester.einheitentyp = Einheitstyp.Sprungtruppen;
                }
                if (wahlIndex == 2)
                {
                    // Bike!
                    ordenspriester.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                    this.einheitentyp = Einheitstyp.Bike;
                    ordenspriester.einheitentyp = Einheitstyp.Bike;
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                    ordenspriester.wid = 5;
                }

            }

            // Auwahl Ausrüstung:
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                ordenspriester.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }


            ordenspriester.kg = 5;
            ordenspriester.bf = 4;
            ordenspriester.st = 4;
            ordenspriester.ini = 4;
            ordenspriester.lp = 2;
            ordenspriester.at = 2;
            ordenspriester.mw = 10;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(ordenspriester);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }
}

