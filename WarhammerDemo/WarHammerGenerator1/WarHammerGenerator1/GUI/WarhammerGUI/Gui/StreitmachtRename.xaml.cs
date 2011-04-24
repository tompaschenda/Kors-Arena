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
using spielerArmee;
using Common;
using Listen;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für StreitmachtEdit.xaml
    /// </summary>
    public partial class StreitmachtRename : Window
    {
        public StreitmachtRename(MainWindow mainWindow, int indexDerArmee)
        {
            m_mainWindowParent = mainWindow;
            InitializeComponent();

            // Ich möchte, dass der alte Name direkt als Auswahl erscheint:
            this.namensTextbox.Text = spielerArmeeListe.getInstance().armeeSammlung[indexDerArmee].armeeName;

            m_indexDerArmee = indexDerArmee;
        }

        private MainWindow m_mainWindowParent;
        private int m_indexDerArmee;

        private void abbrechenKlick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okayKlick(object sender, RoutedEventArgs e)
        {
            // Wenn alles okay ist, legen wir eine neue Armee an!
            if(checkValidity())
            {
                string neuerArmeeName = this.namensTextbox.Text;
               
                // Ersetze den Namen:
                spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeName = neuerArmeeName;

                // Außerdem wollen wir, dass die Anzeige-Box des Hauptfensters aktualisiert wird!
                m_mainWindowParent.updateArmeeListenBox();
    
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
                MessageBox.Show("Bitte einen Namen eingeben!", "Kein Name eingegeben!", MessageBoxButton.OK, MessageBoxImage.Error);
                allesOkay = false;
            }

            // Außerdem darf der Name noch nicht vergeben sein!
            for (int i = 0; i < spielerArmeeListe.getInstance().armeeSammlung.Count; ++i)
                if (spielerArmeeListe.getInstance().armeeSammlung[i].armeeName == this.namensTextbox.Text && spielerNamensstring != spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeName)
                {
                    MessageBox.Show("Bitte einen Namen eingeben, der noch nicht vergeben ist!", "Kein einzigartiger Name eingegeben!", MessageBoxButton.OK, MessageBoxImage.Error);
                    allesOkay = false;
                }

            return allesOkay;
        }
    }
}
