namespace RationalNumbers
{
    public static class MathUtil
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        }
    }
}