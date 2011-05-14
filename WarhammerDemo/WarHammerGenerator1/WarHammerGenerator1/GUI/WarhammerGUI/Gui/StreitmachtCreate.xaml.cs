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
using System.Windows.Forms;
using Common;
using Listen;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für StreitmachtEdit.xaml
    /// </summary>
    public partial class StreitmachtCreate : Window
    {
        public StreitmachtCreate(MainWindow mainWindow)
        {
            m_mainWindowParent = mainWindow;
            InitializeComponent();

            // Ich möchte, dass schon einmal eine Demo-Auswahl vorgegeben wird:
            this.namensTextbox.Text = "NeueArmee";
            this.fraktionCombo.SelectedIndex = 10;
        }

        private MainWindow m_mainWindowParent;

        private void abbrechenKlick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void weiterKlick(object sender, RoutedEventArgs e)
        {
            // Wenn alles okay ist, legen wir eine neue Armee an!
            if(checkValidity())
            {
                var meineArmee = new spielerArmeeKlasse();
                meineArmee.armeeName = this.namensTextbox.Text;
                var richtigerInt = EnumExtensions.GetEnumIntForDescritpion(typeof(Fraktionen), this.fraktionCombo.Text);
                meineArmee.armeeFraktion = (Fraktionen)richtigerInt;

                var alteArmeeAnzahl = spielerArmeeListe.getInstance().armeeSammlung.Count;

                // Und natürlich schreiben wir diese auch gleich in unsere globale Armee-Liste!
                spielerArmeeListe.getInstance().armeeSammlung.Add(meineArmee);

                // Außerdem wollen wir, dass die Anzeige-Box des Hauptfensters aktualisiert wird!
                m_mainWindowParent.updateArmeeListenBox();

                // Und wir möchten gerne die neu erstelle Armee ausgewählt haben!
                m_mainWindowParent.ListBoxArmeeListe.SelectedIndex = alteArmeeAnzahl;
    
                this.Close();           
            }
        }

        /// <summary>
        /// Prüft, ob die Eingabe des Nutzers in das Textfeld erfolgt ist und eine Armee ausgewählt wurde!
        /// </summary>
        private bool checkValidity()
        {
            bool allesOkay = true;         
            
            // Wir brauchen erst einmal überhaupt einen Namen!
            string spielerNamensstring = this.namensTextbox.Text;
            if (spielerNamensstring == "")
            {
                System.Windows.MessageBox.Show("Bitte einen Namen eingeben!", "Kein Name eingegeben!", MessageBoxButton.OK, MessageBoxImage.Error);
                allesOkay = false;
            }

            // Außerdem darf der Name noch nicht vergeben sein!
            for (int i = 0; i < spielerArmeeListe.getInstance().armeeSammlung.Count; ++i)
                if (spielerArmeeListe.getInstance().armeeSammlung[i].armeeName == this.namensTextbox.Text)
                {
                    System.Windows.MessageBox.Show("Bitte einen Namen eingeben, der noch nicht vergeben ist!", "Kein einzigartiger Name eingegeben!", MessageBoxButton.OK, MessageBoxImage.Error);
                    allesOkay = false;
                }

            // Wir brauchen eine gültige Fraktion!
            string spielerFraktion = this.fraktionCombo.Text;
            if (spielerFraktion == "")
            {
                System.Windows.MessageBox.Show("Bitte eine Fraktion auswählen!", "Keine Fraktion ausgewählt!", MessageBoxButton.OK, MessageBoxImage.Error);
                allesOkay = false;
            }

            return allesOkay;
        }
    }
}
