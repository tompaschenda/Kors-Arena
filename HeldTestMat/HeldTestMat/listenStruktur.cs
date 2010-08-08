using System;
using System.Collections.Generic;

namespace listenStruktur
{
    /// <summary>
    /// Struktur, die Listen mit allen im aventurischen Sinne verfügbaren,
    /// aufzählbaren Attributen einer bestimmten Kategorie enthält.
    /// Z.B: Rassen, Kulturen, Vor- und Nachteile, etc.
    /// Nach Möglichkeit sollten NIRGENDS im Code außer in dieser Liste
    /// Klartextnamen verwendet werden, sondern immer nur die Namen aus
    /// dieser Struktur. Das vermeidet Fehler, die durch Typos entstehen
    /// können in Strings!
    /// </summary>
    public struct listenSammlung
    {
        /// <summary>
        /// Eine Liste aller Hauptrassen in Aventurien:
        /// </summary>
        public List<string> rassen;
        /// <summary>
        /// Eine Liste aller Subrassen in Aventurien. Nicht zu verwechseln mit
        /// Kulturen und Subkulturen! Laut Regelwerk werden diese Subrassen auch "Varianten" genannt,
        /// was ein wenig irreführend ist, denn wenn man einer Variante angehört ist man IMMER
        /// gleichzeitig auch Mitglied der Hauptrasse! Bsp: Ein Firnelf ist IMMER ein Elf!
        /// </summary>
        public List<string> subrassen;
        /// <summary>
        /// Eine Liste aller Hauptkulturen in Aventurien. Achtung! Es gibt auch nich Subkulturen!
        /// </summary>
        public List<string> kulturen;
        /// <summary>
        /// Eine Liste aller Subkulturen in Aventurien. 
        /// </summary>
        public List<string> subkulturen;


