namespace LeetCodeEasy2287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Solution.RearrangeCharacters("ilovecodingonleetcode", "code");
            if (result1 != 2)
            {
                Console.WriteLine($"result1 is: {result1} instead of 2");
                return;
            }
            int result2 = Solution.RearrangeCharacters("ilovecodingonleetcode", "code");
            if (result2 != 1)
            {
                Console.WriteLine($"result2 is: {result2} instead of 1");
                return;
            }

            int result3 = Solution.RearrangeCharacters("ilovecodingonleetcode", "code");
            if (result3 != 1)
            {
                Console.WriteLine($"result3 is: {result3} instead of 1");
                return;
            }
            Console.WriteLine($"it works perfectly!");
        }
    }
}
