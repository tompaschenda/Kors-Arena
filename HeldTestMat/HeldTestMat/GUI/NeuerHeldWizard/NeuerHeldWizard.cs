using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using heldenStruktur;

namespace GUI
{
    class NeuerHeldWizard : Wizard<NeuerHeldWizardData>
    {
        public NeuerHeldWizard()
        {
            AddStep(new WizardStep<NeuerHeldWizardData>(new WizardGeschlechtAuswahlControl(), "Geschlecht auswählen"));
            AddStep(new WizardStep<NeuerHeldWizardData>(new WizardRassenAuswahlControl(), "Rasse auswählen"));
        }
    }
}
