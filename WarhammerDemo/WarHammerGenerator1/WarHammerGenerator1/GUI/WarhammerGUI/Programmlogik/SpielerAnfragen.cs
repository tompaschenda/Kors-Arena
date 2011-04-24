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
        /// <summary>
        /// Fragt den Spieler, wie viele Sub-Einheiten er wählen möchte und berechnet die Kosten dafür.
        /// </summary>
        /// <param name="baseNumber"> Anzahl der Basiseinheiten</param>
        /// <param name="minValue"> Minimal mögliche Auswahl</param>
        /// <param name="maxValue"> Maximal mögliche Auswahl</param>
        /// <param name="costPerValuePoint"> Punktekosten pro Auswahlpunkt</param>
        /// <param name="totalCostBase"> Gesamtpunktekosten vor der Auswahl</param>
        /// <param name="descriptionString"> Beschreibungsstring für die GUI</param>
        /// <returns> Gibt die Anzahl zurück, die der Spieler gewünscht hat</returns>
        public int spielerAuswahlNumberBox(int baseNumber, int minValue, int maxValue, int costPerValuePoint, int totalCostBase, string descriptionString)
        {
            int anzahl = 1;

            // An dieser Stelle muss ich aus dem Code heraus ein Fenster in WPF basteln, dass die gewünschten 


            // GUI-Aufbau:
            // TODO!
            // Funktionspointer auf die Update-Funktionen!

            return anzahl;
        }


        /// <summary>
        /// Erlaubt dem Spieler, aus N Auswahlen aus einem Pulldown Menü (etc.) genau eine auszuwählen.
        /// </summary>
        /// <param name="totalCostBase"> Gesamtpunktekosten vor der Auswahl</param>
        /// <param name="anzahlElemente"> Faktor, wie häufig die Kosten zu Buche schlagen (z.B. 5 für 5 x kostenProElement bei 5 Einheiten)</param>
        /// <param name="descriptionString"> Beschreibung der Auswahl</param>
        /// <param name="pulldownAuswahlen"> Liste mit allen Auswahlmöglichkeiten (hier sollten die Kosten drin stehen!)</param>
        /// <returns></returns>
        public int spielerAuswahl1AusN(int totalCostBase, int anzahlElemente, string descriptionString, List<pulldownAuswahl> pulldownAuswahlen)
        {
            var auswahlIndex = new int();

            // TODO: GUI-Aufbau!
            // TODO: GUI-String aus CAST von "auswahl" auf String + WhiteSpace + kosten + Whitespace + "Punkte pro Modell"

            return auswahlIndex;
        }


        public List<int> spielerAuswahlMAusN(int totalCostBase, int anzahlElemente, string descriptionString, List<pulldownAuswahl> pulldownAuswahlen)
        {
            var ausWahlVektor = new List<int>() { };

            // TODO: GUI-Aufbau!
            // TODO: GUI-String aus CAST von "auswahl" auf String + WhiteSpace + kosten + Whitespace + "Punkte pro Modell"
            // TODO: NUR dann eintragen, wenn der Spieler wirklich eine Auswahl getätigt hat!

            return ausWahlVektor;
        }


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
