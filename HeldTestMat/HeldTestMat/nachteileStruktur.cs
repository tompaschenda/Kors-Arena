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
        public NachteileNamen name;
        /// <summary>
        /// Die Ausprägung im Falle von Zaubermerkmalen, z.B. "Hellsicht"
        /// </summary>
        public ZauberMerkmale auspraegungZauberMerkmal;
        /// <summary>
        /// Die Ausprägung im Falle von Talenten, z.B. "Klettern"
        /// </summary>
        public TalentNamen auspraegungTalent;
        /// <summary>
        /// Die Ausprägung im Falle von Talentkategorien, z.B. "Kampftalente"
        /// </summary>
        public TalentKategorie auspraegungTalengruppe;

        /// <summary>
        /// Ausprägung für Suchtmittel
        /// </summary>
        public Suchtmittel auspraegungSucht;

        /// <summary>
        /// Ausprägung für eine Angst / Phobie
        /// </summary>
        public Aengste auspraegungAngst;

        /// <summary>
        /// Der zugehörige Wert des Nachteils
        /// </summary>
        public int wert;

        /// <summary>
        /// Die Ausprägung im Falle eines Sinnes:
        /// </summary>
        public SinneNamen auspraegungSinn;

    }

}
