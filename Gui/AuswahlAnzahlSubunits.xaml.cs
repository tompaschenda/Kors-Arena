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

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für AuswahlAnzahlSpieler.xaml
    /// </summary>
    public partial class AuswahlAnzahlSpieler : Window
    {
        public AuswahlAnzahlSpieler(Einheit aktEinheit, int anzMin, int anzMax, string descriptionString, int gesamtArmeeKosten, int kostenProSubeinheit)
        {
            InitializeComponent();


            announcementBox.Text = descriptionString;
            anzahlSlider.Minimum = 0;
            anzahlSlider.Maximum = anzMax-anzMin;
            anzahlSlider.TickFrequency = 1;
            anzahlSlider.IsSnapToTickEnabled = true;

            blockKostenSubeinheit.Text = kostenProSubeinheit.ToString();

            m_gesamtArmeeKosten = gesamtArmeeKosten;
            m_kostenProSubeinheit = kostenProSubeinheit;
            m_anzMinSubEinheiten = anzMin;

            anzSubeinheitenGesamt.Text = anzMin.ToString();
            m_bisherigeEinheitskosten = aktEinheit.basispunkteKosten;

            var gesamtPunkteNeu = m_gesamtArmeeKosten + m_bisherigeEinheitskosten;
            blockGesamtPunkte.Text = gesamtPunkteNeu.ToString();

            blockKostenEinheit.Text = m_bisherigeEinheitskosten.ToString();

            this.ShowDialog();
        }

        public int anzahlGewaehlt;
        public bool allesOkay = false;
        private int m_gesamtArmeeKosten;
        private int m_kostenProSubeinheit;
        private int m_anzMinSubEinheiten;
        private int m_bisherigeEinheitskosten;


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
        /// Es kann weitergehen!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickWeiter(object sender, RoutedEventArgs e)
        {
            anzahlGewaehlt = (int) anzahlSlider.Value;
            allesOkay = true;
            this.Close();
        }


        /// <summary>
        /// Wird aufgerufen, sobald sich der Wert für den Slider ändert!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anzahlSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blockKostenEinheit.Text = "";
            var kostenDerEinheitZusaetzlich = anzahlSlider.Value * m_kostenProSubeinheit;
            var kostenDerEinheitGesamt = m_bisherigeEinheitskosten + kostenDerEinheitZusaetzlich;
            var gesamtPunkteNeu = m_gesamtArmeeKosten + kostenDerEinheitGesamt;
            blockGesamtPunkte.Text = gesamtPunkteNeu.ToString();

            var gesamtSubeinheiten = m_anzMinSubEinheiten + anzahlSlider.Value;
            anzSubeinheitenGesamt.Text = gesamtSubeinheiten.ToString();

            blockKostenEinheit.Text = kostenDerEinheitGesamt.ToString();

            //blockKostenEinheit = 
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
