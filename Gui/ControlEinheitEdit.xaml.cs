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
using System.Diagnostics;

namespace WarhammerGUI.Gui
{
    public class AuswahlTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Auswahl1AusN
        {
            get;
            set;
        }

        public DataTemplate AuswahlMAusN
        {
            get;
            set;
        }

        public DataTemplate AuswahlSlider
        {
            get;
            set;
        }

        public override DataTemplate SelectTemplate(object item,
        DependencyObject container)
        {
            choiceDefinition cd = (choiceDefinition)item;
            Window window = Application.Current.MainWindow;
            switch (cd.toolDerAuswahl)
            {
                case AuswahlTool.EinsAusN:
                    return Auswahl1AusN;
                case AuswahlTool.MAusN:
                    return AuswahlMAusN;
                case AuswahlTool.AnzahlSlider:
                    return AuswahlSlider;
                default:
                    Debug.Assert(false);
                    return null;
            }
        }
    }
    /// <summary>
    /// Interaction logic for ControlEinheitEdit.xaml
    /// </summary>
    public partial class ControlEinheitEdit : UserControl
    {
        public ControlEinheitEdit()
        {
            InitializeComponent();
        }
    }
}
