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
using System.Windows.Navigation;
using System.Windows.Shapes;
using spielerArmee;
using Listen;
using spielerAnfragen;
using System.Windows.Forms;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            updateArmeeListenBox();
        }

        private void klickNeueStreitmacht(object sender, RoutedEventArgs e)
        {
            StreitmachtCreate streitmachtErzeugenFenster = new StreitmachtCreate(this);
            streitmachtErzeugenFenster.Owner = this;
            streitmachtErzeugenFenster.ShowDialog();
        }

        private void klickNeueStreitmachtMenu(object sender, RoutedEventArgs e)
        {
            StreitmachtCreate streitmachtErzeugenFenster = new StreitmachtCreate(this);
            streitmachtErzeugenFenster.ShowDialog();
        }


        private void klickQuitMenu(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Löscht eine in der GUI ausgewählte Streitmacht!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickLoescheStreitMacht(object sender, RoutedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            // Wir zeigen natürlich nur dann etwas an, wenn auch etwas ausgewählt ist! :)
            if (selectionIndex != -1)
            {
                // Zunächst stellen wir eine Sicherheitsabfrage:
                string message = "Soll die ausgewählte Armee wirklich und endgültig gelöscht werden?";
                string caption = "Sicherheitsabfrage";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = System.Windows.Forms.MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Dann löschen wir. Wir wissen ja, dass der Name eindeutig ist!
                    spielerArmeeListe.getInstance().armeeSammlung.RemoveAt(selectionIndex);
                    // Refresh des Displays:
                    updateArmeeListenBox();
                }

                // Sonst passiert nichts!
            }
        }
          

        // Abhängig davon, welche Armee gerade aus der Liste selektiert worden ist, muss ich
        // natürlich noch dafür sorgen, dass die entsprechenden Haupteigenschaften im Fenster
        // ausgelesen und angezeigt werden!
        // Dazu muss ich erst einmal wissen, welches Item ausgewählt wurde!
        private void detailsAktualisieren(object sender, SelectionChangedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            // Wir zeigen natürlich nur dann etwas an, wenn auch etwas ausgewählt ist! :)
            if (selectionIndex != -1)
            {
                displayArmyName.Clear();
                string neuerName = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex].armeeName;
                displayArmyName.AppendText(neuerName);

                string neueFraktion = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex].armeeFraktion.ToString();
                displayArmySide.Clear();
                displayArmySide.AppendText(neueFraktion);

                string gesamtKosten = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex].gesamtPunkte.ToString();
                displayArmyPoints.Clear();
                displayArmyPoints.AppendText(gesamtKosten);
            }

        }

        /// <summary>
        /// Aktualisiert die GUI-Anzeige der Armee-Liste!
        /// </summary>
        public void updateArmeeListenBox()
        {
            // Zunächst mal müssen die alten Einträge natürlich weg:
            ListBoxArmeeListe.Items.Clear();

            // Jetzt muss ich die Sachen auch noch anzeigen:
            for (int i = 0; i < spielerArmeeListe.getInstance().armeeSammlung.Count; ++i)
            {
                ListBoxArmeeListe.Items.Add(spielerArmeeListe.getInstance().armeeSammlung[i].armeeName);
            }
        }


        /// <summary>
        /// Gibt einer Streitmacht einen neuen Namen!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtUmbennnen(object sender, RoutedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            if (selectionIndex != -1)
            {
                StreitmachtRename streitmachtRenameFenster = new StreitmachtRename(this, selectionIndex);
                streitmachtRenameFenster.Owner = this;
                streitmachtRenameFenster.ShowDialog();
            }
        }

        /// <summary>
        /// Kopiert eine bereite vorhandene Streitmacht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtKopieren(object sender, RoutedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            if (selectionIndex != -1)
            {
                var blaupauseArmee =  spielerArmeeListe.getInstance().armeeSammlung[selectionIndex];
                spielerArmeeKlasse neueArmee = new spielerArmeeKlasse(blaupauseArmee);
                neueArmee.armeeName = "Kopie von " + neueArmee.armeeName;
                spielerArmeeListe.getInstance().armeeSammlung.Add(neueArmee);
                updateArmeeListenBox();
            }
        }



    }
}
