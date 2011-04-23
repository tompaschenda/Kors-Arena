using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using EinheitDefinition;
using WaffenfabrikNamespace;
using spielerAnfragen;

namespace WarHammerGenerator1
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

            return listeAllerSpaceMarineEinheiten;
        }
    }







    /// <summary>
    /// Taktischer Trupp der Space Marines!
    /// </summary>
    public class taktischerTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = SpaceMarineEinheiten.TaktischerTrupp;
            //spielerEinheitenName = "MEINSTRING"; // SpaceMarineEinheiten.TaktischerTrupp.ToString();
            fraktion = Fraktionen.SpaceMarines;

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = SpaceMarinesSubUnits.SpaceMarine , anzahl = 4});
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = SpaceMarinesSubUnits.SergeantDerSpaceMarines, anzahl = 1 });

            basispunkteKosten = 90;
            totalePunkteKosten = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Standard);

            angeschlosseneFahrzeugtypenBasis = new List<object>(){ };
            angeschlosseneFahrzeugtypenBasis.Add(SpaceMarineEinheiten.Rhino);
            angeschlosseneFahrzeugtypenBasis.Add(SpaceMarineEinheiten.Razorback);

            // Jetzt müssen noch die tatsächlichen Auswahlen durch den Spieler vorgenommen
            // werden!
            createUnitInteraktion();
           
            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion()
        {
            // TODO: Wahl Anzahl übrige Einheiten festlegen:
            var guiMediator = new SpielerAnfragen() { };
            int anzahlSpaceMarines = guiMediator.spielerAuswahlNumberBox(1, 0, 5, 16, totalePunkteKosten, "Darf bis zu fünf zusätzliche Space Marines erhalten");
            // Update der Punktekosten:
            totalePunkteKosten = basispunkteKosten + anzahlSpaceMarines * 16;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Okay, legen wir die Space Marines an:
            var spaceMarine = new subEinheit() { };
            spaceMarine.name = SpaceMarinesSubUnits.SpaceMarine;

            // Jeder Space Marine hat eine Servorüstung (keine Extra-Kosten):
            spaceMarine.ruestung = alleRuestungen.ServoRuestung;

            // Jeder Space Marine hat Fragment- und Sprenggranaten (keine Extra-Kosten):
            spaceMarine.ausruestung = new List<Object>();
            spaceMarine.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarine.ausruestung.Add(alleAusruestung.Sprenggranaten);

            // Das Gleiche gilt für die Boltpistole!
            spaceMarine.waffen = new List<waffe>() { };
            spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));     

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarines; ++i )
            {
                // Von 1 bis 8 nur Standard und keine weiteren Kosten!
                if(i < 8)
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                if(i == 8)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });

                    wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    totalePunkteKosten = totalePunkteKosten + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else if (i == 9)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 10 });

                    wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    totalePunkteKosten = totalePunkteKosten + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                // Wenn alles erfolgt ist, darf ich einsortieren:
                subEinheiten.Add(spaceMarine);                
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = new subEinheit() { };
            spaceMarineSergeant.name = SpaceMarinesSubUnits.SergeantDerSpaceMarines;

            spaceMarineSergeant.ausruestung = new List<object>() { };
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprenggranaten);
            spaceMarineSergeant.ruestung = alleRuestungen.ServoRuestung;
            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSarge1 = new List<pulldownAuswahl>() { };
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiewaffe, kosten = 15 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
            wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSarge1);
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSarge1[wahlIndex].auswahl));
            totalePunkteKosten = totalePunkteKosten + auswahlSarge1[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSarge2 = new List<pulldownAuswahl>() { };
            if( (alleWaffenNamen)auswahlSarge1[wahlIndex].auswahl != alleWaffenNamen.Boltpistole)
                auswahlSarge2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            // Das Kettenschwert geht ansonsten immer:
            auswahlSarge2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, 
                "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSarge2);
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSarge2[wahlIndex].auswahl));
            totalePunkteKosten = totalePunkteKosten + auswahlSarge2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var auswahlSargeAusruestung = new List<pulldownAuswahl>() { };
            auswahlSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            auswahlSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.TeleportPeilsender, kosten = 15 });

            var wahlVektor = guiMediator.spielerAuswahlMAusN(totalePunkteKosten, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", auswahlSargeAusruestung);
            foreach (int i in wahlVektor)
            {
                spaceMarineSergeant.ausruestung.Add(auswahlSargeAusruestung[i].auswahl);
                totalePunkteKosten = totalePunkteKosten + auswahlSarge2[i].kosten * 1;
            }
            subEinheiten.Add(spaceMarineSergeant);

            // TODO
            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!

            //base.spielerOptionen();
        }
    }

    
}
