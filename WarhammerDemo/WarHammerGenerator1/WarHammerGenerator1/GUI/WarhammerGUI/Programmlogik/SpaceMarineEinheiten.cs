﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;

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

            var rhino = new rhino() { };
            rhino.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(rhino);

            var razorback = new razorback() { };
            razorback.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(razorback);

            var landungskapsel = new landungskapsel() { };
            landungskapsel.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(landungskapsel);

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
            einheitenName = alleEinheitenNamen.TaktischerTrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = alleSubeinheitenNamen.SpaceMarine , anzahl = 4});
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = alleSubeinheitenNamen.SergeantDerSpaceMarines, anzahl = 1 });

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


                // Von 1 bis 8 nur Standard und keine weiteren Kosten!
                if(i < 7)
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                if(i == 7)
                {
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

                // Fehlen noch die eigentlichen Were für den  Marine:
                spaceMarine.kg = 4;
                spaceMarine.bf = 4;
                spaceMarine.st = 4;
                spaceMarine.wid = 4;
                spaceMarine.lp = 1;
                spaceMarine.at = 1;
                spaceMarine.mw = 8;
                spaceMarine.rw = 3;

                spaceMarine.einheitentyp = Einheitstyp.Infanterie;

                // Wenn alles erfolgt ist, darf ich einsortieren:
                subEinheiten.Add(spaceMarine);                
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = new subEinheit() { };
            spaceMarineSergeant.name = alleSubeinheitenNamen.SergeantDerSpaceMarines;

            spaceMarineSergeant.ausruestung = new List<alleAusruestung>() { };
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprenggranaten);
            spaceMarineSergeant.ruestung = alleRuestungen.ServoRuestung;
            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            // auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiewaffe, kosten = 15 });
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
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiewaffe, kosten = 15 });
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


            // Fehlen noch die eigentlichen Were für den  Marine:
            spaceMarineSergeant.kg = 4;
            spaceMarineSergeant.bf = 4;
            spaceMarineSergeant.st = 4;
            spaceMarineSergeant.wid = 4;
            spaceMarineSergeant.lp = 1;
            spaceMarineSergeant.at = 2;
            spaceMarineSergeant.mw = 9;
            spaceMarineSergeant.rw = 3;
            spaceMarineSergeant.einheitentyp = Einheitstyp.Infanterie;

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


    public class rhino : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Rhino;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = alleEinheitenNamen.Rhino, anzahl = 1 });

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


    public class razorback : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Razorback;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = alleEinheitenNamen.Razorback, anzahl = 1 });

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

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = alleEinheitenNamen.Landungskapsel, anzahl = 1 });

            basispunkteKosten = 35;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugOffen;

            sonderregeln = new List<Sonderregeln>() { };

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

}
