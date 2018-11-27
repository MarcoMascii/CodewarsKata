using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Completed
{
    [TestClass]
    public class TwiceLinearTest
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test1()
        {
            testing(TwiceLinear.DblLinear(10), 22);
            testing(TwiceLinear.DblLinear(20), 57);
            testing(TwiceLinear.DblLinear(30), 91);
            testing(TwiceLinear.DblLinear(50), 175);
            testing(TwiceLinear.DblLinear(2000), 19773);
        }

        [TestMethod]
        public void test2()
        {
            testing(TwiceLinear.DblLinear(6000), 80914);
            testing(TwiceLinear.DblLinear(25000), 495031);
        }
    }
}
