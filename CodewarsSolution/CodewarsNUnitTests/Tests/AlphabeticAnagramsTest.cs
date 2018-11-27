using CodewarsProject;
using NUnit.Framework;

namespace CodewarsNUnitTests.Tests
{
    [TestFixture]
    public class AlphabeticAnagramsTest
    {
        [Test]
        public void Test1()
        {
            TestNumberToOrdinal("A", 1);
        }
        [Test]
        public void Test2()
        {
            TestNumberToOrdinal("ABAB", 2);
        }
        [Test]
        public void Test3()
        {
            TestNumberToOrdinal("AAAB", 1);
        }
        [Test]
        public void Test4()
        {
            TestNumberToOrdinal("BAAA", 4);
        }
        [Test]
        public void Test5()
        {
            TestNumberToOrdinal("QUESTION", 24572);
        }
        [Test]
        public void Test6()
        {
            TestNumberToOrdinal("BOOKKEEPER", 10743);
        }

        public void TestNumberToOrdinal(string value, long expected)
        {
            Assert.AreEqual(expected, AlphabeticAnagrams.ListPosition(value), string.Format("Input {0}", value));
        }
    }
}
