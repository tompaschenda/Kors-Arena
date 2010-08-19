using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Listen;

namespace nachteileStruktur
{

    /// <summary>
    /// Eine Struktur, die lediglich ALLE Attribute enthält, mit denen sich ein Nachteil
    /// mit ALLEN Ausprägungen EINDEUTIG identifizieren lässt.
    /// </summary>
    public struct NachteilsIdentifier
    {
        /// <summary>
        /// Der Hauptname des Nachteils, z.B. "Begabung für Talentgruppe"
        /// </summary>
        public NachteileName name;

        /// <summary>
        /// Die Ausprägung eines Nachteils. Das kann eine Ausprägung sein für:
        ///  - Zaubermerkmal
        ///  - Talent
        ///  - Talentgruppe
        ///  - Bestimmtes Gift
        ///  - Giftart
        ///  - Giftwirkungstyp
        ///  - Bestimmte Krankheit
        ///  - Sinn
        ///  - Gliedmaße
        ///  - Sucht
        ///  - Angst
        /// </summary>
        public object auspraegung;

        /// <summary>
        /// Der zugehörige Wert des Nachteils
        /// </summary>
        public int wert;

    }

}
