namespace LeetCodeSolving.Easy
{
    public static class TwoSumSolve
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j] == target) && i != j) return new int[] { i, j };
                }
            }

            return Array.Empty<int>();
        }
    }
}
