using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Investec_Assessment.Extensions
{
    public static class StringOperations
    {

        public static string CheckDuplicates(this string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                string sanitizeToLowerCase = ReplaceWhitespace(input.ToLower(), string.Empty);
                IEnumerable<char> characters = sanitizeToLowerCase.ToCharArray();

                var duplicates = characters.GroupBy(c => c)
                    .Where(g => g.Count() > 1)
                    .Select(y => y.Key)
                    .ToArray();
                if (duplicates.Length > 0)
                    return $"Found the following duplicates: {string.Join(string.Empty, duplicates)}";
            }

            return @"No duplicate values were found";
        }

        public static string CountUniqueVowels(this string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                Dictionary<char, int> vowels = new Dictionary<char, int>()
                {
                    {'a', 0},
                    {'e', 0},
                    {'i', 0},
                    {'o', 0},
                    {'u', 0}
                };
                string sanitizeToLowerCase = ReplaceWhitespace(input.ToLower(), string.Empty);

                foreach (var character in sanitizeToLowerCase)
                {
                    if (vowels.ContainsKey(character) && vowels[character] <= 0)
                    {
                        vowels[character]++;
                    }
                }

                var uniqueVowelCount = vowels.Where(c => c.Value > 0).Count();
                if(uniqueVowelCount > 0)
                    return $"The number of vowels is {uniqueVowelCount}";
            }

            return @"No vowels were found";
        }

        public static string EvaluateVowelNonVowel(this string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                Dictionary<char, int> vowels = new Dictionary<char, int>()
                {
                    {'a', 0},
                    {'e', 0},
                    {'i', 0},
                    {'o', 0},
                    {'u', 0}
                };

                var sanitizeToLowerCase = ReplaceWhitespace(input.ToLower(), string.Empty);

                foreach (var character in sanitizeToLowerCase)
                {
                    if (vowels.ContainsKey(character))
                    {
                        vowels[character]++;
                    }
                }

                var vowelCount = vowels.Sum(e => e.Value);

                double vowelRatio = (double)vowelCount / sanitizeToLowerCase.Length;
                const double halfRatio = 0.5;

                if(vowelRatio > halfRatio)
                {
                    return @"The text has more vowels than non vowels";
                }
                else if(vowelRatio < halfRatio)
                {
                    return @"The text has more non vowels than vowels";
                }
            }

            return @"The text has an equal amount of vowels and non vowels";
        }


        private static readonly Regex Whitespace = new Regex(@"\s+");
        private static string ReplaceWhitespace(string input, string replacement)
        {
            return Whitespace.Replace(input, replacement);
        }
    }
}
