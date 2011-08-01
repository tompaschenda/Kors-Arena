// -----------------------------------------------------------------------
// <copyright file="spielerArmeeTest.cs" company="Capgemini">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ArmyBenchTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using WarhammerGUI;
    using WarhammerGUI.Utility;
    using Listen;
    using WarhammerGUI.Programmlogik;

    [TestFixture]
    public class spielerArmeeTest
    {
        
        [Test]
        public void SpeichernUndLaden()
        {
            var filename = "TestArmee.xml";
            //Create
            var armee = new spielerArmeeKlasse();
            armee.armeeFraktion = Fraktionen.BloodAngels;
            armee.armeeName = "TestName";
            armee.gesamtPunkte = 1000;
            //Save
            SerializationHelper.SaveToXmlAndIncludeTypes(armee, filename);
            //Load
            var armeeGeladen = SerializationHelper.LoadFromXmlAndIncludeTypes<spielerArmeeKlasse>(filename);
            //verify
            Assert.IsTrue(armee.EqualValues(armeeGeladen));
        }

        [Test]
        public void Equality()
        {
            var a = new spielerArmeeKlasse();
            var a2 = new spielerArmeeKlasse();
            Assert.IsTrue(a.EqualValues(a2));
        }

    }
}
