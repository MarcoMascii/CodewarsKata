using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    public class AlphabeticAnagrams
    {
        public static long ListPosition(string value)
        {

            List<char> sortedLetters = value.ToCharArray().ToList();
            sortedLetters.Sort();
            Dictionary<char, int> frequencies = new Dictionary<char, int>();
            long index = 1;
            int remainingLetters = value.Length - 1;
            int splitStringIndex = 0;
            foreach (char letter in sortedLetters.Distinct())
            {
                frequencies.Add(letter, sortedLetters.Count(x => x == letter));
            }

            while (sortedLetters.Count > 0)
            {
                for (var i = 0; i < sortedLetters.Count; i++)
                {
                    if (sortedLetters[i] != value[splitStringIndex])
                    {
                        if (sortedLetters[i] != sortedLetters[i + 1])
                        {
                            var permutations = Factorial(remainingLetters);
                            index += permutations / GetSubPermutations(frequencies, sortedLetters[i]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        splitStringIndex++;
                        frequencies[sortedLetters[i]]--;
                        sortedLetters.RemoveRange(i, 1);
                        remainingLetters--;
                        break;
                    }
                }
            }

            return index;
        }

        private static long GetSubPermutations(Dictionary<char, int> frequencies, char currentLetter)
        {
            frequencies[currentLetter]--;
            long denominator = 1;
            foreach (var key in frequencies)
            {
                var subPermutations = Factorial(frequencies[key.Key]);
                 denominator *= subPermutations != 0 ? subPermutations : 1;
            }
            frequencies[currentLetter]++;
            return denominator;
        }

        private static long Factorial(int n)
        {
            int temp = n;
            long output = n;
            while (temp-- > 1)
            {
                output *= temp;
            }
            return output;
        }
    }
}
