using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum RassenTyp
    {
        [Description("Mittelländer")]
        Mittellaender,
        [Description("Fröhlicher Mittellaender")]
        Fro_Mittellaender,
        [Description("Tulamiden")]
        Tulamiden,

        [Description("Thorwaler")]
        Thorwaler,

    }
}
