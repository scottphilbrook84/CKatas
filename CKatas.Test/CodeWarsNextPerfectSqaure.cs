using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKatas.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FixedTest()
        {
            Assert.AreEqual(-1,  Kata.FindNextSquare(155));
            Assert.AreEqual(144, Kata.FindNextSquare(121));
            Assert.AreEqual(676, Kata.FindNextSquare(625));
            Assert.AreEqual(320356, Kata.FindNextSquare(319225));
            Assert.AreEqual(15241630849, Kata.FindNextSquare(15241383936));
        }
    }
}
