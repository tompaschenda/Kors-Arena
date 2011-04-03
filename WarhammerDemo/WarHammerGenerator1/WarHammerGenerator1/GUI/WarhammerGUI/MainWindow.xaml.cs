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



    }
}
