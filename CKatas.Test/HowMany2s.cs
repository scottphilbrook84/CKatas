using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKatas.Test
{
    [TestClass]
    public class HowMany2s
    {
        [TestMethod]
        public void FixedTest()
        {
            Assert.AreEqual(3, Kata.TwoCount(24));
            Assert.AreEqual(7, Kata.TwoCount(17280));
            Assert.AreEqual(1, Kata.TwoCount(222222222));
            Assert.AreEqual(8, Kata.TwoCount(256));
            Assert.AreEqual(0, Kata.TwoCount(1));
            Assert.AreEqual(1, Kata.TwoCount(2));
            Assert.AreEqual(0, Kata.TwoCount(7));
        }
    }
}
