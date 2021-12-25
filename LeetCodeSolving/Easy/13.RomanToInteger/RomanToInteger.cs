namespace LeetCodeSolving.Easy
{
    public static class RomanToIntegerSolve
    {
        public static int RomanToInt(string s)
        {
            ushort result = 0;

            for (byte i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && ConvertValue(s[i]) < ConvertValue(s[i + 1])) result -= ConvertValue(s[i]);
                else result += ConvertValue(s[i]);
            }

            return result;
        }

        private static ushort ConvertValue(char value) =>
            value switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentException("Incorrect value.", nameof(value))
            };
    }
}
