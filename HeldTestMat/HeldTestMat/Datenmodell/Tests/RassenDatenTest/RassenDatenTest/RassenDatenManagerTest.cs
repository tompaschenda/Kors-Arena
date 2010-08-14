using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Datenmodell;
using System.IO;

namespace DatenmodellTest
{
    [TestFixture]
    class RassenDatenManagerTest
    {
        [Test]
        public void Constructor()
        {
            var m = new RassenDatenManager();
        }
        
        [Test]
        public void SpeichernUndLaden()
        {
            var m = new RassenDatenManager();
            m.Rassen = TestDaten.GetTestRassen();
            m.SpeichereRassenDaten(@"TestRassen.xml");
            var m2 = new RassenDatenManager();
            m2.LadeRassenDaten(@"TestRassen.xml");
            Assert.AreEqual(m.Rassen, m2.Rassen);
        }
        
        [Test]
        public void LadeStammddaten()
        {
            var m = new RassenDatenManager();
            m.LadeRassenDaten(GetRassenStammdatenDatei());
            System.Console.WriteLine(m.ToString());
            var r = m.GetRassenDaten("Mittelländer");
            Assert.AreEqual(r.Name, "Mittelländer");
        }
        
        /*
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetRassenDaten()
        {
            var m = new RassenDatenManager();
            var r = m.GetRassenDaten("Mich gibt es nicht.");
        }
         * */
        private string GetRassenStammdatenDatei()
        {
            var curDir = new DirectoryInfo(Directory.GetCurrentDirectory());
            
            var stammDatenDir = curDir.Parent.Parent.Parent.Parent.Parent.Parent;

            return Path.Combine(stammDatenDir.FullName, "Stammdaten", "Rassen.xml");
        }
    }
}
