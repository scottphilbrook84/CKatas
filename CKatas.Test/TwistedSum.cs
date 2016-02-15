using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKatas.Test
{
    [TestClass]
    public class TwistedSumTest
    {
        [TestMethod]
        public void When03_Then6()
        {
            Assert.AreEqual(6, TwistedSum.Solution(3));
        }
        [TestMethod]
        public void When10_Then46()
        {
            Assert.AreEqual(46, TwistedSum.Solution(10));
        }
        [TestMethod]
        public void When11_Then48()
        {
            Assert.AreEqual(48, TwistedSum.Solution(11));
        }
        [TestMethod]
        public void When12_Then51()
        {
            Assert.AreEqual(51, TwistedSum.Solution(12));
        }
        [TestMethod]
        public void When123_Then1038()
        {
            Assert.AreEqual(1038, TwistedSum.Solution(123));
        }

    }
}
