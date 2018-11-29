using CodewarsProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsNUnitTests.Tests.NotFinished
{
    [TestFixture()]
    public class SudokuSolverTest
    {
        [Test()]
        public void ConfigurationTest()
        {
            Assert.AreEqual(81, SudokuSolver.squares.Length, "errors in squares");
            Assert.AreEqual(27, SudokuSolver._unitList.Count(), "errors in unitList");
            foreach (string s in SudokuSolver.squares)
            {
                Assert.AreEqual(20, SudokuSolver._peers[s].Count(), "error in peers");
            }
            foreach (string s in SudokuSolver.squares)
            {
                Assert.AreEqual(3, SudokuSolver._units[s].Count(), "error in units");
            }
            SudokuSolver.CreateUnitList();
            string[] p = { "A2", "B2", "D2", "E2", "F2", "G2", "H2", "I2", "C1", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "A1", "A3", "B1", "B3" };
            HashSet<string> toBeChecked = new HashSet<string>(p);

            //SudokuSolver._peers["C2"].ToList().ForEach(Console.WriteLine);

            Assert.AreEqual(toBeChecked, SudokuSolver._peers["C2"], "errors in peers composition");

            string grid1 = "003020600900305001001806400008102900700000008006708200002609500800203009005010300";
            string hard1 = ".....6....59.....82....8....45........3........6..3.54...325..6..................";

            Assert.AreNotEqual(null, SudokuSolver.Solve(grid1), "testone");

            Assert.AreNotEqual(null, SudokuSolver.Solve(hard1), "testone1");
        }
    }
}
