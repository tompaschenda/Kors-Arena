using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;

namespace WarhammerGUI
{
    /// <summary>
    /// Enthält ALLE Waffenobjekte im Spiel.
    /// </summary>
    public class waffenfabrik
    {

        private static waffenfabrik m_Instance;

        public static waffenfabrik getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new waffenfabrik();
            }
            return m_Instance;
        }

        /// <summary>
        /// Konstruktor: Muss privat bleiben, da wir
        /// ein Singleton haben wollen!
        /// </summary>
        private waffenfabrik() 
        {
            // Wir wollen immer alle Waffen sofort anlegen!
            // Dadurch sind auch sofort alle Waffengattungen für
            // ALLE Rassen angelegt worden!
            createAllWeapons();
        }

        /// <summary>
        /// Eine Liste, die alle Waffen enthält.
        /// </summary>
        public List<waffe> waffen;

        /// <summary>
        /// Alle Waffen der Space Mariens
        /// </summary>
        public List<waffe> spaceMarineWaffen;

        /// <summary>
        /// Legt in der Waffenstruktur ALLE Waffen ab!
        /// </summary>
        public void createAllWeapons()
        {
            this.waffen = new List<waffe>() { };
            this.waffen.AddRange(createAllSpaceMarineWeapons());
        }

        /// <summary>
        /// Gibt ein beliebiges Waffenobjekt zurück, unter der Annahme,
        /// dass eine Waffe eindeutig über ihren Namen identifizierbar ist.
        /// </summary>
        /// <returns></returns>
        public waffe gibMirFolgendeWaffe(Object waffenName)
        {
            var gewuenschteWaffe = waffen.Find
            (
                delegate(waffe weap)
                {
                    return weap.name.ToString() == waffenName.ToString();
                }
            );

            if (gewuenschteWaffe == null)
                throw new ArgumentOutOfRangeException("Konnte die angegebene Waffe nicht finden!");

            return gewuenschteWaffe;
        }

        private List<waffe> createAllSpaceMarineWeapons() 
        {
            var waffenListe = new List<waffe>() { };

            waffenListe.Add(createSpaceMarinesAstartes());
            waffenListe.Add(createSpaceMarinesAuxilaris());
            waffenListe.Add(createSpaceMarinesBolter());
            waffenListe.Add(createSpaceMarinesBoltpistole());
            waffenListe.Add(createSpaceMarinesCrozius());
            waffenListe.Add(createSpaceMarinesCyclone());
            waffenListe.Add(createSpaceMarinesDigital());
            waffenListe.Add(createSpaceMarinesEhrenklinge());
            waffenListe.Add(createSpaceMarinesEnergieklaue());
            waffenListe.Add(createSpaceMarinesEnergiefaust());
            waffenListe.Add(createSpaceMarinesEnergiehammer());
            waffenListe.Add(createSpaceMarinesFlammenwerfer());
            waffenListe.Add(createSpaceMarinesKettenfaust());
            waffenListe.Add(createSpaceMarinesKettenschwert());
            waffenListe.Add(createSpaceMarinesKampfmesser());
            waffenListe.Add(createSpaceMarinesKombimelter());
            waffenListe.Add(createSpaceMarinesKombiFlammer());
            waffenListe.Add(createSpaceMarinesKombiPlasma());
            waffenListe.Add(createSpaceMarinesKonversion());
            waffenListe.Add(createSpaceMarinesLaserkanone());
            waffenListe.Add(createSpaceMarinesMelter());
            waffenListe.Add(createSpaceMarinesMelter());
            waffenListe.Add(createSpaceMarinesMultimelter());
            waffenListe.Add(createSpaceMarinesPsiwaffe());
            waffenListe.Add(createSpaceMarinesPlasmakanone());
            waffenListe.Add(createSpaceMarinesPlasmapistole());
            waffenListe.Add(createSpaceMarinesPlasmawerfer());
            waffenListe.Add(createSpaceMarinesRaketenwerfer());
            waffenListe.Add(createSpaceMarinesSchwererBolter());
            waffenListe.Add(createSpaceMarinesSchwererFlammer());
            waffenListe.Add(createSpaceMarinesSchrotflinte());
            waffenListe.Add(createSpaceMarinesScharfschuetze());
            waffenListe.Add(createSpaceMarinesSturmbolter());
            waffenListe.Add(createSpaceMarinesSturmkanone());
            waffenListe.Add(createSpaceMarinesSyncSchwererBolter());
            waffenListe.Add(createSpaceMarinesSyncSchwererFlammer());
            waffenListe.Add(createSpaceMarinesSyncSturmkanone());
            waffenListe.Add(createSpaceMarinesSyncLaserKanone());
            waffenListe.Add(createSpaceMarinesSyncPlasmawerfer());
            waffenListe.Add(createSpaceMarinesDeathwind());
            waffenListe.Add(createSpacemarinesHurricane());
            waffenListe.Add(createSpacemarinesFlammensturm());
            waffenListe.Add(createSpaceMarinesEnergieschwert());
            waffenListe.Add(createSpaceMarinesWhirlwindMehrfach());
            waffenListe.Add(createSpaceMarinesDemolisher());
            waffenListe.Add(createSpaceMarinesStalker());
            waffenListe.Add(createSpaceMarinesTalass());
            waffenListe.Add(createSpaceMarinesStabTigurius());
            waffenListe.Add(createSpaceMarinesInfernus());
            waffenListe.Add(createSpaceMarinesDornsPfeil());
            waffenListe.Add(createSpaceMarinesDornsFaust());
            waffenListe.Add(createSpaceMarinesRabenklauen());
            waffenListe.Add(createSpaceMarinesMondfang());
            waffenListe.Add(createSpaceMarinesSpeerDesVulkan());
            waffenListe.Add(createSpaceMarinesSchmiedefeuerhandschuh());
            waffenListe.Add(createSpaceMarinesCerberus());
            waffenListe.Add(createSpaceMarinesSyncBolter());
            waffenListe.Add(createSpaceMarinesSyncMaschkan());
            waffenListe.Add(createSpaceMarinesCybotNah());
            waffenListe.Add(createSpaceMarinesSeismischerHammer());
            waffenListe.Add(createSpaceMarinesMaschkan());
            waffenListe.Add(createSpaceMarinesOrbital());
            waffenListe.Add(createSpaceMarinesServoarm());
            waffenListe.Add(createSpaceMarinesSyncPlasmapistole());

            this.spaceMarineWaffen = waffenListe;

            return waffenListe;
        }

        private waffe createSpaceMarinesAstartes()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.AstartesGranatwerfer;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Fragmentgranate,
                reichweite = Reichweiten.Zoll24,
                staerke = 3,
                durchschlag = 6,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Explosiv  },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Sprenggranate,
                reichweite = Reichweiten.Zoll24,
                staerke = 6,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer },
            });

            return weap;
        }
        private waffe createSpaceMarinesAuxilaris()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.AuxilarisGranatwerfer;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Sprenggranate,
                reichweite = Reichweiten.Zoll12,
                staerke = 6,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Fragmentgranate,
                reichweite = Reichweiten.Zoll12,
                staerke = 3,
                durchschlag = 6,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1, WaffenRegeln.Explosiv },
            });

            return weap;
        }
        private waffe createSpaceMarinesBolter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Bolter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer },
            });

            return weap;
        }
        private waffe createSpaceMarinesBoltpistole()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Boltpistole;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Pistole },
            });

            return weap;
        }
        private waffe createSpaceMarinesCrozius()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Crozius;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe },
            });

            return weap;
        }
        private waffe createSpaceMarinesCyclone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.CycloneRaketenwerfer;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Sprenggranate,
                reichweite = Reichweiten.Zoll48,
                staerke = 8,
                durchschlag = 3,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer2 },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Fragmentgranate,
                reichweite = Reichweiten.Zoll48,
                staerke = 4,
                durchschlag = 6,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer2, WaffenRegeln.Explosiv },
            });

            return weap;
        }
        private waffe createSpaceMarinesDigital()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Digitalwaffe;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Meisterhaft },
            });

            return weap;
        }
        private waffe createSpaceMarinesEhrenklinge()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Ehrenklinge;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 6,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe },
            });

            return weap;
        }
        private waffe createSpaceMarinesEnergieklaue()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energieklaue;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.VerwundungswuerfeWiederholen },
            });

            return weap;
        }
        private waffe createSpaceMarinesEnergiefaust()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energiefaust;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.IniVerlust, WaffenRegeln.verdoppeltStaerke },
            });

            return weap;
        }
        private waffe createSpaceMarinesEnergiehammer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energiehammer;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.IniVerlust, WaffenRegeln.StunAngriff, WaffenRegeln.verdoppeltStaerke },
            });

            return weap;
        }
        private waffe createSpaceMarinesFlammenwerfer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Flammenwerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Flammen,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesKettenfaust()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Kettenfaust;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.ExtraPanzerungsDurchschlag2W6, WaffenRegeln.IniVerlust, WaffenRegeln.verdoppeltStaerke },
            });

            return weap;
        }
        private waffe createSpaceMarinesKettenschwert()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Kettenschwert;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() { },
            });

            return weap;
        }
        private waffe createSpaceMarinesKampfmesser()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Kampfmesser;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() { },
            });

            return weap;
        }
        private waffe createSpaceMarinesKombimelter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.KombiMelter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Bolter,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Melter,
                reichweite = Reichweiten.Zoll12,
                staerke = 8,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1, WaffenRegeln.Melter },
            });

            return weap;
        }
        private waffe createSpaceMarinesKombiFlammer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.KombiFlammenwerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Bolter,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Flammenwerfer,
                reichweite = Reichweiten.Flammen,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesKombiPlasma()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.KombiPlasmawerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Bolter,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Plasmawerfer,
                reichweite = Reichweiten.Zoll24,
                staerke = 7,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Ueberhitzen },
            });

            return weap;
        }
        private waffe createSpaceMarinesKonversion()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Konversionsstrahler;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Bis18Zoll,
                staerke = 6,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Explosiv },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Von18Bis42Zoll,
                staerke = 8,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Explosiv },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Von42Bis27Zoll,
                staerke = 10,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Explosiv },
            });

            return weap;
        }
        private waffe createSpaceMarinesLaserkanone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Laserkanone;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll48,
                staerke = 9,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesMelter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Melter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 8,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1, WaffenRegeln.Melter },
            });

            return weap;
        }
        private waffe createSpaceMarinesMultimelter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Multimelter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 8,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Melter },
            });

            return weap;
        }
        private waffe createSpaceMarinesPsiwaffe()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Psiwaffe;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Psiwaffe },
            });

            return weap;
        }
        private waffe createSpaceMarinesPlasmakanone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Plasmakanone;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll36,
                staerke = 7,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Explosiv, WaffenRegeln.Ueberhitzen },
            });

            return weap;
        }
        private waffe createSpaceMarinesPlasmapistole()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Plasmapistole;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 7,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Pistole, WaffenRegeln.Ueberhitzen },
            });

            return weap;
        }
        private waffe createSpaceMarinesPlasmawerfer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Plasmawerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 7,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Ueberhitzen },
            });

            return weap;
        }
        private waffe createSpaceMarinesRaketenwerfer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Raketenwerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Sprenggranate,
                reichweite = Reichweiten.Zoll48,
                staerke = 8,
                durchschlag = 3,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1 },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Fragmentgranate,
                reichweite = Reichweiten.Zoll48,
                staerke = 4,
                durchschlag = 6,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Explosiv },
            });

            return weap;
        }

        private waffe createSpaceMarinesSchwererBolter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.SchwererBolter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll36,
                staerke = 5,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer3 },
            });

            return weap;
        }
        private waffe createSpaceMarinesSchwererFlammer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.SchwererFlammer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Flammen,
                staerke = 5,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesSchrotflinte()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Schrotflinte;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 4,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesScharfschuetze()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Scharfschützengewehr;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll36,
                staerke = -1,
                durchschlag = 6,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Scharfschuetze },
            });


            return weap;
        }
        private waffe createSpaceMarinesSturmbolter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Sturmbolter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm2 },
            });

            return weap;
        }
        private waffe createSpaceMarinesSturmkanone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Sturmkanone;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 6,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer4, WaffenRegeln.Ruestungsbrechend },
            });

            return weap;
        }


        private waffe createSpaceMarinesSyncMelter()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncMelter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 8,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1, WaffenRegeln.Melter , WaffenRegeln.Synchronisiert},
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncMultiMelter()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncMultiMelter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 8,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Melter, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }


        private waffe createSpaceMarinesSyncSchwererBolter()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncSchwererBolter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll36,
                staerke = 5,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer3, WaffenRegeln.Synchronisiert },
            });


            return weap;
        }
        private waffe createSpaceMarinesSyncSchwererFlammer()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncSchwererFlammenwerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Flammen,
                staerke = 5,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncSturmkanone()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Syncsturmkanone;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 6,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer4, WaffenRegeln.Ruestungsbrechend, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncLaserKanone()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncLaserKanone;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll48,
                staerke = 9,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncPlasmawerfer()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncPlasmawerfer;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 7,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Ueberhitzen, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncPlasmapistole()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncPlasmapistole;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 7,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Pistole, WaffenRegeln.Ueberhitzen, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }


        private waffe createSpaceMarinesDeathwind()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.DeathwindSystem;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll12,
                staerke = 5,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1, WaffenRegeln.Explosiv5Zoll },
            });

            return weap;
        }
        private waffe createSpacemarinesHurricane()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.HurricaneBolter;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpacemarinesFlammensturm()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Flammensturmkanone;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Flammen,
                staerke = 6,
                durchschlag = 3,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesEnergieschwert()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Energieschwert;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe},
            });

            return weap;
        }
        private waffe createSpaceMarinesWhirlwindMehrfach()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.WhirlwindMehrfachRaketenWerfer;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Vergelterrakete,
                reichweite = Reichweiten.Von12Bis48Zoll,
                staerke = 5,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Geschuetz1, WaffenRegeln.Sperrfeuer },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Kastellan,
                reichweite = Reichweiten.Von12Bis48Zoll,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Geschuetz1, WaffenRegeln.Sperrfeuer , WaffenRegeln.DeckungIgnorieren},
            });

            return weap;
        }
        private waffe createSpaceMarinesDemolisher()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.DemolisherGeschuetz;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 10,
                durchschlag = 2,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Geschuetz1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesStalker()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.StalkerSchemaBolter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll36,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer2, WaffenRegeln.Ruestungsbrechend, WaffenRegeln.Niederhalten },
            });


            return weap;
        }
        private waffe createSpaceMarinesTalass()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.TalassarianischeSturmklinge;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 6,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Meisterhaft, WaffenRegeln.Energiewaffe, WaffenRegeln.SofotAusgeschaltet },
            });

            return weap;
        }
        private waffe createSpaceMarinesStabTigurius()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.StabDesTigurius;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() {  WaffenRegeln.Meisterhaft, WaffenRegeln.Psiwaffe },
            });

            return weap;
        }
        private waffe createSpaceMarinesInfernus()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Infernus;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Bolter,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Meisterhaft, WaffenRegeln.Hoellenfeuermunition },
            });
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.Flammenwerfer,
                reichweite = Reichweiten.Flammen,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1, WaffenRegeln.Meisterhaft, WaffenRegeln.Hoellenfeuermunition },
            });

            return weap;
        }
        private waffe createSpaceMarinesDornsPfeil()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.DornsPfeil;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm4 },
            });

            return weap;
        }
        private waffe createSpaceMarinesDornsFaust()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.DornsFaust;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 10,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.IniVerlust, WaffenRegeln.StunAngriff, WaffenRegeln.FahrzeugtabellePlus1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesRabenklauen()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Rabenklauen;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.Meisterhaft, WaffenRegeln.Ruestungsbrechend, WaffenRegeln.VerwundungswuerfeWiederholen},
            });

            return weap;
        }
        private waffe createSpaceMarinesMondfang()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Mondfang;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.SofotAusgeschaltet },
            });

            return weap;
        }
        private waffe createSpaceMarinesSpeerDesVulkan()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SpeerDesVulkan;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 0,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Meisterhaft, WaffenRegeln.SofotAusgeschaltet, WaffenRegeln.Energiewaffe },
            });

            return weap;
        }
        private waffe createSpaceMarinesSchmiedefeuerhandschuh()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Schmiedefeuerhandschuh;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Flammen,
                staerke = 5,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesCerberus()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.CerberusWerfer;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = -1,
                durchschlag = -1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Sturm1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncBolter()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncBolter;
            weap.haendigkeit = 2;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll24,
                staerke = 4,
                durchschlag = 5,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schnellfeuer, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpaceMarinesSyncMaschkan()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SyncMaschkanone;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll48,
                staerke = 7,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer2, WaffenRegeln.Synchronisiert },
            });

            return weap;
        }
        private waffe createSpaceMarinesMaschkan()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Maschinenkanone;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Zoll48,
                staerke = 7,
                durchschlag = 4,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Schwer2 },
            });

            return weap;
        }
        private waffe createSpaceMarinesCybotNah()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.CybotNahkampfWaffe;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 10,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Energiewaffe, WaffenRegeln.verdoppeltStaerke},
            });

            return weap;
        }
        private waffe createSpaceMarinesServoarm()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.Servoarm;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 8,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.IniVerlust, WaffenRegeln.IgnoriertRuestungswuerfe },
            });

            return weap;
        }
        private waffe createSpaceMarinesSeismischerHammer()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.SeismischerHammer;
            weap.haendigkeit = 1;
            weap.istSchusswaffe = false;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.Nahkampf,
                staerke = 10,
                durchschlag = 0,
                waffenRegeln = new List<WaffenRegeln>() {WaffenRegeln.Energiewaffe, WaffenRegeln.verdoppeltStaerke, WaffenRegeln.FahrzeugtabellePlus1 },
            });

            return weap;
        }
        private waffe createSpaceMarinesOrbital()
        {
            var weap = new waffe() { };
            weap.name = alleWaffenNamen.OrbitalesBombardement;
            weap.haendigkeit = 0;
            weap.istSchusswaffe = true;
            weap.auspraegungen.Add(new waffenAuspraegung()
            {
                beschreibung = WaffenSubTypen.blank,
                reichweite = Reichweiten.unbeschraenkt,
                staerke = 10,
                durchschlag = 1,
                waffenRegeln = new List<WaffenRegeln>() { WaffenRegeln.Geschuetz1, WaffenRegeln.Explosiv5Zoll},
            });

            return weap;
        }

    }



    /// <summary>
    /// Definition einer Waffe:
    /// </summary>
    public class waffe
    {
        /// <summary>
        /// Konstruktor einer Waffe:
        /// </summary>
        public waffe() 
        {
            name = alleWaffenNamen.undefined;
            haendigkeit = 1;
            istSchusswaffe = true;
            auspraegungen = new List<waffenAuspraegung>() { };
        }

        /// <summary>
        /// Name der Waffe
        /// </summary>
        public alleWaffenNamen name;

        /// <summary>
        /// Wie viele Hände brauche ich, um die Waffe zu führen?
        /// Kann 1 oder 2 sein!
        /// </summary>
        public int haendigkeit;

        /// <summary>
        /// Handelt es sich um eine Schusswaffe? (sonst: Nahkampfwaffe!)
        /// </summary>
        public bool istSchusswaffe;

        /// <summary>
        /// Eine Waffe kann ggfs. mehrere Ausprägungen haben,
        /// je nachdem, in welchem Modus sie benutzt wird.
        /// </summary>
        public List<waffenAuspraegung> auspraegungen;
    }

    public struct waffenAuspraegung
    {
        /// <summary>
        /// Beschreibung der jeweiligen Ausprägung. Z.B. "Spenggranaten"
        /// </summary>
        public WaffenSubTypen beschreibung;

        /// <summary>
        /// Reichweite der Waffe
        /// </summary>
        public Reichweiten reichweite;

        /// <summary>
        /// Stärke der Waffe. -1 für nicht vorhanden!
        /// </summary>
        public int staerke;

        /// <summary>
        /// Durschschlag der Waffe
        /// </summary>
        public int durchschlag;

        /// <summary>
        /// Von welchen Typ(en) ist die Waffenausprägung?
        /// </summary>
        public List<WaffenRegeln> waffenRegeln;
    }
}
