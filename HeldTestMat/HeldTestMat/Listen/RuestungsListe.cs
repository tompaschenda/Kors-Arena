using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    /// <summary>
    /// Eine Liste mit allen Rüstungsnamen (z.B.) für die SF Rüstungsgewöhnung, etc.
    /// </summary>
    public enum RuestungsName
    {
        [Description("undefined")]
        undefined,
        [Description("Kettenhemd")]
        Kettenhemd,
        [Description("Kürass")]
        Kuerass,
        [Description("Leichte Platte")]
        LeichtePlatte,
        [Description("Wattierter Waffenrock")]
        WattierterWaffenrock,
        [Description("Lederwams")]
        Lederwams,
        [Description("Lederrüstung")]
        Lederruestung,
        [Description("Lederkleidung")]
        Lederkleidung,
        [Description("Ringelpanzer")]
        Ringelpanzer,
        [Description("Gambeson")]
        Gambeson,
        [Description("Leichtes Kettenhemd")]
        LeichtesKettenhemd,
        [Description("Kurzes Kettenhemd")]
        KurzesKettenhemd,
        [Description("Langes Kettenhemd")]
        LangesKettenhemd,
        [Description("Maraskanischer Hartholzharnisch")]
        MaraskanischerHartholzharnisch,
    }
}
