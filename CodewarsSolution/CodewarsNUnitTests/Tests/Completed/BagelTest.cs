using CodewarsProject;
using NUnit.Framework;
using System;
namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class BagelTest
    {
        [Test]
        public void TestBagel()
        {
            Bagel bagel = BagelSolver.Bagel;
            Assert.AreEqual(4, bagel.Value);
        }
    }
}
