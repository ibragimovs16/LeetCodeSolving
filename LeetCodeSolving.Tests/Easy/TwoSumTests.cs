using Xunit;

namespace LeetCodeSolving.Easy.Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void TwoSumExamplesTest()
        {
            Assert.Equal(
                new int[] { 0, 1 },
                TwoSumSolve.TwoSum(new int[] { 2, 7, 11, 15 }, 9)
            );

            Assert.Equal(
                new int[] { 1, 2 },
                TwoSumSolve.TwoSum(new int[] { 3, 2, 4 }, 6)
            );

            Assert.Equal(
                new int[] { 0, 1 },
                TwoSumSolve.TwoSum(new int[] { 3, 3 }, 6)
            );
        }
    }
}