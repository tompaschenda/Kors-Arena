using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;
using System.ComponentModel;

namespace WarhammerGUI
{
    public enum AuswahlTyp
    {
        [Description("Waffenauswahl")]
        Waffenauswahl,
        [Description("Transportfahrzeugwahl")]
        Transportfahrzeugwahl,
        [Description("Ausrüstungsauswahl")]
        Ausruestungsauswahl,
        [Description("Rüstungsauswahl")]
        Ruestungsauswahl,
        [Description("Zusätzliche Subeinheiten-Auswahl")]
        ZusSubeinheitenAuswahl,
    }

    public enum AuswahlTool
    {
        [Description("1AusN")]
        EinsAusN,
        [Description("MAusN")]
        MAusN,
        [Description("AnzahlSlider")]
        AnzahlSlider,
    }

    public enum ChoiceAuswahlIdentifier
    {
        [Description("Waffenwahl01")]
        Waffe01,
        [Description("Waffenwahl02")]
        Waffe02,
        [Description("Waffenwahl03")]
        Waffe03,
        [Description("Waffenwahl04")]
        Waffe04,
        [Description("Waffenwahl05")]
        Waffe05,

        [Description("Rüstungswahl01")]
        Ruest01,
        [Description("Rüstungswahl02")]
        Ruest02,
        [Description("Rüstungswahl03")]
        Ruest03,

        [Description("Ausrüstungswahl01")]
        Ausruest01,
        [Description("Ausrüstungswahl02")]
        Ausruest02,
        [Description("Ausrüstungswahl03")]
        Ausruest03,
        [Description("Ausrüstungswahl04")]
        Ausruest04,
        [Description("Ausrüstungswahl05")]
        Ausruest05,
        [Description("Ausrüstungswahl06")]
        Ausruest06,

        [Description("Anzahl Subunits Wahl01")]
        AnzSub01,
        [Description("Anzahl Subunits Wahl02")]
        AnzSub02,
        [Description("Anzahl Subunits Wahl03")]
        AnzSub03,
        [Description("Anzahl Subunits Wahl04")]
        AnzSub04,

        [Description("Transportfahrzeugwahl01")]
        Trans01,
    }

    public abstract class choiceDefinition : ICloneable
    {
        public AuswahlTyp artDerAuswahl;
        public AuswahlTool toolDerAuswahl;

        /// <summary>
        /// Die Auswahlen, die in der GUI angezeigt werden.
        /// </summary>
        public List<pulldownAuswahl> AuswahlOptionen
        {
            get
            {
                return auswahlOptionen;
            }
        }

        public List<pulldownAuswahl> auswahlOptionen;

        public ChoiceAuswahlIdentifier auswahlIdentifier;

        /// <summary>
        /// Ist die Auswahl gerade aktiv?
        /// </summary>
        public bool isActive;

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        /// <summary>
        /// Mit welchem Label soll die Auswahl ausgestattet werden?
        /// </summary>
        public string labelString;

        /// <summary>
        /// Der Text, der in der GUI angezeigt werden soll.
        /// </summary>
        public string GUIText
        {
            get
            {
                return labelString;
            }
        }

        /// <summary>
        /// Virtuelle Funktion, die das Validieren der Unterklassen-Auswahlen übernimmt.
        /// </summary>
        public abstract void validate();

        public virtual object Clone()
        {
            var copy = (choiceDefinition)this.MemberwiseClone();
            copy.auswahlOptionen = new List<pulldownAuswahl>() { };
            for (int i = 0; i < auswahlOptionen.Count; ++i)
            {
                copy.auswahlOptionen.Add((pulldownAuswahl)this.auswahlOptionen[i].Clone());
            }
            return copy;
        }
    }

    /// <summary>
    /// Auswahl einer Waffe
    /// </summary>
    public class waffenAuswahl : choiceDefinition
    {
        public override object Clone()
        {
            var copy = base.Clone();           
            return copy;
        }

        public waffenAuswahl() 
        {
            artDerAuswahl = AuswahlTyp.Waffenauswahl;
            toolDerAuswahl = AuswahlTool.EinsAusN;
            auswahlOptionen = new List<pulldownAuswahl>() { };
            auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
            isActive = true;
            labelString = "Bewaffnung: ";
            chosenIndex = 0;
        }

