using CodewarsProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class ExpandingDependencyChainsTest
    {
        [Test]
        public void ExampleFromDescription()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>
            {
                ["A"] = new string[] { "B", "D" },
                ["B"] = new string[] { "C" },
                ["C"] = new string[] { "D" },
                ["D"] = new string[] { }
            };

            var correctFiles = new Dictionary<string, string[]>
            {
                ["A"] = new string[] { "B", "C", "D" },
                ["B"] = new string[] { "C", "D" },
                ["C"] = new string[] { "D" },
                ["D"] = new string[] { }
            };

            // Act
            var actualFiles = ExpandingDependencyChains.ExpandDependencies(startFiles);

            // Assert
            Assert.IsTrue(CheckDictionary(correctFiles, actualFiles), "Different output");
        }

        [Test]
        public void BiggerChainText()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>
            {
                ["A"] = new string[] { "B", "C" },
                ["B"] = new string[] { "C", "E" },
                ["C"] = new string[] { "G" },
                ["D"] = new string[] { "A", "F" },
                ["E"] = new string[] { "F" },
                ["F"] = new string[] { "H" },
                ["G"] = new string[] { },
                ["H"] = new string[] { }
            };

            var correctFiles = new Dictionary<string, string[]>
            {
                ["A"] = new string[] { "B", "C", "E", "F", "G", "H" },
                ["B"] = new string[] { "C", "E", "F", "G", "H" },
                ["C"] = new string[] { "G" },
                ["D"] = new string[] { "A", "B", "C", "E", "F", "G", "H" },
                ["E"] = new string[] { "F", "H" },
                ["F"] = new string[] { "H" },
                ["G"] = new string[] { },
                ["H"] = new string[] { }
            };

            // Act
            var actualFiles = ExpandingDependencyChains.ExpandDependencies(startFiles);

            // Assert
            Assert.IsTrue(CheckDictionary(correctFiles, actualFiles), "Different output");
        }

        [Test]
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

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCircularDependencies()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>
            {
                ["A"] = new string[] { "B" },
                ["B"] = new string[] { "C" },
                ["C"] = new string[] { "D" },
                ["D"] = new string[] { "A" }
            };
            ExpandingDependencyChains.ExpandDependencies(startFiles);
        }

        bool CheckDictionary(Dictionary<string, string[]> input1, Dictionary<string, string[]> input2)
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
