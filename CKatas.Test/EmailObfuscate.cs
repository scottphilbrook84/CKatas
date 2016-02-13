using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKatas.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class EmailObfuscate
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("test [at] 123 [dot] com",
            EmailObfuscator.Obfuscate("test@123.com"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Code_warrior [at] foo [dot] ac [dot] uk",
            EmailObfuscator.Obfuscate("Code_warrior@foo.ac.uk"));
        }
    }
}
