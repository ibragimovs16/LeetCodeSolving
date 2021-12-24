namespace LeetCodeSolving.Easy
{
    public static class PalindromeNumberSolve
    {
        public static bool PalindromeNumber(int x)
        {
            if (x < 0) return false;

            var strX = x.ToString();
            var result = "";

            for (int i = strX.Length - 1; i >= 0; i--)
                result += strX[i];

            if (result == strX) return true;

            return false;
        }
    }
}
