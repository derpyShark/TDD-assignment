namespace Kata
{
    public class RecentlyUsedList : IRecentlyUsedList
    {
        public int Size { get; private set; }

        public RecentlyUsedList(int size = 5)
        {
            Size = size;
        }

        public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(string value)
        {
            throw new NotImplementedException();
        }
    }
}
