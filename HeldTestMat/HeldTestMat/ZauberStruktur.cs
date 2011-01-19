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
        /// Es gibt auch Zauber, bei denen eine Eigenschaft variieren kann! => Attributo!
        /// TODO: Dies muss abgebildet werden!
        /// </summary>
        public List<EigenschaftenName> eigenschaften;

        /// <summary>
        /// Ist die Magieresistenz als Modifikator mit auf die Probe als Erschwernis anzurechnen?
        /// </summary>
        public bool mrModifikator;

        /// <summary>
        /// Ist zusätzlich "+Mod" auf den Zauber als Erschwernis (oder Erleichterung) anzurechnen?
        /// </summary>
        public bool modModifikator;

        /// <summary>
        ///  Liste mit allen Merkmalen des Zaubers
        /// </summary>
        public List<ZauberMerkmal> merkmale;

        /// <summary>
        /// Liste mit allen Verbeitungen des Zaubers
        /// </summary>
        public List<GenericListenNameWertPaar<Zauberer>> verbreitungen;



        /// <summary>
        /// Wie lange ist die Zauberdauer in Aktionen? 1 KR = 2 Aktionen. 1 SR = 5 Minuten = 5 * 40 Aktionen
        /// </summary>
        public int zauberDauerAktionen;// TODO!

        /// <summary>
        /// Kosten des Zaubers in ASP
        /// </summary>
        public int aspKosten; // TODO!

        /// <summary>
        /// Reichweite des Zaubers in Schritt. -1 für Talentwert oder ähnliches. 0 für Berührung.
        /// </summary>
        public int reichweite; //TODO!

        /// <summary>
        /// Wirkungsdauer eines Zaubers in Aktionen. -1 für unendlich/unbegrenzt/augenblicklich
        /// </summary>
        public int wirkungsdauer; // TODO!

        /// <summary>
        /// Eine Liste, die alle möglichen spontanen Modifikationen eines Zaubers enthält:
        /// </summary>
        public List<ZauberModifikationen> modifikationen; // TODO!

        /// <summary>
        /// Eine Liste, die alle möglichen Varianten eines Zaubers enthält:
        /// </summary>
        public List<ZauberVariante> varianten; // TODO!

        /// <summary>
        /// Kann man den Zauber umkehren?
        /// </summary>
        public bool reversalisMoeglich; // TODO!

        /// <summary>
        /// Kann man den Zauber mit Antimagie erschweren / verhindern?
        /// </summary>
        public bool antimagieMoeglich; // TODO!



        /// <summary>
        /// Welche Komplexität weist ein Zauber auf?
        /// TODO: Ist KEIN INT, sondern Map auf INT!
        /// </summary>
        public int komplexitaet;  // TODO!

        // TODO: Repräsentationen / Verbreitungen


        /// <summary>
        /// Ab hier folgen die einzelnen Funktionen, die einen Zauberspruch generieren.
        /// </summary>
        /// <returns></returns>
        private ZauberSpruch createAbveneum()
        {
            var spruch = new ZauberSpruch() { };
            spruch.name = ZauberName.Abveneum;

            spruch.eigenschaften = new List<EigenschaftenName>() { };
            spruch.eigenschaften.Add(EigenschaftenName.KL);
            spruch.eigenschaften.Add(EigenschaftenName.KL);
            spruch.eigenschaften.Add(EigenschaftenName.KL);

            spruch.modModifikator = true;

            spruch.merkmale = new List<ZauberMerkmal>() { };
            spruch.merkmale.Add(ZauberMerkmal.Objekt);

            spruch.verbreitungen = new List<GenericListenNameWertPaar<Zauberer>>() { };
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Druide, wert = +6 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Elf, wert = +6 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Hexe, wert = +6 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Magier, wert = +6 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Geode, wert = +5 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Kirstallomant, wert = +4 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Schelm, wert = +4 });

            return spruch;
        }

        private ZauberSpruch createAccuratum()
        {
            var spruch = new ZauberSpruch() { };
            spruch.name = ZauberName.Accuratum;

            spruch.eigenschaften = new List<EigenschaftenName>() { };
            spruch.eigenschaften.Add(EigenschaftenName.KL);
            spruch.eigenschaften.Add(EigenschaftenName.CH);
            spruch.eigenschaften.Add(EigenschaftenName.FF);

            spruch.modModifikator = true;

            spruch.merkmale = new List<ZauberMerkmal>() { };
            spruch.merkmale.Add(ZauberMerkmal.Objekt);

            spruch.verbreitungen = new List<GenericListenNameWertPaar<Zauberer>>() { };
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Magier, wert = +4 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Scharlatan, wert = +4 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Hexe, wert = +2 });

            return spruch;
        }

        private ZauberSpruch createAdamantium()
        {
            var spruch = new ZauberSpruch() { };
            spruch.name = ZauberName.Adamantium;

            spruch.eigenschaften = new List<EigenschaftenName>() { };
            spruch.eigenschaften.Add(EigenschaftenName.KL);
            spruch.eigenschaften.Add(EigenschaftenName.FF);
            spruch.eigenschaften.Add(EigenschaftenName.KO);

            // Man beachte: Der modModifikator und mrModifikator werden nicht gesetzt, da 
            // sie automatisch mit "false" initialisiert werden.

            spruch.merkmale = new List<ZauberMerkmal>() { };
            spruch.merkmale.Add(ZauberMerkmal.Objekt);
            spruch.merkmale.Add(ZauberMerkmal.ElementarErz);

            spruch.verbreitungen = new List<GenericListenNameWertPaar<Zauberer>>() { };
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Kirstallomant, wert = +6 });
            spruch.verbreitungen.Add(new GenericListenNameWertPaar<Zauberer>() { name = Zauberer.Magier, wert = +5 });

            return spruch;
        }

        // TODO! Hier fortführen für alle anderen Zauber wie oben! Dabei den Attributo erst einmal überspringen, da er eine Sonderrolle hat!
        // (wegen "EIG" als dritte Eigenschaftsprobe!

    };

}