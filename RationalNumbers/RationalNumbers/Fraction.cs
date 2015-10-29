namespace RationalNumbers
{
    public class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int i = numerator + other.numerator;
            return new Fraction(i, denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", numerator, denominator);
        }
    }
}