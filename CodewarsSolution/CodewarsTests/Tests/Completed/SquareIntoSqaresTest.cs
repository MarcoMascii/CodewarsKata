using CodewarsProject.Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Completed
{
    [TestClass]
    public class SquareIntoSqaresTest
    {
        [TestMethod]
        public void Test1()
        {
            Decompose d = new Decompose();
            long n = 11;
            Assert.AreEqual("1 2 4 10", d.decompose(n));
            Assert.AreEqual("1 3 5 8 49", d.decompose(50));
        }
    }
}
