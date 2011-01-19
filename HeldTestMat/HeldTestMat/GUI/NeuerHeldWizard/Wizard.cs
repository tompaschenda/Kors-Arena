using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI
{
    class Wizard<DataClass>
    {
        public delegate void UpdateCurrentStepDelegate();

        public Wizard()
        {
            steps = new List<WizardStep<DataClass>>();
            updateCurrentStepDelegate = null;
        }

        public void setUpdateCurrentStepDelegate(UpdateCurrentStepDelegate d)
        {
            updateCurrentStepDelegate += d;
        }

        public WizardStep<DataClass> currentStep
        {
            get
            {
                return currentWizarStep;
            }
        }

        public DataClass data
        {
            get
            {
                return wizardData;
            }
            set
            {
                wizardData = value;
            }
        }

        /// <summary>
        /// C# does not allow property getters as delegates, so we need an explicit getter for data.
        /// See http://geekswithblogs.net/akraus1/archive/2006/02/10/69047.aspx
        /// </summary>
        public DataClass getData()
        {
            return data;
        }

        public void GoFirstStep()
        {
            GotoStep(steps.First());
        }

        protected void AddStep(WizardStep<DataClass> wizardStep)
        {
            wizardStep.dataDelegate = getData;
            steps.Add(wizardStep);
        }

        public void GoNext()
        {
            if (!IsLastStep())
            {
                GotoStep(steps[steps.IndexOf(currentStep) + 1]);
            }
        }

        public void GoBack()
        {
            if (!IsFirstStep())
            {
                GotoStep(steps[steps.IndexOf(currentStep) - 1]);
            }
        }

        private bool IsFirstStep()
        {
            return currentStep.Equals(steps.First());
        }

        private void GotoStep(WizardStep<DataClass> wizardStep)
        {
            currentWizarStep = wizardStep;
            updateCurrentStepDelegate();
        }

        private bool IsLastStep()
        {
            return currentStep.Equals(steps.Last());
        }

        private List<WizardStep<DataClass>> steps;
        private WizardStep<DataClass> currentWizarStep;
        private UpdateCurrentStepDelegate updateCurrentStepDelegate;
        private DataClass wizardData;

    }
}
