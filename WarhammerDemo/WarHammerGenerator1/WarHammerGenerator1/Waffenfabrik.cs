using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;

namespace WaffenfabrikNamespace
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
            waffenListe.Add(createSpaceMarinesEnergiewaffe());
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
            waffenListe.Add(createSpaceMarinesMeisterhaft());
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

            this.spaceMarineWaffen = waffenListe;

            return waffenListe;
        }

        private waffe createSpaceMarinesAstartes()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.AstartesGranatwerfer;

            return weap;
        }
        private waffe createSpaceMarinesAuxilaris()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.AuxilarisGranatwerfer;

            return weap;
        }
        private waffe createSpaceMarinesBolter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Bolter;

            return weap;
        }
        private waffe createSpaceMarinesBoltpistole()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Boltpistole;

            return weap;
        }
        private waffe createSpaceMarinesCrozius()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Crozius;

            return weap;
        }
        private waffe createSpaceMarinesCyclone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.CycloneRaketenwerfer;

            return weap;
        }
        private waffe createSpaceMarinesDigital()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Digitalwaffe;

            return weap;
        }
        private waffe createSpaceMarinesEhrenklinge()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Ehrenklinge;

            return weap;
        }
        private waffe createSpaceMarinesEnergieklaue()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energieklaue;

            return weap;
        }
        private waffe createSpaceMarinesEnergiefaust()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energiefaust;

            return weap;
        }
        private waffe createSpaceMarinesEnergiewaffe()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energiewaffe;

            return weap;
        }
        private waffe createSpaceMarinesEnergiehammer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Energiehammer;

            return weap;
        }
        private waffe createSpaceMarinesFlammenwerfer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Flammenwerfer;

            return weap;
        }
        private waffe createSpaceMarinesKettenfaust()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Kettenfaust;

            return weap;
        }
        private waffe createSpaceMarinesKettenschwert()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Kettenschwert;

            return weap;
        }
        private waffe createSpaceMarinesKampfmesser()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Kampfmesser;

            return weap;
        }
        private waffe createSpaceMarinesKombimelter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.KombiMelter;

            return weap;
        }
        private waffe createSpaceMarinesKombiFlammer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.KombiFlammenwerfer;

            return weap;
        }
        private waffe createSpaceMarinesKombiPlasma()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.KombiPlasmawerfer;

            return weap;
        }
        private waffe createSpaceMarinesKonversion()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Konversionsstrahler;

            return weap;
        }
        private waffe createSpaceMarinesLaserkanone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Laserkanone;

            return weap;
        }
        private waffe createSpaceMarinesMeisterhaft()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.MeisterhafteWaffe;

            return weap;
        }
        private waffe createSpaceMarinesMelter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Melter;

            return weap;
        }
        private waffe createSpaceMarinesMultimelter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Multimelter;

            return weap;
        }
        private waffe createSpaceMarinesPsiwaffe()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Psiwaffe;

            return weap;
        }
        private waffe createSpaceMarinesPlasmakanone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Plasmakanone;

            return weap;
        }
        private waffe createSpaceMarinesPlasmapistole()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Plasmapistole;

            return weap;
        }
        private waffe createSpaceMarinesPlasmawerfer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Plasmawerfer;

            return weap;
        }
        private waffe createSpaceMarinesRaketenwerfer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Raketenwerfer;

            return weap;
        }
        private waffe createSpaceMarinesSchwererBolter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.SchwererBolter;

            return weap;
        }
        private waffe createSpaceMarinesSchwererFlammer()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.SchwererFlammer;

            return weap;
        }
        private waffe createSpaceMarinesSchrotflinte()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Schrotflinte;

            return weap;
        }
        private waffe createSpaceMarinesScharfschuetze()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Scharfschützengewehr;

            return weap;
        }
        private waffe createSpaceMarinesSturmbolter()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Sturmbolter;

            return weap;
        }
        private waffe createSpaceMarinesSturmkanone()
        {
            var weap = new waffe(){};
            weap.name = alleWaffenNamen.Sturmkanone;

            return weap;
        }
    }



    /// <summary>
    /// Definition einer Waffe:
    /// </summary>
    public class waffe
    {
        /// <summary>
        /// Name der Waffe
        /// </summary>
        public Object name;

        /// <summary>
        /// Wie viele Hände brauche ich, um die Waffe zu führen?
        /// Kann 1 oder 2 sein!
        /// </summary>
        public int haendigkeit;

        /// <summary>
        /// Handelt es sich um eine Schusswaffe?
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
        public List<Waffentypen> waffentypen;
    }
}
