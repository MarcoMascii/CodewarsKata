using CodewarsProject;
using NUnit.Framework;
using System;
namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class SumByFactorsTest
    {
        static string Array2String(int[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }


        static void Testing(int[] l, string exp)
        {
            string ans = SumOfDivided.sumOfDivided(l);
            Assert.AreEqual(exp, ans);
        }


        [Test]
        public void Test1()
        {
            int[] lst = new int[] { 12, 15 };
            Testing(lst, "(2 12)(3 27)(5 15)");
            lst = new int[] { 15, 21, 24, 30, 45 };
            Testing(lst, "(2 54)(3 135)(5 90)(7 21)");
            lst = new int[] { 107, 158, 204, 100, 118, 123, 126, 110, 116, 100 };
            Testing(lst, "(2 1032)(3 453)(5 310)(7 126)(11 110)(17 204)(29 116)(41 123)(59 118)(79 158)(107 107)");
            lst = new int[] { -29804, -4209, -28265, -72769, -31744 };
            Testing(lst, "(2 -61548)(3 -4209)(5 -28265)(23 -4209)(31 -31744)(53 -72769)(61 -4209)(1373 -72769)(5653 -28265)(7451 -29804)");
            lst = new int[] { 17, -17, 51, -51 };
            Testing(lst, "(3 0)(17 0)");
            lst = new int[] { 173471 };
            Testing(lst, "(41 173471)(4231 173471)");
            lst = new int[] { 100000, 1000000 };
            Testing(lst, "(2 1100000)(5 1100000)");
        }

        public static string SumOfDividedPRIX(int[] lst)
        {
            int[] rem = new int[lst.Length];
            int max = 0;
            string result = "";
            for (int i = 0; i < lst.Length; ++i)
            {
                rem[i] = Math.Abs(lst[i]);
                max = Math.Max(max, Math.Abs(lst[i]));
            }
            for (int fac = 2; fac <= max; ++fac)
            {
                bool isFactor = false;
                int tot = 0;
                for (int i = 0; i < lst.Length; ++i)
                {
                    if (rem[i] % fac == 0)
                    {
                        isFactor = true;
                        tot += lst[i];
                        while (rem[i] % fac == 0)
                        {
                            rem[i] /= fac;
                        }
                    }
                }
                if (isFactor)
                {
                    result += "(" + fac + " " + tot + ")";
                }
            }
            return result;
        }
        //-----------------------
        static Random rnd = new Random();
        static int randint(Random rnd, int min, int max)
        {
            int randomNumber = rnd.Next(max - min) + min;
            return randomNumber;
        }
        public static int[] doEx(int k)
        {
            int i = 0;
            int[] res = new int[k];
            while (i < k)
            {
                int rn = randint(rnd, -100, 500);
                if (rn != 0) res[i] = rn;
                i++;
            }
            return res;
        }

        public void WTests1()
        {
            for (int i = 0; i < 25; i++)
            {
                int[] v = doEx(randint(rnd, 5, 25));
                String exp = SumOfDividedPRIX(v);
                Testing(v, exp);
            }
        }

        //[TestMethod]
        public void RandomTests()
        {
            WTests1();
        }
    }
}