        private int chosenIndex;

        public void setChosenIndex(int newIndex)
        {
            if (newIndex >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Index für Waffenwahl ist out of range!");
            chosenIndex = newIndex;
        }

        public override void validate()
        {
            if(toolDerAuswahl != AuswahlTool.EinsAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für waffenAuswahl!");

            if(chosenIndex == -1 || chosenIndex >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Falscher Index für Waffenauswahl selektiert!");
        }

        public alleWaffenNamen getSelectedWeaponName()
        {
            var gewSelection = auswahlOptionen[chosenIndex];
            return (alleWaffenNamen) gewSelection.auswahl;
        }

        public void removeWeapon(alleWaffenNamen waffenName)
        {
            bool found = false;
            for (int i = 0; i < auswahlOptionen.Count; ++i)
            {
                if ((alleWaffenNamen)auswahlOptionen[i].auswahl == waffenName)
                {
                    auswahlOptionen.RemoveAt(i);
                    found = true;
                    break;
                }
            }
            if (!found)
                throw new ArgumentOutOfRangeException("Die angegebene Waffe gibt es nicht!");
        }
    }

    public class transportfahrzeugWahl : choiceDefinition
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        private int chosenIndex;

        public void setChosenIndex(int newIndex)
        {
            if (newIndex >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Index für Fahrzeugwahl ist out of range!");
            chosenIndex = newIndex;
        }

        public transportfahrzeugWahl()
        {
            artDerAuswahl = AuswahlTyp.Transportfahrzeugwahl;
            toolDerAuswahl = AuswahlTool.EinsAusN;
            auswahlOptionen = new List<pulldownAuswahl>() { };
            auswahlIdentifier = ChoiceAuswahlIdentifier.Trans01;
            isActive = true;
            labelString = "Angeschlossenes Transportfahrzeug: ";
            chosenIndex = 0;
        }

        public override void validate()
        {
            if (toolDerAuswahl != AuswahlTool.EinsAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für transportfahrzeugWahl!");
            if (chosenIndex == -1 || chosenIndex >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Falscher Index für Transportfahrzeug selektiert!");
        }

        public alleEinheitenNamen getSelectedVehicle()
        {
            var gewSelection = auswahlOptionen[chosenIndex];
            return (alleEinheitenNamen)gewSelection.auswahl;
        }

        public void removeVehicle(alleEinheitenNamen fahrzeugName)
        {
            bool found = false;
            for (int i = 0; i < auswahlOptionen.Count; ++i)
            {
                if ((alleEinheitenNamen)auswahlOptionen[i].auswahl == fahrzeugName)
                {
                    auswahlOptionen.RemoveAt(i);
                    found = true;
                    break;
                }
            }
            if (!found)
                throw new ArgumentOutOfRangeException("Das angegebene Fahrzeug gibt es nicht!");
        }
    }

    public class ausruestungsAuswahl : choiceDefinition
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public ausruestungsAuswahl()
        {
            artDerAuswahl = AuswahlTyp.Ausruestungsauswahl;
            toolDerAuswahl = AuswahlTool.MAusN;
            auswahlOptionen = new List<pulldownAuswahl>() { };
            auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
            isActive = true;
            labelString = "Ausrüstung: ";
            selectedIndices = new List<int>() { };
        }

        private List<int> selectedIndices;

        public void setChosenIndices(List<int> newIndices)
        {
            if (newIndices.Count >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Index für Fahrzeugwahl ist out of range!");

            for (int i = 0; i < newIndices.Count; ++i)
            {
                selectedIndices[i] = newIndices[i];
            }
        }

        public List<alleAusruestung> getSelectedEquip()
        {
            var selectedEquip = new List<alleAusruestung>() { };

            for (int i = 0; i < selectedIndices.Count; ++i)
                selectedEquip.Add((alleAusruestung) auswahlOptionen[i].auswahl);

            return selectedEquip;
        }

        public void removeEquip(alleAusruestung ausruestungsname)
        {
            bool found = false;
            for (int i = 0; i < auswahlOptionen.Count; ++i)
            {
                if ((alleAusruestung)auswahlOptionen[i].auswahl == ausruestungsname)
                {
                    auswahlOptionen.RemoveAt(i);
                    found = true;
                    break;
                }
            }
            if (!found)
                throw new ArgumentOutOfRangeException("Das angegebene Equip gibt es nicht!");
        }

        public override void validate()
        {
            if(toolDerAuswahl != AuswahlTool.MAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für ausruestungsAuswahl!");
        }
    }

    public class ruestungsAuswahl : choiceDefinition
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        private int chosenIndex;

        public void setChosenIndex(int newIndex)
        {
            if (newIndex >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Index für Rüstungswahl ist out of range!");
            chosenIndex = newIndex;
        }

        public ruestungsAuswahl()
        {
            artDerAuswahl = AuswahlTyp.Ruestungsauswahl;
            toolDerAuswahl = AuswahlTool.EinsAusN;
            auswahlOptionen = new List<pulldownAuswahl>() { };
            auswahlIdentifier = ChoiceAuswahlIdentifier.Ruest01;
            isActive = true;
            labelString = "Rüstung: ";
            chosenIndex = 0;
        }

        public alleRuestungen getSelectedArmor()
        {
            var selectedArmor = (alleRuestungen)auswahlOptionen[chosenIndex].auswahl;
            return selectedArmor;
        }

        public void removeEquip(ruestungsAuswahl ruestungsname)
        {
            bool found = false;
            for (int i = 0; i < auswahlOptionen.Count; ++i)
            {
                if ((ruestungsAuswahl)auswahlOptionen[i].auswahl == ruestungsname)
                {
                    auswahlOptionen.RemoveAt(i);
                    found = true;
                    break;
                }
            }
            if (!found)
                throw new ArgumentOutOfRangeException("Die angegebene Rüstung gibt es nicht!");
        }

        public override void validate()
        {
            if (toolDerAuswahl != AuswahlTool.EinsAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für ruestungsAuswahl!");
            if(chosenIndex == -1)
                throw new ArgumentOutOfRangeException("Falscher Index für ruestungsAuswahl!");
        }
    }

    public class zusSubeinheitenAuswahl : choiceDefinition
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public zusSubeinheitenAuswahl()
        {
            artDerAuswahl = AuswahlTyp.ZusSubeinheitenAuswahl;
            toolDerAuswahl = AuswahlTool.AnzahlSlider;
            auswahlOptionen = new List<pulldownAuswahl>() { };
            auswahlIdentifier = ChoiceAuswahlIdentifier.AnzSub01;

            minimaleAnzahl = -1;
            maximaleAnzahl = -1;
            stepsize = 1;
            unitBaseCost = -1;
            costPerAditionalSubUnit = -1000;

            isActive = true;

            labelString = "Anzahl der Subeinheiten: ";
        }

        /// <summary>
        /// Wie viele Subeinheiten muss ich mindestens selektieren?
        /// </summary>
        public int minimaleAnzahl;
        /// <summary>
        /// Wie viele Subeinheiten darf ich maximal selektieren?
        /// </summary>
        public int maximaleAnzahl;
        /// <summary>
        /// Um wieviele Subeinheiten "pro Schritt" darf ich erhöhen oder senken?
        /// </summary>
        public int stepsize;

        /// <summary>
        /// Wie teuer ist die Einheit für die minimale Anzahl an Subeinheiten
        /// </summary>
        public int unitBaseCost;

        /// <summary>
        /// Wie teuer ist es, EINE zusätzliche Subeinheit hinzuzufügen?
        /// </summary>
        public int costPerAditionalSubUnit;

        private int totalSubUnits;

        /// <summary>
        /// Property für die gewählte Anzahl der Subeinheiten
        /// </summary>
        public int TotalSubUnits
        {
            get
            {
                return totalSubUnits;
            }
            set
            {
                totalSubUnits = value;
            }
        }

        public override void validate()
        {
            if (toolDerAuswahl != AuswahlTool.AnzahlSlider)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für zusSubeinheitenAuswahl!");

            if(minimaleAnzahl < 0 || minimaleAnzahl >= maximaleAnzahl)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die minimale Auswahlanzahl!");

            if (maximaleAnzahl < 0 || minimaleAnzahl >= maximaleAnzahl)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die maximale Auswahlanzahl!");

            if(unitBaseCost < 0)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Basiskosten der Einheit!");

            if (costPerAditionalSubUnit < 0)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Subunit-Costs!");

            if(stepsize < 1)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Slider-Stepsize!");
        }
    }

}
