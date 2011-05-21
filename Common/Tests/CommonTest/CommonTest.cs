using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Common;

namespace CommonTest
{
    [TestFixture]
    public class GlobalTest
    {
        [Test]
        public void RangeLadenUndSpeichern()
        {
            var r=new Range(1, 3);
            var filename = "TestRange.xml";
            ObjectExtentions.SaveToXml(r, filename);
            var rGeladen = ObjectExtentions.LoadFromXml<Range>(filename);
            Assert.AreEqual(r, rGeladen);
        }

        [Test]
        public void RangeMapLadenUndSpeichern()
        {
            var r = new RangeMap<string>();
            r.Add(new Range(1, 3), "schwarz");
            r.Add(new Range(4, 7), "braun");
            var filename="TestRangeMap.xml";
            ObjectExtentions.SaveToXml(r, filename);
            var rGeladen = ObjectExtentions.LoadFromXml <RangeMap<string>>(filename);
        }

    }
}
