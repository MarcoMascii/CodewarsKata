using CodewarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodewarsTests.Tests
{
    [TestClass]
    public class IntegerPartitionsTest
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests Small Numbers");
            Assert.AreEqual("Range: 1 Average: 1.50 Median: 1.50", IntegerPartitions.Part(2));
            Assert.AreEqual("Range: 2 Average: 2.00 Median: 2.00", IntegerPartitions.Part(3));
            Assert.AreEqual("Range: 3 Average: 2.50 Median: 2.50", IntegerPartitions.Part(4));
            Assert.AreEqual("Range: 5 Average: 3.50 Median: 3.50", IntegerPartitions.Part(5));
        }

        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("****** Basic Tests Bigger Numbers");
            Assert.AreEqual("Range: 53 Average: 19.69 Median: 16.00", IntegerPartitions.Part(11));
            Assert.AreEqual("Range: 80 Average: 27.08 Median: 22.50", IntegerPartitions.Part(12));
            Assert.AreEqual("Range: 107 Average: 35.07 Median: 27.00", IntegerPartitions.Part(13));
            Assert.AreEqual("Range: 161 Average: 47.33 Median: 35.00", IntegerPartitions.Part(14));
            Assert.AreEqual("Range: 242 Average: 63.91 Median: 45.00", IntegerPartitions.Part(15));
            Assert.AreEqual("Range: 323 Average: 84.44 Median: 56.00", IntegerPartitions.Part(16));
            Assert.AreEqual("Range: 485 Average: 112.66 Median: 73.50", IntegerPartitions.Part(17));
            Assert.AreEqual("Range: 728 Average: 151.44 Median: 96.00", IntegerPartitions.Part(18));
            Assert.AreEqual("Range: 971 Average: 199.34 Median: 118.50", IntegerPartitions.Part(19));
            Assert.AreEqual("Range: 1457 Average: 268.11 Median: 152.00", IntegerPartitions.Part(20));
        }

        [TestMethod]
        public void Test3()
        {
            Console.WriteLine("****** Basic Tests Still Bigger Numbers");
            Assert.AreEqual("Range: 13121 Average: 1500.90 Median: 625.00", IntegerPartitions.Part(26));
            Assert.AreEqual("Range: 19682 Average: 2009.29 Median: 775.00", IntegerPartitions.Part(27));
            Assert.AreEqual("Range: 26243 Average: 2669.98 Median: 980.00", IntegerPartitions.Part(28));
            Assert.AreEqual("Range: 39365 Average: 3558.37 Median: 1224.50", IntegerPartitions.Part(29));
            Assert.AreEqual("Range: 59048 Average: 4764.89 Median: 1538.00", IntegerPartitions.Part(30));
            Assert.AreEqual("Range: 78731 Average: 6326.47 Median: 1920.00", IntegerPartitions.Part(31));
            //Assert.AreEqual("Range: 86093441 Average: 1552316.81 Median: 120960.00", IntPart.Part(50));
        }

        [TestMethod]
        public static void RandomTests1()
        {
            Console.WriteLine("****** Series 1");
            //Assert.AreEqual("Range: 2186 Average: 358.10 Median: 197.00", IntPart.Part(21));
            Assert.AreEqual("Range: 4373 Average: 633.44 Median: 315.00", IntegerPartitions.Part(23));
            Assert.AreEqual("Range: 177146 Average: 11292.63 Median: 3024.00", IntegerPartitions.Part(33));
            Assert.AreEqual("Range: 354293 Average: 20088.78 Median: 4704.00", IntegerPartitions.Part(35));
            Assert.AreEqual("Range: 708587 Average: 35745.98 Median: 7371.00", IntegerPartitions.Part(37));
            Assert.AreEqual("Range: 1594322 Average: 63823.27 Median: 11475.00", IntegerPartitions.Part(39));
            Assert.AreEqual("Range: 6377291 Average: 202904.65 Median: 27262.50", IntegerPartitions.Part(43));
            Assert.AreEqual("Range: 19131875 Average: 484712.39 Median: 51975.00", IntegerPartitions.Part(46));
            //Assert.AreEqual("Range: 28697813 Average: 648367.27 Median: 64260.00", IntPart.Part(47));
            Assert.AreEqual("Range: 43046720 Average: 867970.08 Median: 79830.00", IntegerPartitions.Part(48));
        }

        [TestMethod]
        public static void RandomTests2()
        {
            Console.WriteLine("****** Series 2");
            //Assert.AreEqual("Range: 2186 Average: 358.10 Median: 197.00", IntPart.Part(21));
            Assert.AreEqual("Range: 6560 Average: 846.79 Median: 390.00", IntegerPartitions.Part(24));
            Assert.AreEqual("Range: 8747 Average: 1126.14 Median: 500.00", IntegerPartitions.Part(25));
            Assert.AreEqual("Range: 236195 Average: 15031.03 Median: 3761.50", IntegerPartitions.Part(34));
            Assert.AreEqual("Range: 1062881 Average: 47763.72 Median: 9152.00", IntegerPartitions.Part(38));
            Assert.AreEqual("Range: 3188645 Average: 113720.82 Median: 17745.00", IntegerPartitions.Part(41));
            Assert.AreEqual("Range: 4782968 Average: 152184.15 Median: 21888.00", IntegerPartitions.Part(42));
            Assert.AreEqual("Range: 19131875 Average: 484712.39 Median: 51975.00", IntegerPartitions.Part(46));
            //Assert.AreEqual("Range: 28697813 Average: 648367.27 Median: 64260.00", IntPart.Part(47));
            Assert.AreEqual("Range: 57395627 Average: 1159398.98 Median: 98227.50", IntegerPartitions.Part(49));
        }

        [TestMethod]
        public static void RandomTests3()
        {
            Console.WriteLine("****** Series 3");
            //Assert.AreEqual("Range: 2915 Average: 475.46 Median: 245.00", IntPart.Part(22));
            Assert.AreEqual("Range: 6560 Average: 846.79 Median: 390.00", IntegerPartitions.Part(24));
            Assert.AreEqual("Range: 118097 Average: 8457.17 Median: 2420.00", IntegerPartitions.Part(32));
            Assert.AreEqual("Range: 236195 Average: 15031.03 Median: 3761.50", IntegerPartitions.Part(34));
            Assert.AreEqual("Range: 531440 Average: 26832.81 Median: 5865.00", IntegerPartitions.Part(36));
            Assert.AreEqual("Range: 2125763 Average: 85158.49 Median: 14250.00", IntegerPartitions.Part(40));
            Assert.AreEqual("Range: 4782968 Average: 152184.15 Median: 21888.00", IntegerPartitions.Part(42));
            Assert.AreEqual("Range: 9565937 Average: 271332.21 Median: 33796.00", IntegerPartitions.Part(44));
            //Assert.AreEqual("Range: 14348906 Average: 363114.82 Median: 41947.50", IntPart.Part(45));
            Assert.AreEqual("Range: 57395627 Average: 1159398.98 Median: 98227.50", IntegerPartitions.Part(49));
        }
    }
}
