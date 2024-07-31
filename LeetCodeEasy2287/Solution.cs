using System.Text.RegularExpressions;

namespace LeetCodeEasy2287
{
    public static class Solution
    {
        public static int RearrangeCharacters(string s, string target)
        {
            if(target.All(c => c == target[0]))
            {
                int result = 0;
                int count = 0;

                foreach (char c in s)
                    if (c == target[0])
                    {
                        count++;
                        if (target.Length == count)
                        {
                            result++;
                            count = 0;
                        }
                    }

                return result; 
            }


            char[] targetChars = target.ToCharArray();
            List<char[]> allFound =
            [
                new char[targetChars.Length]
            ]; 

            foreach (char c in s)
            {
                if(targetChars.Contains(c))
                {
                    List<int> found = targetChars.Select((b, i) => b.Equals(c) ? i : -1).Where(i => i != -1).ToList();

                    bool isAdded = false; 
                    foreach (var item in allFound)
                    {
                        for (int i = 0; i < found.Count; i++)
                        {
                            if (item[found[i]] == '\0')
                            {
                                item[found[i]] = c;
                                isAdded = true; 
                                break;
                            }
                        }
                        if (isAdded)
                            break; 
                    }
                    if(!isAdded)
                    {
                        char[] temp = new char[targetChars.Length];
                        temp[found[0]] = c;
                        allFound.Add(temp);
                    }
                }
            }

            return allFound.Where(c => !c.Contains('\0')).Count();
        }
    }
}
