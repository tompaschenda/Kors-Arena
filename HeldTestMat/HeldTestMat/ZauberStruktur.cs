using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Listen;

namespace zauberStruktur
{
    /// <summary>
    /// Eine Struktur, die lediglich ALLE Attribute enthält, mit denen sich ein Zauber
    /// mit ALLEN Ausprägungen EINDEUTIG identifizieren lässt.
    /// </summary>
    public struct ZauberIdentifier
    {
        /// <summary>
        ///  Name eines Zaubers
        /// </summary>
        public ZauberName name;

        /// <summary>
        /// Ausprägung des Zaubers (z.B. Element, etc.)
        /// </summary>
        public object auspraegung;
    };

}