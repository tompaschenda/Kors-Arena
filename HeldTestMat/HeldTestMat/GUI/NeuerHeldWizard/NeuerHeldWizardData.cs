using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using heldenStruktur;
using Common;

namespace GUI
{
    public class NeuerHeldWizardData
    {
        public Held held { get; set; }

        public List<rassenStruktur.rassenStruct> rassen
        {
            get
            {
                return rassenStruktur.rassenStruct.erzeugeAlleRassen();
            }
        }


        public override string ToString()
        {
            return ObjectExtentions.ToStringGeneric(this);
        }
    }
}
