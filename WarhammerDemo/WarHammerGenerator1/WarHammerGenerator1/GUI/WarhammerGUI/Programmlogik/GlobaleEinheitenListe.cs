using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;

namespace WarhammerGUI
{
    /// <summary>
    /// Hier werden alle Einheitenidentifier einmalig erzeugt und stehen dann zur Verfügung.
    /// Klasse wird als Singleton implementiert!
    /// </summary>
    public class GlobaleEinheitenListe
    {
        private static GlobaleEinheitenListe m_Instance;
        private static List<Einheit> m_globalUnitList;

        public static GlobaleEinheitenListe getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new GlobaleEinheitenListe();
            }
            return m_Instance;
        }

        /// <summary>
        /// Konstruktor: Muss privat bleiben, da wir
        /// ein Singleton haben wollen!
        /// Wir legen hier alle Einheiten für alle Fraktionen an!
        /// </summary>
        private GlobaleEinheitenListe() 
        {
            createAllUnits();
        }



        /// <summary>
        /// Legt einmalig bei der Instanziierung unserer globalen Einheitenliste 
        /// ALLE Einheiten im Basismodus fest!
        /// </summary>
        private void createAllUnits()
        {
            m_globalUnitList = new List<Einheit>(){};


            // Hier tragen wir nun nach einander alle Einheiten einer Fraktion ein!
            // MAT TODO: Wenn es mehrere Fraktionen gibt, muss ich die natürlich hier eintragen! ;-)
            var spaceMarineallUnits = new SpaceMarineEinheitenListe();
            m_globalUnitList.AddRange(spaceMarineallUnits.gibMirAlleSpaceMarineEinheiten());

            // Für jede der angelegten Einheiten führen wir nun einen Konsistenzcheck durch!
            einheitenKonsistenzcheck();
        }


        /// <summary>
        /// Nimmt aus dem globalen Baum mit allen Einheiten die gewünschte heraus und liefert sie
        /// frisch kopiert zurück!
        /// </summary>
        /// <param name="einheitsFraktion"></param>
        /// <param name="einheitenName"></param>
        /// <returns></returns>
        public Einheit kopiereMirFolgendeEinheit( Fraktionen einheitsFraktion, Object einheitenName)
        {
            Einheit blaupauseGewuenscht = null;
            Einheit gewuenschteEinheit = null;

            for (int aktUnitIndex = 0; aktUnitIndex < m_globalUnitList.Count; ++aktUnitIndex)
            {
                var aktUnit = m_globalUnitList[aktUnitIndex];

                // Sobald wir den ersten Treffer gefunden haben, sind wir schon fertig, denn er ist immer
                // eindeutig!
                if(aktUnit.einheitenName.ToString() == einheitenName.ToString() &&   aktUnit.fraktion.ToString() == einheitsFraktion.ToString() )
                {
                    blaupauseGewuenscht = aktUnit;
                    break;
                }
            }

            if(blaupauseGewuenscht != null)
                gewuenschteEinheit = new Einheit(blaupauseGewuenscht); // Copy-Konstruktor!

            if(gewuenschteEinheit == null)
                throw new ArgumentException("Die gewünschte Einheit existiert nicht!", "kopiereMirFolgendeEinheit");

            return gewuenschteEinheit;
        }



        /// <summary>
        /// Gibt alle Einheiten zurück, die einer bestimmen Fraktion und einer bestimmten Einheitenauswahl (Base)
        /// angehören!
        /// </summary>
        /// <param name="einheitsFraktion"></param>
        /// <param name="einheitenAuswahl"></param>
        /// <returns></returns>
        public List<Einheit> gibMirAlleEinheitenVonFraktionUndAuswahltyp(Fraktionen einheitsFraktion, EinheitenAuswahl einheitenAuswahl)
        {
            var listeMitAllenEinheiten = new List<Einheit>() { };

            int anzEinheiten = m_globalUnitList.Count;
            for (int aktUnitIndex = 0; aktUnitIndex < anzEinheiten; ++aktUnitIndex)
            {
                var aktUnitBlaupause = m_globalUnitList[aktUnitIndex];
                
                // Es kann sein, dass eine Einheit zu mehreren Auswahlen zählen darf. Das ist nicht schlimm, dann sortieren wir
                // sie eben auch mehrmals in den Auswahlbildschirm ein. Der Spieler muss sich dann bei der Auswahl erst entscheiden,
                // welche er wählen möchte!

                for (int aktAuswahlIndex = 0; aktAuswahlIndex < aktUnitBlaupause.auswahlTypBasis.Count; aktAuswahlIndex++)
                {
                    var aktAuswahlMoeglichkeit = aktUnitBlaupause.auswahlTypBasis[aktAuswahlIndex];
                    if (aktUnitBlaupause.fraktion == einheitsFraktion && aktAuswahlMoeglichkeit == einheitenAuswahl)
                    {
                        var aktUnitKopie = new Einheit(aktUnitBlaupause); // Copy-Konstruktor!
                        listeMitAllenEinheiten.Add(aktUnitKopie);
                    }
                }
            }
            return listeMitAllenEinheiten;
        }



        /// <summary>
        /// Liefert eine Referenz auf eine Einheit zurück, die einen vorgegebenen uniqueString besitzt!
        /// </summary>
        /// <param name="uniqueString"></param>
        /// <returns></returns>
        public Einheit gibMirEinheitMitFolgendemUniqueStringAlsOriginal(string uniqueString)
        {
            Einheit original = null;

            int anzEinheiten = m_globalUnitList.Count;
            for (int aktUnitIndex = 0; aktUnitIndex < anzEinheiten; ++aktUnitIndex)
            {
                var aktOriginal = m_globalUnitList[aktUnitIndex];
                if (aktOriginal.uniqueStringProperty == uniqueString)
                {
                    original = aktOriginal;
                }
            }
            return original;
        }



        /// <summary>
        /// Liefert eine Einheit zurück, die einen vorgegebenen uniqueString besitzt!
        /// </summary>
        /// <param name="uniqueString"></param>
        /// <returns></returns>
        public Einheit gibMirEinheitMitFolgendemUniqueStringAlsKopie(string uniqueString)
        {
            Einheit kopierteEinheit = null;

            int anzEinheiten = m_globalUnitList.Count;
            for (int aktUnitIndex = 0; aktUnitIndex < anzEinheiten; ++aktUnitIndex)
            {
                var aktUnitBlaupause = m_globalUnitList[aktUnitIndex];
                if( aktUnitBlaupause.uniqueStringProperty == uniqueString)
                {
                    kopierteEinheit = new Einheit(aktUnitBlaupause);
                }
            }
            return kopierteEinheit;
        }


        /// <summary>
        /// Gibt eine Liste mit allen Identifiern aller Einheiten aller Fraktionen
        /// zurück.
        /// </summary>
        /// <returns></returns>
        public List<Einheit> gibMirDieEinheitenliste()
        {
            // Mat TODO: Brauche ich das überhaupt noch?
            return m_globalUnitList;
        }


        /// <summary>
        /// Prüft, ob alle angelegten Einheiten auch vernünftig angelegt wurden!
        /// </summary>
        private void einheitenKonsistenzcheck()
        {
            int anzEinheiten = m_globalUnitList.Count;
            for (int aktEinheitIndex = 0; aktEinheitIndex < anzEinheiten; aktEinheitIndex++)
            {
                var aktEinheit = m_globalUnitList[aktEinheitIndex];

                // Jede Einheit muss einen Namen haben!
                if (aktEinheit.einheitenName.ToString() == "")
                    throw new ArgumentOutOfRangeException("Die aktuelle Einheit hat keinen Namensbezeichner!");

                // Jede Einheit muss über einen einzigartigen String verfügen (der natürlich auch einzigartig sein muss!)
                if(aktEinheit.uniqueStringProperty == "")
                    throw new ArgumentOutOfRangeException("Die Einheit mit den Namen " + aktEinheit.einheitenName.ToString() + " hat keine einzigartige String Property!");

                int occurenceCounter = 0;
                for (int aktIndex = 0; aktIndex < anzEinheiten; aktIndex++)
                {
                    if(m_globalUnitList[aktIndex].uniqueStringProperty == aktEinheit.uniqueStringProperty)
                        occurenceCounter++;
                }
                if (occurenceCounter > 1)
                    throw new ArgumentOutOfRangeException("Der Unique-String der Einheit " +aktEinheit.einheitenName.ToString() + " ist nicht einzigartig!");

                // Jede Einheit muss etwas Kosten - sowohl generell als auch mit Modifikationen!
                if(aktEinheit.basispunkteKosten == -1)
                    throw new ArgumentOutOfRangeException("Die Einheit " + aktEinheit.einheitenName.ToString() + " hat keine Basispunktekosten!");

                if(aktEinheit.einheitKostenGesamt == -1)
                    throw new ArgumentOutOfRangeException("Die Einheit " + aktEinheit.einheitenName.ToString() + " hat keine totalen Punktekosten!");
            }
        }
    }
}
