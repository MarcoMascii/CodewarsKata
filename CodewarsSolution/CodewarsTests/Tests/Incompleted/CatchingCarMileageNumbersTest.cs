using CodewarsProject.Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodewarsTests.Tests.Incompleted
{
    [TestClass]
    public class CatchingCarMileageNumbersTest
    {
        [TestMethod]
        public void ShouldWorkTest()
        {
            Assert.AreEqual(0, CatchingCarMileageNumbers.IsInteresting(3, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CatchingCarMileageNumbers.IsInteresting(1336, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CatchingCarMileageNumbers.IsInteresting(1337, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, CatchingCarMileageNumbers.IsInteresting(11208, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CatchingCarMileageNumbers.IsInteresting(11209, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CatchingCarMileageNumbers.IsInteresting(11211, new List<int>() { 1337, 256 }));
        }

        [TestMethod]
        public void AdvancedTests()
        {
            Assert.AreEqual(1, CatchingCarMileageNumbers.IsInteresting(799999, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, CatchingCarMileageNumbers.IsInteresting(7540, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CatchingCarMileageNumbers.IsInteresting(67888, new List<int>() { 1337, 256 }));
            
        }

    }
}
