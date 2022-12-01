using FluentAssertions;
using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class StringSumKataTests
    {
        [Test]
        public void ShouldNotExceptNullAsFirstArgument()
        {
            string num1 = null;
            var num2 = "124";

            var action = () => StringSumKata.AddStringNaturalNumbers(num1, num2);

            action.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void ShouldNotExceptNullAsSecondArgument()
        {
            var num1 = "124";
            string num2 = null;

            var action = () => StringSumKata.AddStringNaturalNumbers(num1, num2);

            action.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void ShouldThrowExceptionIfFirstArgumentIsNotANaturalNumber()
        {
            var num1 = "0";
            var num2 = "1512";

            var action = () => StringSumKata.AddStringNaturalNumbers(num1, num2);

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void ShouldThrowExceptionIfSecondArgumentIsNotANaturalNumber()
        {
            var num1 = "1245";
            var num2 = "-1";

            var action = () => StringSumKata.AddStringNaturalNumbers(num1, num2);

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void ShouldSumNumbersCorrectly()
        {
            var num1 = "1245";
            var num2 = "7192";

            var result = StringSumKata.AddStringNaturalNumbers(num1, num2);

            result.Should().Be("8437");
        }

        [Test]
        public void ShouldHandleVeryLargeNumbersCorrectly()
        {
            var num1 = "100000000000000000000000000000000000000000000000000006";
            var num2 = "1100000000000000000000000000000000000000000000000000001";

            var result = StringSumKata.AddStringNaturalNumbers(num1, num2);

            result.Should().Be("1200000000000000000000000000000000000000000000000000007");
        }
    }
}
