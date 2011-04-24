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
using EinheitDefinition;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für UnitRename.xaml
    /// </summary>
    public partial class UnitRename : Window
    {
        public UnitRename(StreitmachtEdit parentWindow, int indexDerArmee, Einheit testEinheit)
        {
            m_WindowParent = parentWindow;
            InitializeComponent();
            m_indexDerArmee = indexDerArmee;

            // Ich möchte, dass der alte Name direkt als Auswahl erscheint:
            this.namensTextbox.Text = testEinheit.spielerEinheitenName;
        }

        private StreitmachtEdit m_WindowParent;
        private int m_indexDerArmee = -1;
        public bool m_okay = false;
        public string m_neuerSpielerString = "";


        private void abbrechenKlick(object sender, RoutedEventArgs e)
        {
            m_neuerSpielerString = "";
            m_okay = false;
            this.Close();
        }

        private void okayKlick(object sender, RoutedEventArgs e)
        {
            // Wenn alles okay ist, übernehmen wir den Namen!
            if(checkUnitNameValidity())
            {
                m_neuerSpielerString = this.namensTextbox.Text;
                m_okay = true;

                // Das Aktualisieren geschieht außen!
                this.Close();           
            }
            // Wenn das Checken nicht geklappt hat, lassen wir den Nutzer niemals aus diesem Dialog heraus!
            // Es sei denn, er klickt auf abbrechen!
        }

        /// <summary>
        /// Prüft, ob die Eingabe des Nutzers in das Textfeld erfolgt ist und diese gültig ist!
        /// </summary>
        public bool checkUnitNameValidity()
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
            for (int i = 0; i < spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten.Count; ++i)
                if (spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[i].spielerEinheitenName == this.namensTextbox.Text)
                {
                    MessageBox.Show("Bitte einen Namen eingeben, der noch nicht vergeben ist!", "Kein einzigartiger Name eingegeben!", MessageBoxButton.OK, MessageBoxImage.Error);
                    allesOkay = false;
                }

            return allesOkay;
        }
    }
}
