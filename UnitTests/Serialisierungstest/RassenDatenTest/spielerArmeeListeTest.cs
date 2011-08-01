using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NUnit.Framework;
using System.IO;
using WarhammerGUI;
using WarhammerGUI.Utility;
using WarhammerGUI.Programmlogik;

namespace ArmyBenchTest
{
    [TestFixture]
    class spielerArmeeListeTest
    {
        [Test]
        public void SpeichernUndLaden()
        {
            var filename = "TestArmeeListe.xml";
            //Create
            var armee = spielerArmeeListe.getInstance();
            //Save
            SerializationHelper.SaveToXmlAndIncludeTypes(armee, filename);
            //Load
            var armeeGeladen = SerializationHelper.LoadFromXmlAndIncludeTypes<spielerArmeeListe>(filename);
            //verify
            Assert.IsTrue(armee.EqualValues(armeeGeladen));
        }

        [Test]
        public void Equality()
        {
            //Die Semantik von Object.Equals hängt davon ab, ob es sich um ein class oder ein struct handelt.
            //siehe http://en.csharp-online.net/CSharp_Canonical_Forms%E2%80%94What_Does_Equality_Mean
            var a = new spielerArmeeListe();

            var aAlias = a;

            var a2 = new spielerArmeeListe();

            Assert.IsTrue(a.EqualValues(a2));
            Assert.AreSame(a, aAlias);
            Assert.AreNotEqual(a, a2);
            Assert.AreNotSame(a, a2);
        }
        
    }
}
