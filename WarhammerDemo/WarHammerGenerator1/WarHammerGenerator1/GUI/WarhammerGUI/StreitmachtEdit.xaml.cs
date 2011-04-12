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
using Listen;
using spielerAnfragen;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für StreitmachtEdit.xaml
    /// </summary>
    public partial class StreitmachtEdit : Window
    {
        public StreitmachtEdit(MainWindow mainWindow, int indexDerArmee)
        {
            m_mainWindowParent = mainWindow;
            m_indexDerArmee = indexDerArmee;
            InitializeComponent();

            // Es sollen auch gleich die korrekten Werte angezeigt werden:
            updateArmyView();

            // Außerdem möchte ich alle möglichen Einheiten im rechten Tree-View anzeigen.
            // Diese Anzeige muss nicht aktualisiert werden können, da sie sich nicht ändert!
            updateAvailableUnitTree();
        }

        private MainWindow m_mainWindowParent;
        private int m_indexDerArmee;

        /// <summary>
        /// Aktualisiert die Ansicht der Armee in der GUI
        /// </summary>
        private void updateArmyView()
        {
            // Aktualisiere den Namen der Armee (er sollte eigentlich gleich bleiben, aber man weiß ja nie...)
            this.displayArmyName.Clear();
            string neuerName = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeName;
            this.displayArmyName.AppendText(neuerName);

            // Desgleichen für die Fraktion:
            this.displayArmySide.Clear();
            string neueFraktion = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].armeeFraktion.ToString();
            this.displayArmySide.AppendText(neueFraktion);

            // Desgleichen für die Punktzahl der Armee:
            this.displayArmyPoints.Clear();
            string neuePunktzahl = spielerArmeeListe.getInstance().armeeSammlung[m_indexDerArmee].gesamtPunkte.ToString();
            this.displayArmyPoints.AppendText(neuePunktzahl);

            // Das Treeview mit allen Einheiten muss auch aktualisiert werden:
            updateArmyTreeView();
        }

        /// <summary>
        /// Aktualisiert die Tree-View-Ansich der Spielerarmee.
        /// </summary>
        private void updateArmyTreeView()
        {
            // MAT: TODO!
            // Struktur: Fraktion => Einheitentyp (z.B. "Standard") => Einheit + Einheit-Username + ggfs. angeschlossenes Transportfahrzeug!
        }




        /// <summary>
        /// Aktualisiert die Ansicht im rechten Tree-View für alle vorhandenen Einheiten der Armee!
        /// </summary>
        private void updateAvailableUnitTree()
        {
            // MAT: TODO!
            // Struktur:   Fraktion => Einheitentyp (z.B. "Standard") => Einheit
        }


        /// <summary>
        /// Schließt die Bearbeitungs-Ansicht und kehrt zurück zum Parent:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickSchliessen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
