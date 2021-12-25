namespace LeetCodeSolving.Easy
{
    public static class ValidParenthesesSolve
    {
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var brackets = new Dictionary<char, char>
            {
                ['}'] = '{',
                [')'] = '(',
                [']'] = '['
            };

            foreach (var bracket in s)
            {
                if (stack.Count > 0 && brackets.ContainsKey(bracket) && stack.Peek() == brackets[bracket]) stack.Pop();
                else stack.Push(bracket);
            }

            return stack.Count == 0;
        }
    }
}
