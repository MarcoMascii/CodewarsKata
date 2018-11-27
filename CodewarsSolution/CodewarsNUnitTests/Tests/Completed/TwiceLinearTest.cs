using CodewarsProject;
using NUnit.Framework;
using System;
namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class TwiceLinearTest
    {
        static void Testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test1()
        {
            Testing(TwiceLinear.DblLinear(10), 22);
            Testing(TwiceLinear.DblLinear(20), 57);
            Testing(TwiceLinear.DblLinear(30), 91);
            Testing(TwiceLinear.DblLinear(50), 175);
            Testing(TwiceLinear.DblLinear(2000), 19773);
        }

        [Test]
        public void Test2()
        {
            Testing(TwiceLinear.DblLinear(6000), 80914);
            Testing(TwiceLinear.DblLinear(25000), 495031);
        }
    }
}
