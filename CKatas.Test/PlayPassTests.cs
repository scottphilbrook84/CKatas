using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKatas.Test
{
    [TestClass]
    public class PlayPassTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("!!!vPz fWpM J", PlayPass.playPass("I LOVE YOU!!!", 1));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO",
                PlayPass.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2));
        }

    }
}
