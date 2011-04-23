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
    /// Interaktionslogik für UnitRename.xaml
    /// </summary>
    public partial class UnitRename : Window
    {
        public UnitRename(StreitmachtEdit parentWindow, int indexDerArmee, int indexDerUnit, bool checkOnly)
        {
            m_WindowParent = parentWindow;
            InitializeComponent();

            // Ich möchte, dass der alte Name direkt als Auswahl erscheint:
            this.namensTextbox.Text = spielerArmeeListe.getInstance().armeeSammlung[indexDerArmee].armeeEinheiten[indexDerUnit].spielerEinheitenName;

            m_indexDerArmee = indexDerArmee;
            m_indexDerUnit = indexDerUnit;
            m_checkOnly = checkOnly;
        }

        private StreitmachtEdit m_WindowParent;
        private int m_indexDerArmee;
        private int m_indexDerUnit;
        private bool m_checkOnly;

        private void abbrechenKlick(object sender, RoutedEventArgs e)
        {
            if(! m_checkOnly)
                this.Close();
        }

        private void okayKlick(object sender, RoutedEventArgs e)
        {
            // Wenn alles okay ist, übernehmen wir den Namen!
            if(checkUnitNameValidity())
            {
                string neuerUnitName = this.namensTextbox.Text;

                // Ersetze den Namen:
                spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[m_indexDerUnit].spielerEinheitenName = neuerUnitName;

                // Und aktualisiere den einzigartigen Einheitsnamen!
                var alterBaseUnitName = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[m_indexDerUnit].einheitenName;
                var alterBaseNameReadable = EnumExtensions.getEnumDescription(alterBaseUnitName.GetType(), alterBaseUnitName.ToString());
                spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeEinheiten[m_indexDerUnit].einheitenUniqueName = alterBaseNameReadable + " (" + neuerUnitName + ")";

                // Aktualisieren der Anzeige:
                m_WindowParent.updateArmyTreeView();

                this.Close();           
            }
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
