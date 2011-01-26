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
using heldenStruktur;
using Listen;
using System.Diagnostics;

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var w = new NeuerHeldWindow();
            //w.ShowDialog();
        }

        private void NeuerHeld_Click(object sender, RoutedEventArgs e)
        {
            starteHeldenerstellung();
        }

        public void starteHeldenerstellung()
        {
            Held h = new Held();
            var Tulamiden = rassenStruktur.rassenStruct.getRasseByIdentifier(SpielerRassenName.Tulamiden);
            h.Rasse = Tulamiden;
            h.Subrasse = Tulamiden.moeglicheSubrassen[0];
            h.Geschlecht = GeschlechtNamen.maennlich;
            h.Name = "Keiner von Niemand";


            NeuerHeldWizardData d = new NeuerHeldWizardData();
            d.held = h;
            NeuerHeldWizardWindow neuerHeldWindow = new NeuerHeldWizardWindow(d);
            neuerHeldWindow.Show();
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
