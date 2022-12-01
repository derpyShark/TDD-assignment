namespace Kata
{
    internal interface IRecentlyUsedList<T>
    {
        public void Add();

        public T this[int index] { get; set; }
    }
}
