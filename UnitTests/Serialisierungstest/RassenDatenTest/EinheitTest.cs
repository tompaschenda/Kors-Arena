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
    public class EinheitTest
    {

        [Test]
        public void SpeichernUndLaden()
        {
            var filename = "TestEinheit.xml";
            //Create
            var einheit = new taktischerTrupp();
            einheit.createUnitBase();
            einheit.declareChoices();
            einheit.updateChoiceDependencies();
            einheit.createSubunitsAndEvalChoices();
            
            //Save
            SerializationHelper.SaveToXmlAndIncludeTypes(einheit, filename);
            //Load
            var einheitGeladen = SerializationHelper.LoadFromXmlAndIncludeTypes<taktischerTrupp>(filename);
            //verify
            Assert.IsTrue(einheit.EqualValues(einheitGeladen));
        }

        [Test]
        public void Equality()
        {
            var a = new taktischerTrupp();
            a.createUnitBase();
            a.declareChoices();
            a.updateChoiceDependencies();
            a.createSubunitsAndEvalChoices();
            var b = new taktischerTrupp();
            b.createUnitBase();
            b.declareChoices();
            b.updateChoiceDependencies();
            b.createSubunitsAndEvalChoices();
            Assert.IsTrue(a.EqualValues(b));
        }

    }
}
