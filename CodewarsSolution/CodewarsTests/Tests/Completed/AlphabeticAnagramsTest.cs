using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodewarsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests.Tests.Completed
{
    [TestClass]
    public class AlphabeticAnagramsTest
    {
        [TestMethod]
        public void test1()
        {
            TestNumberToOrdinal("A", 1);
        }
        [TestMethod]
        public void test2()
        {
            TestNumberToOrdinal("ABAB", 2);
        }
        [TestMethod]
        public void test3()
        {
            TestNumberToOrdinal("AAAB", 1);
        }
        [TestMethod]
        public void test4()
        {
            TestNumberToOrdinal("BAAA", 4);
        }
        [TestMethod]
        public void test5()
        {
            TestNumberToOrdinal("QUESTION", 24572);
        }
        [TestMethod]
        public void test6()
        {
            TestNumberToOrdinal("BOOKKEEPER", 10743);
        }

        public void TestNumberToOrdinal(string value, long expected)
        {
            Assert.AreEqual(expected, AlphabeticAnagrams.ListPosition(value), string.Format("Input {0}", value));
        }
    }
}
