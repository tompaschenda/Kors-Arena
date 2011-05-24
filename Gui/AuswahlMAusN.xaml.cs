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
    public partial class AuswahlMAusN : Window
    {

        /// <summary>
        /// Erlaubt es dem Spieler, aus N Auswahlen M <= N auszuwählen.
        /// </summary>
        /// <param name="aktEinheit"></param>
        /// <param name="totalCostArmy"></param>
        /// <param name="totalCostBase"></param>
        /// <param name="anzahlElemente"></param>
        /// <param name="descriptionString"></param>
        /// <param name="pulldownAuswahlen"></param>
        public AuswahlMAusN(Einheit aktEinheit, int totalCostArmy, int totalCostBase, int anzahlElemente, string descriptionString, List<pulldownAuswahl> pulldownAuswahlen)
        {
            InitializeComponent();

            announcementBox.Text = descriptionString;

            int anzAuswahlen = pulldownAuswahlen.Count;

            // Ich muss mir nun überlegen, wie viele verschiedene Checkboxes genutzt werden sollen. Maximal können dies 12 sein!
            if (anzAuswahlen > 12)
                throw new ArgumentOutOfRangeException("Es dürfen nur bis zu 12 Auswahlen bei M aus N genutzt werden!");

            gesamtListe = new List<CheckBox>() { };
            gesamtListe.Add(checkBox1);
            gesamtListe.Add(checkBox2);
            gesamtListe.Add(checkBox3);
            gesamtListe.Add(checkBox4);
            gesamtListe.Add(checkBox5);
            gesamtListe.Add(checkBox6);
            gesamtListe.Add(checkBox7);
            gesamtListe.Add(checkBox8);
            gesamtListe.Add(checkBox9);
            gesamtListe.Add(checkBox10);
            gesamtListe.Add(checkBox11);
            gesamtListe.Add(checkBox12);

            for (int i = 0; i < 12; ++i )
            {
                if (i < anzAuswahlen)
                {
                    var aktAuswahl = pulldownAuswahlen[i];

                    // Für den Header müssen wir natürlich die Description verwenden:
                    var tempString = EnumExtensions.getEnumDescription(aktAuswahl.auswahl.GetType(), aktAuswahl.auswahl.ToString());

                    gesamtListe[i].Content = tempString + " (+" + pulldownAuswahlen[i].kosten.ToString() + " Punkte)";
                }
                else
                {
                    gesamtListe[i].Content = "";
                    gesamtListe[i].IsEnabled = false;
                }
            }

            totaleArmeekosten = totalCostArmy;
            totaleEinheitsKosten = totalCostBase;
            textArmeeKostenJetzt.Text = aktEinheit.einheitKostenGesamt.ToString();
            textEinheitKostenJetzt.Text = (totalCostBase + totalCostArmy ).ToString();
            textAuswahlExtrakosten.Text = "0";

            pulldownReferenzPrivat = pulldownAuswahlen;

            wahlIndexVektor = new List<int>() { };

            allesOkay = false;

            this.ShowDialog();
        }

        private int totaleArmeekosten;
        private int totaleEinheitsKosten;
        public List<int> wahlIndexVektor;
        private List<CheckBox> gesamtListe;

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
            wahlVektorAktualisieren();

            allesOkay = true;
            this.Close();
        }


        private void punkteAktualisieren()
        {
            int extraAuswahlpunkte = 0;
            for (int i = 0; i < wahlIndexVektor.Count; ++i )
            {
                Nullable<bool> checkState = gesamtListe[wahlIndexVektor[i]].IsChecked;
                if( checkState == true)
                    extraAuswahlpunkte = extraAuswahlpunkte + pulldownReferenzPrivat[wahlIndexVektor[i]].kosten;
            }


            textArmeeKostenJetzt.Text = (totaleArmeekosten + extraAuswahlpunkte + totaleEinheitsKosten).ToString();
            textEinheitKostenJetzt.Text = (totaleEinheitsKosten + extraAuswahlpunkte).ToString();
            textAuswahlExtrakosten.Text = extraAuswahlpunkte.ToString();
        }


        private void wahlVektorAktualisieren()
        {
            // An dieser Stelle muss ich nachhalten, welche Selektionen
            // vom Spieler gemacht worden sind:
            wahlIndexVektor = new List<int>() { };
            for (int i = 0; i < 12; ++i)
            {
                Nullable<bool> checkState = gesamtListe[i].IsChecked;
                if (checkState == true)
                {
                    wahlIndexVektor.Add(i);
                }
            }

            punkteAktualisieren();
        }

        // Jedes Mal, wenn eine Selektion gemacht oder zurück genommen wird, muss ich die
        // Anzeige aktualisieren!
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            wahlVektorAktualisieren();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.A || e.Key == Key.Escape)
                klickAbbrechen(this, e);

            if (e.Key == Key.W || e.Key == Key.Return)
                klickWeiter(this, e);
        }

    }
}
