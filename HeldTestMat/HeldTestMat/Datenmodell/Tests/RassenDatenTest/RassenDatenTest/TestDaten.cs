using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datenmodell;
using Common;
namespace DatenmodellTest
{
    class TestDaten
    {
        static public RassenDatenMap GetTestRassen()
        {
            return new RassenDatenMap
            {
                {"TästRasse", new RassenDaten{Name="TästRasse"}}
            };
        }

        static public RassenDaten GetTestRasse()
        {
            var r = new RassenDaten();
            r.Name = "TästRasse";
            r.Generierungskosten = 6;
            r.Haarfarben = new RangeMap<string>
            {
             {new Range(1, 3), "schwarz"},
             {new Range(4, 7), "braun"}
            };
            return r;
        }
    }
}
