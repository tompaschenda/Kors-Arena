using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using WarhammerGUI.Utility;

namespace WarhammerGUI
{

    /// <summary>
    /// Eine Auswahloption für ein Pulldownmenü
    /// </summary>
    public class pulldownAuswahl : ValueCompare, ICloneable
    {
        public pulldownAuswahl()
        {
            kosten = 0;
            auswahl = null;
            IstGewaehlt = false;
        }

        public object Clone()
        {
            var copy = (pulldownAuswahl)this.MemberwiseClone();
            return copy;
        }

        public string GUIText
        {
            get
            {
                Type enumTyp = auswahl.GetType();

                string tempString;
                if (enumTyp.Name != "String")
                    tempString = EnumExtensions.getEnumDescription(enumTyp, auswahl.ToString());
                else
                    tempString = auswahl.ToString();
                return (tempString + "    (+ " + kosten.ToString() + " Punkte)");
            }
        }

        /// <summary>
        /// Ist die Auswahl selektiert?
        /// </summary>
        public bool IstGewaehlt
        {
            set;
            get;
        }

        /// <summary>
        /// Punktekosten der Auswahl
        /// </summary>
        public int kosten;

        /// <summary>
        /// Die eigentliche Auswahl. Kann eine Waffe sein, ein Fahrzeug, ein Ausrüstungsgegenstand, etc.
        /// </summary>
        public Object auswahl;
    }

    /// <summary>
    /// Stellt eine Auswahl von verschiedenen Nachfragen bereit, die ein
    /// Spieler beantworten muss, damit eine Einheit nach seinen Wünschen
    /// konfiguriert werden kann.
    /// </summary>
    class SpielerAnfragen
    {
        ///////////////////////////////////////////////////////
        // PRIVATE FUNKTIONEN!!!
        ///////////////////////////////////////////////////////

        private int updateTotalCostNumberBox(int totalCostBefore, int costPerUnit, int actNumberOfChoices)
        {
            var neueKosten = new int();
            neueKosten = totalCostBefore + costPerUnit * actNumberOfChoices;
            return neueKosten;
        }
        private int updateTotalNumberOfUnitsNumberBox(int baseNumber, int extraUnits)
        {
            return baseNumber + extraUnits;
        }
        private int updateChoiceCostNumberBox(int costPerUnit, int actNumberOfChoices)
        {
            return costPerUnit * actNumberOfChoices;
        }


    }
}
