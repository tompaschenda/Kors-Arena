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

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für fehlerMessageBox.xaml
    /// </summary>
    public partial class fehlerMessageBox : Window
    {
        public fehlerMessageBox()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
