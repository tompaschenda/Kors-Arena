using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NUnit.Framework;
using Datenmodell;
using System.IO;

namespace DatenmodellTest
{
    [TestFixture]
    class RassenDatenTest
    {
        [Test]
        public void Konstruktor()
        {
            var r = new RassenDaten();
        }

        [Test]
        public void SpeichernUndLaden()
        {
            //Create
            var r = new RassenDaten();
            r.Name = "TestRasse";
            //Save
            XmlSerializer serializer = new XmlSerializer(typeof(RassenDaten));
            TextWriter textWriter = new StreamWriter(@"TestRasse.xml");
            serializer.Serialize(textWriter, r);
            textWriter.Close();
            //Load
            XmlSerializer deserializer = new XmlSerializer(typeof(RassenDaten));
            TextReader textReader = new StreamReader(@"TestRasse.xml");
            RassenDaten rGeladen;
            rGeladen = (RassenDaten)deserializer.Deserialize(textReader);
            textReader.Close();
            //verify
            Assert.AreEqual(rGeladen.Name, r.Name);
        }

        [Test]
        public void Equality()
        {
            //Die Semantik von Object.Equals hängt davon ab, ob es sich um ein class oder ein struct handelt.
            //siehe http://en.csharp-online.net/CSharp_Canonical_Forms%E2%80%94What_Does_Equality_Mean
            var r = new RassenDaten();
            r.Name = "TestRasse";

            var rAlias = r;

            var r2 = new RassenDaten();
            r2.Name = "TestRasse";

            Assert.AreNotSame(r, rAlias); //RassenDaten ist ein struct. Daher ist rAlias eine Kopier von r
            Assert.AreEqual(r, r2); //Die Werte sollten gleich sein.
            Assert.AreNotSame(r, r2);
        }
    }
}
