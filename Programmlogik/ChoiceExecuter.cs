using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;
using System.ComponentModel;
using System.Diagnostics;

namespace WarhammerGUI
{
    /// <summary>
    /// Kümmert sich darum, dass eine Choice ausgeführt wird und nimmt alle nötigen
    /// Änderungen an der Einheit oder Subeinheit vor, die sich daraus ergeben!
    /// </summary>
    public static class ChoiceExecuter
    {
        /*
        public void executeChoice(choiceDefinition auswahl, Einheit dieEinheit, subEinheit dieSubEinheit)
        {
            Debug.Assert(false);
            throw new ArgumentOutOfRangeException("Eine allgemeine Auswahl sollte niemals auftreten!");
        }*/

        /// <summary>
        /// Führt eine Waffenauswahl durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        public static void execChoice(waffenAuswahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Zunächst einmal errechnen wir die neuen Kosten und tragen sie in der Einheit ein:
            int neueKosten = auswahl.getChoiceCost();
            dieEinheit.einheitKostenGesamt = dieEinheit.einheitKostenGesamt + neueKosten;

            // Dann müssen wir noch die Waffe selbst hinzufügen:
            var aktWaffenName = auswahl.getSelectedWeaponName();
            dieSubEinheit.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(aktWaffenName));
        }


        /// <summary>
        /// Führt eine optionale Waffenauswahl durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        public static void execChoice(optWaffenAuswahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Holen wir uns alle ausgewählten Waffen:
            List<pulldownAuswahl> waffenChoices = (List<pulldownAuswahl>)auswahl.getChoiceValues();

            // Rein damit und die Kosten updaten!
            foreach (var i in waffenChoices)
            {
                dieEinheit.einheitKostenGesamt += i.kosten;
                dieSubEinheit.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe((alleWaffenNamen) i.auswahl));
            }
        }


        /// <summary>
        /// Führt eine Ausrüstungs-Auswahl durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        public static void execChoice(ausruestungsAuswahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit, bool abrechnen=true)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Zunächst einmal errechnen wir die neuen Kosten und tragen sie in der Einheit ein:
            int neueKosten = auswahl.getChoiceCost();

            // Wir rechnen aber nur ab, wenn es gewünscht ist (Default).
            if(abrechnen)
                dieEinheit.einheitKostenGesamt = dieEinheit.einheitKostenGesamt + neueKosten;

            // Und jetzt müssen wir alle Ausrüstungsgegenstände hinzufügen:
            dieSubEinheit.ausruestung.AddRange(auswahl.getSelectedEquip());
        }



        /// <summary>
        /// Führt eine exklusive Ausrüstungs-Auswahl durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        public static void execChoice(exklusiveAusruestungsAuswahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Zunächst einmal errechnen wir die neuen Kosten und tragen sie in der Einheit ein:
            int neueKosten = auswahl.getChoiceCost();

            dieEinheit.einheitKostenGesamt = dieEinheit.einheitKostenGesamt + neueKosten;

            alleAusruestung gewaehlteAusruestung = auswahl.getSelectedAusruestung();
            if (gewaehlteAusruestung == alleAusruestung.keine || gewaehlteAusruestung == alleAusruestung.undefined)
                return;

            // Und jetzt müssen wir alle Ausrüstungsgegenstände hinzufügen:
            dieSubEinheit.ausruestung.Add(gewaehlteAusruestung);
        }


        /// <summary>
        /// Führt eine Auswahl eines Transportfahrzeuges durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubeinheit"></param>
        public static void execChoice(transportfahrzeugWahl auswahl, Einheit dieEinheit, subEinheit dieSubeinheit)
        {
            throw new NotImplementedException("Fehler! Noch nicht eingebaut!");
        }

        /// <summary>
        /// Führt eine Rüstungsauswahl durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        public static void execChoice(ruestungsAuswahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Zunächst einmal errechnen wir die neuen Kosten und tragen sie in der Einheit ein:
            int neueKosten = auswahl.getChoiceCost();
            dieEinheit.einheitKostenGesamt = dieEinheit.einheitKostenGesamt + neueKosten;

            // Jetzt lasse ich mir die Rüstung geben:
            var aktRuestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(auswahl.getSelectedArmor());

            // Und jetzt setze ich die Rüstung:
            dieSubEinheit.ruestung = aktRuestung;

            // Eventuell muss ich auch noch die Ausrüstung hinzufügen, die durch die Rüstung definiert wird:
            for (int i = 0; i < aktRuestung.ausruestung.Count; ++i)
            {
                dieSubEinheit.ausruestung.Add(aktRuestung.ausruestung[i]);
            }

            // Der RS der Subunit und der Rettungswurf werden automatisch abhängig vom Rest der Ausrüstung aktualisiert
            // an anderer Stelle!
        }

        /// <summary>
        /// Führt die Auswahl einer Subeinheit-Anzahl durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        public static void execChoice(zusSubeinheitenAuswahl auswahl, Einheit dieEinheit)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Hier kann ich lediglich die Kosten updaten. Der Rest MUSS in der Einheitenklasse selbst geschehen!
            int neueKosten = auswahl.getChoiceCost();
            dieEinheit.einheitKostenGesamt += neueKosten;
        }

        /// <summary>
        /// Führt die Auswahl einer Anzahl von Ausrüstungsupgrades oder Nicht-Upgrades durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        /// <param name="akutellerIndex"></param>
        public static void execChoice(ausruestungProSubUnitWahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit, int akutellerIndex)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Die Kosten der Einheit rechnen wir nur EINMALIG ab:
            if (akutellerIndex == 0)
            {
                int neueKosten = auswahl.getChoiceCost();
                dieEinheit.einheitKostenGesamt += neueKosten;
            }

            // Erst arbeiten wir die Nicht-Upgrades ab, dann die Upgrades.
            if (akutellerIndex < auswahl.getNumberOfNonUpgrades())
            {
                // Hier brauche ich also nichts zu tun!
            }
            else
            {
                // Hier gibt es die Ausrüstung dazu!
                dieSubEinheit.ausruestung.Add(auswahl.dieAusruestung);
            }
        }



        /// <summary>
        /// Führt die Auswahl einer Anzahl von Waffen oder Nicht-Upgrades durch!
        /// </summary>
        /// <param name="auswahl"></param>
        /// <param name="dieEinheit"></param>
        /// <param name="dieSubEinheit"></param>
        /// <param name="akutellerIndex"></param>
        public static void execChoice(waffenProSubUnitWahl auswahl, Einheit dieEinheit, subEinheit dieSubEinheit, int akutellerIndex)
        {
            // Wenn die aktuelle Auswahl gar nicht aktiv ist, machen wir natürlich nichts:
            if (!auswahl.IsActive)
                return;

            // Die Kosten der Einheit rechnen wir nur EINMALIG ab:
            if (akutellerIndex == 0)
            {
                int neueKosten = auswahl.getChoiceCost();
                dieEinheit.einheitKostenGesamt += neueKosten;
            }

            // Erst arbeiten wir die Nicht-Upgrades ab, dann die Upgrades.
            if (akutellerIndex < auswahl.getNumberOfNonUpgrades())
            {
                // Hier wird die Default-Waffe eingesetzt!
                dieSubEinheit.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahl.defaultWep));
            }
            else
            {
                // Hier gibt es die Upgrade-Waffe dazu:
                dieSubEinheit.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahl.upgradeWep));
            }
        }


    }
}
