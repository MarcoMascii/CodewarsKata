using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodewarsTests.Tests.Completed
{
    [TestClass]
    public class NextBiggerNumberTest
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("****** Small Number");
            //Assert.AreEqual(21, NextBiggerNumbers.NextBiggerNumber(12));
            Assert.AreEqual(531, NextBiggerNumbers.NextBiggerNumber(513));
            Assert.AreEqual(2071, NextBiggerNumbers.NextBiggerNumber(2017));
            Assert.AreEqual(441, NextBiggerNumbers.NextBiggerNumber(414));
            Assert.AreEqual(414, NextBiggerNumbers.NextBiggerNumber(144));
        }
        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("****** Bigger Numbers");
            Assert.AreEqual(123456798, NextBiggerNumbers.NextBiggerNumber(123456789));
            Assert.AreEqual(1234567908, NextBiggerNumbers.NextBiggerNumber(1234567890));
            Assert.AreEqual(-1, NextBiggerNumbers.NextBiggerNumber(9876543210));
            Assert.AreEqual(-1, NextBiggerNumbers.NextBiggerNumber(9999999999));
            Assert.AreEqual(59884848483559, NextBiggerNumbers.NextBiggerNumber(59884848459853));
        }
    }
}
