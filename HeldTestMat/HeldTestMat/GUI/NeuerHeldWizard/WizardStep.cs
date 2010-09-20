using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace GUI
{
    class WizardStep
    {
        public WizardStep(UIElement widget, string header)
        {
            this.widget = widget;
            this.header = header;
        }

        public UIElement Widget 
        {
            get
            {
                return widget;
            }
        }

        private UIElement widget;
        private string header;
    }
}
