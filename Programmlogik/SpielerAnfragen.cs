using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarhammerGUI
{

    /// <summary>
    /// Eine Auswahloption für ein Pulldownmenü
    /// </summary>
    public struct pulldownAuswahl
    {
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
