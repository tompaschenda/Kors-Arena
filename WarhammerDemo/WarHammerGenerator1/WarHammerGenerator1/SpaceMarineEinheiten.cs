using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using EinheitDefinition;
using Waffenfabrik;

namespace WarHammerGenerator1
{
    /// <summary>
    /// Taktischer Trupp der Space Marines!
    /// </summary>
    public class taktischerTrupp : Einheit
    {
        public override void createUnit()
        {
            einheitsname = SpaceMarineEinheiten.TaktischerTrupp;

            basisGroesse = new List<Groessenspecifier>() { };
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = SpaceMarinesInfanterie.SpaceMarine , anzahl = 4});
            basisGroesse.Add(new Groessenspecifier() { subEinheitenname = SpaceMarinesInfanterie.SergeantDerSpaceMarines, anzahl = 1 });

            basispunkteKosten = 90;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            basisAusruestung = new List<Object>() { };

            basisRüstung = new List<object>() { };
            basisRüstung.Add(SpaceMarinesRuestungen.ServoRuestung);

            var meineWaffenFabrik = new waffenfabrik() { };
            basisWaffen = new List<waffe>() { };
            basisWaffen.Add(meineWaffenFabrik.gibMirFolgendeWaffe(SpaceMarinesWaffen.Boltpistole));
            basisWaffen.Add(meineWaffenFabrik.gibMirFolgendeWaffe(SpaceMarinesWaffen.Fragmentgranaten));
            basisWaffen.Add(meineWaffenFabrik.gibMirFolgendeWaffe(SpaceMarinesWaffen.Sprenggranaten));
            basisWaffen.Add(meineWaffenFabrik.gibMirFolgendeWaffe(SpaceMarinesWaffen.Bolter));

            // REST: TODO SOME OTHER TIME!!! :)




            //base.createUnit();
        }
    }

    
}
