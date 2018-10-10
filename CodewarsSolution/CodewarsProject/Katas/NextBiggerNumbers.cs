using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    public class NextBiggerNumbers
    {
        public static long NextBiggerNumber(long n)
        {
            long numberLength = n.ToString().Length;
            if (n.ToString().Length == 1)
            {
                return -1;
            }
            long i = 0;
            long original = n;
            long[] digits = new long[numberLength];
            long counter = numberLength - 1;
            while (n > 0)
            {
                digits[counter] = (int)(n % 10);
                n = n / 10;
                counter--;
            }

            for (i = numberLength - 1; i > 0; i--)
            {
                if (digits[i] > digits[i - 1])
                {
                    break;
                }
            }
            if (i == 0)
            {
                return -1;
            }
            long smallest = i;
            long x = digits[i - 1];
            for (long j = i + 1; j < numberLength; j++)
            {
                if (digits[j] > x && digits[j] < digits[smallest])
                {
                    smallest = j;
                }
            }
            swap(ref digits[smallest], ref digits[i - 1]);
            Array.Reverse(digits);
            sortToIndex(ref digits, numberLength - i);
            long temp = 0;
            for (long k = numberLength - 1; k >= 0; k--)
            {
                temp *= 10;
                temp += digits[k];
            }
            return temp;
        }

        public static void swap(ref long a, ref long b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }

        public static void sortToIndex(ref long[] array, long index)
        {
            List<long> sorted = new List<long>();
            for (long i = 0; i < index; i++)
            {
                sorted.Add(array[i]);
            }
            sorted = sorted.OrderByDescending(x => x).ToList();

            for (long i = 0; i < index; i++)
            {
                array[i] = sorted[(int)i];
            }
        }
    }
}
