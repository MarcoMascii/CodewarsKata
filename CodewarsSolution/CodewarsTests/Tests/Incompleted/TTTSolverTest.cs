using CodewarsProject.Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Incompleted
{
    [TestClass]
    public class TTTSolverTest
    {
        [TestMethod]
        public void TestOneField()
        {
            var board = new int[][]
            {
        new int[] { 0, 2, 1 },
        new int[] { 2, 2, 1 },
        new int[] { 2, 1, 0 }
            };  
            Assert.AreEqual(new int[] { 0, 0 }, TTTSolver.TurnMethod(board, 1));
        }
    }
}
