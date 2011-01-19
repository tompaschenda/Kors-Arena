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
using rassenStruktur;

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für RassenAuswahlControl.xaml
    /// </summary>
    public partial class RassenAuswahlControl : UserControl
    {
        public RassenAuswahlControl()
        {
            InitializeComponent();
            treeViewRassen.Items.Clear();
            treeViewRassen.ItemsSource = rassenStruktur.rassenStruct.erzeugeAlleRassen();
        }
    }
}
