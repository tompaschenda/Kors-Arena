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

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für NeuerHeldWizard.xaml
    /// </summary>
    public partial class NeuerHeldWizardWindow : Window
    {
        public NeuerHeldWizardWindow()
        {
            InitializeComponent();
            wizard = new NeuerHeldWizard();
            wizard.setUpdateCurrentStepDelegate(UpdateCurrentStep);
            wizard.GoFirstStep();
        }

        public NeuerHeldWizardWindow(NeuerHeldWizardData d) : this()
        {
            wizard.data = d;
            DataContext = d;
        }

        private void UpdateCurrentStep()
        {
            wizardContentControl.Content = wizard.currentStep.Widget;
        }

        private void WizardButtonsControl_Back(object sender, RoutedEventArgs e)
        {
            wizard.GoBack();
            System.Console.WriteLine(wizard.data.ToString());
        }

        private void WizardButtonsControl_Next(object sender, RoutedEventArgs e)
        {
            wizard.GoNext();
            System.Console.WriteLine(wizard.data.ToString());
        }

        private NeuerHeldWizard wizard;
        
    }
}
