namespace RationalNumbers
{
    public class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            int gcd = MathUtil.GreatestCommonDivisor(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = numerator + other.numerator;
            return new Fraction(newNumerator, denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", numerator, denominator);
        }
    }
}