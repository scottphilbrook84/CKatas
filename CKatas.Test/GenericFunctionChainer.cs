using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKatas.Test
{
    [TestClass]
    public class GenericFunctionChainer
    {
        public static double add(double x) { return x + 10; }
        public static double mul(double x) { return x * 30; }

        [TestMethod]
        public void ExampleTest()
        {
            Assert.AreEqual(Kata.Chain(2, new[] { (Func<double, double>)add, mul }), 360, "Incorrect Value for '2'");
        }
    }
}
