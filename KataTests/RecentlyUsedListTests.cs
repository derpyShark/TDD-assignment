using NUnit.Framework;
using FluentAssertions;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class RecentlyUsedListTests
    {
        [Test]
        public void ShouldHaveNewestItemFirstLatestItemLast()
        {
            var firstAddedString = "firstAddedString";
            var lastAddedString = "lastAddedString";

            var recentlyUsedList = new RecentlyUsedList();
            recentlyUsedList.Add(firstAddedString);
            recentlyUsedList.Add(lastAddedString);

            recentlyUsedList[0].Should().Be(lastAddedString);
            recentlyUsedList[1].Should().Be(firstAddedString);
        }

        [Test]
        public void ShouldBeInitiallyEmpty()
        {
            var recentlyUsedList = new RecentlyUsedList();

            var action = () => recentlyUsedList[0];

            action.Should().Throw<IndexOutOfRangeException>();
        }

        [Test]
        public void ShouldMoveDuplicateItemsToTheFront()
        {
            var firstAddedString = "input1";
            var secondAddedString = "input2";
            var thirdAddedString = "input1";

            var recentlyUsedList = new RecentlyUsedList();
            recentlyUsedList.Add(firstAddedString);
            recentlyUsedList.Add(secondAddedString);
            recentlyUsedList.Add(thirdAddedString);

            var thirdElementIndexing = () => recentlyUsedList[2];

            recentlyUsedList[0].Should().Be(thirdAddedString);
            recentlyUsedList[1].Should().Be(secondAddedString);
            thirdElementIndexing.Should().Throw<IndexOutOfRangeException>();
        }

        [Test]
        public void ShouldNotAllowNullInsertions()
        {
            var recentlyUsedList = new RecentlyUsedList();

            var action = () => recentlyUsedList.Add(null);

            action.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void ShouldHaveDefaultCapacityEqualTo5()
        {
            var str1 = "str1";
            var str2 = "str2";
            var str3 = "str3";
            var str4 = "str4";
            var str5 = "str5";
            var str6 = "str6";

            var recentlyUsedList = new RecentlyUsedList();
            recentlyUsedList.Add(str1);
            recentlyUsedList.Add(str2);
            recentlyUsedList.Add(str3);
            recentlyUsedList.Add(str4);
            recentlyUsedList.Add(str5);
            recentlyUsedList.Add(str6);

            var sixElementIndexing = () => recentlyUsedList[5];

            recentlyUsedList[0].Should().Be(str6);
            recentlyUsedList[1].Should().Be(str5);
            recentlyUsedList[2].Should().Be(str4);
            recentlyUsedList[3].Should().Be(str2);
            recentlyUsedList[4].Should().Be(str1);
            sixElementIndexing.Should().Throw<IndexOutOfRangeException>();
        }

        [Test]
        public void ShouldNotAllowNegativeIndex()
        {
            var recentlyUsedList = new RecentlyUsedList();

            var negativeIndexing = () => recentlyUsedList[-1];

            negativeIndexing.Should().Throw<IndexOutOfRangeException>();
        }
    }
}
