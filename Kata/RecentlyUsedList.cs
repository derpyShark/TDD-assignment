namespace Kata
{
    public class RecentlyUsedList : IRecentlyUsedList
    {
        private List<string> _list;

        public int Size { get; private set; }

        public RecentlyUsedList(int size = 5)
        {
            Size = size;
            _list = new List<string>();
        }

        public string this[int index] { get => _list[index]; set => _list[index] = value; }

        public void Add(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value was null");
            }

            if (_list.Count == Size)
            {
                _list.RemoveAt(Size - 1);
            }
            else if (_list.Contains(value))
            {
                _list.Remove(value);
            }

            _list.Insert(0, value);
        }
    }
}
