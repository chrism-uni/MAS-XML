using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAS_XML;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        mas mas;

        [TestInitialize]
        public void Initialize()
        {
            mas = Serializer.Deserialize("testdata.xml");
        }

        [TestMethod]
        public void shouldLoadSentences()
        {
            Assert.AreEqual(mas.s.Length, 2);
        }

        [TestMethod]
        public void sentencesHaveIds()
        {
            Assert.AreEqual(mas.s[0].id, "s1");
            Assert.AreEqual(mas.s[1].id, "s2");
        }

        [TestMethod]
        public void sentencesShouldHaveUnits()
        {
            Assert.AreEqual(mas.s[0].unit.Length, 2);
            Assert.AreEqual(mas.s[1].unit.Length, 1);
        }

        [TestMethod]
        public void unitsHaveIds()
        {
            Assert.AreEqual(mas.s[0].unit[0].id, "unit1");
            Assert.AreEqual(mas.s[0].unit[1].id, "unit3");
            Assert.AreEqual(mas.s[1].unit[0].id, "unit4");
        }

        [TestMethod]
        public void unitsCanHave()
        {
            Assert.IsTrue(mas.s[0].unit[0].Items[0] is NE);
            Assert.IsTrue(mas.s[1].unit[0].Items[0] is W);
            Assert.IsTrue(mas.s[0].unit[0].Items[1] is VE);
            Assert.IsTrue(mas.s[0].unit[0].Items[2] is Sbar);
        }

        [TestMethod]
        public void NEsHaveWords()
        {
            NE ne1 = mas.s[0].unit[0].Items[0] as NE;
            Assert.AreEqual(ne1.W.Length, 3);
            for(int i = 0; i < ne1.W.Length; i++)
            {
                Assert.AreEqual(ne1.W[i].Value, "ne1.Word" + i);
                Assert.AreEqual(ne1.W[i].Lpos, "ne1.POS" + i);
            }
            
        }

        [TestMethod]
        public void VEsHaveWords()
        {
            VE ve1 = mas.s[0].unit[0].Items[1] as VE;
            Assert.AreEqual(ve1.W.Length, 3);
            for (int i = 0; i < ve1.W.Length; i++)
            {
                Assert.AreEqual(ve1.W[i].Value, "ve1.Word" + i);
                Assert.AreEqual(ve1.W[i].Lpos, "ve1.POS" + i);
            }
        }
    }
}
