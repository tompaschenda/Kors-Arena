using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;

namespace WarhammerGUI
{
    public class ruestungsfabrik
    {
        private static ruestungsfabrik m_Instance;

        public static ruestungsfabrik getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new ruestungsfabrik();
            }
            return m_Instance;
        }

        /// <summary>
        /// Die interne Liste aller Rüstungen!
        /// </summary>
        private List<Ruestung> alleExistierendenRuestungen;

        /// <summary>
        /// Konstruktor: Muss privat bleiben, da wir
        /// ein Singleton haben wollen!
        /// </summary>
        private ruestungsfabrik() 
        {
            // Wir wollen immer alle Rüstungen sofort anlegen!
            // Dadurch sind auch sofort alle Rüstungen für
            // ALLE Rassen angelegt worden!
            createAllArmors();
        }

        public Ruestung gibMirFolgendeRuestung(Object rsName)
        {
            var gewuenschteRuestung = alleExistierendenRuestungen.Find
            (
                delegate(Ruestung rs)
                {
                    return rs.name.ToString() == rsName.ToString();
                }
            );

            if (gewuenschteRuestung == null)
                throw new ArgumentOutOfRangeException("Konnte die angegebene Rüstung nicht finden!");

            return gewuenschteRuestung;
        }

        /// <summary>
        /// Legt alle Rüstungen an, die es gibt!
        /// </summary>
        private void createAllArmors()
        {
            alleExistierendenRuestungen = new List<Ruestung>(){};
            alleExistierendenRuestungen.Add(createServoruestung());
            alleExistierendenRuestungen.Add(createScoutruestung());
            alleExistierendenRuestungen.Add(createMeisterhafteRuestung());
            alleExistierendenRuestungen.Add(createTerminatorruestung());
            alleExistierendenRuestungen.Add(createAntilochus());
        }

        private Ruestung createServoruestung()
        {
            var ruest = new Ruestung(){};
            ruest.name = alleRuestungen.ServoRuestung;
            ruest.ruestungswert = 3;
            ruest.rettungswurf = -1;
            return ruest;
        }

        private Ruestung createScoutruestung()
        {
            var ruest = new Ruestung() { };
            ruest.name = alleRuestungen.Scoutruestung;
            ruest.ruestungswert = 4;
            ruest.rettungswurf = -1;
            return ruest;
        }

        private Ruestung createMeisterhafteRuestung()
        {
            var ruest = new Ruestung() { };
            ruest.name = alleRuestungen.MeisterhafteRuestung;
            ruest.ruestungswert = 2;
            ruest.rettungswurf = -1;
            return ruest;
        }

        private Ruestung createTerminatorruestung()
        {
            var ruest = new Ruestung() { };
            ruest.name = alleRuestungen.TerminatorRuestung;
            ruest.ruestungswert = 2;
            ruest.rettungswurf = 5;
            return ruest;
        }

        private Ruestung createAntilochus()
        {
            var ruest = new Ruestung() { };
            ruest.name = alleRuestungen.RuestungDesAntilochus;
            ruest.ruestungswert = 2;
            ruest.rettungswurf = 5;
            ruest.ausruestung.Add(alleAusruestung.TeleportPeilsender);
            return ruest;
        }

    }

    /// <summary>
    /// Hier wird alles nachgehalten, was mit einer Rüstung zu tun hat!
    /// </summary>
    public class Ruestung
    {
        public Ruestung()
        { 
            ausruestung = new List<alleAusruestung>(){};
        }

        public alleRuestungen name;
        public int ruestungswert;
        public int rettungswurf;

        /// <summary>
        /// Es kann sein, dass eine Rüstung auch Ausrüstung enthält. Wenn ja, steht sie hier:
        /// </summary>
        public List<alleAusruestung> ausruestung;

        public Ruestung Clone()
        {
            var copy = (Ruestung)this.MemberwiseClone();
            copy.ausruestung = new List<alleAusruestung>() { };
            for (int i = 0; i < this.ausruestung.Count; ++i)
            {
                copy.ausruestung.Add((alleAusruestung)this.ausruestung[i]);
            }
            return copy;
        }
    }
    

}
