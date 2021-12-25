using Xunit;

namespace LeetCodeSolving.Easy.Tests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void RomanToIntegerExamplesTest()
        {
            Assert.Equal(
                3,
                RomanToIntegerSolve.RomanToInt("III")
            );

            Assert.Equal(
                58,
                RomanToIntegerSolve.RomanToInt("LVIII")
            );

            Assert.Equal(
                1994,
                RomanToIntegerSolve.RomanToInt("MCMXCIV")
            );
        }
    }
}