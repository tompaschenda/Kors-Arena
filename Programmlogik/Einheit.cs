using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;

namespace WarhammerGUI
{
    public class foo
    {

    }

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

    public abstract class Einheit : IComparable<Einheit>
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
            zugehoerigeEinheit = "";
            auswahlen = new List<choiceDefinition>() { };
            subEinheiten = new List<subEinheit>() { };
        }

        public T CloneEinheit<T>(T alteEinheit) where T : Einheit
        {
            var copy = (T)alteEinheit.MemberwiseClone();
            copy.sonderregeln = new List<Sonderregeln>(alteEinheit.sonderregeln);
            copy.auswahlTypBasis = new List<EinheitenAuswahl>(alteEinheit.auswahlTypBasis);
            copy.subEinheiten = new List<subEinheit>() { };
            for (int i = 0; i < alteEinheit.subEinheiten.Count; ++i)
            {
                copy.subEinheiten.Add((subEinheit)alteEinheit.subEinheiten[i].Clone());
            }
            copy.auswahlTypBasis = new List<EinheitenAuswahl>() { };
            for (int i = 0; i < alteEinheit.auswahlTypBasis.Count; ++i)
            {
                copy.auswahlTypBasis.Add(alteEinheit.auswahlTypBasis[i]);
            }

            copy.auswahlen = new List<choiceDefinition>() { };
            for (int i = 0; i < alteEinheit.auswahlen.Count; ++i)
            {
                copy.auswahlen.Add((choiceDefinition)alteEinheit.auswahlen[i].Clone());
            }
            return copy;
        }

        /// <summary>
        /// Der Name, der im GUI angezeigt wird
        /// </summary>
        public string GUIName
        {
            get
            {
                return EnumExtensions.getEnumDescription(typeof(alleEinheitenNamen), einheitenName) + spielerEinheitenName;
            }
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
        /// Der unique identifier einer zugehörigen Einheit. Das kann entweder ein angeschlossenes Transportfahrzeug sein ODER
        /// umgekehrt die Einheit, der das Transportfahrzeug gehört.
        /// </summary>
        public string zugehoerigeEinheit;

        /// <summary>
        /// Die Auswahlen, die man per declareChoices() deklariert und die der Spieler treffen kann/muss.
        /// </summary>
        public List<choiceDefinition> auswahlen;

        /// <summary>
        /// Wurde die Einheit korrekt inklusive aller Spielerabfragen erzeugt?
        /// </summary>
        public bool erschaffungOkay;

        /// <summary>
        /// Zu welcher Fraktion gehört diese Einheit?
        /// </summary>
        public Fraktionen fraktion;

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
        /// Gibt für jede existierende Sub-Einheit einen Eintrag in der Liste zurück!
        /// </summary>
        /// <returns></returns>
        public List<alleSubeinheitenNamen> getAllTypesOfSubunits()
        {
            var liste = new List<alleSubeinheitenNamen>() { };

            for (int i = 0; i < this.subEinheiten.Count; ++i)
            {
                if (!liste.Contains(this.subEinheiten[i].name))
                    liste.Add(this.subEinheiten[i].name);
            }

            return liste;
        }


        //////////
        //
        //
        //    METHODEN DER KLASSE!
        //
        //
        /////////

        /// <summary>
        /// Virtuelle Funktion, die die jeweiligen
        /// Optionen abhandelt, die der Spieler zur Konfiguration 
        /// seines Trupps treffen muss.
        /// Erst wenn sie abgehandelt wurden, ist die
        /// Einheit fertig konfiguriert!
        /// Wird nicht automatisch bei der erstellung der globalen Enheitenliste
        /// ausgeführt!
        /// </summary>
        public abstract void createUnitInteraktion(int gesamtArmeePunkteKosten);

        /// <summary>
        /// Virtuelle Funktion, die mit Leben gefüllt werden
        /// muss, damit eine Einheit erstellt werden kann.
        /// Diese Basisfunktion kann automatisch OHNE Spielerinteraktion aufgerufen
        /// werden und definiert eine Einheit bereits automatisch.
        /// </summary>
        public virtual void createUnitBase() { }

        /// <summary>
        /// Hier werden alle vom Spieler zu treffenden Auswahlen definiert.
        /// </summary>
        public virtual void declareChoices() { }

        /// <summary>
        /// Hier werden die Abhängigkeiten der Auswahlen unter einander abhängig von vorherigen Auswahlen
        /// umgesetzt. Eine Auswahl kann eine andere invalidieren oder die auszuwählenden Optionen ändern.
        /// </summary>
        public virtual void updateChoiceDependencies() { }

        /// <summary>
        /// Führt die ausgewählten Auswahlen durch.
        /// </summary>
        public virtual void evaluateChoives() { }

        public choiceDefinition getSpecificChoice( ChoiceAuswahlIdentifier ziel)
        {
            for (int i = 0; i < auswahlen.Count; ++i)
            {
                if (auswahlen[i].auswahlIdentifier == ziel)
                {
                    return auswahlen[i];
                }
            }
            throw new ArgumentOutOfRangeException("Die angegebene Auswahl existiert nicht in der Auswahlliste der Einheit!");
        }

        /// <summary>
        /// Gibt zurück, wie häufig der vorgegebene Subeinheitenname in dieser Einheit vorhanden ist!
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public int getNumberOfSubunitsOfType(alleSubeinheitenNamen name)
        {
            int anzahl = 0;
            for (int i = 0; i < this.subEinheiten.Count; ++i)
                if (this.subEinheiten[i].name == name)
                    anzahl = anzahl + 1;
            return anzahl;
        }

        public subEinheit getFirstSubunitWithName(alleSubeinheitenNamen name)
        {
            subEinheit ersteSub = new subEinheit() { };
            for (int i = 0; i < this.subEinheiten.Count; ++i)
            {
                if (this.subEinheiten[i].name == name)
                {
                    ersteSub = this.subEinheiten[i];
                    break;
                }
            }

            if (ersteSub.name == alleSubeinheitenNamen.undefined)
                throw new ArgumentOutOfRangeException("Diese Subeinheit gibt es in der aktuellen Auswahl gar nicht!");

            return ersteSub;
        }

        /// <summary>
        /// Gibt zurück, wie häufig eine bestimmte Waffe in einem bestimmten Subunit-Typ vorkommt!
        /// </summary>
        /// <param name="nameSubEinheit"></param>
        /// <param name="nameWaffe"></param>
        /// <returns></returns>
        public int getNumberOfWeapsInSubunits(alleSubeinheitenNamen nameSubEinheit, alleWaffenNamen nameWaffe)
        {
            int anzahl = 0;
            for (int i = 0; i < this.subEinheiten.Count; ++i)
                for (int j = 0; j < this.subEinheiten[i].waffen.Count; ++j)
                    if (this.subEinheiten[i].waffen[j].name == nameWaffe && this.subEinheiten[i].name == nameSubEinheit)
                        anzahl = anzahl + 1;

            return anzahl;
        }

        public int getNumberOfEquipInSubunits(alleSubeinheitenNamen nameSubEinhiet, alleAusruestung nameAusruestung)
        {
            int anzahl = 0;
            for (int i = 0; i < this.subEinheiten.Count; ++i)
                for (int j = 0; j < this.subEinheiten[i].ausruestung.Count; ++j)
                    if (this.subEinheiten[i].ausruestung[j] == nameAusruestung && this.subEinheiten[i].name == nameSubEinhiet)
                        anzahl = anzahl + 1;
                
            return anzahl;
        }

        public int getNumberOfArmorInSubunits(alleSubeinheitenNamen nameSubEinhiet, alleRuestungen nameRuestung)
        {
            int anzahl = 0;
            for (int i = 0; i < this.subEinheiten.Count; ++i)
                   if (this.subEinheiten[i].ruestung == nameRuestung && this.subEinheiten[i].name == nameSubEinhiet)
                        anzahl = anzahl + 1;

            return anzahl;
        }

        public string getUniqueHeaderProperty()
        {
            var baseName = EnumExtensions.getEnumDescription(this.einheitenName.GetType(), this.einheitenName.ToString());
            return baseName + " (" + this.spielerEinheitenName + ")";
        }
        public string getUniqueHeaderProperty(string spielerEinheitenName)
        {
            var baseName = EnumExtensions.getEnumDescription(this.einheitenName.GetType(), this.einheitenName.ToString());
            return baseName + " (" + spielerEinheitenName + ")";
        }

        /// <summary>
        /// Prüft, ob alle deklarierten Auswahlen auch in allen Bereichen korrekt initialisiert wurden!
        /// </summary>
        public void checkDeclaredChoicesValidity()
        {
            for (int i = 0; i < auswahlen.Count; ++i)
            {
                var aktAuswahl = auswahlen[i];
                aktAuswahl.validate();
                
                // Ist der Identifier der Auswahl einzigartig?
                for (int j = 0; j < auswahlen.Count; ++j)
                {
                    if (j == i)
                        continue;

                    if (aktAuswahl.auswahlIdentifier == auswahlen[j].auswahlIdentifier)
                        throw new ArgumentOutOfRangeException("Der Auswahl-Identifier war nicht einzigartig!");
                }
            }
        }

        /// <summary>
        /// Sortierfunktion für Subeinheiten.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Einheit obj)
        {
            // Verglichen wird natürlich auf den Spieler-Einheitennamen!
            string nameKlasse = uniqueHeaderProperty;
            string nameDelegat = obj.uniqueHeaderProperty;

            if (nameKlasse == null)
                nameKlasse = EnumExtensions.getEnumDescription(typeof(alleEinheitenNamen), einheitenName);
            if (nameDelegat == null)
                nameDelegat = EnumExtensions.getEnumDescription(typeof(alleEinheitenNamen), obj.einheitenName);

            return nameKlasse.CompareTo(nameDelegat);
        }
    }

    /// <summary>
    /// Eine Subeinheit einer Einheit.
    /// Beispiel: 
    ///     Einheit: Taktischer Trupp
    ///     Subeinheit: Space Marine
    ///     Subeinheit: Sergeant
    /// </summary>
    public class subEinheit : ICloneable
    {
        // Default-Konstruktor:
        public subEinheit() 
        { 
            name = alleSubeinheitenNamen.undefined;
            ausruestung = new List<alleAusruestung>() { };
            waffen = new List<waffe>() { };
            ruestung = alleRuestungen.undefined;
            kg = -1;
            bf = -1;
            st = -1;
            wid = -1;
            ini = -1;
            lp = -1;
            at = -1;
            mw = -1;
            rw = -1;
            ret = -1;
            front = -1;
            seit = -1;
            heck = -1;
            transportkapazitaet = 0;
            einheitentyp = Einheitstyp.undefined;
            psikraefte = new List<Psikraefte>() { };
        }

        /// <summary>
        /// Klone-Methode für die Subeinheit!
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var copy = (subEinheit) this.MemberwiseClone();
            copy.ausruestung = new List<alleAusruestung>(this.ausruestung);
            copy.waffen = new List<waffe>() { };
            for (int i = 0; i < this.waffen.Count; ++i)
            {
                copy.waffen.Add((waffe) this.waffen[i].Clone());
            }
            copy.psikraefte = new List<Psikraefte>(this.psikraefte);

            return copy;
        }

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
        public int ini;
        public int lp;
        public int at;
        public int mw;
        public int rw;
        public int ret;

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

        public List<Psikraefte> psikraefte;
    }
}
