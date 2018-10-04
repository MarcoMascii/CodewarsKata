using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests
{
    [TestClass]
    public class ExpandingDependencyChainsTest
    {
        [TestMethod]
        public void ExampleFromDescription()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "B", "D" };
            startFiles["B"] = new string[] { "C" };
            startFiles["C"] = new string[] { "D" };
            startFiles["D"] = new string[] { };

            var correctFiles = new Dictionary<string, string[]>();
            correctFiles["A"] = new string[] { "B", "C", "D" };
            correctFiles["B"] = new string[] { "C", "D" };
            correctFiles["C"] = new string[] { "D" };
            correctFiles["D"] = new string[] { };

            // Act
            var actualFiles = ExpandingDependencyChains.ExpandDependencies(startFiles);

            // Assert
            Assert.AreEqual(correctFiles, actualFiles, "Different output");
        }

        [TestMethod]
        public void TestEmptyFileList()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>();
            var correctFiles = new Dictionary<string, string[]>();

            // Act
            var actualFiles = ExpandingDependencyChains.ExpandDependencies(startFiles);

            // Assert
            Assert.AreEqual(correctFiles, actualFiles, "errors in considering empty lists");
        }

        [TestMethod]
        public void TestCircularDependencies()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "B" };
            startFiles["B"] = new string[] { "C" };
            startFiles["C"] = new string[] { "D" };
            startFiles["D"] = new string[] { "A" };

            // Act/Assert
            Assert.AreEqual(typeof(InvalidOperationException), ExpandingDependencyChains.ExpandDependencies(startFiles), "A circular dependency should have thrown an InvalidOperationException.");
        }
    }
}
