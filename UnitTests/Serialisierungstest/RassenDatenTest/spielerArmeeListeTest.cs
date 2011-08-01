using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NUnit.Framework;
using Datenmodell;
using System.IO;
using WarhammerGUI;

namespace Serialisierungstest
{
    [TestFixture]
    class spielerArmeeListeTest
    {
        //[Test]
        public void SpeichernUndLaden()
        {
            var filename = "TestArmee.xml";
            //Create
            var armee = spielerArmeeListe.getInstance();
            
            //Save
            XmlSerializer serializer = new XmlSerializer(typeof(spielerArmeeListe));
            TextWriter textWriter = new StreamWriter(filename);
            serializer.Serialize(textWriter, armee);
            textWriter.Close();
            //Load
            XmlSerializer deserializer = new XmlSerializer(typeof(spielerArmeeListe));
            TextReader textReader = new StreamReader(filename);
            spielerArmeeListe armeeGeladen;
            armeeGeladen = (spielerArmeeListe)deserializer.Deserialize(textReader);
            textReader.Close();
            //verify
            //Assert.AreEqual(armee, armeeGeladen);
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
