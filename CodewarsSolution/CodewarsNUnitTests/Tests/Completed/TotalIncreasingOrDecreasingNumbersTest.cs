using CodewarsProject;
using NUnit.Framework;
using System.Numerics;

namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class TotalIncreasingOrDecreasingNumbersTest
    {
        static void Tester(int inp, BigInteger exp)
        {
            Assert.AreEqual(exp, TotalIncreasingOrDecreasingNumbers.TotalIncDec(inp), "Should return the total below 10<sup>" + inp + "</sup>");
        }
        [Test]
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
