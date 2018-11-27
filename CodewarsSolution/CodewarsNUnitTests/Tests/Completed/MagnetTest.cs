using CodewarsProject;
using NUnit.Framework;
using System;
namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class MagnetTest
    {
        static void AssertFuzzyEquals(double act, double exp)
        {
            bool inrange = Math.Abs(act - exp) <= 1e-6;
            if (inrange == false)
            {
                string specifier = "#0.000000";
                Console.WriteLine(
                    "At 1e-6: Expected must be " + exp.ToString(specifier) + ", but got " + act.ToString(specifier));
            }
            Assert.AreEqual(true, inrange);
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Fixed Tests: Doubles");
            AssertFuzzyEquals(Magnets.Doubles(1, 10), 0.5580321939764581); // 0.5580321939764581
            AssertFuzzyEquals(Magnets.Doubles(10, 1000), 0.6921486500921933); // 0.6921486500921933
            AssertFuzzyEquals(Magnets.Doubles(10, 10000), 0.6930471674194457); // 0.6930471674194457
            AssertFuzzyEquals(Magnets.Doubles(20, 10000), 0.6930471955575918); // 0.6930471955575918
        }

    }
}
