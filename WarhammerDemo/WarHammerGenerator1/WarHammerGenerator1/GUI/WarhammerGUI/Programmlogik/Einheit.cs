﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;


namespace WarhammerGUI
{

    /// <summary>
    /// Enthält alles, was nötig ist, um eine Einheit eindeutig zu identifizieren und einordnen zu können.
    /// Das sind:
    ///     - Fraktion
    ///     - Einheitenname
    ///     - (Basis-)Auswahltyp
    /// </summary>
    public struct EinheitsIdentifier
    {
        /// <summary>
        /// Name der Einheit
        /// </summary>
        public Object einheitName;

        /// <summary>
        /// Fraktion, zu der die Einheit gehört
        /// </summary>
        public Fraktionen einheitFraktion;

        public EinheitenAuswahl einheitAuswahl;
    }

    public class Einheit
    {
        /// <summary>
        /// Konstruktor:
        /// </summary>
        public Einheit() 
        {
            spielerEinheitenName = "";
            fraktion = Fraktionen.BloodAngels;
            einheitenName = alleEinheitenNamen.CaptainLysander;
            uniqueStringProperty = "";
            basispunkteKosten = -1;
            einheitKostenGesamt = -1;
            erschaffungOkay = false;
            angeschlossenesFahrzeugString = "";
        }

        /// <summary>
        /// Copy-Konstruktor von Hand! TODO TODO TODO!
        /// WARNUNG! IMMER UP-TO-DATE halten!
        /// </summary>
        /// <param name="altEinheit"></param>
        public Einheit(Einheit alteEinheit)
        {
            einheitenName = alteEinheit.einheitenName;
            uniqueStringProperty = alteEinheit.uniqueStringProperty;
            spielerEinheitenName = alteEinheit.spielerEinheitenName;
            fraktion = alteEinheit.fraktion;
            basisGroesse = alteEinheit.basisGroesse;
            basispunkteKosten = alteEinheit.basispunkteKosten;
            einheitKostenGesamt = alteEinheit.einheitKostenGesamt;
            einzigartig = alteEinheit.einzigartig;
            einheitentyp = alteEinheit.einheitentyp;
            sonderregeln = alteEinheit.sonderregeln;
            psikraefte = alteEinheit.psikraefte;
            auswahlTypBasis = alteEinheit.auswahlTypBasis;
            auswahlTypSpieler = alteEinheit.auswahlTypSpieler;
            angeschlossenesFahrzeugString = alteEinheit.angeschlossenesFahrzeugString;
            subEinheiten = alteEinheit.subEinheiten;
            erschaffungOkay = alteEinheit.erschaffungOkay;
            uniqueHeaderProperty = alteEinheit.uniqueHeaderProperty;
        }

        /// <summary>
        /// Name der Einheit
        /// </summary>
        public alleEinheitenNamen einheitenName;

        /// <summary>
        /// Jede Warhammer Einheit hat einen einzigartigen Bezeichner, der sich aus
        /// Fraktion + Einheitenname zusammensetzen sollte als String.
        /// </summary>
        public string uniqueStringProperty;

        /// <summary>
        /// Jeder Spieler-Einheit bekommt eine einzigartige String-Property,  unter dem das zugehörige Treeview-Item zu finden ist!
        /// </summary>
        public string uniqueHeaderProperty;

        /// <summary>
        /// Der Name, den der Nutzer einer Einheit selbst mitgeben möchte! Muss einzigartig sein!
        /// </summary>
        public string spielerEinheitenName;

        /// <summary>
        /// Wurde die Einheit korrekt inklusive aller Spielerabfragen erzeugt?
        /// </summary>
        public bool erschaffungOkay;

        /// <summary>
        /// Zu welcher Fraktion gehört diese Einheit?
        /// </summary>
        public Fraktionen fraktion;

        /// <summary>
        /// Wie viele Subeinheiten sind automatisch
        /// pro Typ dabei?
        /// </summary>
        public List<Groessenspecifier> basisGroesse;

        /// <summary>
        /// Wievele Basispunktekosten habe ich automatisch?
        /// </summary>
        public int basispunkteKosten;

        /// <summary>
        /// Wieviele Punktekosten hat die Einheit insgesamt?
        /// </summary>
        public int einheitKostenGesamt;

        /// <summary>
        /// Ist die Einheit einzigartig?
        /// </summary>
        public bool einzigartig;

