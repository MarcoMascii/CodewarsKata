using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Incompleted
{
    [TestClass]
    public class SudokuSolverTest
    {
        [TestMethod]
        public void ConfigurationTest()
        {
            Assert.AreEqual(SudokuSolver.squares.Length, 81, "errors in squares");
            //Assert.AreEqual(SudokuSolver.unitList.Length, 27, "errors in unitList");
            foreach (string s in SudokuSolver.squares)
            {
                Assert.AreEqual(SudokuSolver._peers[s], 20, "error in peers");
            }

            string[] toBeChecked = { "A2", "B2","D2","E2","F2","G2","H2","I2","C1","C3","C4","C5","C6","C7","C8","C9","A1","A3","B1","B3" };

            Assert.AreEqual(SudokuSolver._peers["C2"], toBeChecked, "errors in peers composition");

        }
    }
}
