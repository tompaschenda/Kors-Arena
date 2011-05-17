using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Common;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für Auswahl1AusN.xaml
    /// </summary>
    public partial class Auswahl1AusN : Window
    {

        /// <summary>
        /// Erlaubt dem Spieler, aus N Auswahlen aus einem Pulldown Menü (etc.) genau eine auszuwählen.
        /// </summary>
        /// <param name="totalCostBase"> Gesamtpunktekosten vor der Auswahl</param>
        /// <param name="anzahlElemente"> Faktor, wie häufig die Kosten zu Buche schlagen (z.B. 5 für 5 x kostenProElement bei 5 Einheiten)</param>
        /// <param name="descriptionString"> Beschreibung der Auswahl</param>
        /// <param name="pulldownAuswahlen"> Liste mit allen Auswahlmöglichkeiten (hier sollten die Kosten drin stehen!)</param>
        /// <returns></returns>
        public Auswahl1AusN(Einheit aktEinheit, int totalCostArmy, int totalCostBase, int anzahlElemente, string descriptionString, List<pulldownAuswahl> pulldownAuswahlen)
        {
            InitializeComponent();

            announcementBox.Text = descriptionString;

            // Pulldown mit Daten füllen:
            for (int i = 0; i < pulldownAuswahlen.Count; ++i)
            {
                var aktAuswahl = pulldownAuswahlen[i];

                // Für den Header müssen wir natürlich die Description verwenden:
                var tempString = EnumExtensions.getEnumDescription(aktAuswahl.auswahl.GetType(), aktAuswahl.auswahl.ToString());
                pullDown.Items.Add(tempString + "    (+ " + pulldownAuswahlen[i].kosten.ToString() + " Punkte)");
            }


            totaleArmeekosten = totalCostArmy;
            totaleEinheitsKosten = totalCostBase;
            textArmeeKostenJetzt.Text = aktEinheit.einheitKostenGesamt.ToString();
            textEinheitKostenJetzt.Text = (totalCostBase + totalCostArmy + pulldownAuswahlen[0].kosten).ToString();
            textAuswahlExtrakosten.Text = pulldownAuswahlen[0].kosten.ToString();

            pulldownReferenzPrivat = pulldownAuswahlen;

            // Es soll immer der erste Index gewählt werden!
            pullDown.SelectedIndex = 0;

            gewaehlterIndexAusN = -1;
            allesOkay = false;

            this.ShowDialog();
        }

        private int totaleArmeekosten;
        private int totaleEinheitsKosten;
        public int gewaehlterIndexAusN;
        public bool allesOkay;
        private List<pulldownAuswahl> pulldownReferenzPrivat;



        /// <summary>
        /// Wird ausgelöst, wenn der Spieler abbricht!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickAbbrechen(object sender, RoutedEventArgs e)
        {
            allesOkay = false;
            this.Close();
        }

        /// <summary>
        /// Wird ausgelöst, wenn es weiter gehen soll!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickWeiter(object sender, RoutedEventArgs e)
        {
            gewaehlterIndexAusN = pullDown.SelectedIndex;

            allesOkay = true;
            this.Close();
        }

        /// <summary>
        /// Wird aufgerufen, sobald die Auswahl aktualisiert wird!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pullDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = pullDown.SelectedIndex;

            textArmeeKostenJetzt.Text = (totaleEinheitsKosten + totaleArmeekosten + pulldownReferenzPrivat[selectedIndex].kosten).ToString();
            textEinheitKostenJetzt.Text = (totaleEinheitsKosten + pulldownReferenzPrivat[selectedIndex].kosten).ToString();
            textAuswahlExtrakosten.Text = pulldownReferenzPrivat[selectedIndex].kosten.ToString();
        }


    }
}
