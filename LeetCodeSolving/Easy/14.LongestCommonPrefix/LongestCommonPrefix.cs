namespace LeetCodeSolving.Easy
{
    public static class LongestCommonPrefixSolve
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var result = "";

            var minWordLength = strs.First().Length;

            for (var i = 1; i < strs.Length; i++)
                if (minWordLength > strs[i].Length) minWordLength = strs[i].Length;

            for (var i = 0; i < minWordLength; i++)
            {
                var currentLetter = strs.First()[i];

                foreach (var word in strs)
                    if (word[i] != currentLetter) return result;

                result += currentLetter;
            }

            return result;
        }
    }
}
