using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsTests.Tests.Completed
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
            Assert.IsTrue(CheckDictionary(correctFiles, actualFiles), "Different output");
        }

        [TestMethod]
        public void BiggerChainText()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "B", "C" };
            startFiles["B"] = new string[] { "C", "E" };
            startFiles["C"] = new string[] { "G" };
            startFiles["D"] = new string[] { "A", "F" };
            startFiles["E"] = new string[] { "F" };
            startFiles["F"] = new string[] { "H" };
            startFiles["G"] = new string[] { };
            startFiles["H"] = new string[] { };

            var correctFiles = new Dictionary<string, string[]>();
            correctFiles["A"] = new string[] { "B", "C", "E", "F", "G", "H" };
            correctFiles["B"] = new string[] { "C", "E", "F", "G", "H" };
            correctFiles["C"] = new string[] { "G" };
            correctFiles["D"] = new string[] { "A", "B", "C", "E", "F", "G", "H" };
            correctFiles["E"] = new string[] { "F", "H" };
            correctFiles["F"] = new string[] { "H" };
            correctFiles["G"] = new string[] { };
            correctFiles["H"] = new string[] { };

            // Act
            var actualFiles = ExpandingDependencyChains.ExpandDependencies(startFiles);

            // Assert
            Assert.IsTrue(CheckDictionary(correctFiles, actualFiles), "Different output");
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
            Assert.IsTrue(CheckDictionary(correctFiles, actualFiles), "errors in considering empty lists");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "A circular dependency should have thrown an InvalidOperationException.")]
        public void TestCircularDependencies()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "B" };
            startFiles["B"] = new string[] { "C" };
            startFiles["C"] = new string[] { "D" };
            startFiles["D"] = new string[] { "A" };
            ExpandingDependencyChains.ExpandDependencies(startFiles);            
        }

        private bool CheckDictionary(Dictionary<string, string[]> input1, Dictionary<string, string[]> input2)
        {
            foreach (var item in input1)
            {
                if (!input2.ContainsKey(item.Key))
                {
                    return false;
                }
                foreach (string element in item.Value)
                {
                    if (!input2[item.Key].Contains(element))
                    {
                        return false;
                    }
                }
            }

            foreach (var item in input2)
            {
                if (!input1.ContainsKey(item.Key))
                {
                    return false;
                }
                foreach (string element in item.Value)
                {
                    if (!input1[item.Key].Contains(element))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
