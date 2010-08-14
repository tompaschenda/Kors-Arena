using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Datenmodell
{
    [Serializable]
    public struct RassenDaten:IKeyedValue<string>
    {
        public string GetKey()
        {
            return Name;
        }
        /// <summary>
        /// Name der Rasse.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Generierungskosten für die jeweilige Rasse in GP
        /// </summary>
        public int Generierungskosten { get; set; }

        /// <summary>
        /// Map, in der alle Haarfarben und ihre Wahrscheinlichkeiten abgelegt sind
        /// </summary>
        public RangeMap<string> Haarfarben { get; set; }

        /// <summary>
        /// Map, die die möglichen Augenfarben und die jeweiligen Wahrscheinlichkeiten dafür enthält.
        /// </summary>
        public RangeMap<string> Augenfarben { get; set; }

        public override string ToString()
        {
            return ObjectExtentions.ToStringGeneric(this);
        }
    }
}
