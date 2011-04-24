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
        public AuswahlAnzahlSpieler(int anzMin, int anzMax)
        {
            InitializeComponent();

            anzahlSlider.Minimum = anzMin;
            anzahlSlider.Maximum = anzMax;
        }




        public int anzahlGewaehlt;
        public bool allesOkay = false;


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
            anzahlGewaehlt = (int) anzahlSlider.Value -1;
            allesOkay = true;
            this.Close();
        }


    }
}
