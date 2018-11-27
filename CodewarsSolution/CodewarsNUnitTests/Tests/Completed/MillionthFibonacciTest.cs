using CodewarsProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace CodewarsNUnitTests.Tests.Completed
{
    [TestFixture]
    public class MillionthFibonacciTest
    {
        [Test]
        public void TestFib()
        {
            List<int> tests = new List<int> { 0, 1, 2, 3, 4, 5, -6, -96, 1000, 1001 };

            Random rnd = new Random();
            for (int i = 0; i < 10; ++i)
            {
                tests.Add(rnd.Next(-100, 0));
            }
            tests.Add(rnd.Next(10000, 100000));
            tests.Add(rnd.Next(1000000, 1500000));

            foreach (int n in tests)
            {
                BigInteger found = Fibonacci.fib(n);
                Assert.AreEqual(FibonacciRef.fib(n), found);
            }
        }

        static class FibonacciRef
        {
            static IDictionary<int, BigInteger> fibs = new Dictionary<int, BigInteger>();

            static FibonacciRef()
            {
                fibs[0] = BigInteger.Zero;
                fibs[1] = BigInteger.One;
                fibs[2] = BigInteger.One;
                fibs[3] = fibs[2] + fibs[1];
                fibs[4] = fibs[3] + fibs[2];
                fibs[5] = fibs[4] + fibs[3];
            }

            private static BigInteger calcFib(int n)
            {
                if (fibs.TryGetValue(n, out BigInteger result))
                    return result;

                if ((n & 1) == 1)
                {

                    int k = (n + 1) / 2;
                    BigInteger fk = BigInteger.Pow(calcFib(k), 2);
                    BigInteger fkm1 = BigInteger.Pow(calcFib(k - 1), 2);
                    result = fk + fkm1;
                }
                else
                {
                    int k = n / 2;
                    BigInteger fk = calcFib(k);
                    BigInteger fkm1 = calcFib(k - 1);
                    result = (fkm1 * fibs[3] + fk) * fk;
                }

                fibs[n] = result;
                return result;
            }

            public static BigInteger fib(int n)
            {
                bool neg = n < 0;

                if (neg)
                    n = -n;

                BigInteger result = calcFib(n);

                if (neg && (n & 1) == 0)
                    result = -result;

                return result;
            }
        }
    }
}