using System.Text.RegularExpressions;

namespace LeetCodeEasy2287
{
    public static class Solution
    {
        public static int RearrangeCharacters(string s, string target)
        {
            if (target.All(c => c == target[0]))
                return s.Count(c => c == target[0]) / target.Length;

            Dictionary<char, int> targetCount = new Dictionary<char, int>();
            foreach (char c in target)
            {
                if (targetCount.ContainsKey(c))
                    targetCount[c]++;
                else
                    targetCount[c] = 1;
            }

            Dictionary<char, int> sCount = new();
            foreach (char c in s)
            {
                if (targetCount.ContainsKey(c))
                {
                    if (sCount.ContainsKey(c))
                        sCount[c]++;
                    else
                        sCount[c] = 1;
                }
            }

            int result = int.MaxValue;
            foreach (var kvp in targetCount)
            {
                char c = kvp.Key;
                int requiredCount = kvp.Value;

                if (sCount.ContainsKey(c))
                    result = Math.Min(result, sCount[c] / requiredCount);
                else
                    return 0; 
            }

            return result;
        }

    }
}
