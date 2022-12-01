namespace Kata
{
    internal interface IRecentlyUsedList
    {
        public void Add();

        public string this[int index] { get; set; }
    }
}
