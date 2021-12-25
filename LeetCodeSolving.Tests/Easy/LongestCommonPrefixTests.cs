using Xunit;

namespace LeetCodeSolving.Easy.Tests
{
    public class LongestCommonPrefixTests
    {
        [Fact]
        public void LongestCommonPrefixExamplesTest()
        {
            Assert.Equal(
                "fl",
                LongestCommonPrefixSolve.LongestCommonPrefix(new string[] { "flower", "flow", "flight" })
            );

            Assert.Equal(
                "",
                LongestCommonPrefixSolve.LongestCommonPrefix(new string[] { "dog", "racecar", "car" })
            );
        }
    }
}
