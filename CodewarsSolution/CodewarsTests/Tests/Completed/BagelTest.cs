﻿using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.Tests.Completed
{
    [TestClass]
    public class BagelTest
    {
        [TestMethod]
        public void TestBagel()
        {
            Bagel bagel = BagelSolver.Bagel;
            Assert.AreEqual(4, bagel.Value);
        }
    }
}
