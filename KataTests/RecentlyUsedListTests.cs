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
            var recentlyUsedList = new RecentlyUsedList();
        }
    }
}
