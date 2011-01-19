using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace GUI
{
    class WizardStep<DataClass>
    {
        public delegate DataClass GetDataDelegate();

        public WizardStep(UIElement widget, string header)
        {
            this.widget = widget;
            this.header = header;
            getDataDelegate = null;
        }

        public GetDataDelegate dataDelegate
        {
            set
            {
                getDataDelegate = value;
            }
        }

        public UIElement Widget 
        {
            get
            {
                return widget;
            }
        }

        public DataClass getData()
        {
            return getDataDelegate();
        }

        private UIElement widget;
        private string header;
        private GetDataDelegate getDataDelegate; 
    }
}
