namespace Kata
{
    internal interface IRecentlyUsedList
    {
        public void Add(string value);

        public string this[int index] { get; set; }
    }
}
