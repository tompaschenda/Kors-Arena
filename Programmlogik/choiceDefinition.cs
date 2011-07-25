﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;
using System.ComponentModel;
using System.Diagnostics;

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

        [Description("WaffeProSubunitWahl")]
        WaffeProSubunitWahl,
        [Description("AusrüstungProSubunitWahl")]
        AusruestungProSubunitWahl,
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

        [Description("SubunitAusrüstungswahl01")]
        SubEquip01,
        [Description("SubunitAusrüstungswahl02")]
        SubEquip02,
        [Description("SubunitAusrüstungswahl03")]
        SubEquip03,
        [Description("SubunitAusrüstungswahl04")]
        SubEquip04,
        [Description("SubunitAusrüstungswahl05")]
        SubEquip05,

        [Description("SubunitWaffenwahl01")]
        SubWep01,
        [Description("SubunitWaffenwahl02")]
        SubWep02,
        [Description("SubunitWaffenwahl03")]
        SubWep03,
        [Description("SubunitWaffenwahl04")]
        SubWep04,
        [Description("SubunitWaffenwahl05")]
        SubWep05,

    }

    public abstract class choiceDefinition : ICloneable, INotifyPropertyChanged
    {
        /// <summary>
        /// Den folgenden Event brauchen wir, um der GUI Bescheid zu sagen.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public AuswahlTyp artDerAuswahl;
        public AuswahlTool toolDerAuswahl;
        public ChoiceAuswahlIdentifier auswahlIdentifier;

        /// <summary>
        /// Ist die Auswahl gerade aktiv?
        /// </summary>
        private bool isActive;

        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsActive"));
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
            var copy = this.MemberwiseClone();
            return copy;
        }

        public abstract Object getChoiceValues();

        public abstract int getChoiceCost();

    }

    public class ChoiceDefinitionForSelection : choiceDefinition
    {
        public ChoiceDefinitionForSelection(AuswahlTool tool)
        {
            auswahlOptionen = new List<pulldownAuswahl>() { };
            toolDerAuswahl = tool;
            switch (tool)
            {
                case AuswahlTool.EinsAusN:
                    multiSelect =false;
                    break;
                case AuswahlTool.MAusN:
                    multiSelect =true;
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }
        }

        public override object Clone()
        {
            var copy = this.MemberwiseClone();
            ((ChoiceDefinitionForSelection)copy).auswahlOptionen = new List<pulldownAuswahl>() { };
            for (int i = 0; i < auswahlOptionen.Count; ++i)
            {
                ((ChoiceDefinitionForSelection)copy).auswahlOptionen.Add((pulldownAuswahl)this.auswahlOptionen[i].Clone());
            }
            return copy;
        }

        public override object getChoiceValues()
        {
            throw new NotImplementedException();
        }
        public override int getChoiceCost()
        {
            throw new NotImplementedException();
        }

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

        public void setChosenIndex(int newIndex)
        {
            if (newIndex >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Index für Waffenwahl ist out of range!");
            if (!multiSelect)
                resetAuswahl();
            auswahlOptionen[newIndex].IstGewaehlt=true;
        }
        
        public void setChosenIndices(List<int> newIndices)
        {
            if (!multiSelect)
                throw new ArgumentOutOfRangeException("Mehrfachauswahl nicht erlaubt.");

            if (newIndices.Count >= auswahlOptionen.Count)
                throw new ArgumentOutOfRangeException("Index für Fahrzeugwahl ist out of range!");

            
            foreach (var i in newIndices)
            {
                auswahlOptionen[i].IstGewaehlt=true;
            }
        }
        
        public Object getChosenItem()
        {
            var chosenItems = getChosenItems();
            if (chosenItems.Count>0)
                return chosenItems[0];
            else
                return null;
        }

        public List<Object> getChosenItems()
        {
            var chosenItems = new List<Object>();
            foreach (var i in auswahlOptionen)
            {
                if (i.IstGewaehlt)
                    chosenItems.Add(i.auswahl);
            }
            return chosenItems;
        }

        public bool removeItem(Object item)
        {
            if (auswahlOptionen.RemoveAll(i => i.auswahl==item) >0 )
                return true;
            else
                return false;
        }

        public override void validate()
        {
            if (!multiSelect && getChosenItems().Count > 1)
                throw new ArgumentOutOfRangeException("Mehrfachauswahl nicht erlaubt.");
        }

        private void resetAuswahl()
        {
            foreach (var i in auswahlOptionen)
            {
                i.IstGewaehlt = false;
            }
        }

        private bool multiSelect;
        private List<pulldownAuswahl> auswahlOptionen;
    }


    /// <summary>
    /// Auswahl einer Waffe
    /// </summary>
    public class waffenAuswahl : ChoiceDefinitionForSelection
    {

        public override object getChoiceValues()
        {
            return getSelectedWeaponName();
        }

        public override int getChoiceCost()
        {
            pulldownAuswahl aktAuswahl = new pulldownAuswahl() { };
            foreach (var i in AuswahlOptionen)
            {
                if (i.IstGewaehlt)
                {
                    aktAuswahl = i;
                    break;
                }
            }
            return  aktAuswahl.kosten;
        }

        private const int InvalidIndex = -1;

        public override object Clone()
        {
            var copy = base.Clone();           
            return copy;
        }

        public waffenAuswahl() : base(AuswahlTool.EinsAusN)
        {
            artDerAuswahl = AuswahlTyp.Waffenauswahl;
            auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
            IsActive = true;
            labelString = "Bewaffnung: ";
        }

        public override void validate()
        {
            base.validate();
            if(toolDerAuswahl != AuswahlTool.EinsAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für waffenAuswahl!");
        }

        public alleWaffenNamen getSelectedWeaponName()
        {
            if (getChosenItem() != null)
                return (alleWaffenNamen)getChosenItem();
            else
                return alleWaffenNamen.undefined;
        }

        public void removeWeapon(alleWaffenNamen waffenName)
        {
            if (!removeItem(waffenName))
                throw new ArgumentOutOfRangeException("Die angegebene Waffe gibt es nicht!");
        }
    }

    public class transportfahrzeugWahl : ChoiceDefinitionForSelection
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public override object getChoiceValues()
        {
            return getSelectedVehicle();
        }


        public override int getChoiceCost()
        {
            // Mat: TODO! Wie komme ich an die Kosten für die Auswahl heran?
            // Sie ist eigentlich im Pulldown-Menü als "kosten" hinterlegt.
            Debug.Assert(false);
            return -1;
        }



        public transportfahrzeugWahl() : base(AuswahlTool.EinsAusN)
        {
            artDerAuswahl = AuswahlTyp.Transportfahrzeugwahl;
            auswahlIdentifier = ChoiceAuswahlIdentifier.Trans01;
            IsActive = true;
            labelString = "Angeschlossenes Transportfahrzeug: ";
        }

        public override void validate()
        {
            base.validate();
            if (toolDerAuswahl != AuswahlTool.EinsAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für transportfahrzeugWahl!");
        }

        public alleEinheitenNamen getSelectedVehicle()
        {
            if (getChosenItem() != null)
                return (alleEinheitenNamen)getChosenItem();
            else
                return alleEinheitenNamen.KeineEinheit;
        }

        public void removeVehicle(alleEinheitenNamen fahrzeugName)
        {
            if (!removeItem(fahrzeugName))
                throw new ArgumentOutOfRangeException("Das angegebene Fahrzeug gibt es nicht!");
        }
    }

    public class ausruestungsAuswahl : ChoiceDefinitionForSelection
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public ausruestungsAuswahl() : base(AuswahlTool.MAusN)
        {
            artDerAuswahl = AuswahlTyp.Ausruestungsauswahl;
            auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
            IsActive = true;
            labelString = "Ausrüstung: ";
            
        }

        public override object getChoiceValues()
        {
            return getSelectedEquip();
        }

        public override int getChoiceCost()
        {
            int totalCosts = 0;

            foreach (var i in AuswahlOptionen)
            {
                if (i.IstGewaehlt)
                    totalCosts += i.kosten;
            }
            return totalCosts;
        }

        public List<alleAusruestung> getSelectedEquip()
        {
            var selectedEquip = new List<alleAusruestung>() { };

            foreach (var i in getChosenItems())
            {
                selectedEquip.Add((alleAusruestung)i);
            }
            return selectedEquip;
        }

        public void removeEquip(alleAusruestung ausruestungsname)
        {
            if (!removeItem(ausruestungsname))
                throw new ArgumentOutOfRangeException("Das angegebene Equip gibt es nicht!");
        }

        public override void validate()
        {
            base.validate();
            if(toolDerAuswahl != AuswahlTool.MAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für ausruestungsAuswahl!");
        }
    }

    public class ruestungsAuswahl : ChoiceDefinitionForSelection
    {
        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public override object getChoiceValues()
        {
            return getSelectedArmor();
        }

        public override int getChoiceCost()
        {
            int totalCosts = 0;
            foreach (var i in AuswahlOptionen)
            {
                if (i.IstGewaehlt)
                    totalCosts += i.kosten;
            }
            return totalCosts;
        }


        public ruestungsAuswahl() : base(AuswahlTool.EinsAusN)
        {
            artDerAuswahl = AuswahlTyp.Ruestungsauswahl;
            auswahlIdentifier = ChoiceAuswahlIdentifier.Ruest01;
            IsActive = true;
            labelString = "Rüstung: ";
        }

        public alleRuestungen getSelectedArmor()
        {
            if (getChosenItem() != null)
                return (alleRuestungen)getChosenItem();
            else
                return alleRuestungen.keine;
        }

        public void removeEquip(ruestungsAuswahl ruestungsname)
        {
            if (!removeItem(ruestungsname))
                throw new ArgumentOutOfRangeException("Die angegebene Rüstung gibt es nicht!");
        }

        public override void validate()
        {
            base.validate();
            if (toolDerAuswahl != AuswahlTool.EinsAusN)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für ruestungsAuswahl!");
        }
    }

    public class zusSubeinheitenAuswahl : choiceDefinition
    {
        public override int getChoiceCost()
        {
            // Die Kosten für die Auswahl ergeben sich aus den ZUSÄTZLICHEN Subeinheiten mal
            // der Kosten pro zusätzlicher Einheit!
            int anzNeueEinheiten = 0;
            if(totalSubUnits != 0)
             anzNeueEinheiten =  totalSubUnits-minimaleAnzahl;

            int gesamtKosten = anzNeueEinheiten * costPerAditionalSubUnit;
            return gesamtKosten;
        }

        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public override object getChoiceValues()
        {
            return totalSubUnits;
        }

        public zusSubeinheitenAuswahl()
        {
            artDerAuswahl = AuswahlTyp.ZusSubeinheitenAuswahl;
            toolDerAuswahl = AuswahlTool.AnzahlSlider;
            auswahlIdentifier = ChoiceAuswahlIdentifier.AnzSub01;

            minimaleAnzahl = -1;
            maximaleAnzahl = -1;
            stepsize = 1;
            unitBaseCost = -1;
            costPerAditionalSubUnit = -1000;

            IsActive = true;

            labelString = "Anzahl der Subeinheiten: ";
        }

        /// <summary>
        /// Wie viele Subeinheiten muss ich mindestens selektieren?
        /// </summary>
        private int minimaleAnzahl;
        /// <summary>
        /// Wie viele Subeinheiten darf ich maximal selektieren?
        /// </summary>
        private int maximaleAnzahl;
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
        /// Property für den Minimalen Slider-Wert:
        /// </summary>
        public int MinimaleAnzahl
        {
            get
            {
                return minimaleAnzahl;
            }
            set
            {
                minimaleAnzahl = value;
            }
        }

        /// <summary>
        /// Property für die maximale Anzahl:
        /// </summary>
        public int MaximaleAnzahl
        {
            get
            {
                return maximaleAnzahl;
            }
            set
            {
                maximaleAnzahl = value;
            }
        }

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


    public class ausruestungProSubUnitWahl : choiceDefinition
    {

        public int getNumberOfNonUpgrades()
        {
            int upgradesNichtGewaehlt = maximaleAnzahl - totalSelections;
            return upgradesNichtGewaehlt;
        }

        public int getNumberOfUpgrades()
        {
            int upgradesGewaehlt = totalSelections - minimaleAnzahl;
            return upgradesGewaehlt;
        }

        public override int getChoiceCost()
        {
            // Die Kosten errechnen sich natürlich aus beiden Anteilen:
            int kosten = getNumberOfUpgrades() * costForUpgrade + getNumberOfNonUpgrades() * costForNonUpgrade;

            return kosten;
        }

        public override object getChoiceValues()
        {
            throw new NotImplementedException();
        }


        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public ausruestungProSubUnitWahl()
        {
            artDerAuswahl = AuswahlTyp.AusruestungProSubunitWahl;
            toolDerAuswahl = AuswahlTool.AnzahlSlider;
            auswahlIdentifier = ChoiceAuswahlIdentifier.SubEquip01;

            minimaleAnzahl = -1;
            maximaleAnzahl = -1;
            stepsize = 1;

            costForNonUpgrade = -1;
            costForUpgrade = -1;

            dieAusruestung = alleAusruestung.undefined;

            IsActive = true;

            labelString = "ICH BRAUCHE EIN LABEL!: ";
        }

        /// <summary>
        /// Minimal möglicher Slider-Wert
        /// </summary>
        private int minimaleAnzahl;
        /// <summary>
        /// Maximal möglicher Slider-Wert
        /// </summary>
        private int maximaleAnzahl;
        /// <summary>
        /// Schrittweite des Sliders:
        /// </summary>
        public int stepsize;

        /// <summary>
        /// Was kostet die Option, die NICHT durch Selektion gewählt wird (i.d.R. 0)?
        /// </summary>
        public int costForNonUpgrade;

        /// <summary>
        /// Was kostet die Option, DIE durch Selektion gewählt wird?
        /// </summary>
        public int costForUpgrade;


        private int totalSelections;

        /// <summary>
        /// Property für den Minimalen Slider-Wert:
        /// </summary>
        public int MinimaleAnzahl
        {
            get
            {
                return minimaleAnzahl;
            }
            set
            {
                minimaleAnzahl = value;
            }
        }

        /// <summary>
        /// Property für die maximale Anzahl:
        /// </summary>
        public int MaximaleAnzahl
        {
            get
            {
                return maximaleAnzahl;
            }
            set
            {
                maximaleAnzahl = value;
            }
        }

        /// <summary>
        /// Property für die gewählte Anzahl der Subeinheiten
        /// </summary>
        public int TotalSubUnits
        {
            get
            {
                return totalSelections;
            }
            set
            {
                totalSelections = value;
            }
        }

        public alleAusruestung dieAusruestung = alleAusruestung.undefined;

        public override void validate()
        {
            if (dieAusruestung == alleAusruestung.undefined)
                throw new ArgumentOutOfRangeException("Keine Ausrüstung spezifiziert!");

            if (toolDerAuswahl != AuswahlTool.AnzahlSlider)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für zusSubeinheitenAuswahl!");

            if (minimaleAnzahl < 0 || minimaleAnzahl >= maximaleAnzahl)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die minimale Auswahlanzahl!");

            if (maximaleAnzahl < 0 || minimaleAnzahl >= maximaleAnzahl)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die maximale Auswahlanzahl!");

            if (costForUpgrade < 0)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Basiskosten der Einheit!");

            if (costForNonUpgrade < 0)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Subunit-Costs!");

            if (stepsize < 1)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Slider-Stepsize!");
        }
    }

    public class waffenProSubUnitWahl : choiceDefinition
    {

        public int getNumberOfNonUpgrades()
        {
            int upgradesNichtGewaehlt = maximaleAnzahl - totalSelections;
            return upgradesNichtGewaehlt;
        }

        public int getNumberOfUpgrades()
        {
            int upgradesGewaehlt = totalSelections - minimaleAnzahl;
            return upgradesGewaehlt;
        }

        public override int getChoiceCost()
        {
            // Die Kosten errechnen sich natürlich aus beiden Anteilen:
            int kosten = getNumberOfUpgrades() * costForUpgrade + getNumberOfNonUpgrades() * costForNonUpgrade;

            return kosten;
        }

        public override object getChoiceValues()
        {
            throw new NotImplementedException();
        }


        public override object Clone()
        {
            var copy = base.Clone();
            return copy;
        }

        public waffenProSubUnitWahl()
        {
            artDerAuswahl = AuswahlTyp.WaffeProSubunitWahl;
            toolDerAuswahl = AuswahlTool.AnzahlSlider;
            auswahlIdentifier = ChoiceAuswahlIdentifier.SubWep01;

            minimaleAnzahl = -1;
            maximaleAnzahl = -1;
            stepsize = 1;

            costForNonUpgrade = -1;
            costForUpgrade = -1;

            defaultWep = alleWaffenNamen.undefined;
            upgradeWep = alleWaffenNamen.undefined;

            IsActive = true;

            labelString = "ICH BRAUCHE EIN LABEL!: ";
        }

        /// <summary>
        /// Minimal möglicher Slider-Wert
        /// </summary>
        private int minimaleAnzahl;
        /// <summary>
        /// Maximal möglicher Slider-Wert
        /// </summary>
        private int maximaleAnzahl;
        /// <summary>
        /// Schrittweite des Sliders:
        /// </summary>
        public int stepsize;

        /// <summary>
        /// Was kostet die Option, die NICHT durch Selektion gewählt wird (i.d.R. 0)?
        /// </summary>
        public int costForNonUpgrade;

        /// <summary>
        /// Was kostet die Option, DIE durch Selektion gewählt wird?
        /// </summary>
        public int costForUpgrade;


        private int totalSelections;

        /// <summary>
        /// Property für den Minimalen Slider-Wert:
        /// </summary>
        public int MinimaleAnzahl
        {
            get
            {
                return minimaleAnzahl;
            }
            set
            {
                minimaleAnzahl = value;
            }
        }

        /// <summary>
        /// Property für die maximale Anzahl:
        /// </summary>
        public int MaximaleAnzahl
        {
            get
            {
                return maximaleAnzahl;
            }
            set
            {
                maximaleAnzahl = value;
            }
        }

        /// <summary>
        /// Property für die gewählte Anzahl der Subeinheiten
        /// </summary>
        public int TotalSubUnits
        {
            get
            {
                return totalSelections;
            }
            set
            {
                totalSelections = value;
            }
        }

        public alleWaffenNamen defaultWep = alleWaffenNamen.undefined;
        public alleWaffenNamen upgradeWep = alleWaffenNamen.undefined;

        public override void validate()
        {
            if (defaultWep == alleWaffenNamen.undefined || upgradeWep == alleWaffenNamen.undefined)
                throw new ArgumentOutOfRangeException("Keine Waffe(n) spezifiziert!");

            if (toolDerAuswahl != AuswahlTool.AnzahlSlider)
                throw new ArgumentOutOfRangeException("Falsche Auswahlart für zusSubeinheitenAuswahl!");

            if (minimaleAnzahl < 0 || minimaleAnzahl >= maximaleAnzahl)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die minimale Auswahlanzahl!");

            if (maximaleAnzahl < 0 || minimaleAnzahl >= maximaleAnzahl)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die maximale Auswahlanzahl!");

            if (costForUpgrade < 0)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Basiskosten der Einheit!");

            if (costForNonUpgrade < 0)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Subunit-Costs!");

            if (stepsize < 1)
                throw new ArgumentOutOfRangeException("Schwachsinnige Definition für die Slider-Stepsize!");
        }
    }
}