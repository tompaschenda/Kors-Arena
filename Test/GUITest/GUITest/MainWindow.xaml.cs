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
using WarhammerGUI;
using System.Diagnostics;

namespace GUITest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var e =new taktischerTrupp();
            e.declareChoices();
            ((zusSubeinheitenAuswahl)e.getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01)).TotalSubUnits = 3;
            e.updateChoiceDependencies();
            DataContext = e;
            foreach (var a in e.Auswahlen)
            {
                Debug.WriteLine(a.GUIText + ", Aktiv: "+ a.IsActive);
            }


        }
    }
}
