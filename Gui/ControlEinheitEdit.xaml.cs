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
    /// <summary>
    /// Interaction logic for ControlEinheitEdit.xaml
    /// </summary>
    public partial class ControlEinheitEdit : UserControl
    {
        public ControlEinheitEdit()
        {
            InitializeComponent();
        }

        private void ControlAuswahlAnzahl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updateEinheit();
        }

        private Einheit getEinheit()
        {
            return (Einheit)DataContext;
        }

        private void listBoxChoices2_Checked(object sender, RoutedEventArgs e)
        {
            updateEinheit();
        }

        private void updateEinheit()
        {
            if (getEinheit() != null)
            {
                getEinheit().updateChoiceDependencies();

                // Matt TODO:
                // Wir müssen nicht nur die Abhängigkeiten aktualisieren, sondern auch
                // dafür sorgen, dass die gewählten Items tatsächlich 
                // der Einheit zugeschrieben werden. Dazu muss die Einheit intern jeweils immer
                // von Grund auf neu generiert werden. Ausnahme: Der Name, den der Nutzer vorgegeben hat,
                // denn der sollte sich nicht jedesmal ändern, wenn eine Auswahl geändert wird.
                getEinheit().evaluateChoices();
                // Außerdem müssen wir die Gesamtkosten der Armee und die Ansicht der Subeinheit updaten!
                // TODO!!!!
                // ????
            }
        }
    }

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
}
