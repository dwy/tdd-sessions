namespace RationalNumbers
{
    using NUnit.Framework;

    [TestFixture]
    public class AddTests
    {
        [Test]
        public void SameDenominator()
        {
            var f = new Fraction(1, 3);

            var result = f.Add(new Fraction(1, 3));

            Assert.AreEqual("2/3", result.ToString());
        }

        [Test]
        public void SameDenominator_Reduced()
        {
            var f = new Fraction(1, 8);

            var result = f.Add(new Fraction(5, 8));

            Assert.AreEqual("3/4", result.ToString());
        }
    }
}