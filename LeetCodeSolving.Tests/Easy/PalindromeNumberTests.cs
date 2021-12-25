using Xunit;

namespace LeetCodeSolving.Easy.Tests
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void PalindromeNumberExamplesTest()
        {
            Assert.True(PalindromeNumberSolve.PalindromeNumber(121));
            Assert.False(PalindromeNumberSolve.PalindromeNumber(-121));
            Assert.False(PalindromeNumberSolve.PalindromeNumber(10));
        }
    }
}
