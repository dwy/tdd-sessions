namespace RationalNumbers
{
    public class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            int gcd = GreatestCommonDivisor(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }

        public Fraction Add(Fraction other)
        {
            int newDenominator = numerator + other.numerator;
            return new Fraction(newDenominator, denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", numerator, denominator);
        }

        static int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        }
    }
}