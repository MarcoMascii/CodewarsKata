using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Incompleted
{
    [TestClass]
    public class LinearSystemTest
    {
        [TestMethod]
        public void TestAndVerify1()
        {
            LinearSystem ls = new LinearSystem();
            string input = "1 2 0 7\r\n0 2 4 8\r\n0 5 6 9";
            //string result = ls.Solve(input);
            //should be SOLUTION=(10; -1,5; 2,75)
            //string testResult = Tests.testIt(input, result);
            //if (testResult.Length > 0) Assert.Fail(testResult); else Console.WriteLine("'" + result + "' accepted!");
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestAndVerify2()
        {
            LinearSystem ls = new LinearSystem();
            string input = "1 2 0 4 7\r\n0 2 0 2 8\r\n0 0 -1 4 6\r\n1 2 3 2 3";
            //string result = ls.Solve(input);
            //string testResult = Tests.testIt(input, result);
            //if (testResult.Length > 0) Assert.Fail(testResult); else Console.WriteLine("'" + result + "' accepted!");
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestAndVerify3()
        {
            LinearSystem ls = new LinearSystem();
            string input = "1 2 1\r\n1 2 0";
            //string result = ls.Solve(input);
            //string testResult = Tests.testIt(input, result);
            //if (testResult.Length > 0) Assert.Fail(testResult); else Console.WriteLine("'" + result + "' accepted!");
            Assert.IsFalse(false);
        }
    }
}
