using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject.Katas
{
    public static class CatchingCarMileageNumbers
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number < 100)
                return 0;

            string currentNumber = number.ToString();

            if (IsIntresting(currentNumber, awesomePhrases))
                return 2;

            string closeIntrsting = (number + 1).ToString();

            if (IsIntresting(closeIntrsting, awesomePhrases))
                return 1;

            closeIntrsting = (number + 2).ToString();
            if (IsIntresting(closeIntrsting, awesomePhrases))
                return 1;

            return 0;

        }


        static bool IsIntresting(string number, List<int> awesome)
        {
            return AscendingOrder(number) || DescendingOrder(number) || HasLeadingZeros(number) || IsPalindrome(number) || IsAwesome(number, awesome);
        }

        static bool AscendingOrder(string number)
        {   
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] >= number[i + 1])
                    return false;
            }
            return true;
        }

        static bool DescendingOrder(string number)
        {
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] > number[i + 1])
                    return false;
            }
            return true;
        }

        static bool HasLeadingZeros(string number)
        {
            for (int i = 1; i < number.Length -1 ; i++)
            {
                if (number[i] != '0')
                    return false;
            }
            return true;
        }

        static bool IsPalindrome(string number)
        {
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] != number[number.Length -1 - i])
                    return false;
            }
            return true;
        }

        static bool IsAwesome(string number, List<int> awesome)
        {
            int num = int.Parse(number);
            return awesome.Contains(num);
        }
    }
}
