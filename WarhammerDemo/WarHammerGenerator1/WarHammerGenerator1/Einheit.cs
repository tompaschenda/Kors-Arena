using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using WaffenfabrikNamespace;
using spielerAnfragen;

namespace EinheitDefinition
{
    public class Einheit
    {
        /// <summary>
        /// Konstruktor:
        /// </summary>
        public Einheit() 
        {
            spielerEinheitenName = "";
            fraktion = Fraktionen.BloodAngels;
            einheitenName = "";
        }

        /// <summary>
        /// Copy-Konstruktor von Hand!
        /// WARNUNG! IMMER UP-TO-DATE halten!
        /// </summary>
        /// <param name="altEinheit"></param>
        public Einheit(Einheit alteEinheit)
        {
            einheitenName = alteEinheit.einheitenName;
            spielerEinheitenName = alteEinheit.spielerEinheitenName;
            fraktion = alteEinheit.fraktion;
            basisGroesse = alteEinheit.basisGroesse;
            basispunkteKosten = alteEinheit.basispunkteKosten;
            totalePunkteKosten = alteEinheit.totalePunkteKosten;
            einzigartig = alteEinheit.einzigartig;
            einheitentyp = alteEinheit.einheitentyp;
            sonderregeln = alteEinheit.sonderregeln;
            psikraefte = alteEinheit.psikraefte;
            auswahlTypBasis = alteEinheit.auswahlTypBasis;
            auswahlTypSpieler = alteEinheit.auswahlTypSpieler;
            angeschlosseneFahrzeugtypenBasis = alteEinheit.angeschlosseneFahrzeugtypenBasis;
            angeschlossenesFahrzeug = alteEinheit.angeschlossenesFahrzeug;
            subEinheiten = alteEinheit.subEinheiten;
        }

        /// <summary>
        /// Name der Einheit
        /// </summary>
        public Object einheitenName;

        /// <summary>
        /// Der Name, den der Nutzer einer Einheit selbst mitgeben möchte!
        /// </summary>
        public string spielerEinheitenName;

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
        public int totalePunkteKosten;

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
        /// Welche Fahrzeugtypen stehen als angeschlossene
        /// Fahrzeuge zur Verfügung?
        /// ACHTUNG: Kann von der Anzahl der Subeinheiten
        /// abhängen!
        /// </summary>
        public List<Object> angeschlosseneFahrzeugtypenBasis;

        /// <summary>
        /// Für welches angeschlossene Fahrzeug hat sich der 
        /// Spieler entschieden?
        /// ACHTUNG: Dies bedingt, dass man das Fahrzeug
        /// gleich mit selektiert und konfiguriert!
        /// </summary>
        public Object angeschlossenesFahrzeug;

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
        /// </summary>
        public virtual void spielerOptionen(){ }

        /// <summary>
        /// Virtuelle Funktion, die mit Leben gefüllt werden
        /// muss, damit eine Einheit erstellt werden kann.
        /// Diese muss von Aussen beim Erstellung einer
        /// Einheit aufgerufen werden und handelt alle
        /// Initialisierungen, etc. von Attributen der
        /// Klasse ab.
        /// </summary>
        public virtual void createUnit() 
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
        public Object name;

        /// <summary>
        /// Liste mit allen Ausrüstungsgegenständen
        /// der Einheit.
        /// </summary>
        public List<Object> ausruestung;

        /// <summary>
        /// Liste mit allen Waffen der Einheit
        /// </summary>
        public List<waffe> waffen;

        /// <summary>
        /// Eine Einheit kann immer nur EINE Rüstung tragen!
        /// </summary>
        public Object ruestung;
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
