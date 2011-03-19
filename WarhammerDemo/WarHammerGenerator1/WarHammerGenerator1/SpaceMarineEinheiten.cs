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
    /// Taktischer Trupp der Space Marines!
    /// </summary>
    public class taktischerTrupp : Einheit
    {
        public override void createUnit()
        {
            einheitsname = SpaceMarineEinheiten.TaktischerTrupp;

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = SpaceMarinesInfanterie.SpaceMarine , anzahl = 4});
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = SpaceMarinesInfanterie.SergeantDerSpaceMarines, anzahl = 1 });

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
            angeschlosseneFahrzeugtypenBasis.Add(SpaceMarinesFahrzeuge.Rhino);
            angeschlosseneFahrzeugtypenBasis.Add(SpaceMarinesFahrzeuge.Razorback);

            // Jetzt müssen noch die tatsächlichen Auswahlen durch den Spieler vorgenommen
            // werden!
            spielerOptionen();
           
            base.createUnit();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void spielerOptionen()
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
            spaceMarine.name = SpaceMarinesInfanterie.SpaceMarine;

            // Jeder Space Marine hat eine Servorüstung (keine Extra-Kosten):
            spaceMarine.ruestung = SpaceMarinesRuestungen.ServoRuestung;

            // Jeder Space Marine hat Fragment- und Sprenggranaten (keine Extra-Kosten):
            spaceMarine.ausruestung.Add(SpaceMarinesAusruestung.Fragmentgranaten);
            spaceMarine.ausruestung.Add(SpaceMarinesAusruestung.Sprenggranaten);

            // Das Gleiche gilt für die Boltpistole!
            spaceMarine.waffen = new List<waffe>() { };
            spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(SpaceMarinesWaffen.Boltpistole));     

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarines; ++i )
            {
                // Von 1 bis 8 nur Standard und keine weiteren Kosten!
                if(i < 8)
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(SpaceMarinesWaffen.Bolter));
                if(i == 8)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Flammenwerfer, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Melter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Plasmawerfer, kosten = 10 });

                    wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    totalePunkteKosten = totalePunkteKosten + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else if (i == 9)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.SchwererBolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Multimelter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Raketenwerfer, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Plasmakanone, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Laserkanone, kosten = 10 });

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
            spaceMarineSergeant.name = SpaceMarinesInfanterie.SergeantDerSpaceMarines;

            spaceMarineSergeant.ausruestung.Add(SpaceMarinesAusruestung.Fragmentgranaten);
            spaceMarineSergeant.ausruestung.Add(SpaceMarinesAusruestung.Sprenggranaten);
            spaceMarineSergeant.ruestung = SpaceMarinesRuestungen.ServoRuestung;
            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSarge1 = new List<pulldownAuswahl>() { };
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Bolter, kosten = 0 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Boltpistole, kosten = 0 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.KombiFlammenwerfer, kosten = 10 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.KombiMelter, kosten = 10 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.KombiPlasmawerfer, kosten = 10 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Plasmapistole, kosten = 15 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Energiewaffe, kosten = 15 });
            auswahlSarge1.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Energiefaust, kosten = 25 });
            wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSarge1);
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSarge1[wahlIndex].auswahl));
            totalePunkteKosten = totalePunkteKosten + auswahlSarge1[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSarge2 = new List<pulldownAuswahl>() { };
            if( (SpaceMarinesWaffen)auswahlSarge1[wahlIndex].auswahl != SpaceMarinesWaffen.Boltpistole)
                auswahlSarge2.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Boltpistole, kosten = 0 });
            // Das Kettenschwert geht ansonsten immer:
            auswahlSarge2.Add(new pulldownAuswahl() { auswahl = SpaceMarinesWaffen.Kettenschwert, kosten = 0 });
            wahlIndex = guiMediator.spielerAuswahl1AusN(totalePunkteKosten, 1, 
                "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSarge2);
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSarge2[wahlIndex].auswahl));
            totalePunkteKosten = totalePunkteKosten + auswahlSarge2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var auswahlSargeAusruestung = new List<pulldownAuswahl>() { };
            auswahlSargeAusruestung.Add(new pulldownAuswahl() { auswahl = SpaceMarinesAusruestung.Melterbomben, kosten = 5 });
            auswahlSargeAusruestung.Add(new pulldownAuswahl() { auswahl = SpaceMarinesAusruestung.TeleportPeilsender, kosten = 15 });

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
