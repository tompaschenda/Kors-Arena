using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    }
}
