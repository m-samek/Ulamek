using System;
using lab7Ulamek;
using Xunit;

namespace UlamekTests
{
    public class UlamekTests
    {
        [Fact]
        public void Constructor_ValidInputs_ShouldCreateUlamek()
        {
            var ulamek = new Ulamek(1, 2);
            Assert.Equal(1, ulamek.licznik);
            Assert.Equal(2, ulamek.mianownik);
        }

        [Fact]
        public void Constructor_DenominatorZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => new Ulamek(1, 0));
        }

        [Fact]
        public void ToString_ShouldReturnCorrectFormat()
        {
            var ulamek = new Ulamek(1, 2);
            Assert.Equal("1/2", ulamek.ToString());
        }

        [Fact]
        public void OperatorMultiplication_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            var result = ulamek1 * ulamek2;
            Assert.Equal(new Ulamek(1, 8), result);
        }

        [Fact]
        public void OperatorAddition_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            var result = ulamek1 + ulamek2;
            Assert.Equal(new Ulamek(6, 8), result);
        }

        [Fact]
        public void OperatorSubtraction_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            var result = ulamek1 - ulamek2;
            Assert.Equal(new Ulamek(2, 8), result);
        }

        [Fact]
        public void OperatorDivision_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            var result = ulamek1 / ulamek2;
            Assert.Equal(new Ulamek(4, 2), result);
        }

        [Fact]
        public void OperatorGreaterThan_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            Assert.True(ulamek1 > ulamek2);
        }

        [Fact]
        public void OperatorLessThan_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 4);
            var ulamek2 = new Ulamek(1, 2);
            Assert.True(ulamek1 < ulamek2);
        }

        [Fact]
        public void OperatorEqual_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 2);
            Assert.True(ulamek1 == ulamek2);
        }

        [Fact]
        public void OperatorNotEqual_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            Assert.True(ulamek1 != ulamek2);
        }

        [Fact]
        public void ExplicitOperatorDouble_ShouldReturnCorrectResult()
        {
            var ulamek = new Ulamek(1, 2);
            double result = (double)ulamek;
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void CompareTo_ShouldReturnCorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(1, 4);
            Assert.True(ulamek1.CompareTo(ulamek2) > 0);
        }
    }
}
