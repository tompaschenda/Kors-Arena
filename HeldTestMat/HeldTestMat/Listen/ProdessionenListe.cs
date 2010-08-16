using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum ProfessionsTypen
    {
        [Description("kämpferisch")]
        Kaempferisch,
        [Description("reisend und Wildnis")]
        ReisendUndWildnis,
        [Description("gesellschaftlich")]
        Gesellschaftlich,
        [Description("handwerklich und Wissen")]
        HandwerklichUndWissen,
        [Description("magisch")]
        Magisch,
        [Description("geweiht")]
        Geweiht,
    }

    public enum ProfessionsNamen
    {
        // TODO!

    }
}