        /// <summary>
        /// Initialisiert die Struktur mit den korrekten Werten für alle Listen:
        /// </summary>
        public void init()
        {
            rassen = new List<string>()
            {
                "Mittelländer", "Tulamide", "Thorwaler", "Nivese", "Norbarde", "Trollzacker", "Waldmensch",
                "Utulu", "Elf", "Halbelf", "Zwerg", "Ork", "Halbork", "Goblin", "Achaz"
            };

            subrassen = new List<string>()
            {
                // Achtung: Man kann eine Subrasse haben, muss aber nicht. In diesem Fall hat man die Subrasse "keine"!
                "keine", "Fjarninger", "Gjalskerländer", "Rochshaz", "Tocamuyac", "Auelf", "Waldelf", "Firnelf", "Halbelf firnelfischer Abstammung",
                "Halbelf nivesischer Abstammung", "Halbelf thorwalscher Abstammung", "Brilliantzwerg", "Ambosszwerg", 
                "Wilder Zwerg", "Orkfrau", "Goblinfrau", "Orkland-Achaz", "Waldinsel-Achaz", "Maraskan-Achaz"
            };


            kulturen = new List<string>()
            {
                "Mittelländische Städte", "Mittelländische Landbevölkerung", "Andergast und Nostria", "Bornland", "Svellttal und Nordlande",
                "Almada", "Horasreich", "Zyklopeninseln", "Amazonenburg", "Aranien", "Mhanadistan", "Tulamidische Stadtstaaten", "Novadi", "Ferkina",
                "Zahori", "Thorwal", "Gjalskerland", "Fjarninger", "Dschungelstämme", "Verlorene Stämme", "Waldinsel Utulus", "Miniwatu",
                "Tocamuyac", "Maraskan", "Südaventurien", "Bukanier", "Nivesenstämme", "Nuanaä-Lie", "Norbardensippe", "Trollzacken", "Auelfische Sippe",
                "Elfische Siedlung", "Steppenelfische Sippe", "Waldelfische Sippe", "Firnelfische Sippe", "Ambosszwerge", "Erzzwerge", "Hügelzwerge",
                "Brillantzwerge", "Brobim", "Orkland", "Yurach", "Svellttal Besatzer", "Goblinstamm", "Goblinbande", "Festumer Ghetto", "Archaische Achaz",
                "Stammes-Achaz"
            };

            subkulturen = new List<string>()
            {
                "keine",                
                "Hafenstädte und Städte an großen Flüssen", "Städte mit wichtigem Tempel/Pilgerstätte", "Siedlerstädte des Nordens", "Städtischer Adel",
                "Kannemünde / Mhanerhaven", "Flüchtlinge aus borbaradianisch besetzten Städten", "Maraskanische Exilanten",
                // Mittelländische Landbevölkerung:
                "Künstengebiete oder an großen Flüssen", "An einer wichtigen Handelsroute/Reichsstraße", "Regionen Weiden und Greifenfurt", "Gebirge",
                "Fern der Zivilisation", "Landadel", "Jilaskan", "Borbaradianisch besetzte Gebiete",
                // Andergast und Nostria:
                "Stadt", "Landadel", "Gebirge", "Küstengebiete", "Teshkalien",
                // Bornland:
                "Landstädte", "Küstengebiete", "Landadel",
                // Svellttal und Nordlande:
                "Stadt", "Kleinstädte", "Küstengebiete oder an großen Flüssen", "Fern der Zivilisation", "Flüchtlinge aus Glorania",
                // Almada:
                "Städte am Yaquir", "Orte mit wichtigem Tempel/Pilgerstätte", "Städtischer Adel", "An einer wichtigen Handelsroute", "Gebirge",
                "Landadel",
                // Horasreich:
                "Hafenstädte/Städte an großen Flüssen", "Städte mit wichtigem Tempel/Pilgerstätte", "Städtischer Adel",
                "Dörfer an der Küste oder an großen Flüssen", "An einer wichtigen Handelsroute", "Fernab der Zivilisation", "Landadel",
                // Zyklopeninseln:
                "Landadel",
                // Aranien:
                "Stadt", "Küstengebiete oder am Barun-Ulah", "Adel",
                // Mhanadistan:
                "An wichtigen Handelsrouten", "Fernab der Zivilisation", "Küstengebiete oder an großen Flüssen", "Tulamidische Nomadenstämme",
                // Tulamidische Stadtstaaten:
                "See- oder Mhanadihafen", "Kasimiten",
                // Novadi:
                "Wüstenoase",
                // Thorwal:
                "Binnenland",
                // Dschungelstämme:
                "Tschopukikuha", "Bergstämme", "Haipu", "Darna",
                // Verlorene Stämme:
                "Shokubunga", "Chirakha", 
                // Maraskan:
                "Dschungel", "Küstengebiete", "Maraskanische Städte",
                // Südaventurien:
                "Südliche Stadtstaaten", "Kolonialhäfen", "Dschungeldorf/Plantage", "Selem", "Maraskanische Exilanten",
                // Nivesenstämme:
                "Halbsesshafte Küstenstämme", 
                // Nuanaä-Lie:
                "Nauoke",
                // Auelfische Sippe:
                "Hoher Norden",
                // Elfische Siedlung:
                "Südliche Mittellande", "Großstadt", "Firnelfisch beeinflusste Siedlung", "Waldelfisch beeinflusste Siedlung",
                // Firnelfische Sippe:
                "Küste und Inseln",
                // Orkland:
                "Ergoch", "Grishik", "Drasdech", "Khurkach", 
                // TODO: Stämme ermöglichen! "Korogai", "Mokolash", "Olochtai", "Orichai", "Truanzhai", "Tscharshai", "Zholochai"
                // Goblinstamm:
                "Ebene", "Gebirge", "Schneegoblins",
                // Stammes-Achaz:
                "Maraskan", "Orkland", "Echsensümpfe", "Loch Harodrol", "Waldinseln/Südaventurien"
            };

        }


    }

}