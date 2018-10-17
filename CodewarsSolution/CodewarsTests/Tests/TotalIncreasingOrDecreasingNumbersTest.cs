using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace CodewarsTests
{
    [TestClass]
    public class TotalIncreasingOrDecreasingNumbersTest
    {
        private static void Tester(int inp, BigInteger exp)
        {
            Assert.AreEqual(exp, TotalIncreasingOrDecreasingNumbers.TotalIncDec(inp), "Should return the total below 10<sup>" + inp + "</sup>");
        }
        [TestMethod]
        public void BasicTests()
        {
            Tester(0, BigInteger.Parse("1"));
            Tester(1, BigInteger.Parse("10"));
            Tester(2, BigInteger.Parse("100"));
            Tester(3, BigInteger.Parse("475"));
            Tester(4, BigInteger.Parse("1675"));
            Tester(5, BigInteger.Parse("4954"));
            Tester(6, BigInteger.Parse("12952"));
        }
    }
}
