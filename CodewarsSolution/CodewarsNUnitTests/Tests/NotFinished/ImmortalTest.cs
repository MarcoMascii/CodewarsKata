using CodewarsProject;
using NUnit.Framework;
namespace CodewarsNUnitTests.Tests.NotFinished
{
    [TestFixture]
    public class ImmortalTest
    {
        [Test]
        public void TestCase()
        {
            Assert.AreEqual(5, Immortal.ElderAge(8, 5, 1, 100));
            Assert.AreEqual(224, Immortal.ElderAge(8, 8, 0, 100007));
            Assert.AreEqual(11925, Immortal.ElderAge(25, 31, 0, 100007));
            Assert.AreEqual(4323, Immortal.ElderAge(5, 45, 3, 1000007));
            Assert.AreEqual(1586, Immortal.ElderAge(31, 39, 7, 2345));
            Assert.AreEqual(808451, Immortal.ElderAge(545, 435, 342, 1000007));
            // You need to run this test very quickly before attempting the actual tests :)
            //Assert.AreEqual(5456283, Immortal.ElderAge(28827050410L, 35165045587L, 7109602, 13719506));
        }
    }
}
