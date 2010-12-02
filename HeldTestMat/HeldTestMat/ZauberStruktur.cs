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

    /// <summary>
    /// Eine Struktur, die ALLE Attribute enthält, die zur Beschreibung eines Zaubers notwendig sind.
    /// </summary>
    public struct ZauberSpruch
    {
        /// <summary>
        /// Name des Zaubers
        /// </summary>
        public ZauberName name;

        /// <summary>
        /// Eine Liste, die jeweils Namen der jeweiligen Eigenschaften für die Talentprobe enthält.
        /// Es gibt auch Zauber, bei denen eine Eigenschaft variieren kann!
        /// TODO: Dies muss abgebildet werden!
        /// </summary>
        public List<EigenschaftenName> eigenschaften;

        /// <summary>
        /// Ist die Magieresistenz als Modifikator mit auf die Probe als Erschwernis anzurechnen?
        /// </summary>
        public bool mrModifikator;

        // TODO: Es gibt auch noch sonstige Modifikatoren (Umwelt, Beschwörung, etc., etc.!)

        /// <summary>
        /// Wie lange ist die Zauberdauer in Aktionen? 1 KR = 2 Aktionen. 1 SR = 5 Minuten = 5 * 40 Aktionen
        /// </summary>
        public int zauberDauerAktionen;

        /// <summary>
        /// Dito, aber in Spielrunden. 1 SR = 5 Minuten, 1 Stunde = 12 SR
        /// </summary>
        public int zauberDauerSR;

        /// <summary>
        /// Kosten des Zaubers in ASP
        /// </summary>
        public int aspKosten;

        /// <summary>
        /// Reichweite des Zaubers in Schritt. -1 für Talentwert oder ähnliches. 0 für Berührung.
        /// </summary>
        public int reichweite;

        /// <summary>
        /// Wirkungsdauer eines Zaubers in Aktionen. -1 für unendlich/unbegrenzt/augenblicklich
        /// </summary>
        public int wirkungsdauer;

        /// <summary>
        /// Eine Liste, die alle möglichen spontanen Modifikationen eines Zaubers enthält:
        /// </summary>
        public List<ZauberModifikationen> modifikationen;

        /// <summary>
        /// Eine Liste, die alle möglichen Varianten eines Zaubers enthält:
        /// </summary>
        public List<ZauberVariante> varianten;

        /// <summary>
        /// Kann man den Zauber umkehren?
        /// </summary>
        public bool reversalisMoeglich;

        /// <summary>
        /// Kann man den Zauber mit Antimagie erschweren / verhindern?
        /// </summary>
        public bool antimagieMoeglich;

        /// <summary>
        ///  Liste mit allen Merkmalen des Zaubers
        /// </summary>
        public List<ZauberMerkmal> merkmal;

        /// <summary>
        /// Welche Komplexität weist ein Zauber auf?
        /// TODO: Ist KEIN INT, sondern Map auf INT!
        /// </summary>
        public int komplexitaet;

        // TODO: Repräsentationen / Verbreitungen

    };


}