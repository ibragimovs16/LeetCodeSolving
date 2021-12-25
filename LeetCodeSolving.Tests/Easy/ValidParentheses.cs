using Xunit;

namespace LeetCodeSolving.Easy.Tests
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void ValidParenthesesExamplesTest()
        {
            Assert.True(ValidParenthesesSolve.IsValid("()"));
            Assert.True(ValidParenthesesSolve.IsValid("()[]{}"));
            Assert.False(ValidParenthesesSolve.IsValid("(]"));
        }
    }
}