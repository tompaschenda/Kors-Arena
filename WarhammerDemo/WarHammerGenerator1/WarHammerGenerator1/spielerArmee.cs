using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using EinheitDefinition;

namespace spielerArmee
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
        }

        /// <summary>
        /// Die Sammlung der eigentlichen Armeen.
        /// </summary>
        public List<spielerArmeeKlasse> armeeSammlung;

    }
}
