using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Completed
{
    [TestClass]
    public class HumanReadableDurationFormatTest
    {
        [TestMethod]
        public void test1()
        {
            Assert.AreEqual("now", HumanTimeFormat.formatDuration(0));
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreEqual("1 second", HumanTimeFormat.formatDuration(1));
        }

        [TestMethod]
        public void test3()
        {
            Assert.AreEqual("1 minute and 2 seconds", HumanTimeFormat.formatDuration(62));
        }

        [TestMethod]
        public void test4()
        {
            Assert.AreEqual("2 minutes", HumanTimeFormat.formatDuration(120));
        }

        [TestMethod]
        public void test5()
        {
            Assert.AreEqual("1 hour, 1 minute and 2 seconds", HumanTimeFormat.formatDuration(3662));
        }


        [TestMethod]
        public void test6()
        {
            Assert.AreEqual("182 days, 1 hour, 44 minutes and 40 seconds", HumanTimeFormat.formatDuration(15731080));
        }


        [TestMethod]
        public void test7()
        {
            Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes", HumanTimeFormat.formatDuration(132030240));
        }


        [TestMethod]
        public void test8()
        {
            Assert.AreEqual("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", HumanTimeFormat.formatDuration(205851834));
        }


        [TestMethod]
        public void test9()
        {
            Assert.AreEqual("8 years, 12 days, 13 hours, 41 minutes and 1 second", HumanTimeFormat.formatDuration(253374061));
        }


        [TestMethod]
        public void test10()
        {
            Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", HumanTimeFormat.formatDuration(242062374));
        }

        [TestMethod]
        public void test11()
        {
            Assert.AreEqual("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", HumanTimeFormat.formatDuration(101956166));
        }

        [TestMethod]
        public void test12()
        {
            Assert.AreEqual("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", HumanTimeFormat.formatDuration(33243586));
        }
    }
}
