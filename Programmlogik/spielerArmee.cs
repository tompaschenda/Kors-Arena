using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;

namespace WarhammerGUI
{
    public class spielerArmeeKlasse
    {
        /// <summary>
        /// Konstruktor:
        /// </summary>
        public spielerArmeeKlasse()
        {
            armeeName = "";
            armeeFraktion = Fraktionen.SpaceMarines;
            gesamtPunkte = 0;
            armeeEinheiten = new List<Einheit>() { };
        }

        /// <summary>
        /// Copy-Konstruktor a lá Matthias :)
        /// </summary>
        /// <param name="alteArmee"></param>
        public spielerArmeeKlasse(spielerArmeeKlasse alteArmee)
        {
            armeeName = alteArmee.armeeName;
            armeeFraktion = alteArmee.armeeFraktion;
            gesamtPunkte = alteArmee.gesamtPunkte;

            // Achtung! Für die Einheiten der Armee muss ich natürlich den speziellen
            // Copy-Konstruktor benutzen, sonst gibt es keine Deep-Copy!
            armeeEinheiten = new List<Einheit>() { };
            for (int i = 0; i < alteArmee.armeeEinheiten.Count; ++i)
            {
                var vorlageEinheit = alteArmee.armeeEinheiten[i];
                Einheit kopierteEinheit = new Einheit(vorlageEinheit); // Copy-Konstruktor!
                armeeEinheiten.Add(kopierteEinheit);
            }
        }
            
        /// <summary>
        /// Der Name der Armee
        /// </summary>
        public string armeeName;

        /// <summary>
        /// Die Fraktion, der die Armee angehört.
        /// </summary>
        public Fraktionen armeeFraktion;

        /// <summary>
        /// Gesamtpunktewert der jeweiligen Armee!
        /// </summary>
        public int gesamtPunkte;

        /// <summary>
        /// Eine Liste, in der alle Einheiten der Armee eingetragen sind!
        /// </summary>
        public List<Einheit> armeeEinheiten;


        // Prüft, ob alle Units dieser Armee auch einen einzigartigen Namen haben!       
        public bool checkUnitNameUniqueness()
        {
            var isUnique = true;
            for (int i = 0; i < armeeEinheiten.Count; ++i )
            {
                int counter = 0;
                var refName = armeeEinheiten[i].einheitenName + " (" + armeeEinheiten[i].spielerEinheitenName + ")";
                for (int j = 0; j < armeeEinheiten.Count; ++j)
                {
                    var aktName = armeeEinheiten[j].einheitenName + " (" + armeeEinheiten[j].spielerEinheitenName + ")";
                    if (refName == aktName)
                        counter = counter + 1;
                }
                if (counter > 1)
                    isUnique = false;
            }

            return isUnique;
        }

        public int gibMirDieAnzahlFuerAuswahltyp(EinheitenAuswahl auswahl)
        {
            int anzahl = 0;
            for (int i = 0; i < this.armeeEinheiten.Count; ++i)
            {
                if (this.armeeEinheiten[i].auswahlTypSpieler == auswahl)
                    anzahl = anzahl + 1;
            }
            return anzahl;
        }

    }

    // Enthält beliebig viele Spieler-Armeen und ist immer ein Singleton.
    // Es kann und darf lediglich eine einzige Armeen-Liste geben!
    public class spielerArmeeListe
    {
        private static spielerArmeeListe m_Instance;

        public static spielerArmeeListe getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new spielerArmeeListe();
            }
            return m_Instance;
        }

        /// <summary>
        /// Konstruktor: Muss privat bleiben, da wir
        /// ein Singleton haben wollen!
        /// </summary>
        private spielerArmeeListe() 
        {
            // Beim Konstruktor passiert zunächst erst einmal nichts außer der Initialisierung
            // der Armee-Sammlung
            this.armeeSammlung = new List<spielerArmeeKlasse>() { };
            this.saveString = "";
        }

        /// <summary>
        /// Die Sammlung der eigentlichen Armeen.
        /// </summary>
        public List<spielerArmeeKlasse> armeeSammlung;

        /// <summary>
        /// Merkt sicht, wo die Armeeliste zuletzt abgespeichert wurde.
        /// </summary>
        public string saveString;

        /// <summary>
        /// Löscht eine Spielerarmeeliste vollständig!
        /// </summary>
        public void eraseMeTotally()
        {
            this.armeeSammlung = new List<spielerArmeeKlasse>() { };
            this.saveString = "";
        }

        /// <summary>
        /// Berechnet die Gesamtpunkte kosten aller Armeen neu!
        /// </summary>
        public void aktualisiereGesamtkosten()
        {
            int gesamtkostenProArmee;
            for (int i = 0; i < this.armeeSammlung.Count; ++i)
            {
                gesamtkostenProArmee = 0;

                for (int j = 0; j < this.armeeSammlung[i].armeeEinheiten.Count; ++j)
                {
                    gesamtkostenProArmee = gesamtkostenProArmee + this.armeeSammlung[i].armeeEinheiten[j].einheitKostenGesamt;
                }

                this.armeeSammlung[i].gesamtPunkte = gesamtkostenProArmee;
            }
        }

    }
}
