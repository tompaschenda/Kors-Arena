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
    public partial class NeuerHeldWizard : Window
    {
        public NeuerHeldWizard()
        {
            InitializeComponent();
            steps = new List<WizardStep>();
            AddStep(new WizardStep(new WizardGeschlechtAuswahlControl(), "Geschlecht auswählen"));
            AddStep(new WizardStep(new WizardRassenAuswahlControl(), "Rasse auswählen"));
            GoFirstStep();
        }

        private void GoFirstStep()
        {
            GotoStep(steps.First());
        }

        private void UpdateCurrentStep()
        {
            wizardContentControl.Content = currentStep.Widget;
        }

        private void AddStep(WizardStep wizardStep)
        {
            steps.Add(wizardStep);
        }

        private void WizardButtonsControl_Back(object sender, RoutedEventArgs e)
        {
            GoBack();
        }

        private void WizardButtonsControl_Next(object sender, RoutedEventArgs e)
        {
            GoNext();
        }

        private void GoNext()
        {
            if (!IsLastStep())
            {
                GotoStep(steps[steps.IndexOf(currentStep) + 1]);
            }
        }

        private void GoBack()
        {
            if (!IsFirstStep())
            {
                GotoStep(steps[steps.IndexOf(currentStep) -1]);
            }
        }

        private bool IsFirstStep()
        {
            return currentStep.Equals(steps.First());
        }

        private void GotoStep(WizardStep wizardStep)
        {
            currentStep = wizardStep;
            UpdateCurrentStep();
        }

        private bool IsLastStep()
        {
            return currentStep.Equals(steps.Last());
        }

        private List<WizardStep> steps;
        private WizardStep currentStep;
        
    }
}
