using FluentAssertions;
using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class CalcStatsKataTests
    {
        [Test]
        public void GetMinimumValueShouldThrowExceptionIfSequenceIsEmpty()
        {
            var sequence = new int[0];

            var action = () => CalcStatsKata.GetMinimumValue(sequence);

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void GetMaximumValueShouldThrowExceptionIfSequenceIsEmpty()
        {
            var sequence = new int[0];

            var action = () => CalcStatsKata.GetMaximumValue(sequence);

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void GetAverageValueShouldThrowExceptionIfSequenceIsEmpty()
        {
            var sequence = new int[0];

            var action = () => CalcStatsKata.GetAverageValue(sequence);

            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void GetMinimumValueShouldReturnMinimumValue()
        {
            var sequence = new int[] { 6, 9, 15, -2, 92, 11 };

            var result = CalcStatsKata.GetMinimumValue(sequence);

            result.Should().Be(-2);

        }

        [Test]
        public void GetMaximumValueShouldReturnMaximumValue()
        {
            var sequence = new int[] { 6, 9, 15, -2, 92, 11 };

            var result = CalcStatsKata.GetMinimumValue(sequence);

            result.Should().Be(-2);
        }

        [Test]
        public void GetAverageValueShouldReturnAverageValue()
        {
            var sequence = new int[] { 6, 9, 15, -2, 92, 11 };

            var result = CalcStatsKata.GetAverageValue(sequence);

            result.Should().BeApproximately(21.833333, 10e-6);
        }

        [Test]
        public void GetNumberOfElementsInTheSequenceShouldReturnNumberOfElementsInTheSequence()
        {
            var sequence = new int[] { 6, 9, 15, -2, 92, 11 };

            var result = CalcStatsKata.GetNumberOfElementsInTheSequence(sequence);

            result.Should().Be(6);
        }

        [Test]
        public void GetNumberOfElementsInTheSequenceShouldReturn0WhenEmpty()
        {
            var sequence = new int[0];

            var result = CalcStatsKata.GetNumberOfElementsInTheSequence(sequence);

            result.Should().Be(0);
        }
    }
}
