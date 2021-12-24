using LeetCodeSolving.Easy;

namespace LeetCodeSolving
{
    public static class Program
    {
        public static void Main()
        {
            // 1. Two sum
            Console.WriteLine(
                "1. Two sum: " + String.Join(
                    ", ",
                    TwoSumSolve.TwoSum(
                        nums: new int[] { 2, 7, 11, 15 },
                        target: 9
                    )
                )
            );

            // 9. Palindrome Number
            Console.WriteLine(
                "9. Palindrome Number: " + PalindromeNumberSolve.PalindromeNumber(2221)
            );
        }
    }
}