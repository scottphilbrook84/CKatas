using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(155, Result = -1)]
    [TestCase(121, Result = 144)]
    [TestCase(625, Result = 676)]
    [TestCase(319225, Result = 320356)]
    [TestCase(15241383936, Result = 15241630849)]
    public static long FixedTest(long num)
    {
        return Kata.FindNextSquare(num);
    }
}