        /// <summary>
        /// Von welchem Typ ist die Einheit?
        /// Infanterie, Fahrzeug, etc.
        /// </summary>
        public Einheitstyp einheitentyp;

        /// <summary>
        /// Welche Sonderregeln gelten für die Einheit?
        /// </summary>
        public List<Sonderregeln> sonderregeln;

        /// <summary>
        /// Welche Psikräfte stehen zur Auswahl?
        /// </summary>
        public List<Object> psikraefte;

        /// <summary>
        /// Zu welchem Auswahltyp gehört die Einheit?
        /// HQ, Standard, Elite, etc.
        /// Dies können mehrere sein!
        /// </summary>
        public List<EinheitenAuswahl> auswahlTypBasis;

        /// <summary>
        /// Für welchen der Auswahltypen hat sich der
        /// Spieler entschieden?
        /// </summary>
        public EinheitenAuswahl auswahlTypSpieler;

        /// <summary>
        /// Für welches angeschlossene Fahrzeug hat sich der 
        /// Spieler entschieden?
        /// ACHTUNG: Dies bedingt, dass man das Fahrzeug
        /// gleich mit selektiert und konfiguriert!
        /// </summary>
        public string angeschlossenesFahrzeugString;

        /// <summary>
        /// Hier sind die eigentlichen Subeinheiten
        /// eingetragen!
        /// </summary>
        public List<subEinheit> subEinheiten;

        /// <summary>
        /// Virtuelle Funktion, die die jeweiligen
        /// Optionen abhandelt, die der Spieler zur Konfiguration 
        /// seines Trupps treffen muss.
        /// Erst wenn sie abgehandelt wurden, ist die
        /// Einheit fertig konfiguriert!
        /// Wird nicht automatisch bei der erstellung der globalen Enheitenliste
        /// ausgeführt!
        /// </summary>
        public virtual void createUnitInteraktion(int gesamtArmeePunkteKosten) {  }

        /// <summary>
        /// Virtuelle Funktion, die mit Leben gefüllt werden
        /// muss, damit eine Einheit erstellt werden kann.
        /// Diese Basisfunktion kann automatisch OHNE Spielerinteraktion aufgerufen
        /// werden und definiert eine Einheit bereits automatisch.
        /// </summary>
        public virtual void createUnitBase() 
        {
            // Wenn wir sowieso nur einen Einheitentyp vorliegen haben,
            // dann können wir ihn auch sofort festlegen,ohne den
            // Spieler behelligen zu müssen:
            if (auswahlTypBasis.Count == 1)
                auswahlTypSpieler = auswahlTypBasis[0];
        }

    }

    /// <summary>
    /// Eine Subeinheit einer Einheit.
    /// Beispiel: 
    ///     Einheit: Taktischer Trupp
    ///     Subeinheit: Space Marine
    ///     Subeinheit: Sergeant
    /// </summary>
    public struct subEinheit
    {
        /// <summary>
        /// Name der Subeinheit
        /// </summary>
        public alleSubeinheitenNamen name;

        /// <summary>
        /// Liste mit allen Ausrüstungsgegenständen
        /// der Einheit.
        /// </summary>
        public List<alleAusruestung> ausruestung;

        /// <summary>
        /// Liste mit allen Waffen der Einheit
        /// </summary>
        public List<waffe> waffen;

        /// <summary>
        /// Eine Einheit kann immer nur EINE Rüstung tragen!
        /// </summary>
        public alleRuestungen ruestung;

        /// <summary>
        /// Eigenschaften einer Subeinheit:
        /// </summary>
        public int kg;
        public int bf;
        public int st;
        public int wid;
        public int lp;
        public int at;
        public int mw;
        public int rw;

        /// <summary>
        /// Für den Fall, dass es sich um ein Fahrzeug handelt:
        /// </summary>
        public int front;
        public int seit;
        public int heck;
        public int transportkapazitaet;

        /// <summary>
        /// Von welchem Typ ist die Sub-Einheit?
        /// Infanterie, Fahrzeug, etc.
        /// </summary>
        public Einheitstyp einheitentyp;
    }

    /// <summary>
    /// Gibt für jede Subeinheit einer Einheit die
    /// zugehörigen möglichen oder tatsächlichen
    /// Anzahlen an.
    /// </summary>
    public struct Groessenspecifier
    {
        public Object subEinheitenname;

        public int anzahl;
    }
}
