using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NUnit.Framework;
using System.IO;
using WarhammerGUI;
using WarhammerGUI.Utility;

namespace UtilityTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;




    [TestFixture]
    public class ValueCompareTest
    {
        private class A : ValueCompare
        {
            public int x = 1;
            private int y = 2;
        }

        private class ANoCompare
        {
            private int j = 0;
        }

        private class B : ValueCompare
        {
            public A a  = new A();
            private ANoCompare aNoCompare = new ANoCompare();
        }

        private class ListOfA : ValueCompare
        {
            public ListOfA()
            {
                l2.Add(new A());
            }

            public List<A> l = new List<A>();
            private List<A> l2 = new List<A>();
            private int i = 1;
        }

        [Test]
        public void ValueTypeCompare()
        {
            var a = new A();
            var a2 = new A();
            Assert.IsTrue(a.EqualValues(a2));
            a2.x = 0;
            Assert.IsFalse(a.EqualValues(a2));
        }

        [Test]
        public void UsualClassCompare()
        {
            var b = new B();
            var b2 = new B();

            Assert.IsTrue(b.EqualValues(b));
            Assert.IsFalse(b.EqualValues(b2));
        }

        [Test]
        public void ListCompare()
        {
            var l1 = new List<A>();
            l1.Add(new A());
            var l2 = new List<A>();
            l2.Add(new A());
            Assert.IsTrue(ValueCompare.EqualValuesList(l1, l2));
            l2.Add(new A());
            Assert.IsFalse(ValueCompare.EqualValuesList(l1, l2));
        }

        [Test]
        public void ListClassCompare()
        {
            var l1 = new ListOfA();
            var l2 = new ListOfA();
            Assert.IsTrue(ValueCompare.EqualValuesList(l1.l, l2.l));

            Assert.IsTrue(l1.EqualValues(l2));
            l2.l.Add(new A());
            Assert.IsFalse(l1.EqualValues(l2));
        }

    }
}
