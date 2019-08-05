using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests.Tests.Incompleted
{
    [TestClass]
    public class SortBinaryTreeByLevelsTest
    {
        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual(new List<int>(), SortBinaryTreeByLevels.TreeByLevels(null));
        }

        [TestMethod]
        public void BasicTest()
        {
            Assert.AreEqual(new List<int>() { 1, 2, 3, 4, 5, 6 }, SortBinaryTreeByLevels.TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1)));
        }
    }
}
